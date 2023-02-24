Imports System.Data.SqlClient

Public Class CriminalsListForm

    Private Sub CriminalsList_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        If conn.State = ConnectionState.Open Then conn.Close()
        conn.Open()
        Dim command As New SqlCommand("select CriminalId,CriminalImage,CriminalName,DateofArrest,PlaceofArrest,CrimeComitted,ActionTaken,AresstingOfficer,FingerPrint from CriminalTable order by CriminalId", conn)
        Dim adapter As New SqlDataAdapter(command)
        Dim table As New DataTable()
        adapter.Fill(table)

        DataGridView1.AllowUserToAddRows = False
        DataGridView1.RowTemplate.Height = 100
        Dim imgc, imgc1 As New DataGridViewImageColumn

        DataGridView1.DataSource = table
        imgc = DataGridView1.Columns(1)
        imgc1 = DataGridView1.Columns(8)
        imgc.ImageLayout = DataGridViewImageCellLayout.Stretch
        imgc1.ImageLayout = DataGridViewImageCellLayout.Stretch

        If conn.State = ConnectionState.Open Then conn.Close()

        Me.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub ButtonCancel_Click(sender As System.Object, e As System.EventArgs) Handles ButtonCancel.Click
        Me.Hide()

    End Sub
End Class