Imports System.Data.SqlClient

Public Class CaseStatusPendingForm

    Private Sub ButtonCancel_Click(sender As System.Object, e As System.EventArgs) Handles ButtonCancel.Click
        MDIParent1.Show()
        Me.Hide()
    End Sub

    Private Sub CaseStatusPendingForm_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        If conn.State = ConnectionState.Open Then conn.Close()
        conn.Open()
        Dim ds1 As New DataSet
        Dim adp As New SqlDataAdapter("select CaseID,CaseTitle,CaseFiledBy,CaseFiledDate,CaseStatus,CaseHandledBy,VictimName,CaseDescription From CaseTable where CaseStatus  = 'Pending Case' ", conn)
        adp.Fill(ds1)
        DataGridView1.DataSource = ds1.Tables(0)

        If conn.State = ConnectionState.Open Then conn.Close()

        Me.WindowState = FormWindowState.Maximized
    End Sub

   
End Class