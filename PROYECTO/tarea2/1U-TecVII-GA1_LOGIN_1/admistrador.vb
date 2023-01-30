Imports System.Windows.Forms
Imports System.Data.SqlClient
Imports System.Data
Public Class admistrador
    Dim con As SqlConnection = New SqlConnection(My.Settings.CONEXION)
    Dim sentencia, mensaje As String
    Public Sub Ejecutarsql(ByVal sql As String, ByVal msg As String)
        Try
            Dim cmd As New SqlCommand(sql, con)
            con.Open()
            cmd.ExecuteNonQuery()
            con.Close()
            MsgBox(msg)
        Catch ex As Exception
            con.Close()
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btn_cargar_Click(sender As Object, e As EventArgs) Handles btn_cargar.Click
        Try
            Dim da As New SqlDataAdapter("Select * from PARTICIPANTES", con)
            Dim ds As New DataSet
            da.Fill(ds)
            Me.DataGridView1.DataSource = ds.Tables(0)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub admistrador_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btn_borrar_Click(sender As Object, e As EventArgs) Handles btn_borrar.Click
        sentencia = "Delete PARTICIPANTES Where id=" + txt_id.Text + ""
        mensaje = " SEGISTRO ELIMINADO CORRECTAMENTE"
        Ejecutarsql(sentencia, mensaje)
        Try
            Dim da As New SqlDataAdapter("Select * from PARTICIPANTES", con)
            Dim ds As New DataSet
            da.Fill(ds)
            Me.DataGridView1.DataSource = ds.Tables(0)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btn_editar_Click(sender As Object, e As EventArgs) Handles btn_editar.Click
        sentencia = "Update PARTICIPANTES Set id='" + txt_id.Text + "', nombre='" + txt_nombre.Text + "', apellido='" + txt_appellido.Text + "', correo='" + txt_correo.Text + "', edad='" + txt_edad.Text + "', usuario='" + txt_usuario.Text + "', contraseña='" + txt_contraseña.Text + "', roll='" + txt_roll.Text + "' Where Id='" + txt_id.Text + "'"
        mensaje = "USUARIO EDITADO CORRECTAMENTE"
        Ejecutarsql(sentencia, mensaje)
        Try
            Dim da As New SqlDataAdapter("Select * from PARTICIPANTES", con)
            Dim ds As New DataSet
            da.Fill(ds)
            Me.DataGridView1.DataSource = ds.Tables(0)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs)


    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        Hide()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim da As New SqlDataAdapter("Select * from PARTICIPANTES Where id='" + txt_id.Text + "'", con)
        Dim ds As New DataSet
        da.Fill(ds)
        Me.DataGridView1.DataSource = ds.Tables(0)
    End Sub

    Private Sub btn_insetar_Click(sender As Object, e As EventArgs) Handles btn_insetar.Click
        sentencia = "Insert into PARTICIPANTES VALUES('" + txt_id.Text + "','" + txt_nombre.Text + "','" + txt_appellido.Text + "','" + txt_correo.Text + "','" + txt_edad.Text + "','" + txt_usuario.Text + "','" + txt_contraseña.Text + "','" + txt_roll.Text + "')"
        mensaje = "participante registrado"
        Ejecutarsql(sentencia, mensaje)
    End Sub
End Class
