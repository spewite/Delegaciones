Imports System.Data.SqlClient
Imports Dllgaciones.BaseDeDatos


Public Class Gestion

    Dim connectionString As String = "Data Source=192.168.0.241;Initial Catalog=DELEGACION;User ID=sa;Password=Negrocabron8@"
    Dim dataTable As DataTable
    Dim sqlQuery As String

    Private Sub Gestion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized
        Me.ControlBox = False

        ActualizarComboBoxCategoria()
        ActualizarComboBoxZonas()

    End Sub

    Private Sub btnConsultarArticulos_Click(sender As Object, e As EventArgs) Handles btnConsultarArticulos.Click
        ' Construir la sentencia SQL base
        sqlQuery = "SELECT * FROM ARTICULOS WHERE 1 = 1"

        ' Agregar condiciones según los valores ingresados en los controles
        If Not String.IsNullOrEmpty(inputIdArticulo.Text) Then
                sqlQuery &= $" AND IdArticulo = {inputIdArticulo.Text}"
            End If

            If Not String.IsNullOrEmpty(inputDescripcionArticulo.Text) Then
                sqlQuery &= $" AND UPPER(Descripcion) LIKE '%{inputDescripcionArticulo.Text.ToUpper}%'"
            End If

            If Not String.IsNullOrEmpty(inputProveedorArticulo.Text) Then
                sqlQuery &= $" AND  UPPER(Proveedor) LIKE '%{inputProveedorArticulo.Text.ToUpper}%'"
            End If

            If Not String.IsNullOrEmpty(inputExistenciasArticulo.Text) Then
                sqlQuery &= $" AND Existencias = {inputExistenciasArticulo.Text}"
            End If

            If Not String.IsNullOrEmpty(inputPrCostArticulos.Text) Then
                sqlQuery &= $" AND PrCost = {inputPrCostArticulos.Text}"
            End If

            If Not String.IsNullOrEmpty(inputPrVentArticulos.Text) Then
                sqlQuery &= $" AND PrVent = {inputPrCostArticulos.Text}"
            End If

            If Not String.IsNullOrEmpty(inputSobreMaximoArticulos.Text) Then
                sqlQuery &= $" AND SobreMaximo = {inputSobreMaximoArticulos.Text}"
            End If

            If Not String.IsNullOrEmpty(inputBajoMinimoArticulos.Text) Then
                sqlQuery &= $" AND BajoMinimo = {inputBajoMinimoArticulos.Text}"
            End If

        If Not String.IsNullOrEmpty(comboCategoriaArticulos.Text) Then
            sqlQuery &= $" AND Categoria LIKE '%{comboCategoriaArticulos.Text}%'"
        End If

        dataTable = ConsultaBBDD(connectionString, sqlQuery)
            dataGridArticulos.DataSource = dataTable

        End Sub



    Private Sub btnConsultarPartners_Click(sender As Object, e As EventArgs) Handles btnConsultarPartners.Click
        ' Construir la sentencia SQL base
        sqlQuery = "SELECT p.IdPartner, z.Descripcion AS Zona, p.Nombre, p.CIF, p.Direccion, p.Telefono, p.Correo, p.FechaRegistro " &
           "FROM PARTNERS p " &
           "INNER JOIN ZONAS z ON z.IdZona = p.IdZona " &
           "WHERE 1 = 1"

        ' Agregar condiciones según los valores ingresados en los controles
        If Not String.IsNullOrEmpty(inputIdPartner.Text) Then
            sqlQuery &= $" AND IdPartner = {inputIdPartner.Text}"
        End If

        If Not String.IsNullOrEmpty(comboZonaPartners.Text) Then
            sqlQuery &= $" AND IdZona LIKE '%{comboZonaPartners.Text.ToUpper}%'"
        End If

        If Not String.IsNullOrEmpty(inputCifPartners.Text) Then
            sqlQuery &= $" AND  UPPER(CIF) LIKE '%{inputCifPartners.Text.ToUpper}%'"
        End If

        If Not String.IsNullOrEmpty(inputNombrePartners.Text) Then
            sqlQuery &= $" AND UPPER(Nombre) LIKE '%{inputNombrePartners.Text}%'"
        End If

        If Not String.IsNullOrEmpty(inputTelefonoPartners.Text) Then
            sqlQuery &= $" AND Telefono = {inputTelefonoPartners.Text}"
        End If

        If Not String.IsNullOrEmpty(inputDireccionPartners.Text) Then
            sqlQuery &= $" AND UPPER(Direccion) = '%{inputDireccionPartners.Text}%'"
        End If

        If Not String.IsNullOrEmpty(inputCorreoPartners.Text) Then
            sqlQuery &= $" AND UPPER(Correo) = '%{inputCorreoPartners.Text}%'"
        End If

        If Not String.IsNullOrEmpty(inputFechaRegistroPartnersDesde.Text) AndAlso Not String.IsNullOrEmpty(inputFechaRegistroPartnersHasta.Text) Then
            Dim fechaDesdeFormateada As String = inputFechaRegistroPartnersDesde.Value.ToString("yyyyMMdd")
            Dim fechaHastaFormateada As String = inputFechaRegistroPartnersHasta.Value.ToString("yyyyMMdd")

            sqlQuery &= $" AND CONVERT(DATE, FechaRegistro, 112) BETWEEN CONVERT(DATE, '{fechaDesdeFormateada}', 112) AND CONVERT(DATE, '{fechaHastaFormateada}', 112)"
        End If

        dataTable = ConsultaBBDD(connectionString, sqlQuery)
        dataGridPartners.DataSource = dataTable
        ActualizarComboBoxZonas()
    End Sub

    Sub ActualizarComboBoxZonas()
        comboZonaPartners.Items.Clear()
        Dim query As String = $"SELECT DISTINCT DESCRIPCION FROM ZONAS"
        dataTable = ConsultaBBDD(connectionString, query)
        For Each fila As DataRow In dataTable.Rows
            comboZonaPartners.Items.Add(fila("DESCRIPCION"))
        Next
    End Sub
    Sub ActualizarComboBoxCategoria()
        comboCategoriaArticulos.Items.Clear()
        Dim query As String = $"SELECT DISTINCT CATEGORIA FROM ARTICULOS"
        dataTable = ConsultaBBDD(connectionString, query)
        For Each fila As DataRow In dataTable.Rows
            comboCategoriaArticulos.Items.Add(fila("CATEGORIA"))
        Next
    End Sub
End Class