Imports System.Data.SqlClient

Public Class StaffUpdateForm
    Dim pkvar As String
    Private Sub ButtonView_Click(sender As System.Object, e As System.EventArgs) Handles ButtonView.Click
        displayrecord()
    End Sub

    Private Sub displayrecord()
        If conn.State = ConnectionState.Open Then conn.Close()
        conn.Open()

        Dim ds1 As New DataSet
        Dim adp As New SqlDataAdapter("select IDno,Name,Designation,Gender,PhNo,Qualification,Email,Address,PinCode from StaffTable order by IDno", conn)
        adp.Fill(ds1)
        DataGridView1.DataSource = ds1.Tables(0)

        If conn.State = ConnectionState.Open Then conn.Close()
    End Sub

    Private Sub UserUpdateForm_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub ButtonUpdate_Click(sender As System.Object, e As System.EventArgs) Handles ButtonUpdate.Click
        If vbNo = MsgBox("Are you sure you want to update this record ?", MsgBoxStyle.YesNo, "delete") Then Exit Sub

        If conn.State = ConnectionState.Open Then conn.Close()
        conn.Open()

        Dim cmd1 As New SqlCommand("Delete from StaffTable where IDno ='" & TextBox1ID.Text & "'", conn)
        cmd1.ExecuteNonQuery()

        If conn.State = ConnectionState.Open Then conn.Close()
        saverecords()
        ButtonView.Enabled = True
        ButtonUpdate.Enabled = True
        ButtonCancel.Enabled = True
        displayrecord()

    End Sub

    Private Sub saverecords()
        Dim q1, q2 As String
        If TextBox1ID.Text = "" Then
            MsgBox("please enter the necessory details")
            Exit Sub
        End If
        If conn.State = ConnectionState.Open Then conn.Close()
        conn.Open()

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

        If conn.State = ConnectionState.Open Then conn.Close()
        MsgBox(" Staff Details Updated Successfully ")

        TextBox1ID.Text = ""
        TextBox2Name.Text = ""
        ComboBox1.Text = ""
        ComboBox2.Text = ""
        TextBox3PhNo.Text = ""
        ComboBox3.Text = ""
        TextBox4Email.Text = ""
        TextBox5Address.Text = ""
        TextBox6PinCode.Text = ""
    End Sub

    Private Sub ButtonCancel_Click(sender As System.Object, e As System.EventArgs) Handles ButtonCancel.Click
        MDIParent1.Show()
        Me.Hide()
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        pkvar = DataGridView1.CurrentRow.Cells(0).Value
    End Sub

    Private Sub DataGridView1_CellMouseClick(sender As Object, e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles DataGridView1.CellMouseClick
        TextBox1ID.Text = DataGridView1.Rows(e.RowIndex).Cells(0).Value
        TextBox2Name.Text = DataGridView1.Rows(e.RowIndex).Cells(1).Value
        ComboBox1.Text = DataGridView1.Rows(e.RowIndex).Cells(2).Value
        ComboBox2.Text = DataGridView1.Rows(e.RowIndex).Cells(3).Value
        TextBox3PhNo.Text = DataGridView1.Rows(e.RowIndex).Cells(4).Value
        ComboBox3.Text = DataGridView1.Rows(e.RowIndex).Cells(5).Value
        TextBox4Email.Text = DataGridView1.Rows(e.RowIndex).Cells(6).Value
        TextBox5Address.Text = DataGridView1.Rows(e.RowIndex).Cells(7).Value
        TextBox6PinCode.Text = DataGridView1.Rows(e.RowIndex).Cells(8).Value
    End Sub

    Private Sub ButtonDelete_Click(sender As System.Object, e As System.EventArgs) Handles ButtonDelete.Click
        If vbNo = MsgBox("Are you sure you want to Delete this record ?", MsgBoxStyle.YesNo, "delete") Then Exit Sub

        If conn.State = ConnectionState.Open Then conn.Close()
        conn.Open()

        Dim cmd1 As New SqlCommand("Delete from StaffTable where IDno='" & TextBox1ID.Text & "'", conn)
        cmd1.ExecuteNonQuery()
        If conn.State = ConnectionState.Open Then conn.Close()
        displayrecord()
        ButtonUpdate.Enabled = True
        ButtonDelete.Enabled = True
        ButtonCancel.Enabled = True
        TextBox1ID.Text = ""
        TextBox2Name.Text = ""
        ComboBox1.Text = ""
        ComboBox2.Text = ""
        TextBox3PhNo.Text = ""
        ComboBox3.Text = ""
        TextBox4Email.Text = ""
        TextBox5Address.Text = ""
        TextBox6PinCode.Text = ""
    End Sub
End Class