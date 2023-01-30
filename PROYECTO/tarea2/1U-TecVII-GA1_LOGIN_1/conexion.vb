Imports System.Data.Sql
Imports System.Data.SqlClient
Imports System.Windows.Forms

Public Class conexion
    Public con As SqlConnection = New SqlConnection(My.Settings.CONEXION)
    Private cmb As SqlCommandBuilder
    Public ds As DataSet = New DataSet
    Public da As SqlDataAdapter
    Public cmd As SqlCommand

    Public Sub Consulta(ByVal sql As String, ByVal tabla As String)
        ds.Tables.Clear()
        da = New SqlDataAdapter(sql, con)
        cmb = New SqlCommandBuilder(da)
        da.Fill(ds, tabla)
    End Sub

    Function Verificacion(ByVal sql)
        con.Open()
        cmd = New SqlCommand(sql, con)
        Dim i As Integer = cmd.ExecuteNonQuery
        con.Close()
        If (i > 0) Then
            Return True
        Else
            Return False
        End If
    End Function

End Class

