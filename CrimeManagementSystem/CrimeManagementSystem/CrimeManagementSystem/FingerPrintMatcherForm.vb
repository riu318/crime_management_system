Imports System.Data.SqlClient
Imports System.IO

Public Class FingerPrintMatcherForm


    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Try
            With OpenFileDialog1
                .Filter = ("Images |* .png; *.bmp; *.jpg; *.jpeg; *.gif; *.ico; *.jfif")
                .FilterIndex = 4
            End With
            OpenFileDialog1.FileName = ""
            If OpenFileDialog1.ShowDialog() = DialogResult.OK Then
                PictureBox1.Image = Image.FromFile(OpenFileDialog1.FileName)
            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        If conn.State = ConnectionState.Open Then conn.Close()
        conn.Open()
        Dim cmd0 As New SqlCommand("Select FingerPrintFile,FingerPrint from CriminalTable where FingerPrintFile='" & Path.GetFileName(OpenFileDialog1.FileName) & "'", conn)
        Dim d1 As SqlDataReader = cmd0.ExecuteReader()
        If d1.HasRows Then
            d1.Read()
            Dim img = CType(d1("FingerPrint"), Byte())

            If img IsNot Nothing Then
                Using ms As New MemoryStream(img, 0, img.Length)
                    ms.Write(img, 0, img.Length)
                    PictureBox2.Image = Image.FromStream(ms, True)
                End Using
            Else
                MsgBox("image not found")
            End If

            Exit Sub
        Else
            MsgBox("dfhjkl")
        End If
    End Sub

    Private Sub ButtonCancel_Click(sender As System.Object, e As System.EventArgs) Handles ButtonCancel.Click
        Me.Hide()
        MDIParent1.Show()

    End Sub

    Private Sub FingerPrintMatcherForm_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized
    End Sub

    
End Class