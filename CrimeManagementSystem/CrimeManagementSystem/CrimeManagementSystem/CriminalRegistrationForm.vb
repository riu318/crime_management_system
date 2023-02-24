Imports System.Data.SqlClient
Imports System.IO
Imports System.Text.RegularExpressions

Public Class CriminalRegistrationForm
    Private Property Namevalid As Boolean

    Private Sub ButtonSave_Click(sender As System.Object, e As System.EventArgs) Handles ButtonSave.Click
        If TextBox1CriminalID.Text = "" Then
            MsgBox(" Enter the Criminal Id ")
            Exit Sub
        End If
        If TextBox2CriminalName.Text = "" Then
            MsgBox(" Enter the Criminal Name ")
            Exit Sub
        End If
        If TextBox3PhoneNo.Text = "" Then
            MsgBox(" Enter The Ph Number  ")
            Exit Sub
        End If
        If ComboBox1.Text = "" Then
            MsgBox("select the gender")
            Exit Sub
        End If

        If TextBox4Nationality.Text = "" Then
            MsgBox(" Enter the Nationality ")
            Exit Sub
        End If
        If TextBox5Age.Text = "" Then
            MsgBox("Enter the Age")
            Exit Sub
        End If
        If TextBox6Height.Text = "" Then
            MsgBox(" Enter the Height ")
            Exit Sub
        End If
        If TextBox7Address.Text = "" Then
            MsgBox(" Enter the Address ")
            Exit Sub
        End If
        If TextBox8PlaceOfArrest.Text = "" Then
            MsgBox(" Enter the Place where Criminal got arrested ")
            Exit Sub
        End If
        If TextBox10Description.Text = "" Then
            MsgBox(" Enter the Description of Criminal")
            Exit Sub
        End If
        If TextBox11ActionTakken.Text = "" Then
            MsgBox("Enter the what action was taken against criminal ")
            Exit Sub
        End If
        If TextBox12ArrestingOfficer.Text = "" Then
            MsgBox("enter the name of officer who arrested the criminal")
        End If

        If conn.State = ConnectionState.Open Then conn.Close()
        conn.Open()
        Dim a1 As New SqlCommand("select * from CriminalTable where criminalId = '" & TextBox1CriminalID.Text & "' ", conn)
        Dim a2 As SqlDataReader = a1.ExecuteReader
        If a2.HasRows Then
            MsgBox("Already Criminal Data is Registered")
            If conn.State = ConnectionState.Open Then conn.Close()
            Exit Sub
        End If

        Dim command As New SqlCommand("insert into CriminalTable(CriminalId,CriminalName,PhoneNo,DoB,Nationality,Address,DateofArrest,PlaceofArrest,CrimeComitted,Description,ActionTaken,AresstingOfficer,Gender,Age,Height,CriminalImage,FingerPrint,CriminalFile,FingerPrintFile)values(@CriminalId,@CriminalName,@PhoneNo,@DoB,@Nationality,@Address,@DateofArrest,@PlaceofArrest,@CrimeComitted,@Description,@ActionTaken,@AresstingOfficer,@Gender,@Age,@Height,@CriminalImage,@FingerPrint,@CriminalFile,@FingerPrintFile)", conn)
        Dim ms, ms1 As New MemoryStream

        PictureBox2.Image.Save(ms, PictureBox2.Image.RawFormat)
        PictureBox3.Image.Save(ms1, PictureBox3.Image.RawFormat)
        command.Parameters.Add("@CriminalId", SqlDbType.NVarChar).Value = TextBox1CriminalID.Text
        command.Parameters.Add("@CriminalName", SqlDbType.NVarChar).Value = TextBox2CriminalName.Text
        command.Parameters.Add("@PhoneNo", SqlDbType.NVarChar).Value = TextBox3PhoneNo.Text
        command.Parameters.Add("@DoB", SqlDbType.NVarChar).Value = DateTimePicker1.Text
        command.Parameters.Add("@Gender", SqlDbType.NVarChar).Value = ComboBox1.Text
        command.Parameters.Add("@Nationality", SqlDbType.NVarChar).Value = TextBox4Nationality.Text
        command.Parameters.Add("@Age", SqlDbType.NVarChar).Value = TextBox5Age.Text
        command.Parameters.Add("@Height", SqlDbType.NVarChar).Value = TextBox6Height.Text
        command.Parameters.Add("@Address", SqlDbType.NVarChar).Value = TextBox7Address.Text
        command.Parameters.Add("@DateofArrest", SqlDbType.NVarChar).Value = DateTimePicker2.Text
        command.Parameters.Add("@PlaceofArrest", SqlDbType.NVarChar).Value = TextBox8PlaceOfArrest.Text
        command.Parameters.Add("@CrimeComitted", SqlDbType.NVarChar).Value = TextBox9CrimeCommitted.Text
        command.Parameters.Add("@Description", SqlDbType.NVarChar).Value = TextBox10Description.Text
        command.Parameters.Add("@ActionTaken", SqlDbType.NVarChar).Value = TextBox11ActionTakken.Text
        command.Parameters.Add("@AresstingOfficer", SqlDbType.NVarChar).Value = TextBox12ArrestingOfficer.Text
        command.Parameters.Add("@CriminalImage", SqlDbType.Image).Value = ms.ToArray
        command.Parameters.Add("@FingerPrint", SqlDbType.Image).Value = ms1.ToArray
        command.Parameters.Add("@CriminalFile", SqlDbType.NVarChar).Value = Path.GetFileName(OpenFileDialog1.FileName)
        command.Parameters.Add("@FingerPrintFile", SqlDbType.NVarChar).Value = Path.GetFileName(OpenFileDialog1.FileName)


        If conn.State = ConnectionState.Open Then conn.Close()
        conn.Open()
        If command.ExecuteNonQuery() = 1 Then
            MsgBox("Details Saved ", vbInformation)

        TextBox1CriminalID.Text = ""
        TextBox2CriminalName.Text = ""
        TextBox3PhoneNo.Text = ""
        ComboBox1.Text = ""
        TextBox4Nationality.Text = ""
        TextBox5Age.Text = ""
        TextBox6Height.Text = ""
        TextBox7Address.Text = ""
        TextBox8PlaceOfArrest.Text = ""
        TextBox9CrimeCommitted.Text = ""
        TextBox10Description.Text = ""
            TextBox11ActionTakken.Text = ""
        TextBox12ArrestingOfficer.Text = ""
            PictureBox2.Image = Nothing
            PictureBox3.Image = Nothing
        autogenerate_ID()

        Else
            MsgBox("Details Not Saved", vbCritical)
        End If
        If conn.State = ConnectionState.Open Then conn.Close()

    End Sub


    Private Sub CriminalRegistrationForm_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        autogenerate_ID()
        Me.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub autogenerate_ID()
        Dim number As Integer
        If conn.State = ConnectionState.Open Then conn.Close()
        conn.Open()
        Dim cmd As New SqlCommand(number, conn)
        cmd.CommandText = "select max(CriminalId) from CriminalTable"
        If IsDBNull(cmd.ExecuteScalar) Then
            number = 1001
            TextBox1CriminalID.Text = number
        Else
            number = cmd.ExecuteScalar + 1
            TextBox1CriminalID.Text = number
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
            TextBox3PhoneNo.Focus()
        End If
    End Sub

    Private Sub TextBox3PhoneNo_Leave(sender As Object, e As System.EventArgs) Handles TextBox3PhoneNo.Leave
        Dim phonenumber As New Regex("^([6-9]{1})([0-9]{9})$")
        TextBox3PhoneNo.MaxLength = 10
        If phonenumber.IsMatch(TextBox3PhoneNo.Text) Then
            DateTimePicker1.Focus()
        Else
            MsgBox("invalid mobile number")
            TextBox3PhoneNo.Text = ""
            TextBox3PhoneNo.Focus()
        End If
    End Sub

    Private Sub TextBox4Nationality_Leave(sender As Object, e As System.EventArgs) Handles TextBox4Nationality.Leave
        If Not Regex.Match(TextBox4Nationality.Text, "^[A-Za-z. ]*$", RegexOptions.IgnoreCase).Success Then
            MessageBox.Show("please enter only characters")
            TextBox4Nationality.Focus()
            TextBox4Nationality.Text = ""
            Namevalid = False
        Else
            Namevalid = True
            TextBox3PhoneNo.Focus()
        End If
    End Sub

    Private Sub TextBox5Age_Leave(sender As Object, e As System.EventArgs) Handles TextBox5Age.Leave
        If Not Regex.Match(TextBox5Age.Text, "^[0-9.]*$", RegexOptions.IgnoreCase).Success Then
            MessageBox.Show("Please Enter Only Numbers")
            TextBox5Age.Focus()
            TextBox5Age.Text = ""
        Else
            TextBox6Height.Focus()
        End If
    End Sub

    Private Sub TextBox6Height_Leave(sender As Object, e As System.EventArgs) Handles TextBox6Height.Leave
        If Not Regex.Match(TextBox6Height.Text, "^[0-9. ]*$", RegexOptions.IgnoreCase).Success Then
            MessageBox.Show("Please Enter Only Numbers")
            TextBox6Height.Focus()
            TextBox6Height.Text = ""
        Else
            TextBox7Address.Focus()
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

    Private Sub Buttonfinger_Click(sender As System.Object, e As System.EventArgs) Handles Buttonfinger.Click
        Try
            With OpenFileDialog1
                .Filter = ("Images |* .png; *.bmp; *.jpg; *.jpeg; *.gif; *.ico; *.jfif;")
                .FilterIndex = 4
            End With
            OpenFileDialog1.FileName = ""
            If OpenFileDialog1.ShowDialog() = DialogResult.OK Then
                PictureBox3.Image = Image.FromFile(OpenFileDialog1.FileName)
            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub ButtonCancel_Click(sender As System.Object, e As System.EventArgs) Handles ButtonCancel.Click
        MDIParent1.Show()
        Me.Hide()
    End Sub
End Class