Imports System.Data.SqlClient
Imports System.Text.RegularExpressions
Imports System.Net.Mail

Public Class StaffRegistrationForm
    Private Property Namevalid As Boolean

    Private Sub ButtonSave_Click(sender As System.Object, e As System.EventArgs) Handles ButtonSave.Click
        If TextBox1ID.Text = "" Then
            MsgBox(" Enter the ID Number ")
            Exit Sub
        End If
        If TextBox2Name.Text = "" Then
            MsgBox(" Enter the Name ")
            Exit Sub
        End If
        If ComboBox1.Text = "" Then
            MsgBox("Select the Designation")
            Exit Sub
        End If
        If ComboBox2.Text = "" Then
            MsgBox("Select the Gender")
            Exit Sub
        End If
        If TextBox3PhNo.Text = "" Then
            MsgBox("Enter the Contact Number")
            Exit Sub
        End If
        If ComboBox3.Text = "" Then
            MsgBox("Select the Qualification")
            Exit Sub
        End If
        If TextBox4Email.Text = "" Then
            MsgBox(" Enter the E-mail ")
            Exit Sub
        End If
        If TextBox5Address.Text = "" Then
            MsgBox(" Enter the Address ")
            Exit Sub
        End If
        If TextBox6PinCode.Text = "" Then
            MsgBox(" Enter the Pin Code Number ")
            Exit Sub
        End If

        If conn.State = ConnectionState.Open Then conn.Close()
        conn.Open()

        Dim a1 As New SqlCommand("select * from StaffTable where IDno = '" & TextBox1ID.Text & "' ", conn)
        Dim a2 As SqlDataReader = a1.ExecuteReader

        If a2.HasRows Then
            MsgBox("Data Already Registered")
            Exit Sub
        End If

        If conn.State = ConnectionState.Open Then conn.Close()
        conn.Open()

        Dim q1, q2 As String

        q1 = " insert into StaffTable( "
        q2 = "values("
        q1 = q1 & "IDno" & ","
        q2 = q2 & " '" & TextBox1ID.Text & "' ,"
        q1 = q1 & "Name" & ","
        q2 = q2 & " '" & TextBox2Name.Text & "' ,"
        q1 = q1 & "Designation" & ","
        q2 = q2 & " '" & ComboBox1.Text & "' ,"
        q1 = q1 & "Gender" & ","
        q2 = q2 & " '" & ComboBox2.Text & "' ,"
        q1 = q1 & "PhNo" & ","
        q2 = q2 & " '" & TextBox3PhNo.Text & "' ,"
        q1 = q1 & "Qualification" & ","
        q2 = q2 & " '" & ComboBox3.Text & "' ,"
        q1 = q1 & "Email" & ","
        q2 = q2 & " '" & TextBox4Email.Text & "' ,"
        q1 = q1 & "Address" & ","
        q2 = q2 & " '" & TextBox5Address.Text & "' ,"
        q1 = q1 & "PinCode" & ")"
        q2 = q2 & "'" & TextBox6PinCode.Text & "' )"


        Dim Command As New SqlCommand(q1 & q2, conn)
        Command.ExecuteNonQuery()
        MsgBox(" Staff Details Resistered Successfully ")


        TextBox1.AppendText("Welcome To Crime Management System" + vbNewLine)
        TextBox1.AppendText("----------------------------------------------------------" + vbNewLine)
        TextBox1.AppendText("ID Number :" + TextBox1ID.Text + vbNewLine)
        TextBox1.AppendText("Name :" + TextBox2Name.Text + vbNewLine)
        TextBox1.AppendText("Designation :" + ComboBox1.Text + vbNewLine)
        TextBox1.AppendText("----------------------------------------------------------" + vbNewLine)

        TextBox1.AppendText("User Id : rinku " + vbNewLine)
        TextBox1.AppendText("Password :  rink31" + vbNewLine)
        TextBox1.AppendText("----------------------------------------------------------" + vbNewLine)
        TextBox1.AppendText("Please Login With These Credentials After Approved" + vbNewLine)
        TextBox1.AppendText("----------------------------------------------------------" + vbNewLine)

        Dim Mail As New MailMessage
        Mail.Subject = "Registration Successful!!!"
        If TextBox4Email.Text = "" Then
            MsgBox("Please Enter The E-Mail Address", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Error!")
        End If
        Mail.To.Add(TextBox4Email.Text)
        Mail.From = New MailAddress("crimemanagement5@gmail.com")
        Mail.Body = TextBox1.Text


        Dim SMTP As New SmtpClient("smtp.gmail.com")
        SMTP.EnableSsl = True
        SMTP.Credentials = New System.Net.NetworkCredential("crimemanagement5@gmail.com", "gowtham@5")
        SMTP.Port = "587"
        SMTP.Send(Mail)
        MsgBox("Confirmation Mail Has Been Sent To Your Mail Id", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Crime Management System")





        TextBox1ID.Text = ""
        TextBox2Name.Text = ""
        ComboBox1.Text = ""
        ComboBox2.Text = ""
        TextBox3PhNo.Text = ""
        ComboBox3.Text = ""
        TextBox4Email.Text = ""
        TextBox5Address.Text = ""
        TextBox6PinCode.Text = ""

        autogenerate_ID()

    End Sub

    Private Sub autogenerate_ID()
        Dim number As Integer
        If conn.State = ConnectionState.Open Then conn.Close()
        conn.Open()
        Dim cmd As New SqlCommand(number, conn)
        cmd.CommandText = "select max(IDno) from StaffTable"
        If IsDBNull(cmd.ExecuteScalar) Then
            number = 1001
            TextBox1ID.Text = number
        Else
            number = cmd.ExecuteScalar + 1
            TextBox1ID.Text = number
        End If
        cmd.Dispose()
    End Sub

    Private Sub TextBox2Name_Leave(sender As Object, e As System.EventArgs) Handles TextBox2Name.Leave
        If Not Regex.Match(TextBox2Name.Text, "^[A-Za-z. ]*$", RegexOptions.IgnoreCase).Success Then
            MessageBox.Show("please enter only characters")
            TextBox2Name.Focus()
            TextBox2Name.Text = ""
            Namevalid = False
        Else
            Namevalid = True
            ComboBox1.Focus()
        End If
    End Sub

    Private Sub TextBox3PhNo_Leave(sender As Object, e As System.EventArgs) Handles TextBox3PhNo.Leave
        Dim phonenumber As New Regex("^([6-9]{1})([0-9]{9})$")
        TextBox3PhNo.MaxLength = 10
        If phonenumber.IsMatch(TextBox3PhNo.Text) Then
            ComboBox2.Focus()
        Else
            MsgBox("invalid mobile number")
            TextBox3PhNo.Text = ""
            TextBox3PhNo.Focus()
        End If
    End Sub

    Private Sub TextBox4Email_Leave(sender As Object, e As System.EventArgs) Handles TextBox4Email.Leave
        Dim regex As Regex = New Regex("^([A-Za-z0-9_\-\.)+\@(A-Za-z0-9_\-\.])+\.([A-Za-z]{2,4})$")
        Dim isvalid As Boolean = regex.IsMatch(TextBox4Email.Text.Trim)
        TextBox5Address.Focus()
        If Not isvalid Then
            MessageBox.Show("invalid email")
            TextBox4Email.Text = ""
            TextBox4Email.Focus()
        End If
    End Sub

    Private Sub TextBox6PinCode_Leave(sender As Object, e As System.EventArgs) Handles TextBox6PinCode.Leave
        If Not Regex.Match(TextBox6PinCode.Text, "^[0-9.]*$", RegexOptions.IgnoreCase).Success Then
            MessageBox.Show("Please Enter Only Numbers")
            TextBox6PinCode.Focus()
            TextBox6PinCode.Text = ""
        End If
    End Sub

    Private Sub ButtonCancel_Click(sender As System.Object, e As System.EventArgs) Handles ButtonCancel.Click
        MDIParent1.Show()
        Me.Hide()
    End Sub

    Private Sub UserRegistrationForm_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        autogenerate_ID()
        Me.WindowState = FormWindowState.Maximized
    End Sub
End Class