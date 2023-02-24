Imports System.Data.SqlClient

Public Class WantedListForm
    Public q1Var As String
    Private Sub WantedListForm_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        If conn.State = ConnectionState.Open Then conn.Close()
        conn.Open()
        Dim command As New SqlCommand("select CriminalNo,CriminalImage,CriminalName,CrimeComited,CriminalDescription from WantedTable order by CriminalNo", conn)
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
        Me.Hide()
        MDIParent1.Show()
    End Sub
End Class