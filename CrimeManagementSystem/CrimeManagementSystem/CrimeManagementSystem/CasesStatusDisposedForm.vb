Imports System.Data.SqlClient

Public Class CasesStatusDisposedForm
    Dim pkvar As String
    Private Sub ButtonCancel_Click(sender As System.Object, e As System.EventArgs) Handles ButtonCancel.Click
        MDIParent1.Show()
        Me.Hide()
    End Sub

    Private Sub CasesStatusDisposedForm_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        If conn.State = ConnectionState.Open Then conn.Close()
        conn.Open()
        Dim ds1 As New DataSet
        Dim adp As New SqlDataAdapter("select CaseID,CaseTitle,CaseFiledBy,CaseFiledDate,CaseStatus,CaseHandledBy,VictimName,CaseDescription From CaseTable where CaseStatus = 'Disposed Case' ", conn)
        adp.Fill(ds1)
        DataGridView1.DataSource = ds1.Tables(0)

        If conn.State = ConnectionState.Open Then conn.Close()

        Me.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub
End Class