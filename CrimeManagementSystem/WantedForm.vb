Imports System.Data.SqlClient
Imports System.IO

Public Class WantedForm

    Private Sub ButtonSave_Click(sender As System.Object, e As System.EventArgs) Handles ButtonSave.Click
        If TextBox1CriminalID.Text = "" Then
            MsgBox(" Enter the Criminal Id ")
            Exit Sub
        End If
        If TextBox2CriminalName.Text = "" Then
            MsgBox(" Enter the Criminal Name ")
            Exit Sub
        End If
        If TextBox10Description.Text = "" Then
            MsgBox(" Enter the Description of Criminal")
            Exit Sub
        End If
        If TextBox9CrimeCommitted.Text = "" Then
            MsgBox(" Enter the Crime Comitted ")
            Exit Sub
        End If
        If TextBox10Description.Text = "" Then
            MsgBox(" Enter the Description of Criminal")
            Exit Sub
        End If

        If conn.State = ConnectionState.Open Then conn.Close()
        conn.Open()
        Dim a1 As New SqlCommand("select * from WantedTable where criminalNo = '" & TextBox1CriminalID.Text & "' ", conn)
        Dim a2 As SqlDataReader = a1.ExecuteReader
        If a2.HasRows Then
            MsgBox("Already Criminal Data is Registered")
            If conn.State = ConnectionState.Open Then conn.Close()
            Exit Sub
        End If

        Dim command As New SqlCommand("insert into WantedTable(CriminalNo,CriminalName,CrimeComited,CriminalDescription,CriminalImage,CriminalFile)values(@CriminalNo,@CriminalName,@CrimeComited,@CriminalDescription,@CriminalImage,@CriminalFile)", conn)
        Dim ms As New MemoryStream

        PictureBox1.Image.Save(ms, PictureBox1.Image.RawFormat)
        command.Parameters.Add("@CriminalNo", SqlDbType.NVarChar).Value = TextBox1CriminalID.Text
        command.Parameters.Add("@CriminalName", SqlDbType.NVarChar).Value = TextBox2CriminalName.Text
        command.Parameters.Add("@CrimeComited", SqlDbType.NVarChar).Value = TextBox9CrimeCommitted.Text
        command.Parameters.Add("@CriminalDescription", SqlDbType.NVarChar).Value = TextBox10Description.Text
        command.Parameters.Add("@CriminalFile", SqlDbType.NVarChar).Value = Path.GetFileName(OpenFileDialog1.FileName)
        command.Parameters.Add("@CriminalImage", SqlDbType.Image).Value = ms.ToArray
        If conn.State = ConnectionState.Open Then conn.Close()
        conn.Open()
        If command.ExecuteNonQuery() = 1 Then
            MsgBox("Details Saved ", vbInformation)

            TextBox1CriminalID.Text = ""
            TextBox2CriminalName.Text = ""
            TextBox10Description.Text = ""
            TextBox9CrimeCommitted.Text = ""
            PictureBox1.Image = Nothing
            autogenerate_ID()

        Else
            MsgBox("Details Not Saved", vbCritical)
        End If
        If conn.State = ConnectionState.Open Then conn.Close()


    End Sub

    Private Sub WantedForm_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        autogenerate_ID()
        Me.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub autogenerate_ID()
        Dim number As Integer
        If conn.State = ConnectionState.Open Then conn.Close()
        conn.Open()
        Dim cmd As New SqlCommand(number, conn)
        cmd.CommandText = "select max(CriminalNo) from WantedTable"
        If IsDBNull(cmd.ExecuteScalar) Then
            number = 1
            TextBox1CriminalID.Text = number
        Else
            number = cmd.ExecuteScalar + 1
            TextBox1CriminalID.Text = number
        End If
        cmd.Dispose()

    End Sub

    Private Sub ButtonImage_Click(sender As System.Object, e As System.EventArgs) Handles ButtonImage.Click
        Try
            With OpenFileDialog1
                .Filter = ("Images |* .png; *.bmp; *.jpg; *.jpeg; *.gif; *.ico; *.jfif;")
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

    Private Sub ButtonCancel_Click(sender As System.Object, e As System.EventArgs) Handles ButtonCancel.Click
        Me.Hide()
        MDIParent1.Show()
    End Sub
End Class