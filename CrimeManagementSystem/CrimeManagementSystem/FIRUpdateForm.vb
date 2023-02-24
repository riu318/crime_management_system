Imports System.Data.SqlClient

Public Class FIRUpdateForm
    Dim pkvar As String
    Private Sub ButtonUpdate_Click(sender As System.Object, e As System.EventArgs) Handles ButtonUpdate.Click

        If vbNo = MsgBox("Are you sure you want to update this record ?", MsgBoxStyle.YesNo, "delete") Then Exit Sub
        If conn.State = ConnectionState.Open Then conn.Close()
        conn.Open()
        Dim cmd1 As New SqlCommand("Delete from FIRtable where FIRno='" & TextBox3FIRno.Text & "'", conn)
        cmd1.ExecuteNonQuery()
        If conn.State = ConnectionState.Open Then conn.Close()
        saverecords()
        ButtonUpdate.Enabled = True
        ButtonDelete.Enabled = True
        ButtonCancel.Enabled = True
        disrecords()

    End Sub

    Private Sub FIRUpdateForm_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        disrecords()
    End Sub

    Private Sub disrecords()
        If conn.State = ConnectionState.Open Then conn.Close()
        conn.Open()
        Dim ds1 As New DataSet
        Dim adp As New SqlDataAdapter("select District,PoliceStation,FIRno,DateOfFIR,TimeOfFIR,ActsAndSection,PlaceOfIncident,FIRdetails,DateOfIncident,TimeOfIncident,OtherDetails,Name,Age,Gender,PhoneNo,Nationality,IDproof,IDno,Address from FIRTable order by FIRno", conn)
        adp.Fill(ds1)
        DataGridView1.DataSource = ds1.Tables(0)
        If conn.State = ConnectionState.Open Then conn.Close()

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
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        pkvar = DataGridView1.CurrentRow.Cells(0).Value
    End Sub

    Private Sub DataGridView1_CellMouseClick(sender As Object, e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles DataGridView1.CellMouseClick
        On Error Resume Next
        TextBox1District.Text = DataGridView1.Rows(e.RowIndex).Cells(0).Value
        TextBox2Policestation.Text = DataGridView1.Rows(e.RowIndex).Cells(1).Value
        TextBox3FIRno.Text = DataGridView1.Rows(e.RowIndex).Cells(2).Value
        DateTimePicker1.Value = DataGridView1.Rows(e.RowIndex).Cells(3).Value
        TextBox4timeOfFIR.Text = DataGridView1.Rows(e.RowIndex).Cells(4).Value
        TextBox5ActsAndSections.Text = DataGridView1.Rows(e.RowIndex).Cells(5).Value
        TextBox6placeOfIncident.Text = DataGridView1.Rows(e.RowIndex).Cells(6).Value
        TextBox7FIRdetails.Text = DataGridView1.Rows(e.RowIndex).Cells(7).Value
        DateTimePicker2.Value = DataGridView1.Rows(e.RowIndex).Cells(8).Value
        TextBox8TimeOfIncident.Text = DataGridView1.Rows(e.RowIndex).Cells(9).Value
        TextBox9otherDetails.Text = DataGridView1.Rows(e.RowIndex).Cells(10).Value
        TextBox10Name.Text = DataGridView1.Rows(e.RowIndex).Cells(11).Value
        TextBox11Age.Text = DataGridView1.Rows(e.RowIndex).Cells(12).Value
        ComboBox1.Text = DataGridView1.Rows(e.RowIndex).Cells(13).Value
        TextBox12PhNo.Text = DataGridView1.Rows(e.RowIndex).Cells(14).Value
        TextBox13Nationality.Text = DataGridView1.Rows(e.RowIndex).Cells(15).Value
        ComboBox2.Text = DataGridView1.Rows(e.RowIndex).Cells(16).Value
        TextBox14IDno.Text = DataGridView1.Rows(e.RowIndex).Cells(17).Value
        TextBox15address.Text = DataGridView1.Rows(e.RowIndex).Cells(18).Value
    End Sub

    Private Sub ButtonCancel_Click(sender As System.Object, e As System.EventArgs) Handles ButtonCancel.Click
        Me.Hide()
    End Sub

    Private Sub ButtonDelete_Click(sender As System.Object, e As System.EventArgs) Handles ButtonDelete.Click
        If vbNo = MsgBox("Are you sure you want to Delete this record ?", MsgBoxStyle.YesNo, "delete") Then Exit Sub
        If conn.State = ConnectionState.Open Then conn.Close()
        conn.Open()
        Dim cmd1 As New SqlCommand("Delete from FIRtable where FIRno='" & TextBox3FIRno.Text & "'", conn)
        cmd1.ExecuteNonQuery()
        If conn.State = ConnectionState.Open Then conn.Close()
        disrecords()
        ButtonUpdate.Enabled = True
        ButtonDelete.Enabled = True
        ButtonCancel.Enabled = True
    End Sub
    Sub saverecords()
        Dim q1, q2 As String
        If TextBox1District.Text = "" Then
            MsgBox("please enter the necessory details")
            Exit Sub
        End If
        If conn.State = ConnectionState.Open Then conn.Close()
        conn.Open()

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
        MsgBox(" FIR updated Successfully ")

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
    End Sub

End Class
