Imports System.Data.SqlClient
Imports System.IO

Public Class CriminalUpdateForm
    Dim pkvar As String
    Dim imag, imag1 As Byte()
    Private Sub ButtonUpdate_Click(sender As System.Object, e As System.EventArgs) Handles ButtonUpdate.Click
        If vbNo = MsgBox("Are you sure you want to update this record ?", MsgBoxStyle.YesNo, "delete") Then Exit Sub
        If conn.State = ConnectionState.Open Then conn.Close()
        conn.Open()
        Dim cmd1 As New SqlCommand("Delete from CriminalTable where CriminalId='" & TextBox1CriminalID.Text & "'", conn)
        cmd1.ExecuteNonQuery()
        If conn.State = ConnectionState.Open Then conn.Close()
        SaveRecords()
        ButtonUpdate.Enabled = True
        ButtonDelete.Enabled = True
        ButtonCancel.Enabled = True
        DisplayRecords()

    End Sub

    Private Sub SaveRecords()
        If conn.State = ConnectionState.Open Then conn.Close()
        conn.Open()

        Dim command As New SqlCommand("insert into CriminalTable(CriminalId,CriminalName,PhoneNo,DoB,Nationality,Address,DateofArrest,PlaceofArrest,CrimeComitted,Description,ActionTaken,AresstingOfficer,Gender,Age,Height,CriminalImage,FingerPrint)values(@CriminalId,@CriminalName,@PhoneNo,@DoB,@Nationality,@Address,@DateofArrest,@PlaceofArrest,@CrimeComitted,@Description,@ActionTaken,@AresstingOfficer,@Gender,@Age,@Height,@CriminalImage,@FingerPrint)", conn)
        Dim ms, ms1 As New MemoryStream

        PictureBox2.Image.Save(ms, PictureBox2.Image.RawFormat)
        PictureBox3.Image.Save(ms1, PictureBox3.Image.RawFormat)
        command.Parameters.Add("@CriminalId", SqlDbType.NVarChar).Value = TextBox1CriminalID.Text
        command.Parameters.Add("@CriminalName", SqlDbType.NVarChar).Value = TextBox2CriminalName.Text
        command.Parameters.Add("@PhoneNo", SqlDbType.NVarChar).Value = TextBox3phoneNo.Text
        command.Parameters.Add("@DoB", SqlDbType.NVarChar).Value = DateTimePicker1.Text
        command.Parameters.Add("@Gender", SqlDbType.NVarChar).Value = ComboBox1.Text
        command.Parameters.Add("@Nationality", SqlDbType.NVarChar).Value = TextBox4Nationality.Text
        command.Parameters.Add("@Age", SqlDbType.NVarChar).Value = TextBox5Age.Text
        command.Parameters.Add("@Height", SqlDbType.NVarChar).Value = TextBox6Address.Text
        command.Parameters.Add("@Address", SqlDbType.NVarChar).Value = TextBox6Address.Text
        command.Parameters.Add("@DateofArrest", SqlDbType.NVarChar).Value = DateTimePicker2.Text
        command.Parameters.Add("@PlaceofArrest", SqlDbType.NVarChar).Value = TextBox8placeofarrest.Text
        command.Parameters.Add("@CrimeComitted", SqlDbType.NVarChar).Value = TextBox9crimecommitted.Text
        command.Parameters.Add("@Description", SqlDbType.NVarChar).Value = TextBox10description.Text
        command.Parameters.Add("@ActionTaken", SqlDbType.NVarChar).Value = TextBox11actionagaints.Text
        command.Parameters.Add("@AresstingOfficer", SqlDbType.NVarChar).Value = TextBox12arrestingofficer.Text
        command.Parameters.Add("@CriminalImage", SqlDbType.Image).Value = ms.ToArray
        command.Parameters.Add("@FingerPrint", SqlDbType.Image).Value = ms1.ToArray
        command.Parameters.Add("@CriminalFile", SqlDbType.NVarChar).Value = Path.GetFileName(OpenFileDialog1.FileName)
        command.Parameters.Add("@FingerPrintFile", SqlDbType.NVarChar).Value = Path.GetFileName(OpenFileDialog1.FileName)


        If conn.State = ConnectionState.Open Then conn.Close()
        conn.Open()
        If command.ExecuteNonQuery() = 1 Then
            MsgBox("Details Updated ", vbInformation)

            TextBox1CriminalID.Text = ""
            TextBox2CriminalName.Text = ""
            TextBox3phoneNo.Text = ""
            ComboBox1.Text = ""
            TextBox4Nationality.Text = ""
            TextBox5Age.Text = ""
            TextBox6Address.Text = ""
            TextBox7Height.Text = ""
            TextBox8placeofarrest.Text = ""
            TextBox9crimecommitted.Text = ""
            TextBox10description.Text = ""
            TextBox11actionagaints.Text = ""
            TextBox12arrestingofficer.Text = ""
            PictureBox2.Image = Nothing
            PictureBox3.Image = Nothing


        Else
            MsgBox("Details Not Updated ", vbCritical)
        End If
        If conn.State = ConnectionState.Open Then conn.Close()
    End Sub

    Private Sub DisplayRecords()
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


    Private Sub DataGridView1_CellContentClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs)
        pkvar = DataGridView1.CurrentRow.Cells(0).Value
    End Sub

    Private Sub ButtonDelete_Click(sender As System.Object, e As System.EventArgs) Handles ButtonDelete.Click
        If vbNo = MsgBox("Are you sure you want to Delete this record ?", MsgBoxStyle.YesNo, "delete") Then Exit Sub
        If conn.State = ConnectionState.Open Then conn.Close()
        conn.Open()
        Dim cmd1 As New SqlCommand("Delete from CriminalTable where CriminalId='" & TextBox1CriminalID.Text & "'", conn)
        cmd1.ExecuteNonQuery()
        If conn.State = ConnectionState.Open Then conn.Close()
        DisplayRecords()
        ButtonUpdate.Enabled = True
        ButtonDelete.Enabled = True
        ButtonCancel.Enabled = True

        TextBox1CriminalID.Text = ""
        TextBox2CriminalName.Text = ""
        TextBox3phoneNo.Text = ""
        ComboBox1.Text = ""
        TextBox4Nationality.Text = ""
        TextBox5Age.Text = ""
        TextBox6Address.Text = ""
        TextBox7Height.Text = ""
        TextBox8placeofarrest.Text = ""
        TextBox9crimecommitted.Text = ""
        TextBox10description.Text = ""
        TextBox11actionagaints.Text = ""
        TextBox12arrestingofficer.Text = ""
        PictureBox2.Image = Nothing
        PictureBox3.Image = Nothing

    End Sub

    

    Private Sub CriminalUpdateForm_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        DisplayRecords()
        Me.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Try
            With OpenFileDialog1
                .Filter = ("Images |* .png; *.bmp; *.jpg; *.jpeg; *.gif; *.ico; *.jfif;")
                .FilterIndex = 4
            End With
            OpenFileDialog1.FileName = ""
            If OpenFileDialog1.ShowDialog() = DialogResult.OK Then
                PictureBox2.Image = Image.FromFile(OpenFileDialog1.FileName)
            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        Try
            With OpenFileDialog1
                .Filter = ("Images |* .png; *.bmp; *.jpg; *.jpeg; *.gif; *.ico; *.jfif;")
                .FilterIndex = 4
            End With
            OpenFileDialog1.FileName = ""
            If OpenFileDialog1.ShowDialog() = DialogResult.OK Then
                PictureBox3.Image = Image.FromFile(OpenFileDialog1.FileName)
            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub ButtonCancel_Click(sender As System.Object, e As System.EventArgs) Handles ButtonCancel.Click
        Me.Hide()
        MdiParent.Show()
    End Sub

 
   
    Private Sub DataGridView1_CellContentClick_1(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        On Error Resume Next
        TextBox1CriminalID.Text = DataGridView1.Rows(e.RowIndex).Cells(0).Value
        TextBox2CriminalName.Text = DataGridView1.Rows(e.RowIndex).Cells(1).Value
        TextBox3phoneNo.Text = DataGridView1.Rows(e.RowIndex).Cells(2).Value
        DateTimePicker1.Value = DataGridView1.Rows(e.RowIndex).Cells(3).Value
        TextBox4Nationality.Text = DataGridView1.Rows(e.RowIndex).Cells(4).Value
        TextBox6Address.Text = DataGridView1.Rows(e.RowIndex).Cells(5).Value
        DateTimePicker2.Value = DataGridView1.Rows(e.RowIndex).Cells(6).Value
        TextBox8placeofarrest.Text = DataGridView1.Rows(e.RowIndex).Cells(7).Value
        TextBox9crimecommitted.Text = DataGridView1.Rows(e.RowIndex).Cells(8).Value
        TextBox10description.Text = DataGridView1.Rows(e.RowIndex).Cells(9).Value
        TextBox11actionagaints.Text = DataGridView1.Rows(e.RowIndex).Cells(10).Value
        TextBox12arrestingofficer.Text = DataGridView1.Rows(e.RowIndex).Cells(11).Value
        ComboBox1.Text = DataGridView1.Rows(e.RowIndex).Cells(12).Value
        TextBox5Age.Text = DataGridView1.Rows(e.RowIndex).Cells(13).Value
        TextBox7Height.Text = DataGridView1.Rows(e.RowIndex).Cells(14).Value
        imag = DataGridView1.Rows(e.RowIndex).Cells(15).Value
        imag1 = DataGridView1.Rows(e.RowIndex).Cells(16).Value
        Dim img As New MemoryStream(imag)
        Dim img1 As New MemoryStream(imag1)

        PictureBox2.Image = Image.FromStream(img)
        PictureBox3.Image = Image.FromStream(img1)

    End Sub
End Class