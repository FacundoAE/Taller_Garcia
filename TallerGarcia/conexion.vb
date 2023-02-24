Module conexion
    Public conexion As New SqlClient.SqlConnection("Data Source=DESKTOP-TMD9FM2\SQLEXPRESS;Initial Catalog=taller_garcia;Integrated Security=false; user id=sa;password=Alberto01")
    Public cmd As New SqlClient.SqlCommand
    Public dr As SqlClient.SqlDataReader
    Public Sub conectar()
        Try
            conexion.Open()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub
End Module
