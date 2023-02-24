Imports System.Windows.Forms

Public Class MDIParent1
    Private Sub ShowNewForm(ByVal sender As Object, ByVal e As EventArgs)
        ' Create a new instance of the child form.
        Dim ChildForm As New System.Windows.Forms.Form
        ' Make it a child of this MDI form before showing it.
        ChildForm.MdiParent = Me

        m_ChildFormNumber += 1
        ChildForm.Text = "Window " & m_ChildFormNumber

        ChildForm.Show()
    End Sub

    Private Sub OpenFile(ByVal sender As Object, ByVal e As EventArgs)
        Dim OpenFileDialog As New OpenFileDialog
        OpenFileDialog.InitialDirectory = My.Computer.FileSystem.SpecialDirectories.MyDocuments
        OpenFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*"
        If (OpenFileDialog.ShowDialog(Me) = System.Windows.Forms.DialogResult.OK) Then
            Dim FileName As String = OpenFileDialog.FileName
            ' TODO: Add code here to open the file.
        End If
    End Sub

    Private Sub SaveAsToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Dim SaveFileDialog As New SaveFileDialog
        SaveFileDialog.InitialDirectory = My.Computer.FileSystem.SpecialDirectories.MyDocuments
        SaveFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*"

        If (SaveFileDialog.ShowDialog(Me) = System.Windows.Forms.DialogResult.OK) Then
            Dim FileName As String = SaveFileDialog.FileName
            ' TODO: Add code here to save the current contents of the form to a file.
        End If
    End Sub



    Private Sub CutToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        ' Use My.Computer.Clipboard to insert the selected text or images into the clipboard
    End Sub

    Private Sub CopyToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        ' Use My.Computer.Clipboard to insert the selected text or images into the clipboard
    End Sub

    Private Sub PasteToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        'Use My.Computer.Clipboard.GetText() or My.Computer.Clipboard.GetData to retrieve information from the clipboard.
    End Sub

    Private Sub CascadeToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Me.LayoutMdi(MdiLayout.Cascade)
    End Sub

    Private Sub TileVerticalToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Me.LayoutMdi(MdiLayout.TileVertical)
    End Sub

    Private Sub TileHorizontalToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Me.LayoutMdi(MdiLayout.TileHorizontal)
    End Sub

    Private Sub ArrangeIconsToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Me.LayoutMdi(MdiLayout.ArrangeIcons)
    End Sub

    Private Sub CloseAllToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        ' Close all child forms of the parent.
        For Each ChildForm As Form In Me.MdiChildren
            ChildForm.Close()
        Next
    End Sub

    Private m_ChildFormNumber As Integer



    Private Sub ComplaintRegistrationToolStripMenuItem_Click_1(sender As System.Object, e As System.EventArgs) Handles ComplaintRegistrationToolStripMenuItem.Click
        ComplaintRegistrationForm.MdiParent = Me
        ComplaintRegistrationForm.Show()
    End Sub

    Private Sub ComplaintUpdateDeleteToolStripMenuItem_Click_1(sender As System.Object, e As System.EventArgs) Handles ComplaintUpdateDeleteToolStripMenuItem.Click
        ComplaintUpdateForm.MdiParent = Me
        ComplaintUpdateForm.Show()
    End Sub

    Private Sub ComplaintViewToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ComplaintViewToolStripMenuItem.Click
        ComplaintViewForm.MdiParent = Me
        ComplaintViewForm.Show()
    End Sub


    Private Sub FIRRegistrationToolStripMenuItem_Click_1(sender As System.Object, e As System.EventArgs) Handles FIRRegistrationToolStripMenuItem.Click
        FIRregistrationForm.MdiParent = Me
        FIRregistrationForm.Show()
    End Sub

    Private Sub FIRViewToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles FIRViewToolStripMenuItem.Click
        FIRViewForm.MdiParent = Me
        FIRViewForm.Show()
    End Sub

    Private Sub CriminalsRegistrationToolStripMenuItem_Click_1(sender As System.Object, e As System.EventArgs) Handles CriminalsRegistrationToolStripMenuItem.Click
        CriminalRegistrationForm.MdiParent = Me
        CriminalRegistrationForm.Show()
    End Sub

    Private Sub CriminalUpdationToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles CriminalUpdationToolStripMenuItem.Click
        CriminalUpdateForm.MdiParent = Me
        CriminalUpdateForm.Show()
    End Sub

    Private Sub CriminalViewToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles CriminalViewToolStripMenuItem.Click
        CriminalViewForm.MdiParent = Me
        CriminalViewForm.Show()
    End Sub

    Private Sub CasesRegistrationToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles CasesRegistrationToolStripMenuItem.Click
        CasesRegistrationForm.MdiParent = Me
        CasesRegistrationForm.Show()
    End Sub

    Private Sub CaseStatusUpdationToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles CaseStatusUpdationToolStripMenuItem.Click
        CaseStatusUpdateForm.MdiParent = Me
        CaseStatusUpdateForm.Show()
    End Sub

    Private Sub CaseReportToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles CaseReportToolStripMenuItem.Click
        CaseReportForm.MdiParent = Me
        CaseReportForm.Show()
    End Sub

    Private Sub PendingCasesToolStripMenuItem_Click_1(sender As System.Object, e As System.EventArgs) Handles PendingCasesToolStripMenuItem.Click
        CaseStatusPendingForm.MdiParent = Me
        CaseStatusPendingForm.Show()
    End Sub

    Private Sub ProgressCaseesToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ProgressCaseesToolStripMenuItem.Click
        CaseStatusProgressForm.MdiParent = Me
        CaseStatusProgressForm.Show()
    End Sub

    Private Sub DispossedCasesToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles DispossedCasesToolStripMenuItem.Click
        CasesStatusDisposedForm.MdiParent = Me
        CasesStatusDisposedForm.Show()
    End Sub

    Private Sub ListOfCriminalsToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ListOfCriminalsToolStripMenuItem.Click
        CriminalsListForm.MdiParent = Me
        CriminalsListForm.Show()
    End Sub

    Private Sub PoliceStationDetailsToolStripMenuItem_Click_1(sender As System.Object, e As System.EventArgs) Handles PoliceStationDetailsToolStripMenuItem.Click
        PoliceStationForm.MdiParent = Me
        PoliceStationForm.Show()
    End Sub

    Private Sub StaffRegistrationToolStripMenuItem_Click_1(sender As System.Object, e As System.EventArgs) Handles StaffRegistrationToolStripMenuItem.Click
        StaffRegistrationForm.MdiParent = Me
        StaffRegistrationForm.Show()
    End Sub

    Private Sub StaffUpdationViewToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles StaffUpdationViewToolStripMenuItem.Click
        StaffUpdateForm.MdiParent = Me
        StaffUpdateForm.Show()
    End Sub

    Private Sub FingerPrintMatcherToolStripMenuItem1_Click(sender As System.Object, e As System.EventArgs) Handles FingerPrintMatcherToolStripMenuItem1.Click
        FingerPrintMatcherForm.MdiParent = Me
        FingerPrintMatcherForm.Show()
    End Sub

    Private Sub LogOutToolStripMenuItem_Click_1(sender As System.Object, e As System.EventArgs) Handles LogOutToolStripMenuItem.Click
        Me.Close()
        Me.Hide()
    End Sub

    Private Sub MDIParent1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub WantedCrininalsRegistrationToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles WantedCrininalsRegistrationToolStripMenuItem.Click
        WantedCriminalsForm.MdiParent = Me
        WantedCriminalsForm.Show()

    End Sub

    Private Sub ListOfWantedCriminalsToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ListOfWantedCriminalsToolStripMenuItem.Click
        WantedCriminalListForm.MdiParent = Me
        WantedCriminalListForm.Show()
    End Sub
End Class
