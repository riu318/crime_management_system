Imports System.Data.SqlClient

Public Class WantedCriminalListForm

    Private Sub WantedCriminalListForm_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        If conn.State = ConnectionState.Open Then conn.Close()
        conn.Open()
        Dim command As New SqlCommand("select CriminalNo,WantedCriminalImage,CriminalName,CrimeCommitted,CriminalDescription from WantedCriminalTable order by CriminalNo", conn)
        Dim adapter As New SqlDataAdapter(command)
        Dim table As New DataTable()
        adapter.Fill(table)

        DataGridView1.AllowUserToAddRows = False
        DataGridView1.RowTemplate.Height = 100
        Dim imgc As New DataGridViewImageColumn

        DataGridView1.DataSource = table
        imgc = DataGridView1.Columns(1)
        imgc.ImageLayout = DataGridViewImageCellLayout.Stretch
        
        If conn.State = ConnectionState.Open Then conn.Close()

        Me.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub ButtonCancel_Click(sender As System.Object, e As System.EventArgs) Handles ButtonCancel.Click
        MDIParent1.Show()
        Me.Hide()
    End Sub
End Class