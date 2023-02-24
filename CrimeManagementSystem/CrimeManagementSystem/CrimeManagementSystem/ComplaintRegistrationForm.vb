Imports System.Data.SqlClient
Imports System.Text.RegularExpressions

Public Class ComplaintRegistrationForm

    Private Property Namevalid As Boolean

    Private Sub ButtonSave_Click(sender As System.Object, e As System.EventArgs) Handles ButtonSave.Click

        If TextBox1Complainno.Text = "" Then
            MsgBox(" Enter the Complaint Number ")
            Exit Sub
        End If
        If TextBox2District.Text = "" Then
            MsgBox(" Enter the District ")
            Exit Sub
        End If
        If TextBox3Policestation.Text = "" Then
            MsgBox(" Enter The Police Station ")
            Exit Sub
        End If
        If TextBox4time.Text = "" Then
            MsgBox(" Enter the time of Complaint Registration")
            Exit Sub
        End If
        If ComboBox1.Text = "" Then
            MsgBox("Select the Complaint Type")
            Exit Sub
        End If
        If TextBox5complainantname.Text = "" Then
            MsgBox("Enter the Name Of Complainant")
            Exit Sub
        End If
        If TextBox6age.Text = "" Then
            MsgBox(" Enter the Age Of Complainant ")
            Exit Sub
        End If
        If TextBox7Phno.Text = "" Then
            MsgBox(" Enter the Phone Number ")
            Exit Sub
        End If
        If ComboBox2.Text = "" Then
            MsgBox("Select the Gender")
            Exit Sub
        End If
        If ComboBox3.Text = "" Then
            MsgBox("Select the ID Proof")
            Exit Sub
        End If
        If TextBox8IDno.Text = "" Then
            MsgBox(" Enter the ID Number ")
            Exit Sub
        End If
        If TextBox9address.Text = "" Then
            MsgBox(" Enter the Address of Complainant")
            Exit Sub
        End If
        If TextBox10complaindetails.Text = "" Then
            MsgBox("Enter the details of the complaint ")
            Exit Sub
        End If

        If conn.State = ConnectionState.Open Then conn.Close()
        conn.Open()

        Dim a1 As New SqlCommand("select * from ComplaintTable where IDno = '" & TextBox1Complainno.Text & "' ", conn)
        Dim a2 As SqlDataReader = a1.ExecuteReader

        If a2.HasRows Then
            MsgBox("Already Complaint is Registered")
            Exit Sub
        End If

        If conn.State = ConnectionState.Open Then conn.Close()
        conn.Open()

        Dim q1, q2 As String

        q1 = " insert into ComplaintTable( "
        q2 = "values("
        q1 = q1 & "ComplaintNo" & ","
        q2 = q2 & " '" & TextBox1Complainno.Text & "' ,"
        q1 = q1 & "District" & ","
        q2 = q2 & " '" & TextBox2District.Text & "' ,"
        q1 = q1 & "PoliceStation" & ","
        q2 = q2 & " '" & TextBox3Policestation.Text & "' ,"
        q1 = q1 & "DateOfComplaint" & ","
        q2 = q2 & " '" & DateTimePicker1.Value & "' ,"
        q1 = q1 & "Time" & ","
        q2 = q2 & " '" & TextBox4time.Text & "' ,"
        q1 = q1 & "ComplaintType" & ","
        q2 = q2 & " '" & ComboBox1.Text & "' ,"
        q1 = q1 & "NameOfComplaint" & ","
        q2 = q2 & " '" & TextBox5complainantname.Text & "' ,"
        q1 = q1 & "Age" & ","
        q2 = q2 & " '" & TextBox6age.Text & "' ,"
        q1 = q1 & "PhoneNo" & ","
        q2 = q2 & " '" & TextBox7Phno.Text & "' ,"
        q1 = q1 & "Gender" & ","
        q2 = q2 & " '" & ComboBox2.Text & "' ,"
        q1 = q1 & "IDproof" & ","
        q2 = q2 & " '" & ComboBox3.Text & "' ,"
        q1 = q1 & "IDno" & ","
        q2 = q2 & " '" & TextBox8IDno.Text & "' ,"
        q1 = q1 & "Address" & ","
        q2 = q2 & " '" & TextBox9address.Text & "' ,"
        q1 = q1 & "ComplaintDetails" & ")"
        q2 = q2 & "'" & TextBox10complaindetails.Text & "' )"


        Dim Command As New SqlCommand(q1 & q2, conn)
        Command.ExecuteNonQuery()
        MsgBox(" Complaint Resistered Successfully ")

        TextBox1Complainno.Text = ""
        TextBox2District.Text = ""
        TextBox3Policestation.Text = ""
        DateTimePicker1.Text = ""
        TextBox4time.Text = ""
        ComboBox1.Text = ""
        TextBox5complainantname.Text = ""
        TextBox6age.Text = ""
        TextBox7Phno.Text = ""
        ComboBox2.Text = ""
        ComboBox3.Text = ""
        TextBox8IDno.Text = ""
        TextBox9address.Text = ""
        TextBox10complaindetails.Text = ""

        autogenerate_ID()
    End Sub

    Private Sub ButtonCancel_Click(sender As System.Object, e As System.EventArgs) Handles ButtonCancel.Click
        MDIParent1.Show()
        Me.Hide()
    End Sub

    Private Sub autogenerate_ID()
        Dim number As Integer
        If conn.State = ConnectionState.Open Then conn.Close()
        conn.Open()
        Dim cmd As New SqlCommand(number, conn)
        cmd.CommandText = "select max(ComplaintNo) from ComplaintTable"
        If IsDBNull(cmd.ExecuteScalar) Then
            number = 1001
            TextBox1Complainno.Text = number
        Else
            number = cmd.ExecuteScalar + 1
            TextBox1Complainno.Text = number
        End If
        cmd.Dispose()
    End Sub

    Private Sub TextBox1Complainno_Leave(sender As Object, e As System.EventArgs) Handles TextBox1Complainno.Leave
        If Not Regex.Match(TextBox1Complainno.Text, "^[0-9.]*$", RegexOptions.IgnoreCase).Success Then
            MessageBox.Show("Please Enter Only Numbers")
            TextBox1Complainno.Focus()
            TextBox1Complainno.Text = ""
        Else
            TextBox2District.Focus()
        End If
    End Sub

    Private Sub TextBox2District_Leave(sender As Object, e As System.EventArgs) Handles TextBox2District.Leave
        If Not Regex.Match(TextBox2District.Text, "^[A-Za-z. ]*$", RegexOptions.IgnoreCase).Success Then
            MessageBox.Show("Please Enter Only Characters")
            TextBox2District.Focus()
            TextBox2District.Text = ""
            Namevalid = False
        Else
            Namevalid = True
            TextBox3Policestation.Focus()
        End If
    End Sub

    Private Sub TextBox3Polocestation_Leave(sender As Object, e As System.EventArgs) Handles TextBox3Policestation.Leave
        If Not Regex.Match(TextBox3Policestation.Text, "^[A-Za-z. ]*$", RegexOptions.IgnoreCase).Success Then
            MessageBox.Show("Please Enter Only Characters")
            TextBox3Policestation.Focus()
            TextBox3Policestation.Text = ""
            Namevalid = False
        Else
            Namevalid = True
            DateTimePicker1.Focus()
        End If
    End Sub
    Private Sub TextBox5complainantname_Leave(sender As Object, e As System.EventArgs) Handles TextBox5complainantname.Leave
        If Not Regex.Match(TextBox5complainantname.Text, "^[A-Za-z. ]*$", RegexOptions.IgnoreCase).Success Then
            MessageBox.Show("please enter only characters")
            TextBox5complainantname.Focus()
            TextBox5complainantname.Text = ""
            Namevalid = False
        Else
            Namevalid = True
            TextBox6age.Focus()
        End If
    End Sub

    Private Sub TextBox6age_Leave(sender As Object, e As System.EventArgs) Handles TextBox6age.Leave
        If Not Regex.Match(TextBox6age.Text, "^[0-9.]*$", RegexOptions.IgnoreCase).Success Then
            MessageBox.Show("Please Enter Only Numbers")
            TextBox6age.Focus()
            TextBox6age.Text = ""
        Else
            TextBox7Phno.Focus()
        End If
    End Sub
    Private Sub TextBox7Phno_Leave(sender As Object, e As System.EventArgs) Handles TextBox7Phno.Leave
        Dim phonenumber As New Regex("^([6-9]{1})([0-9]{9})$")
        TextBox7Phno.MaxLength = 10
        If phonenumber.IsMatch(TextBox7Phno.Text) Then
            ComboBox2.Focus()
        Else
            MsgBox("invalid mobile number")
            TextBox7Phno.Text = ""
            TextBox7Phno.Focus()
        End If
    End Sub

    Private Sub ComplaintRegistrationForm_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        autogenerate_ID()
        Me.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub Timer1_Tick(sender As System.Object, e As System.EventArgs) Handles Timer1.Tick
        Dim i As Integer
        TextBox4time.Text = vbNewLine & TimeOfDay
        i = i + 1
        If i > 5 Then
            Timer1.Enabled = False
            TextBox4time.Show()
        End If
    End Sub
End Class