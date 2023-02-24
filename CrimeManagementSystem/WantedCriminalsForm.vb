Imports System.Data.SqlClient
Imports System.IO
Imports System.Text.RegularExpressions
Public Class WantedCriminalsForm
    Private Property Namevalid As Boolean
    Private Sub ButtonSave_Click(sender As System.Object, e As System.EventArgs) Handles ButtonSave.Click
        If TextBox1CriminalNo.Text = "" Then
            MsgBox(" Enter the Criminal No ")
            Exit Sub
        End If
        If TextBox2CriminalName.Text = "" Then
            MsgBox(" Enter the Criminal Name ")
            Exit Sub
        End If
        If TextBox3CrimeCommitted.Text = "" Then
            MsgBox("enter the crime comitted by the criminals")
            Exit Sub
        End If
        If TextBox4Description.Text = "" Then
            MsgBox(" Enter the Description of Criminal")
            Exit Sub
        End If
        If conn.State = ConnectionState.Open Then conn.Close()
        conn.Open()
        Dim a1 As New SqlCommand("select * from WantedCriminalTable where criminalNo = '" & TextBox1CriminalNo.Text & "' ", conn)
        Dim a2 As SqlDataReader = a1.ExecuteReader
        If a2.HasRows Then
            MsgBox("Already Criminal is Under Wanted List")
            If conn.State = ConnectionState.Open Then conn.Close()
            Exit Sub
        End If

        Dim command As New SqlCommand("insert into WantedCriminalTable(CriminalNo,CriminalName,CrimeCommitted,CriminalDescription,WantedCriminalImage,WantedCriminalFile)values(@CriminalNo,@CriminalName,@CrimeCommitted,@CriminalDescription,@WantedCriminalImage,@WantedCriminalFile)", conn)
        Dim ms As New MemoryStream

        PictureBox2.Image.Save(ms, PictureBox2.Image.RawFormat)
        command.Parameters.Add("@CriminalNo", SqlDbType.NVarChar).Value = TextBox1CriminalNo.Text
        command.Parameters.Add("@CriminalName", SqlDbType.NVarChar).Value = TextBox2CriminalName.Text
        command.Parameters.Add("@CrimeCommitted", SqlDbType.NVarChar).Value = TextBox3CrimeCommitted.Text
        command.Parameters.Add("@CriminalDescription", SqlDbType.NVarChar).Value = TextBox4Description.Text
        command.Parameters.Add("@WantedCriminalImage", SqlDbType.Image).Value = ms.ToArray
        command.Parameters.Add("@WantedCriminalFile", SqlDbType.NVarChar).Value = Path.GetFileName(OpenFileDialog1.FileName)


        If conn.State = ConnectionState.Open Then conn.Close()
        conn.Open()
        If command.ExecuteNonQuery() = 1 Then
            MsgBox("Details Saved ", vbInformation)

            TextBox1CriminalNo.Text = ""
            TextBox2CriminalName.Text = ""
            TextBox3CrimeCommitted.Text = ""
            TextBox4Description.Text = ""
            PictureBox2.Image = Nothing
            autogenerate_ID()

        Else
            MsgBox("Details Not Saved", vbCritical)
        End If
        If conn.State = ConnectionState.Open Then conn.Close()

    End Sub

    Private Sub WantedCriminalsForm_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        autogenerate_ID()
        Me.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub autogenerate_ID()
        Dim number As Integer
        If conn.State = ConnectionState.Open Then conn.Close()
        conn.Open()
        Dim cmd As New SqlCommand(number, conn)
        cmd.CommandText = "select max(CriminalNo) from WantedCriminalTable"
        If IsDBNull(cmd.ExecuteScalar) Then
            number = 1
            TextBox1CriminalNo.Text = number
        Else
            number = cmd.ExecuteScalar + 1
            TextBox1CriminalNo.Text = number
        End If
        cmd.Dispose()
    End Sub

    Private Sub TextBox2CriminalName_Leave(sender As Object, e As System.EventArgs) Handles TextBox2CriminalName.Leave
        If Not Regex.Match(TextBox2CriminalName.Text, "^[A-Za-z. ]*$", RegexOptions.IgnoreCase).Success Then
            MessageBox.Show("please enter only characters")
            TextBox2CriminalName.Focus()
            TextBox2CriminalName.Text = ""
            Namevalid = False
        Else
            Namevalid = True
            TextBox3CrimeCommitted.Focus()
        End If
    End Sub

    Private Sub ButtonImage_Click(sender As System.Object, e As System.EventArgs) Handles ButtonImage.Click
        Try
            With OpenFileDialog1
                .Filter = ("Images |* .png; *.bmp; *.jpg; *.jpeg; *.gif; *.ico; *.jfif;")
                .FilterIndex = 4
            End With
            OpenFileDialog1.FileName = ""
            If OpenFileDialog1.ShowDialog() = DialogResult.OK Then
                PictureBox2.Image = Image.FromFile(OpenFileDialog1.FileName)
            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub ButtonCancel_Click(sender As System.Object, e As System.EventArgs) Handles ButtonCancel.Click
        MDIParent1.Show()
        Me.Hide()
    End Sub

    Private Sub PictureBox2_Click(sender As System.Object, e As System.EventArgs) Handles PictureBox2.Click

    End Sub
End Class