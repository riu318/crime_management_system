Imports System.Data.SqlClient

Public Class ComplaintUpdateForm
    Dim pkvar As String

    Private Sub ButtonCancel_Click(sender As System.Object, e As System.EventArgs) Handles ButtonCancel.Click
        MDIParent1.Show()
        Me.Hide()
    End Sub

    Private Sub ButtonUpdate_Click(sender As System.Object, e As System.EventArgs) Handles ButtonUpdate.Click
        If vbNo = MsgBox("Are you sure you want to update this record ?", MsgBoxStyle.YesNo, "delete") Then Exit Sub
        If conn.State = ConnectionState.Open Then conn.Close()
        conn.Open()
        Dim cmd1 As New SqlCommand("Delete from ComplaintTable where Complaintno='" & TextBox1Complainno.Text & "'", conn)
        cmd1.ExecuteNonQuery()
        If conn.State = ConnectionState.Open Then conn.Close()
        saverecords()
        disrecords()

        ButtonUpdate.Enabled = True
        ButtonDelete.Enabled = True
        ButtonCancel.Enabled = True
    End Sub

    Private Sub saverecords()

        Dim q1, q2 As String

        If TextBox1Complainno.Text = "" Then
            MsgBox("please enter the necessory details")
            Exit Sub
        End If

        If conn.State = ConnectionState.Open Then conn.Close()
        conn.Open()

        q1 = " insert into ComplaintTable( "
        q2 = "values("
        q1 = q1 & "ComplaintNo" & ","
        q2 = q2 & " '" & TextBox1Complainno.Text & "' ,"
        q1 = q1 & "District" & ","
        q2 = q2 & " '" & TextBox2District.Text & "' ,"
        q1 = q1 & "PoliceStation" & ","
        q2 = q2 & " '" & TextBox3Polocestation.Text & "' ,"
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

        If conn.State = ConnectionState.Open Then conn.Close()
        MsgBox(" Complaint resistered Updated Successfully ")

        TextBox1Complainno.Text = ""
        TextBox2District.Text = ""
        TextBox3Polocestation.Text = ""
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
    End Sub

    Private Sub ButtonDelete_Click(sender As System.Object, e As System.EventArgs) Handles ButtonDelete.Click

        If vbNo = MsgBox("Are you sure you want to Delete this record ?", MsgBoxStyle.YesNo, "delete") Then Exit Sub

        If conn.State = ConnectionState.Open Then conn.Close()
        conn.Open()

        Dim cmd1 As New SqlCommand("Delete from ComplaintTable where ComplaintNo='" & TextBox1Complainno.Text & "'", conn)
        cmd1.ExecuteNonQuery()
        If conn.State = ConnectionState.Open Then conn.Close()
        disrecords()

        TextBox1Complainno.Text = ""
        TextBox2District.Text = ""
        TextBox3Polocestation.Text = ""
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

        ButtonUpdate.Enabled = True
        ButtonDelete.Enabled = True
        ButtonCancel.Enabled = True
    End Sub

    Private Sub disrecords()
        If conn.State = ConnectionState.Open Then conn.Close()
        conn.Open()
        Dim ds1 As New DataSet
        Dim adp As New SqlDataAdapter("select ComplaintNo,District,PoliceStation,DateOfComplaint,Time,ComplaintType,NameOfComplaint,Age,PhoneNo,Gender,IDproof,IDno,Address,ComplaintDetails from ComplaintTable order by ComplaintNo", conn)
        adp.Fill(ds1)
        DataGridView1.DataSource = ds1.Tables(0)
        If conn.State = ConnectionState.Open Then conn.Close()
    End Sub

    Private Sub ComplaintUpdateForm_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        disrecords()
        Me.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        pkvar = DataGridView1.CurrentRow.Cells(0).Value
    End Sub

    Private Sub DataGridView1_CellMouseClick(sender As Object, e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles DataGridView1.CellMouseClick
        On Error Resume Next
        TextBox1Complainno.Text = DataGridView1.Rows(e.RowIndex).Cells(0).Value
        TextBox2District.Text = DataGridView1.Rows(e.RowIndex).Cells(1).Value
        TextBox3Polocestation.Text = DataGridView1.Rows(e.RowIndex).Cells(2).Value
        DateTimePicker1.Value = DataGridView1.Rows(e.RowIndex).Cells(3).Value
        TextBox4time.Text = DataGridView1.Rows(e.RowIndex).Cells(4).Value
        ComboBox1.Text = DataGridView1.Rows(e.RowIndex).Cells(5).Value
        TextBox5complainantname.Text = DataGridView1.Rows(e.RowIndex).Cells(6).Value
        TextBox6age.Text = DataGridView1.Rows(e.RowIndex).Cells(7).Value
        TextBox7Phno.Text = DataGridView1.Rows(e.RowIndex).Cells(8).Value
        ComboBox2.Text = DataGridView1.Rows(e.RowIndex).Cells(9).Value
        ComboBox3.Text = DataGridView1.Rows(e.RowIndex).Cells(10).Value
        TextBox8IDno.Text = DataGridView1.Rows(e.RowIndex).Cells(11).Value
        TextBox9address.Text = DataGridView1.Rows(e.RowIndex).Cells(12).Value
        TextBox10complaindetails.Text = DataGridView1.Rows(e.RowIndex).Cells(13).Value
    End Sub
End Class