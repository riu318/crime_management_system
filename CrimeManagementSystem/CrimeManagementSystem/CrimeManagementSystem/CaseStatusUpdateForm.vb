Imports System.Data.SqlClient

Public Class CaseStatusUpdateForm
    Dim a As String
    Dim pkvar As String

    Private Sub ButtonUpdate_Click(sender As System.Object, e As System.EventArgs) Handles ButtonUpdate.Click

        If vbNo = MsgBox("Are you sure you want to update this record ?", MsgBoxStyle.YesNo, "delete") Then Exit Sub

        If conn.State = ConnectionState.Open Then conn.Close()
        conn.Open()

        Dim cmd1 As New SqlCommand("Delete from CaseTable where CaseID ='" & TextBox1CaseID.Text & "'", conn)
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

        If TextBox1CaseID.Text = "" Then
            MsgBox("please enter the necessory details")
            Exit Sub
        End If

        If conn.State = ConnectionState.Open Then conn.Close()
        conn.Open()

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
        q1 = q1 & "CaseDescription" & ")"
        q2 = q2 & "'" & TextBox5CaseDescription.Text & "' )"

        Dim Command As New SqlCommand(q1 & q2, conn)
        Command.ExecuteNonQuery()

        If conn.State = ConnectionState.Open Then conn.Close()
        MsgBox(" Case resistered Updated Successfully ")

        TextBox1CaseID.Text = ""
        TextBox2CaseTitle.Text = ""
        TextBox3FiledBy.Text = ""
        DateTimePicker1.Text = ""
        a = ""
        TextBox4HandledBy.Text = ""
        TextBox5CaseDescription.Text = ""
    End Sub

    Private Sub ButtonView_Click(sender As System.Object, e As System.EventArgs) Handles ButtonView.Click
        displayrecord()
    End Sub

    Private Sub displayrecord()

        If conn.State = ConnectionState.Open Then conn.Close()
        conn.Open()

        Dim ds1 As New DataSet
        Dim adp As New SqlDataAdapter("select CaseID,CaseTitle,CaseFiledBy,CaseFiledDate,CaseStatus,CaseHandledBy,CaseDescription from CaseTable order by CaseId", conn)
        adp.Fill(ds1)
        DataGridView1.DataSource = ds1.Tables(0)

        If conn.State = ConnectionState.Open Then conn.Close()
    End Sub

    Private Sub ButtonCancel_Click(sender As System.Object, e As System.EventArgs) Handles ButtonCancel.Click
        MDIParent1.Show()
        Me.Hide()
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        pkvar = DataGridView1.CurrentRow.Cells(0).Value

        If a = "Pending Cases" Then
            RadioButton1.Checked = True
        ElseIf a = "Progress Cases" Then
            RadioButton2.Checked = True
        ElseIf a = "Dispossed Cases" Then
            RadioButton3.Checked = True
        Else
            RadioButton1.Checked = False
            RadioButton2.Checked = False
            RadioButton3.Checked = False
        End If


    End Sub

    Private Sub DataGridView1_CellMouseClick(sender As Object, e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles DataGridView1.CellMouseClick
        On Error Resume Next
        TextBox1CaseID.Text = DataGridView1.Rows(e.RowIndex).Cells(0).Value
        TextBox2CaseTitle.Text = DataGridView1.Rows(e.RowIndex).Cells(1).Value
        TextBox3FiledBy.Text = DataGridView1.Rows(e.RowIndex).Cells(2).Value
        DateTimePicker1.Value = DataGridView1.Rows(e.RowIndex).Cells(3).Value
        a = DataGridView1.Rows(e.RowIndex).Cells(4).Value
        TextBox4HandledBy.Text = DataGridView1.Rows(e.RowIndex).Cells(5).Value
        TextBox5CaseDescription.Text = DataGridView1.Rows(e.RowIndex).Cells(6).Value
    End Sub

    Private Sub CaseStatusViewForm_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        displayrecord()
        Me.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles RadioButton1.CheckedChanged
        a = "Pending Case"
    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles RadioButton2.CheckedChanged
        a = "Progress Case"
    End Sub

    Private Sub RadioButton3_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles RadioButton3.CheckedChanged
        a = "Disposed Case"
    End Sub

    Private Sub ButtonDelete_Click(sender As System.Object, e As System.EventArgs) Handles ButtonDelete.Click
        If vbNo = MsgBox("Are you sure you want to Delete this record ?", MsgBoxStyle.YesNo, "delete") Then Exit Sub

        If conn.State = ConnectionState.Open Then conn.Close()
        conn.Open()

        Dim cmd1 As New SqlCommand("Delete from CaseTable where CaseID='" & TextBox1CaseID.Text & "'", conn)
        cmd1.ExecuteNonQuery()
        If conn.State = ConnectionState.Open Then conn.Close()
        displayrecord()
        ButtonUpdate.Enabled = True
        ButtonDelete.Enabled = True
        ButtonCancel.Enabled = True

        TextBox1CaseID.Text = ""
        TextBox2CaseTitle.Text = ""
        TextBox3FiledBy.Text = ""
        DateTimePicker1.Text = ""
        a = ""
        TextBox4HandledBy.Text = ""
        TextBox5CaseDescription.Text = ""

    End Sub
End Class