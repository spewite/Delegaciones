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
            Dim ConsultaIdFacturaNueva = "SELECT Max(IdFactura)+1 IdFacturaNueva FROM FACTURAS"
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
            For Each fila As DataRow In DataTablePedidosPartner.Rows
                ' Por cada fila hacemos un update en la tabla Pedidos Asignandole la Factura que hemos creado.

                Dim IdPedido As Integer = fila("IdPedido")

                Dim ConsultaUpdateFactura = $"UPDATE CAB_PEDIDOS
                                            SET IdFactura = {IdFacturaNueva}
                                            WHERE IdPedido = {IdPedido}"

                ' Aunque solo queremos actualizar el registro sin saber cuantas filas a cambiado, tenemos que asignarlo a una variable porque la funcion retorna un entero siempre. 
                Dim ActualizarRegistro As Integer = UpdateBBDD(ConnectionString, ConsultaUpdateFactura)

            Next

            Dim FechaFactura As String = numeroMes & "-" & año
            Dim RutaFactura As String = GenerarFacturaPDF(ConnectionString, IdFacturaNueva, FechaFactura)

            Dim RutaAbsoluta As String = System.IO.Path.GetFullPath(RutaFactura)


            ' Abrir la factura
            If System.IO.File.Exists(RutaAbsoluta) Then
                MsgBox(RutaAbsoluta)
                Process.Start(RutaAbsoluta)
            Else
                MsgBox("No se ha podido abrir la factura. Asegurate si se ha generado correctamente.", vbExclamation + vbOKOnly, "Error al abrir al factura")
            End If

            Dim formularioFactura As New FormularioFacturas(IdFacturaNueva, "", ModoVer)
            formularioFactura.Show()
            Me.Close()

        End If

    End Sub


    Function GenerarFacturaPDF(connectionString As String, IdFactura As Integer, FechaFactura As String) As String
        ' Definir el documento con un tamaño de página A4
        Dim document As New Document(PageSize.A4)

        ' Crear un nombre de archivo para el documento
        Dim nombreArchivoFactura As String = $"facturas/FACTURA_{IdFactura}_{FechaFactura}.pdf"
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
        Dim fuenteCabecera As New Font(FontFamily.HELVETICA, 14, Font.Bold)
        Dim fuente As New Font(FontFamily.HELVETICA, 12)

        ' Agregar un título al documento
        document.Add(New Paragraph($"Factura ({IdFactura})", fuenteTitulo))

        ' Asegúrate de implementar correctamente la función ConsultaBBDD para obtener los datos de la base de datos
        Dim partnerData As DataTable ' = ConsultaBBDD(connectionString, "SELECT ...")
        Dim ordersData As DataTable ' = ConsultaBBDD(connectionString, "SELECT ...")

        ' Si existe información del partner, agregarla al documento
        If partnerData IsNot Nothing AndAlso partnerData.Rows.Count > 0 Then
            Dim partner As DataRow = partnerData.Rows(0)

            ' Asegúrate de que estos campos existen en tu DataTable
            Dim nombre As String = If(partner("Nombre") IsNot DBNull.Value, partner("Nombre"), "")
            Dim direccion As String = If(partner("Direccion") IsNot DBNull.Value, partner("Direccion"), "")
            Dim telefono As String = If(partner("Telefono") IsNot DBNull.Value, partner("Telefono"), "")
            Dim correo As String = If(partner("Correo") IsNot DBNull.Value, partner("Correo"), "")

            document.Add(New Paragraph("Fecha: " & FechaFactura, fuente))
            document.Add(New Paragraph("Partner: " & nombre, fuente))
            document.Add(New Paragraph("Dirección: " & direccion, fuente))
            document.Add(New Paragraph("Teléfono: " & telefono, fuente))
            document.Add(New Paragraph("Correo: " & correo, fuente))
        End If

        ' Agregar una tabla para los detalles de pedidos
        Dim tabla As New PdfPTable(2)
        tabla.SpacingBefore = 20
        tabla.SetWidths(New Integer() {1, 2})

        ' Encabezados de la tabla
        tabla.AddCell(New Phrase("PEDIDO", fuenteCabecera))
        tabla.AddCell(New Phrase("IMPORTE", fuenteCabecera))

        ' Variable para almacenar el importe total
        Dim totalImporte As Decimal = 0

        ' Agregar los detalles de cada pedido a la tabla
        If ordersData IsNot Nothing Then
            For Each order As DataRow In ordersData.Rows
                tabla.AddCell(New Phrase("PEDIDO " & order("IdPedido").ToString(), fuente))
                Dim importe As Decimal = Convert.ToDecimal(order("Importe"))
                totalImporte += importe ' Acumular el total
                tabla.AddCell(New Phrase(importe.ToString("0.00€"), fuente))
            Next
        End If

        ' Agregar la tabla al documento
        document.Add(tabla)

        ' Agregar el importe total al documento
        document.Add(New Paragraph("IMPORTE TOTAL: " & totalImporte.ToString("0.00€"), fuente))

        ' Cerrar el documento
        document.Close()

        Return nombreArchivoFactura
    End Function



End Class