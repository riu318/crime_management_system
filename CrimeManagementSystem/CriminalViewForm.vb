Imports System.Data.SqlClient
Imports System.IO

Public Class CriminalViewForm
    Dim pkvar As String
    Dim imag, imag1 As Byte()


    Private Sub ButtonView_Click(sender As System.Object, e As System.EventArgs) Handles ButtonView.Click
        DisplayRecord()
    End Sub

    Private Sub DisplayRecord()
        If conn.State = ConnectionState.Open Then conn.Close()
        conn.Open()
        Dim command As New SqlCommand("select CriminalId,CriminalName,PhoneNo,DoB,Nationality,Address,DateofArrest,PlaceofArrest,CrimeComitted,Description,ActionTaken,AresstingOfficer,Gender,Age,Height,CriminalImage,FingerPrint,CriminalFile,FingerPrintFile from CriminalTable order by CriminalId", conn)
        Dim adapter As New SqlDataAdapter(command)
        Dim table As New DataTable()
        adapter.Fill(table)

        DataGridView1.AllowUserToAddRows = False
        DataGridView1.RowTemplate.Height = 100
        Dim imgc, imgc1 As New DataGridViewImageColumn

        DataGridView1.DataSource = table
        imgc = DataGridView1.Columns(15)
        imgc1 = DataGridView1.Columns(16)
        imgc.ImageLayout = DataGridViewImageCellLayout.Stretch
        imgc1.ImageLayout = DataGridViewImageCellLayout.Stretch

        If conn.State = ConnectionState.Open Then conn.Close()
    End Sub

    Private Sub ButtonCancel_Click(sender As System.Object, e As System.EventArgs) Handles ButtonCancel.Click
        Me.Hide()
        MDIParent1.Show()

    End Sub


    Private Sub DataGridView1_CellContentClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        pkvar = DataGridView1.CurrentRow.Cells(0).Value
    End Sub

    Private Sub DataGridView1_CellMouseClick(sender As Object, e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles DataGridView1.CellMouseClick
        On Error Resume Next
        TextBox1CriminalID.Text = DataGridView1.Rows(e.RowIndex).Cells(0).Value
        TextBox2criminalname.Text = DataGridView1.Rows(e.RowIndex).Cells(1).Value
        TextBox3phno.Text = DataGridView1.Rows(e.RowIndex).Cells(2).Value
        DateTimePicker1.Value = DataGridView1.Rows(e.RowIndex).Cells(3).Value
        TextBox4nationality.Text = DataGridView1.Rows(e.RowIndex).Cells(4).Value
        TextBox6address.Text = DataGridView1.Rows(e.RowIndex).Cells(5).Value
        DateTimePicker2.Value = DataGridView1.Rows(e.RowIndex).Cells(6).Value
        TextBox8placeofarrest.Text = DataGridView1.Rows(e.RowIndex).Cells(7).Value
        TextBox9crimecomitted.Text = DataGridView1.Rows(e.RowIndex).Cells(8).Value
        TextBox10description.Text = DataGridView1.Rows(e.RowIndex).Cells(9).Value
        TextBox11actiontaken.Text = DataGridView1.Rows(e.RowIndex).Cells(10).Value
        TextBox12arrestingofficer.Text = DataGridView1.Rows(e.RowIndex).Cells(11).Value
        ComboBox1.Text = DataGridView1.Rows(e.RowIndex).Cells(12).Value
        TextBox5age.Text = DataGridView1.Rows(e.RowIndex).Cells(13).Value
        TextBox7height.Text = DataGridView1.Rows(e.RowIndex).Cells(14).Value
        imag = DataGridView1.Rows(e.RowIndex).Cells(15).Value
        imag1 = DataGridView1.Rows(e.RowIndex).Cells(16).Value
        Dim img As New MemoryStream(imag)
        Dim img1 As New MemoryStream(imag1)

        PictureBox2.Image = Image.FromStream(img)
        PictureBox3.Image = Image.FromStream(img1)


    End Sub

    Private Sub CriminalViewForm_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized
    End Sub
End Class