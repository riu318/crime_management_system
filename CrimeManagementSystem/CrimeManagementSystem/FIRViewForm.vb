Imports System.Data.SqlClient

Public Class FIRViewForm
    Dim pkvar As String

    Private Sub ButtonView_Click(sender As System.Object, e As System.EventArgs) Handles ButtonView.Click
        displayrecord()

    End Sub

    Private Sub displayrecord()
        If conn.State = ConnectionState.Open Then conn.Close()
        conn.Open()
        Dim ds1 As New DataSet
        Dim adp As New SqlDataAdapter("select District,PoliceStation,FIRno,DateOfFIR,TimeOfFIR,ActsAndSection,PlaceOfIncident,FIRdetails,DateOfIncident,TimeOfIncident,OtherDetails,Name,Age,Gender,PhoneNo,Nationality,IDproof,IDno,Address from FIRTable order by FIRno", conn)
        adp.Fill(ds1)
        DataGridView1.DataSource = ds1.Tables(0)
        If conn.State = ConnectionState.Open Then conn.Close()
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
        Me.Close()
    End Sub

    Private Sub FIRViewForm_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized
    End Sub
End Class