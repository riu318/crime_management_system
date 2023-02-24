Imports System.Data.SqlClient

Public Class LoginForm

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        If TextBox1.Text = "" Then
            MsgBox(" name required")
            Exit Sub
        End If
        If TextBox2.Text = "" Then
            MsgBox(" password required")
            Exit Sub
        End If
        If conn.State = ConnectionState.Open Then conn.Close()
        conn.Open()
        Dim a1 As New SqlCommand("select * from logintable where username = '" & TextBox1.Text & "' and password = '" & TextBox2.Text & "'", conn)
        Dim a2 As SqlDataReader = a1.ExecuteReader
        If a2.HasRows Then
            MsgBox("logined sucessfully")
            MDIParent1.Show()
        Else
            MsgBox("try again")
            TextBox2.Text = ""
        End If
        If conn.State = ConnectionState.Open Then conn.Close()
    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        Me.Close()
        Me.Hide()
    End Sub

    Private Sub LoginForm_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized
    End Sub
End Class