Imports System.Data.SqlClient

Public Class CaseReportForm

    Private Sub CaseReportForm_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        If conn.State = ConnectionState.Open Then conn.Close()
        conn.Open()
        Dim ds1 As New DataSet
        Dim adp As New SqlDataAdapter("select CaseID,CaseTitle,CaseFiledBy,CaseFiledDate,CaseStatus,CaseHandledBy,CaseDescription,VictimName,Witness1,ContactNo1,Witness2,ContactNo2,Witness3,ContactNo3 From CaseTable order by CaseID", conn)
        adp.Fill(ds1)
        DataGridView1.DataSource = ds1.Tables(0)

        If conn.State = ConnectionState.Open Then conn.Close()

        Me.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub ButtonCancel_Click(sender As System.Object, e As System.EventArgs) Handles ButtonCancel.Click
        Me.Hide()
        MDIParent1.Show()

    End Sub
End Class