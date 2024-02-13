Imports Dllgaciones.BaseDeDatos


Imports iTextSharp.text
Imports iTextSharp.text.pdf
Imports iTextSharp.text.Font
Imports System.IO

Public Class GenerarFacturas

    Dim ConnectionString As String = ConexionBD.CadenaConexion

    Dim ModoEditar As Integer = ModosFormulario.ModoEditar
    Dim ModoVer As Integer = ModosFormulario.ModoVer
    Dim ModoAñadir As Integer = ModosFormulario.ModoAñadir

    Private Sub GenerarFacturas_Load(sender As Object, e As EventArgs) Handles Me.Load

        ' RELLENAR EL COMBO AÑO CON UN RANGO DE AÑOS -3 Y +3 
        Dim añoActual As Integer = Date.Today.Year

        For añoParaInsertar = (añoActual - 3) To (añoActual + 3) Step 1
            comboAño.Items.Add(añoParaInsertar)
        Next

        ' RELLENAR EL COMBO PARTNERS 
        Dim consultaPartners As String = "SELECT Nombre FROM PARTNERS"
        Dim dataTablePartners As DataTable = ConsultaBBDD(ConnectionString, consultaPartners)

        For Each fila As DataRow In dataTablePartners.Rows
            comboPartner.Items.Add(fila("Nombre"))
        Next

        ' CARGAR PÒR DEFECTO LOS INPUTS CON LAS FECHAS ACTUALES
        comboAño.Text = añoActual
        comboMes.SelectedIndex = Date.Today.Month - 1

    End Sub


    Private Sub btnGenerarFactura_Click(sender As Object, e As EventArgs) Handles btnGenerarFactura.Click


        ' VALIDAR SI SE HAN SELECCIONADO TODAS LAS OPCIONES

        If comboMes.Text.Trim = "" Then
            MsgBox("¡Seleccione un mes!", vbExclamation + vbOKOnly, "Error de validación")
            Return
        End If

        If comboAño.Text.Trim = "" Then
            MsgBox("¡Seleccione un año!", vbExclamation + vbOKOnly, "Error de validación")
            Return
        End If

        If comboPartner.Text.Trim = "" Then
            MsgBox("¡Seleccione un partner!", vbExclamation + vbOKOnly, "Error de validación")
            Return
        End If

        ' ESTABLECERA LAS VARIABLES QUE NECESITAMOS

        Dim mes As String = comboMes.Text
        Dim numeroMes As Integer = comboMes.SelectedIndex + 1 ' Cogemos la posicion de la opcion seleccionada del combobox para saber que numero de mes es. Le sumamos 1 porque empieza a contar desde 0.

        Dim partner As String = comboPartner.Text

        Dim año As String = comboAño.Text


        ' VALIDAR SI EL PARTNER TIENE PEDIDOS EN EL MES/AÑO INTRODUCIDO

        Dim ConsultaObtenerCantidadPedidosPartner As String = $"SELECT COUNT(*) Cantidad
                                                                FROM CAB_PEDIDOS pedidos
                                                                INNER JOIN PARTNERS ON (pedidos.IdPartner = PARTNERS.IdPartner)
                                                                WHERE PARTNERS.Nombre = '{partner}'
                                                                AND DATEPART(MONTH, FechaPedido) = {numeroMes} 
                                                                AND DATEPART(YEAR, FechaPedido) = {año}"

        Dim DataTableCantidadPedidosPartner = ConsultaBBDD(ConnectionString, ConsultaObtenerCantidadPedidosPartner)

        Dim CantidadPedidosPartner As Integer = DataTableCantidadPedidosPartner.Rows(0)("Cantidad")

        If CantidadPedidosPartner = 0 Then
            MsgBox($"¡El partner '{partner}' no tiene pedidos en {mes} de {año}!", vbExclamation + vbOKOnly, "Error")
            Return
        End If


        ' EMPEZAR CON LA LOGICA DE INSERTAR FACTURAS EN BASE DE DATOS

        ' Preguntar al usuario si quiere eliminar
        Dim result As DialogResult = MessageBox.Show($"¿Está seguro de que desea generar las facturas de los pedidos del partner '{partner}'? ¡Si los pedidos ya tenian facturas, se van a sobreesribir!", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        ' Si el usuario a seleccionado que sí, borra el registro
        If result = DialogResult.Yes Then

            Dim ConsultaObtenerPedidosPartner = $"SELECT *
                                                FROM CAB_PEDIDOS pedidos
                                                INNER JOIN PARTNERS ON (pedidos.IdPartner = PARTNERS.IdPartner)
                                                WHERE PARTNERS.Nombre = '{partner}'
                                                AND DATEPART(MONTH, FechaPedido) = {numeroMes} 
                                                AND DATEPART(YEAR, FechaPedido) = {año}"

            ' Obtenemos un Id Factura que no exista 
            Dim ConsultaIdFacturaNueva = "SELECT ISNULL(Max(IdFactura), 0)+1 IdFacturaNueva FROM FACTURAS"
            Dim IdFacturaNueva = ConsultaBBDD(ConnectionString, ConsultaIdFacturaNueva).Rows(0)("IdFacturaNueva")

            ' Insertamos una nueva factura en la base de datos (Los datos de la factura estarán vacios (Fechas...), pero cuando se crea la factura se le abre el formulario para editarlo).
            Dim ConsultaInsertarCabeceraFactura = $"INSERT INTO FACTURAS (IdFactura) VALUES ('{IdFacturaNueva}')"
            Dim RegistrosInsertados = InsertBBDD(ConnectionString, ConsultaInsertarCabeceraFactura)

            If RegistrosInsertados = 0 Then
                MsgBox("No se ha podido crear la cabecera de la factura. Contacte con el administrador", vbAbort + vbOKOnly, "Error en la base de datos")
                Return
            Else
                MsgBox("Cabecera de factura creada con éxito. A continuación se van a asignar los pedidos a la factura...", vbInformation + vbOKOnly, "Cabecera de la factura creada.")
            End If

            ' Guardamos los pedidos del partner (en el rango de fecha) dentro de una tabla, y por cada pedido que tiene, cambiamos el campo IdFactura al a factura que hemos creado.
            Dim DataTablePedidosPartner As DataTable = ConsultaBBDD(ConnectionString, ConsultaObtenerPedidosPartner)

            Dim IdFacturaVieja As Integer = -1

            For Each fila As DataRow In DataTablePedidosPartner.Rows
                ' Guardamos si tiene alguna factura asociada, para eliminar la factura despues (porque la factura ya no tendria ningun pedido porque creamos una nueva factura)

                If fila("IdFactura") IsNot DBNull.Value Then
                    IdFacturaVieja = fila("IdFactura")
                End If

                ' Por cada fila hacemos un update en la tabla Pedidos Asignandole la Factura que hemos creado.

                Dim IdPedido As Integer = fila("IdPedido")

                Dim ConsultaUpdateFactura = $"UPDATE CAB_PEDIDOS
                                            SET IdFactura = {IdFacturaNueva}
                                            WHERE IdPedido = {IdPedido}"

                ' Aunque solo queremos actualizar el registro sin saber cuantas filas a cambiado, tenemos que asignarlo a una variable porque la funcion retorna un entero siempre. 
                Dim ActualizarRegistro As Integer = UpdateBBDD(ConnectionString, ConsultaUpdateFactura)

            Next

            ' Vamos a eliminar las facturas que estaban asociadas a estos pedidos (Si hubieran). Para no tener facturas vacías porque acabamos de desvincular los pedidos que tenian una factura.

            If IdFacturaVieja <> -1 Then
                Dim ConsultaEliminarFacturaVieja = $"DELETE FROM FACTURAS WHERE IdFactura = {IdFacturaVieja}"

                Dim FacturasEliminadas As Integer = DeleteBBDD(ConnectionString, ConsultaEliminarFacturaVieja)

                If FacturasEliminadas > 0 Then
                    MsgBox($"Se ha eliminado la factura {IdFacturaVieja} porque ya no tiene pedidos asociados.", vbInformation + vbOKOnly, "Factura Actualizada.")
                End If

            End If

            ' Ponemos el nombre a la factura, lo creamos y lo abrimos 
            Dim FechaFactura As String = numeroMes & "-" & año
            Dim RutaFactura As String = GenerarFacturaPDF(ConnectionString, IdFacturaNueva, FechaFactura)

            Dim RutaAbsoluta As String = System.IO.Path.GetFullPath(RutaFactura)


            ' Preguntar al usuario si quiere eliminar
            result = MessageBox.Show($"¿Quieres abrir el PDF de la factura generada?", "Abrir PDF", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

            ' Si el usuario a seleccionado que sí, borra el registro
            If result = DialogResult.Yes Then

                ' Abrir la factura
                If System.IO.File.Exists(RutaAbsoluta) Then
                    Process.Start(RutaAbsoluta)
                Else
                    MsgBox("No se ha podido abrir la factura. Asegurate si se ha generado correctamente.", vbExclamation + vbOKOnly, "Error al abrir al factura")
                End If
            End If

            Dim formularioFactura As New FormularioFacturas(IdFacturaNueva, "", ModoVer)
            formularioFactura.Show()
            Me.Close()

        End If

    End Sub


    Function GenerarFacturaPDF(connectionString As String, IdFactura As Integer, FechaFactura As String) As String
        ' Definir el documento con un tamaño de página A4
        Dim document As New Document(PageSize.A4)

        Dim nombrePartner = comboPartner.Text.ToUpper

        ' Crear un nombre de archivo para el documento
        Dim nombreArchivoFactura As String = $"facturas/{nombrePartner}/FACTURA {IdFactura} {nombrePartner} {FechaFactura}.pdf"
        ' Asegurarse de que el directorio existe antes de guardar el archivo
        Dim directory As New DirectoryInfo(Path.GetDirectoryName(nombreArchivoFactura))
        If Not directory.Exists Then
            directory.Create()
        End If

        ' Inicializar PdfWriter para escribir en el documento
        Dim writer As PdfWriter = PdfWriter.GetInstance(document, New FileStream(nombreArchivoFactura, FileMode.Create))

        ' Abrir el documento para agregar contenido
        document.Open()

        ' Configurar fuentes utilizando la fuente por defecto
        Dim fuenteTitulo As New Font(FontFamily.HELVETICA, 18, Font.Bold)
        Dim fuenteNegrita As New Font(FontFamily.HELVETICA, 12, Font.Bold)
        Dim fuente As New Font(FontFamily.HELVETICA, 10)

        ' //////////// EMPEZAMOS CON EL ASUNTO ///////////////

        ' Recuperar datos de la factura
        Dim TablaFactura As DataTable = ConsultaBBDD(connectionString, $"SELECT * FROM FACTURAS WHERE IdFactura = {IdFactura}")
        Dim TablaPartner As DataTable = ConsultaBBDD(connectionString, $"SELECT TOP 1 PARTNERS.Nombre, PARTNERS.CIF, PARTNERS.Correo, PARTNERS.Direccion, PARTNERS.Telefono FROM CAB_PEDIDOS INNER JOIN PARTNERS ON CAB_PEDIDOS.IdPartner = PARTNERS.IdPartner WHERE IdFactura = {IdFactura}")
        Dim TablaPedidos As DataTable = ConsultaBBDD(connectionString, $"SELECT * FROM CAB_PEDIDOS WHERE IdFactura = {IdFactura}")


        ' /////////////////////////////////////
        ' ////////////            /////////////
        ' ////////////  CABECERA  /////////////
        ' ////////////            /////////////
        ' /////////////////////////////////////

        ' Crear el titulo
        Dim titulo As New Paragraph($"Factura (ID: {IdFactura})", fuenteTitulo)

        ' Establecer el margen inferior del párrafo
        titulo.SpacingAfter = 20.0F ' Puedes ajustar este valor según tus necesidades

        ' Agregar el título al documento
        document.Add(titulo)


        ' ////////////  PARTE IZQUIERDA  /////////////


        ' Crear una tabla para la cabecera de la izquierda con 1 columna
        Dim leftHeaderTable As New PdfPTable(1)
        leftHeaderTable.WidthPercentage = 50 ' La tabla ocupa el 50% del ancho de la página
        leftHeaderTable.HorizontalAlignment = Element.ALIGN_LEFT ' Alinear la tabla a la izquierda
        leftHeaderTable.DefaultCell.Border = Rectangle.NO_BORDER

        ' Agregar la celda "DE" con estilo negrita
        Dim cellDe As New PdfPCell(New Phrase("DE:", fuenteNegrita))
        cellDe.Border = PdfPCell.NO_BORDER ' Sin bordes
        leftHeaderTable.AddCell(cellDe)

        ' Agregar los detalles de la empresa
        Dim cellEmpresa As New PdfPCell(New Phrase("Gourmet Euskadi Market", fuente))
        cellEmpresa.Border = PdfPCell.NO_BORDER ' Sin bordes
        leftHeaderTable.AddCell(cellEmpresa)

        Dim cellTelefono As New PdfPCell(New Phrase("941 31 69 00", fuente))
        cellTelefono.Border = PdfPCell.NO_BORDER ' Sin bordes
        leftHeaderTable.AddCell(cellTelefono)

        Dim cellDireccion As New PdfPCell(New Phrase("Cebanc, Berio Pasealekua, 20018, Donostia, Guipuzkoa", fuente))
        cellDireccion.Border = PdfPCell.NO_BORDER ' Sin bordes
        leftHeaderTable.AddCell(cellDireccion)

        Dim cellMail As New PdfPCell(New Phrase("gcomercial@cebanc.com", fuente))
        cellMail.Border = PdfPCell.NO_BORDER ' Sin bordes
        leftHeaderTable.AddCell(cellMail)

        ' ////////////  PARTE DERECHA  /////////////

        ' Este es un ejemplo basado en la información que proporcionaste, ajusta según tus necesidades.
        Dim partnerName As String = TablaPartner.Rows(0)("Nombre").ToString()
        Dim partnerAddress As String = TablaPartner.Rows(0)("Direccion").ToString()
        Dim partnerPhone As String = TablaPartner.Rows(0)("Telefono").ToString()
        Dim partnerEmail As String = TablaPartner.Rows(0)("Correo").ToString()

        ' Crear una tabla para la cabecera de la derecha con 1 columna
        Dim rightHeaderTable As New PdfPTable(1)
        rightHeaderTable.WidthPercentage = 50 ' La tabla ocupa el 50% del ancho de la página
        rightHeaderTable.HorizontalAlignment = Element.ALIGN_LEFT ' Alinear la tabla a la izquierda
        rightHeaderTable.DefaultCell.Border = Rectangle.NO_BORDER

        ' Agregar la celda "PARA" con estilo negrita
        Dim cellPara As New PdfPCell(New Phrase("PARA:", fuenteNegrita))
        cellPara.Border = PdfPCell.NO_BORDER ' Sin bordes
        rightHeaderTable.AddCell(cellPara)

        ' Agregar los detalles del partner
        Dim cellPartnerName As New PdfPCell(New Phrase(partnerName, fuente))
        cellPartnerName.Border = PdfPCell.NO_BORDER ' Sin bordes
        rightHeaderTable.AddCell(cellPartnerName)

        Dim cellPartnerAddress As New PdfPCell(New Phrase(partnerAddress, fuente))
        cellPartnerAddress.Border = PdfPCell.NO_BORDER ' Sin bordes
        rightHeaderTable.AddCell(cellPartnerAddress)

        Dim cellPartnerPhone As New PdfPCell(New Phrase(partnerPhone, fuente))
        cellPartnerPhone.Border = PdfPCell.NO_BORDER ' Sin bordes
        rightHeaderTable.AddCell(cellPartnerPhone)

        Dim cellPartnerEmail As New PdfPCell(New Phrase(partnerEmail, fuente))
        cellPartnerEmail.Border = PdfPCell.NO_BORDER ' Sin bordes
        rightHeaderTable.AddCell(cellPartnerEmail)

        ' AÑADIR LAS DOS TABLAS QUE HEMOS CREADO A LA PAGINA

        Dim mainTable As New PdfPTable(2)
        mainTable.WidthPercentage = 100 ' La tabla ocupa el 100% del ancho de la página

        ' Añadir las tablas de cabecera izquierda y derecha a la tabla principal
        mainTable.AddCell(leftHeaderTable)
        mainTable.AddCell(rightHeaderTable)

        mainTable.SpacingAfter = 20.0F

        ' Agregar la tabla principal al documento
        document.Add(mainTable)


        ' /////////////////////////////////////////////
        ' ////////////                     ///////////
        ' ////////////       SEPARADOR     ///////////
        ' ////////////                     ///////////
        ' ////////////////////////////////////////////


        ' Agregar espacio vertical después de la línea (margen vertical de 20 pixeles)
        document.Add(New Chunk(" ", FontFactory.GetFont(FontFactory.HELVETICA, 20)))


        Dim line As New iTextSharp.text.pdf.draw.LineSeparator(1.0F, 100.0F, BaseColor.BLACK, Element.ALIGN_CENTER, 1)
        document.Add(line)

        ' Agregar espacio vertical después de la línea (margen vertical de 20 pixeles)
        document.Add(New Chunk(" ", FontFactory.GetFont(FontFactory.HELVETICA, 20)))



        ' /////////////////////////////////////////////
        ' ////////////                     ///////////
        ' ////////////   DETALLE FACTURA   ///////////
        ' ////////////                     ///////////
        ' ////////////////////////////////////////////

        Dim ImporteFactura As Decimal = 0

        For Each FilaPedido As DataRow In TablaPedidos.Rows

            ' ////////////  INSERTAR CABECERA PEDIDO  /////////////

            Dim IdPedido As Integer = FilaPedido("IdPedido")

            Dim textoPedido As Paragraph = New Paragraph($"Pedido {IdPedido}", fuenteTitulo)
            textoPedido.SpacingAfter = 20.0F ' Añadir margin inferior

            ' Agregar el título al documento
            document.Add(textoPedido)



            ' ////////////  INSERTAR LINEAS /////////////

            Dim ImportePedido As Decimal = 0

            Dim TablaLineasPedido As DataTable = ConsultaBBDD(connectionString, $"SELECT ARTICULOS.IdArticulo, Nombre As Articulo, Cantidad, Precio, Descuento FROM LINEAS_PEDIDO INNER JOIN CAB_PEDIDOS ON (CAB_PEDIDOS.IdPedido = LINEAS_PEDIDO.IdPedido) INNER JOIN ARTICULOS ON (ARTICULOS.IdArticulo = LINEAS_PEDIDO.IdArticulo) WHERE IdFactura = {IdFactura} AND LINEAS_PEDIDO.IdPedido = {IdPedido}")

            ' Crea la tabla con 5 columnas como en la imagen
            Dim TablaLinea As New PdfPTable(5)

            ' Ajusta el ancho de las columnas
            Dim widths As Single() = {2.5F, 1.5F, 1.5F, 1.5F, 1.5F}
            TablaLinea.SetWidths(widths)

            ' Añade las cabeceras de las columnas
            TablaLinea.AddCell("Artículo")
            TablaLinea.AddCell("Cantidad")
            TablaLinea.AddCell("Precio")
            TablaLinea.AddCell("Descuento")
            TablaLinea.AddCell("Total")


            For Each LineaPedido As DataRow In TablaLineasPedido.Rows
                ' Añade la fila de la consulta SEO
                Dim Cantidad As Integer = LineaPedido("Cantidad")
                Dim Precio As Decimal = LineaPedido("Precio")
                Dim Descuento As Decimal = LineaPedido("Descuento")
                Dim Total As Decimal = Cantidad * Precio * 1 - (Descuento / 100)

                ImportePedido += Total


                TablaLinea.AddCell($"{LineaPedido("Articulo")} (ID: {LineaPedido("IdArticulo")})")
                TablaLinea.AddCell($"{Cantidad}")
                TablaLinea.AddCell($"{Precio}")
                TablaLinea.AddCell($"{Descuento}")
                TablaLinea.AddCell($"{Total}")

            Next


            ' Añade la tabla al documento
            document.Add(TablaLinea)

            ' AÑADIR TEXTO TOTAL PEDIDO
            Dim textoTotalPedido As Paragraph = New Paragraph($"Total Pedido: {ImportePedido} €", fuenteNegrita)
            textoTotalPedido.SpacingAfter = 20.0F ' Añadir margin inferior
            textoTotalPedido.Alignment = Element.ALIGN_RIGHT
            textoTotalPedido.IndentationRight = 55.0F


            document.Add(textoTotalPedido)

            ImporteFactura += ImportePedido

        Next

        ' AÑADIR TEXTO TOTAL Factura
        Dim textoTotalFactura As Paragraph = New Paragraph($"Total Factura: {ImporteFactura} €", fuenteNegrita)
        textoTotalFactura.SpacingAfter = 20.0F ' Añadir margin inferior
        textoTotalFactura.Alignment = Element.ALIGN_RIGHT
        textoTotalFactura.IndentationRight = 55.0F

        document.Add(textoTotalFactura)



        ' Cerrar el documento
        document.Close()

        Return nombreArchivoFactura
    End Function



End Class