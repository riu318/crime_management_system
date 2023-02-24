Imports System.Data.SqlClient

Public Class CasesStatusDisposedForm
    Dim pkvar As String
    Public q1Var As String

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

    

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        PP1.ShowDialog()
    End Sub
    Private Sub PrintDocument1_PrintPage(sender As System.Object, e As System.Drawing.Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        Dim XPos, YPos As Long

        YPos = 50
        Dim MyFont As New Font("Times New Roman", 30)
        XPos = 100
        e.Graphics.DrawString("CRIME MANAGEMENT SYSTEM", MyFont, Brushes.Black, XPos, YPos)

        YPos += 50
        MyFont = New Font("Arial", 16)
        XPos = 180
        e.Graphics.DrawString("Karnataka Police Stations Cases Reports", MyFont, Brushes.Black, XPos, YPos)

        YPos += 60
        MyFont = New Font("Courier New", 20)
        XPos = 10
        e.Graphics.DrawString(" Disposed Cases Report List", MyFont, Brushes.Black, XPos, YPos)


        MyFont = New Font("Courier New", 8)
        YPos += 50

        e.Graphics.DrawString("CaseID", MyFont, Brushes.Black, XPos, YPos)
        XPos = XPos + 50
        e.Graphics.DrawString("CaseTitle", MyFont, Brushes.Black, XPos, YPos)
        XPos = XPos + 110
        e.Graphics.DrawString("CaseFiledBy", MyFont, Brushes.Black, XPos, YPos)
        XPos = XPos + 110
        e.Graphics.DrawString("CaseHandledBy", MyFont, Brushes.Black, XPos, YPos)
        XPos = XPos + 110
        e.Graphics.DrawString("VictimName", MyFont, Brushes.Black, XPos, YPos)
        XPos = XPos + 110
        e.Graphics.DrawString("CaseDescription", MyFont, Brushes.Black, XPos, YPos)
        XPos = XPos + 110


        MyFont = New Font("Arial", 7)
        YPos += 25
        For Each r As DataGridViewRow In DataGridView1.Rows
            q1Var = r.Cells(1).Value & " : " & r.Cells(2).Value
            XPos = 10
            e.Graphics.DrawString(r.Cells(0).Value, MyFont, Brushes.Black, XPos, YPos)
            XPos = XPos + 50
            e.Graphics.DrawString(r.Cells(1).Value, MyFont, Brushes.Black, XPos, YPos)
            XPos = XPos + 110
            e.Graphics.DrawString(r.Cells(2).Value, MyFont, Brushes.Black, XPos, YPos)
            XPos = XPos + 110
            e.Graphics.DrawString(r.Cells(5).Value, MyFont, Brushes.Black, XPos, YPos)
            XPos = XPos + 110
            e.Graphics.DrawString(r.Cells(6).Value, MyFont, Brushes.Black, XPos, YPos)
            XPos = XPos + 110
            e.Graphics.DrawString(r.Cells(7).Value, MyFont, Brushes.Black, XPos, YPos)
            XPos = XPos + 110

            YPos += 25
        Next
    End Sub
End Class