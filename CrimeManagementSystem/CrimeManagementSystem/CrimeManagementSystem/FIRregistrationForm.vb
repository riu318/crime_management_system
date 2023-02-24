Imports System.Data.SqlClient
Imports System.Text.RegularExpressions

Public Class FIRregistrationForm
    Private Property Namevalid As Boolean

    Private Sub ButtonSave_Click(sender As System.Object, e As System.EventArgs) Handles ButtonSave.Click
        If TextBox1District.Text = "" Then
            MsgBox(" Enter the District ")
            Exit Sub
        End If
        If TextBox2Policestation.Text = "" Then
            MsgBox(" Enter the Police station ")
            Exit Sub
        End If
        If TextBox3FIRno.Text = "" Then
            MsgBox(" Enter The FIR Number ")
            Exit Sub
        End If
        If TextBox4timeOfFIR.Text = "" Then
            MsgBox(" Enter the time of FIR")
            Exit Sub
        End If
        If TextBox5ActsAndSections.Text = "" Then
            MsgBox("Enter the Act and Section")
            Exit Sub
        End If
        If TextBox6placeOfIncident.Text = "" Then
            MsgBox(" Enter the place of incident ")
            Exit Sub
        End If
        If TextBox7FIRdetails.Text = "" Then
            MsgBox(" Enter the FIR details")
            Exit Sub
        End If
        If TextBox8TimeOfIncident.Text = "" Then
            MsgBox(" Enter the Time Of Incident ")
            Exit Sub
        End If
        If TextBox10Name.Text = "" Then
            MsgBox(" Enter the name of Complainant")
            Exit Sub
        End If
        If TextBox11Age.Text = "" Then
            MsgBox("Enter the Age")
            Exit Sub
        End If
        If ComboBox1.Text = "" Then
            MsgBox("Select the Gender")
            Exit Sub
        End If
        If TextBox12PhNo.Text = "" Then
            MsgBox(" Enter the Phone Number")
            Exit Sub
        End If
        If TextBox13Nationality.Text = "" Then
            MsgBox("Enter the Nationality")
            Exit Sub
        End If
        If ComboBox2.Text = "" Then
            MsgBox("Select the ID Proof")
            Exit Sub
        End If
        If TextBox14IDno.Text = "" Then
            MsgBox(" Enter the ID Number ")
            Exit Sub
        End If
        If TextBox15address.Text = "" Then
            MsgBox(" Enter the Address")
            Exit Sub
        End If
        If conn.State = ConnectionState.Open Then conn.Close()
        conn.Open()

        Dim a1 As New SqlCommand("select * from FIRtable where FIRno = '" & TextBox3FIRno.Text & "' ", conn)
        Dim a2 As SqlDataReader = a1.ExecuteReader

        If a2.HasRows Then
            MsgBox("Already FIR is Registered")
            Exit Sub
        End If

        If conn.State = ConnectionState.Open Then conn.Close()
        conn.Open()

        Dim q1, q2 As String
        q1 = " insert into FIRtable( "
        q2 = "values("
        q1 = q1 & "District" & ","
        q2 = q2 & " '" & TextBox1District.Text & "' ,"
        q1 = q1 & "PoliceStation" & ","
        q2 = q2 & " '" & TextBox2Policestation.Text & "' ,"
        q1 = q1 & "FIRno" & ","
        q2 = q2 & " '" & TextBox3FIRno.Text & "' ,"
        q1 = q1 & "DateOfFIR" & ","
        q2 = q2 & " '" & DateTimePicker1.Value & "' ,"
        q1 = q1 & "TimeOfFIR" & ","
        q2 = q2 & " '" & TextBox4timeOfFIR.Text & "' ,"
        q1 = q1 & "ActsAndSection" & ","
        q2 = q2 & " '" & TextBox5ActsAndSections.Text & "' ,"
        q1 = q1 & "PlaceOfIncident" & ","
        q2 = q2 & " '" & TextBox6placeOfIncident.Text & "' ,"
        q1 = q1 & "FIRdetails" & ","
        q2 = q2 & " '" & TextBox7FIRdetails.Text & "' ,"
        q1 = q1 & "DateOfIncident" & ","
        q2 = q2 & " '" & DateTimePicker2.Value & "' ,"
        q1 = q1 & "TimeOfIncident" & ","
        q2 = q2 & " '" & TextBox8TimeOfIncident.Text & "' ,"
        q1 = q1 & "OtherDetails" & ","
        q2 = q2 & " '" & TextBox9otherDetails.Text & "' ,"
        q1 = q1 & "Name" & ","
        q2 = q2 & " '" & TextBox10Name.Text & "' ,"
        q1 = q1 & "Age" & ","
        q2 = q2 & " '" & TextBox11Age.Text & "' ,"
        q1 = q1 & "Gender" & ","
        q2 = q2 & " '" & ComboBox1.Text & "' ,"
        q1 = q1 & "PhoneNo" & ","
        q2 = q2 & " '" & TextBox12PhNo.Text & "' ,"
        q1 = q1 & "Nationality" & ","
        q2 = q2 & " '" & TextBox13Nationality.Text & "' ,"
        q1 = q1 & "IDproof" & ","
        q2 = q2 & " '" & ComboBox2.Text & "' ,"
        q1 = q1 & "IDno" & ","
        q2 = q2 & " '" & TextBox14IDno.Text & "' ,"
        q1 = q1 & "address" & ")"
        q2 = q2 & "'" & TextBox15address.Text & "' )"


        Dim Command As New SqlCommand(q1 & q2, conn)
        Command.ExecuteNonQuery()
        If conn.State = ConnectionState.Open Then conn.Close()
        MsgBox(" FIR resistered Successfully ")
        'autogenerate_ID()

        TextBox1District.Text = ""
        TextBox2Policestation.Text = ""
        TextBox3FIRno.Text = ""
        DateTimePicker1.Text = ""
        TextBox4timeOfFIR.Text = ""
        TextBox5ActsAndSections.Text = ""
        TextBox6placeOfIncident.Text = ""
        TextBox7FIRdetails.Text = ""
        DateTimePicker2.Text = ""
        TextBox8TimeOfIncident.Text = ""
        TextBox9otherDetails.Text = ""
        TextBox10Name.Text = ""
        TextBox11Age.Text = ""
        ComboBox1.Text = ""
        TextBox12PhNo.Text = ""
        TextBox13Nationality.Text = ""
        ComboBox2.Text = ""
        TextBox14IDno.Text = ""
        TextBox15address.Text = ""

        autogenerate_ID()

    End Sub

    Private Sub ButtonCancel_Click(sender As System.Object, e As System.EventArgs) Handles ButtonCancel.Click
        Me.Close()
        Me.Hide()
    End Sub

    Private Sub TextBox1District_Leave(sender As Object, e As System.EventArgs) Handles TextBox1District.Leave
        If Not Regex.Match(TextBox1District.Text, "^[A-Za-z. ]*$", RegexOptions.IgnoreCase).Success Then
            MessageBox.Show("Please Enter Only Characters")
            TextBox1District.Focus()
            TextBox1District.Text = ""
            Namevalid = False
        Else
            Namevalid = True
            TextBox2Policestation.Focus()
        End If
    End Sub

    Private Sub TextBox2Policestation_Leave(sender As Object, e As System.EventArgs) Handles TextBox2Policestation.Leave
        If Not Regex.Match(TextBox2Policestation.Text, "^[A-Za-z. ]*$", RegexOptions.IgnoreCase).Success Then
            MessageBox.Show("Please Enter Only Characters")
            TextBox2Policestation.Focus()
            TextBox2Policestation.Text = ""
            Namevalid = False
        Else
            Namevalid = True
            TextBox3FIRno.Focus()
        End If
    End Sub

    Private Sub TextBox3FIRno_Leave(sender As Object, e As System.EventArgs) Handles TextBox3FIRno.Leave
        If Not Regex.Match(TextBox3FIRno.Text, "^[0-9.]*$", RegexOptions.IgnoreCase).Success Then
            MessageBox.Show("Please Enter Only Numbers")
            TextBox3FIRno.Focus()
            TextBox3FIRno.Text = ""
        Else
            DateTimePicker1.Focus()
        End If
    End Sub

    Private Sub autogenerate_ID()
        Dim number As Integer
        If conn.State = ConnectionState.Open Then conn.Close()
        conn.Open()
        Dim cmd As New SqlCommand(number, conn)
        cmd.CommandText = "select max(FIRno) from FIRtable"
        If IsDBNull(cmd.ExecuteScalar) Then
            number = 1001
            TextBox3FIRno.Text = number
        Else
            number = cmd.ExecuteScalar + 1
            TextBox3FIRno.Text = number
        End If
        cmd.Dispose()
    End Sub

    Private Sub TextBox10Name_Leave(sender As Object, e As System.EventArgs) Handles TextBox10Name.Leave
        If Not Regex.Match(TextBox10Name.Text, "^[A-Za-z.  ]*$", RegexOptions.IgnoreCase).Success Then
            MessageBox.Show("Please Enter Only Characters")
            TextBox10Name.Focus()
            TextBox10Name.Text = ""
            Namevalid = False
        Else
            Namevalid = True
            TextBox11Age.Focus()
        End If
    End Sub

    Private Sub TextBox11Age_Leave(sender As Object, e As System.EventArgs) Handles TextBox11Age.Leave
        If Not Regex.Match(TextBox11Age.Text, "^[0-9.]*$", RegexOptions.IgnoreCase).Success Then
            MessageBox.Show("Please Enter Only Numbers")
            TextBox11Age.Focus()
            TextBox11Age.Text = ""
        Else
            ComboBox1.Focus()
        End If
    End Sub

    Private Sub TextBox12PhNo_Leave(sender As Object, e As System.EventArgs) Handles TextBox12PhNo.Leave
        Dim phonenumber As New Regex("^([6-9]{1})([0-9]{9})$")
        TextBox12PhNo.MaxLength = 10
        If phonenumber.IsMatch(TextBox12PhNo.Text) Then
            TextBox13Nationality.Focus()
        Else
            MsgBox("Invalid Phone Number")
            TextBox12PhNo.Text = ""
            TextBox12PhNo.Focus()
        End If
    End Sub
    Private Sub TextBox13Nationality_Leave(sender As Object, e As System.EventArgs) Handles TextBox13Nationality.Leave
        If Not Regex.Match(TextBox13Nationality.Text, "^[A-Za-z. ]*$", RegexOptions.IgnoreCase).Success Then
            MessageBox.Show("Please Enter Only Characters")
            TextBox13Nationality.Focus()
            TextBox13Nationality.Text = ""
            Namevalid = False
        Else
            Namevalid = True
            ComboBox2.Focus()
        End If
    End Sub

    Private Sub Timer1_Tick(sender As System.Object, e As System.EventArgs) Handles Timer1.Tick
        Dim i As Integer
        TextBox4timeOfFIR.Text = vbNewLine & TimeOfDay
        i = i + 1
        If i > 5 Then
            Timer1.Enabled = False
            TextBox4timeOfFIR.Show()
        End If

    End Sub

    Private Sub FIRregistrationForm_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        autogenerate_ID()
        Me.WindowState = FormWindowState.Maximized
    End Sub
End Class