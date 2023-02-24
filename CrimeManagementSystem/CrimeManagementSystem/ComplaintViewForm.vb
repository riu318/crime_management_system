Imports System.Data.SqlClient

Public Class ComplaintViewForm
    Dim pkvar As String

    Private Sub ButtonCancel_Click(sender As System.Object, e As System.EventArgs) Handles ButtonCancel.Click
        MDIParent1.Show()
        Me.Hide()
    End Sub
    Private Sub Buttonview_Click(sender As System.Object, e As System.EventArgs) Handles Buttonview.Click
        displayrecord()
    End Sub

    Private Sub displayrecord()
        If conn.State = ConnectionState.Open Then conn.Close()
        conn.Open()
        Dim ds1 As New DataSet
        Dim adp As New SqlDataAdapter("select ComplaintNo,District,PoliceStation,DateOfComplaint,Time,ComplaintType,NameOfComplaint,Age,PhoneNo,Gender,IDproof,IDno,Address,ComplaintDetails from ComplaintTable order by ComplaintNo", conn)
        adp.Fill(ds1)
        DataGridView1.DataSource = ds1.Tables(0)
        If conn.State = ConnectionState.Open Then conn.Close()
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

    Private Sub ComplaintViewForm_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized
    End Sub
End Class