Imports System.Data.SqlClient
Imports System.Text.RegularExpressions

Public Class CasesRegistrationForm
    Dim a As String
    Private Property Namevalid As Boolean

    Private Sub ButtonSave_Click(sender As System.Object, e As System.EventArgs) Handles ButtonSave.Click

        If TextBox1CaseID.Text = "" Then
            MsgBox(" Enter the Case ID ")
            Exit Sub
        End If
        If TextBox2CaseTitle.Text = "" Then
            MsgBox(" Enter the Case Title ")
            Exit Sub
        End If
        If TextBox3FiledBy.Text = "" Then
            MsgBox(" Enter The Name Who Filed The Case ")
            Exit Sub
        End If
        If TextBox4HandledBy.Text = "" Then
            MsgBox("Enter The Name Who Is Handling The Case")
            Exit Sub
        End If
        If TextBox5CaseDescription.Text = "" Then
            MsgBox("Fill the Case Description")
            Exit Sub
        End If
        If TextBox6vitimName.Text = "" Then
            MsgBox("Enter the Name of the Victim ")
            Exit Sub
        End If
        If TextBox1Witness1.Text = "" Then
            MsgBox("Fill the witness details")
            Exit Sub
        End If
        If TextBox1Contact1.Text = "" Then
            MsgBox("Fill the witness details")
            Exit Sub
        End If

        If conn.State = ConnectionState.Open Then conn.Close()
        conn.Open()

        Dim a1 As New SqlCommand("select * from CaseTable where CaseID = '" & TextBox1CaseID.Text & "' ", conn)
        Dim a2 As SqlDataReader = a1.ExecuteReader

        If a2.HasRows Then
            MsgBox("Already Case is Registered")
            Exit Sub
        End If

        If conn.State = ConnectionState.Open Then conn.Close()
        conn.Open()

        Dim q1, q2 As String

        q1 = " insert into CaseTable( "
        q2 = "values("
        q1 = q1 & "CaseID" & ","
        q2 = q2 & " '" & TextBox1CaseID.Text & "' ,"
        q1 = q1 & "CaseTitle" & ","
        q2 = q2 & " '" & TextBox2CaseTitle.Text & "' ,"
        q1 = q1 & "CaseFiledBy" & ","
        q2 = q2 & " '" & TextBox3FiledBy.Text & "' ,"
        q1 = q1 & "CaseFiledDate" & ","
        q2 = q2 & " '" & DateTimePicker1.Value & "' ,"
        q1 = q1 & "CaseStatus" & ","
        q2 = q2 & " '" & a & "' ,"
        q1 = q1 & "CaseHandledBy" & ","
        q2 = q2 & " '" & TextBox4HandledBy.Text & "' ,"
        q1 = q1 & "VictimName" & ","
        q2 = q2 & " '" & TextBox6vitimName.Text & "' ,"
        q1 = q1 & "CaseDescription" & ","
        q2 = q2 & "'" & TextBox5CaseDescription.Text & "' ,"
        q1 = q1 & "Witness1" & ","
        q2 = q2 & "'" & TextBox1Witness1.Text & "' ,"
        q1 = q1 & "ContactNo1" & ","
        q2 = q2 & "'" & TextBox1Contact1.Text & "' ,"
        q1 = q1 & "Witness2" & ","
        q2 = q2 & "'" & TextBox2Witness2.Text & "' ,"
        q1 = q1 & "ContactNo2" & ","
        q2 = q2 & "'" & TextBox2contact2.Text & "' ,"
        q1 = q1 & "Witness3" & ","
        q2 = q2 & "'" & TextBox3Witness3.Text & "' ,"
        q1 = q1 & "ContactNo3" & ")"
        q2 = q2 & "'" & TextBox3contact3.Text & "' )"

        Dim Command As New SqlCommand(q1 & q2, conn)
        Command.ExecuteNonQuery()

        If conn.State = ConnectionState.Open Then conn.Close()
        MsgBox(" Case Status Registered Successfully ")
        TextBox1CaseID.Text = ""
        TextBox2CaseTitle.Text = ""
        TextBox3FiledBy.Text = ""
        DateTimePicker1.Text = ""
        a = ""
        TextBox4HandledBy.Text = ""
        TextBox5CaseDescription.Text = ""
        TextBox6vitimName.Text = ""
        TextBox1Witness1.Text = ""
        TextBox1Contact1.Text = ""
        TextBox2Witness2.Text = ""
        TextBox2contact2.Text = ""
        TextBox3Witness3.Text = ""
        TextBox3contact3.Text = ""

        autogenerate_ID()

    End Sub

    Private Sub autogenerate_ID()
        Dim number As Integer
        If conn.State = ConnectionState.Open Then conn.Close()
        conn.Open()
        Dim cmd As New SqlCommand(number, conn)
        cmd.CommandText = "select max(CaseID) from CaseTable"
        If IsDBNull(cmd.ExecuteScalar) Then
            number = 1001
            TextBox1CaseID.Text = number
        Else
            number = cmd.ExecuteScalar + 1
            TextBox1CaseID.Text = number
        End If
        cmd.Dispose()
    End Sub
    Private Sub TextBox1CaseID_Leave(sender As Object, e As System.EventArgs) Handles TextBox1CaseID.Leave
        If Not Regex.Match(TextBox1CaseID.Text, "^[0-9.]*$", RegexOptions.IgnoreCase).Success Then
            MessageBox.Show("Please Enter Only Numbers")
            TextBox1CaseID.Focus()
            TextBox1CaseID.Text = ""
        Else
            TextBox2CaseTitle.Focus()
        End If
    End Sub

    Private Sub TextBox2CaseTitle_Leave(sender As Object, e As System.EventArgs) Handles TextBox2CaseTitle.Leave
        If Not Regex.Match(TextBox2CaseTitle.Text, "^[A-Za-z. ]*$", RegexOptions.IgnoreCase).Success Then
            MessageBox.Show("Please Enter Only Characters")
            TextBox2CaseTitle.Focus()
            TextBox2CaseTitle.Text = ""
            Namevalid = False
        Else
            Namevalid = True
            TextBox3FiledBy.Focus()
        End If
    End Sub

    Private Sub TextBox3FiledBy_Leave(sender As Object, e As System.EventArgs) Handles TextBox3FiledBy.Leave
        If Not Regex.Match(TextBox3FiledBy.Text, "^[A-Za-z. ]*$", RegexOptions.IgnoreCase).Success Then
            MessageBox.Show("Please Enter Only Characters")
            TextBox3FiledBy.Focus()
            TextBox3FiledBy.Text = ""
            Namevalid = False
        Else
            Namevalid = True
            DateTimePicker1.Focus()
        End If
    End Sub


    Private Sub TextBox4HandledBy_Leave(sender As Object, e As System.EventArgs) Handles TextBox4HandledBy.Leave
        If Not Regex.Match(TextBox3FiledBy.Text, "^[A-Za-z. ]*$", RegexOptions.IgnoreCase).Success Then
            MessageBox.Show("Please Enter Only Characters")
            TextBox4HandledBy.Focus()
            TextBox4HandledBy.Text = ""
            Namevalid = False
        Else
            Namevalid = True
            TextBox5CaseDescription.Focus()
        End If
    End Sub

    Private Sub ButtonCancel_Click(sender As System.Object, e As System.EventArgs) Handles ButtonCancel.Click
        MDIParent1.Show()
        Me.Hide()
    End Sub

    Private Sub CasesRegistrationForm_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        autogenerate_ID()
        Me.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub RadioButton1_Click(sender As Object, e As System.EventArgs) Handles RadioButton1.Click
        a = "Pending Case"
        MsgBox(a)
    End Sub

    Private Sub RadioButton2_Click(sender As Object, e As System.EventArgs) Handles RadioButton2.Click
        a = "Progress Case"
        MsgBox(a)
    End Sub

    Private Sub RadioButton3_Click(sender As Object, e As System.EventArgs) Handles RadioButton3.Click
        a = "Dispossed Case"
        MsgBox(a)
    End Sub

  
End Class