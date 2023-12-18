Imports System.Data.SqlClient
Imports Dllgaciones.BaseDeDatos


Public Class Gestion

    Dim connectionString As String = "Data Source=192.168.0.241;Initial Catalog=DELEGACION;User ID=sa;Password=Negrocabron8@"
    Dim dataGrid As DataGrid

    Private Sub Gestion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized
        Me.ControlBox = False
    End Sub

    Private Sub btnConsultarArticulos_Click(sender As Object, e As EventArgs) Handles btnConsultarArticulos.Click

        Try
            ' Crear una nueva conexión
            Using connection As New SqlConnection(connectionString)
                ' Abrir la conexión
                connection.Open()

                Dim query As String = "SELECT * FROM ARTICULOS"

                Using command As New SqlCommand(query, connection)
                    ' Crear un lector de datos
                    Using reader As SqlDataReader = command.ExecuteReader()
                        ' Crear un DataTable para almacenar los resultados de la consulta
                        Dim dataTable As New DataTable()

                        ' Cargar el DataTable con los resultados del lector de datos
                        dataTable.Load(reader)

                        ' Vincular el DataTable al DataGridView
                        dataGridArticulos.DataSource = dataTable

                    End Using
                End Using
            End Using


        Catch ex As Exception
            MessageBox.Show("Error al conectar a la base de datos: " & ex.Message)
        End Try

    End Sub
End Class