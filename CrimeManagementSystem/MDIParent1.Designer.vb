<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MDIParent1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub


    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MDIParent1))
        Me.MenuStrip = New System.Windows.Forms.MenuStrip()
        Me.ComplaintToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ComplaintRegistrationToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ComplaintUpdateDeleteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ComplaintViewToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FIRToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FIRRegistrationToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FIRViewToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CasesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CasesRegistrationToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CaseStatusUpdationToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CasesReportToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CaseReportToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PendingCasesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProgressCaseesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DispossedCasesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CriminalsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CriminalsRegistrationToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CriminalUpdationToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CriminalViewToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.WantedCrininalsRegistrationToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CriminalsListToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ListOfCriminalsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ListOfWantedCriminalsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PoliceStationToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PoliceStationDetailsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StaffDetailsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StaffRegistrationToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StaffUpdationViewToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FingerPrintMatcherToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FingerPrintMatcherToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.LogOutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StatusStrip = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.MenuStrip.SuspendLayout()
        Me.StatusStrip.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip
        '
        Me.MenuStrip.BackColor = System.Drawing.Color.White
        Me.MenuStrip.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.MenuStrip.Dock = System.Windows.Forms.DockStyle.Left
        Me.MenuStrip.Font = New System.Drawing.Font("Verdana", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible
        Me.MenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ComplaintToolStripMenuItem, Me.FIRToolStripMenuItem, Me.CasesToolStripMenuItem, Me.CasesReportToolStripMenuItem, Me.CriminalsToolStripMenuItem, Me.CriminalsListToolStripMenuItem, Me.PoliceStationToolStripMenuItem, Me.StaffDetailsToolStripMenuItem, Me.FingerPrintMatcherToolStripMenuItem, Me.LogOutToolStripMenuItem})
        Me.MenuStrip.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Table
        Me.MenuStrip.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip.Name = "MenuStrip"
        Me.MenuStrip.Padding = New System.Windows.Forms.Padding(8, 2, 0, 2)
        Me.MenuStrip.Size = New System.Drawing.Size(282, 845)
        Me.MenuStrip.TabIndex = 5
        Me.MenuStrip.Text = "MenuStrip"
        '
        'ComplaintToolStripMenuItem
        '
        Me.ComplaintToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ComplaintRegistrationToolStripMenuItem, Me.ComplaintUpdateDeleteToolStripMenuItem, Me.ComplaintViewToolStripMenuItem})
        Me.ComplaintToolStripMenuItem.ForeColor = System.Drawing.Color.Black
        Me.ComplaintToolStripMenuItem.Name = "ComplaintToolStripMenuItem"
        Me.ComplaintToolStripMenuItem.Size = New System.Drawing.Size(160, 33)
        Me.ComplaintToolStripMenuItem.Text = "Complaint"
        '
        'ComplaintRegistrationToolStripMenuItem
        '
        Me.ComplaintRegistrationToolStripMenuItem.Name = "ComplaintRegistrationToolStripMenuItem"
        Me.ComplaintRegistrationToolStripMenuItem.Size = New System.Drawing.Size(429, 34)
        Me.ComplaintRegistrationToolStripMenuItem.Text = "Complaint Registration"
        '
        'ComplaintUpdateDeleteToolStripMenuItem
        '
        Me.ComplaintUpdateDeleteToolStripMenuItem.Name = "ComplaintUpdateDeleteToolStripMenuItem"
        Me.ComplaintUpdateDeleteToolStripMenuItem.Size = New System.Drawing.Size(429, 34)
        Me.ComplaintUpdateDeleteToolStripMenuItem.Text = "Complaint Update/Detele"
        '
        'ComplaintViewToolStripMenuItem
        '
        Me.ComplaintViewToolStripMenuItem.Name = "ComplaintViewToolStripMenuItem"
        Me.ComplaintViewToolStripMenuItem.Size = New System.Drawing.Size(429, 34)
        Me.ComplaintViewToolStripMenuItem.Text = "Complaint View"
        '
        'FIRToolStripMenuItem
        '
        Me.FIRToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FIRRegistrationToolStripMenuItem, Me.FIRViewToolStripMenuItem})
        Me.FIRToolStripMenuItem.ForeColor = System.Drawing.Color.Black
        Me.FIRToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Transparent
        Me.FIRToolStripMenuItem.Name = "FIRToolStripMenuItem"
        Me.FIRToolStripMenuItem.Size = New System.Drawing.Size(73, 33)
        Me.FIRToolStripMenuItem.Text = "FIR"
        '
        'FIRRegistrationToolStripMenuItem
        '
        Me.FIRRegistrationToolStripMenuItem.Name = "FIRRegistrationToolStripMenuItem"
        Me.FIRRegistrationToolStripMenuItem.Size = New System.Drawing.Size(300, 34)
        Me.FIRRegistrationToolStripMenuItem.Text = "FIR registration"
        '
        'FIRViewToolStripMenuItem
        '
        Me.FIRViewToolStripMenuItem.Name = "FIRViewToolStripMenuItem"
        Me.FIRViewToolStripMenuItem.Size = New System.Drawing.Size(300, 34)
        Me.FIRViewToolStripMenuItem.Text = "FIR View"
        '
        'CasesToolStripMenuItem
        '
        Me.CasesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CasesRegistrationToolStripMenuItem, Me.CaseStatusUpdationToolStripMenuItem})
        Me.CasesToolStripMenuItem.ForeColor = System.Drawing.Color.Black
        Me.CasesToolStripMenuItem.Name = "CasesToolStripMenuItem"
        Me.CasesToolStripMenuItem.Size = New System.Drawing.Size(102, 33)
        Me.CasesToolStripMenuItem.Text = "Cases"
        '
        'CasesRegistrationToolStripMenuItem
        '
        Me.CasesRegistrationToolStripMenuItem.Name = "CasesRegistrationToolStripMenuItem"
        Me.CasesRegistrationToolStripMenuItem.Size = New System.Drawing.Size(372, 34)
        Me.CasesRegistrationToolStripMenuItem.Text = "Cases Registration"
        '
        'CaseStatusUpdationToolStripMenuItem
        '
        Me.CaseStatusUpdationToolStripMenuItem.Name = "CaseStatusUpdationToolStripMenuItem"
        Me.CaseStatusUpdationToolStripMenuItem.Size = New System.Drawing.Size(372, 34)
        Me.CaseStatusUpdationToolStripMenuItem.Text = "Case Status Updation"
        '
        'CasesReportToolStripMenuItem
        '
        Me.CasesReportToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CaseReportToolStripMenuItem, Me.PendingCasesToolStripMenuItem, Me.ProgressCaseesToolStripMenuItem, Me.DispossedCasesToolStripMenuItem})
        Me.CasesReportToolStripMenuItem.ForeColor = System.Drawing.Color.Black
        Me.CasesReportToolStripMenuItem.Name = "CasesReportToolStripMenuItem"
        Me.CasesReportToolStripMenuItem.Size = New System.Drawing.Size(201, 33)
        Me.CasesReportToolStripMenuItem.Text = "Cases Report"
        '
        'CaseReportToolStripMenuItem
        '
        Me.CaseReportToolStripMenuItem.Name = "CaseReportToolStripMenuItem"
        Me.CaseReportToolStripMenuItem.Size = New System.Drawing.Size(307, 34)
        Me.CaseReportToolStripMenuItem.Text = "Case Report"
        '
        'PendingCasesToolStripMenuItem
        '
        Me.PendingCasesToolStripMenuItem.Name = "PendingCasesToolStripMenuItem"
        Me.PendingCasesToolStripMenuItem.Size = New System.Drawing.Size(307, 34)
        Me.PendingCasesToolStripMenuItem.Text = "Pending Cases"
        '
        'ProgressCaseesToolStripMenuItem
        '
        Me.ProgressCaseesToolStripMenuItem.Name = "ProgressCaseesToolStripMenuItem"
        Me.ProgressCaseesToolStripMenuItem.Size = New System.Drawing.Size(307, 34)
        Me.ProgressCaseesToolStripMenuItem.Text = "Progress Cases"
        '
        'DispossedCasesToolStripMenuItem
        '
        Me.DispossedCasesToolStripMenuItem.Name = "DispossedCasesToolStripMenuItem"
        Me.DispossedCasesToolStripMenuItem.Size = New System.Drawing.Size(307, 34)
        Me.DispossedCasesToolStripMenuItem.Text = "Dispossed Cases"
        '
        'CriminalsToolStripMenuItem
        '
        Me.CriminalsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CriminalsRegistrationToolStripMenuItem, Me.CriminalUpdationToolStripMenuItem, Me.CriminalViewToolStripMenuItem, Me.WantedCrininalsRegistrationToolStripMenuItem})
        Me.CriminalsToolStripMenuItem.ForeColor = System.Drawing.Color.Black
        Me.CriminalsToolStripMenuItem.Name = "CriminalsToolStripMenuItem"
        Me.CriminalsToolStripMenuItem.Size = New System.Drawing.Size(158, 33)
        Me.CriminalsToolStripMenuItem.Text = "Criminals "
        '
        'CriminalsRegistrationToolStripMenuItem
        '
        Me.CriminalsRegistrationToolStripMenuItem.Name = "CriminalsRegistrationToolStripMenuItem"
        Me.CriminalsRegistrationToolStripMenuItem.Size = New System.Drawing.Size(496, 34)
        Me.CriminalsRegistrationToolStripMenuItem.Text = "Criminals Registration"
        '
        'CriminalUpdationToolStripMenuItem
        '
        Me.CriminalUpdationToolStripMenuItem.Name = "CriminalUpdationToolStripMenuItem"
        Me.CriminalUpdationToolStripMenuItem.Size = New System.Drawing.Size(496, 34)
        Me.CriminalUpdationToolStripMenuItem.Text = "Criminal Updation "
        '
        'CriminalViewToolStripMenuItem
        '
        Me.CriminalViewToolStripMenuItem.Name = "CriminalViewToolStripMenuItem"
        Me.CriminalViewToolStripMenuItem.Size = New System.Drawing.Size(496, 34)
        Me.CriminalViewToolStripMenuItem.Text = "Criminal View"
        '
        'WantedCrininalsRegistrationToolStripMenuItem
        '
        Me.WantedCrininalsRegistrationToolStripMenuItem.Name = "WantedCrininalsRegistrationToolStripMenuItem"
        Me.WantedCrininalsRegistrationToolStripMenuItem.Size = New System.Drawing.Size(496, 34)
        Me.WantedCrininalsRegistrationToolStripMenuItem.Text = "Wanted Criminals Registration"
        '
        'CriminalsListToolStripMenuItem
        '
        Me.CriminalsListToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ListOfCriminalsToolStripMenuItem, Me.ListOfWantedCriminalsToolStripMenuItem})
        Me.CriminalsListToolStripMenuItem.ForeColor = System.Drawing.Color.Black
        Me.CriminalsListToolStripMenuItem.Name = "CriminalsListToolStripMenuItem"
        Me.CriminalsListToolStripMenuItem.Size = New System.Drawing.Size(206, 33)
        Me.CriminalsListToolStripMenuItem.Text = "Criminals List"
        '
        'ListOfCriminalsToolStripMenuItem
        '
        Me.ListOfCriminalsToolStripMenuItem.Name = "ListOfCriminalsToolStripMenuItem"
        Me.ListOfCriminalsToolStripMenuItem.Size = New System.Drawing.Size(417, 34)
        Me.ListOfCriminalsToolStripMenuItem.Text = "List Of Criminals"
        '
        'ListOfWantedCriminalsToolStripMenuItem
        '
        Me.ListOfWantedCriminalsToolStripMenuItem.Name = "ListOfWantedCriminalsToolStripMenuItem"
        Me.ListOfWantedCriminalsToolStripMenuItem.Size = New System.Drawing.Size(417, 34)
        Me.ListOfWantedCriminalsToolStripMenuItem.Text = "List Of Wanted Criminals"
        '
        'PoliceStationToolStripMenuItem
        '
        Me.PoliceStationToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PoliceStationDetailsToolStripMenuItem})
        Me.PoliceStationToolStripMenuItem.ForeColor = System.Drawing.Color.Black
        Me.PoliceStationToolStripMenuItem.Name = "PoliceStationToolStripMenuItem"
        Me.PoliceStationToolStripMenuItem.Size = New System.Drawing.Size(209, 33)
        Me.PoliceStationToolStripMenuItem.Text = "Police Station"
        '
        'PoliceStationDetailsToolStripMenuItem
        '
        Me.PoliceStationDetailsToolStripMenuItem.Name = "PoliceStationDetailsToolStripMenuItem"
        Me.PoliceStationDetailsToolStripMenuItem.Size = New System.Drawing.Size(368, 34)
        Me.PoliceStationDetailsToolStripMenuItem.Text = "Police station Details"
        '
        'StaffDetailsToolStripMenuItem
        '
        Me.StaffDetailsToolStripMenuItem.BackColor = System.Drawing.Color.Transparent
        Me.StaffDetailsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.StaffRegistrationToolStripMenuItem, Me.StaffUpdationViewToolStripMenuItem})
        Me.StaffDetailsToolStripMenuItem.ForeColor = System.Drawing.Color.Black
        Me.StaffDetailsToolStripMenuItem.Name = "StaffDetailsToolStripMenuItem"
        Me.StaffDetailsToolStripMenuItem.Size = New System.Drawing.Size(190, 33)
        Me.StaffDetailsToolStripMenuItem.Text = "Staff Details"
        '
        'StaffRegistrationToolStripMenuItem
        '
        Me.StaffRegistrationToolStripMenuItem.Name = "StaffRegistrationToolStripMenuItem"
        Me.StaffRegistrationToolStripMenuItem.Size = New System.Drawing.Size(362, 34)
        Me.StaffRegistrationToolStripMenuItem.Text = "Staff Registration"
        '
        'StaffUpdationViewToolStripMenuItem
        '
        Me.StaffUpdationViewToolStripMenuItem.Name = "StaffUpdationViewToolStripMenuItem"
        Me.StaffUpdationViewToolStripMenuItem.Size = New System.Drawing.Size(362, 34)
        Me.StaffUpdationViewToolStripMenuItem.Text = "Staff Updation/View"
        '
        'FingerPrintMatcherToolStripMenuItem
        '
        Me.FingerPrintMatcherToolStripMenuItem.BackColor = System.Drawing.Color.White
        Me.FingerPrintMatcherToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FingerPrintMatcherToolStripMenuItem1})
        Me.FingerPrintMatcherToolStripMenuItem.ForeColor = System.Drawing.Color.Black
        Me.FingerPrintMatcherToolStripMenuItem.Name = "FingerPrintMatcherToolStripMenuItem"
        Me.FingerPrintMatcherToolStripMenuItem.Size = New System.Drawing.Size(274, 33)
        Me.FingerPrintMatcherToolStripMenuItem.Text = "Match Finger Print"
        '
        'FingerPrintMatcherToolStripMenuItem1
        '
        Me.FingerPrintMatcherToolStripMenuItem1.Name = "FingerPrintMatcherToolStripMenuItem1"
        Me.FingerPrintMatcherToolStripMenuItem1.Size = New System.Drawing.Size(363, 34)
        Me.FingerPrintMatcherToolStripMenuItem1.Text = "Finger Print Matcher"
        '
        'LogOutToolStripMenuItem
        '
        Me.LogOutToolStripMenuItem.Name = "LogOutToolStripMenuItem"
        Me.LogOutToolStripMenuItem.Size = New System.Drawing.Size(129, 33)
        Me.LogOutToolStripMenuItem.Text = "Log Out"
        '
        'StatusStrip
        '
        Me.StatusStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel})
        Me.StatusStrip.Location = New System.Drawing.Point(0, 845)
        Me.StatusStrip.Name = "StatusStrip"
        Me.StatusStrip.Padding = New System.Windows.Forms.Padding(1, 0, 19, 0)
        Me.StatusStrip.Size = New System.Drawing.Size(1857, 25)
        Me.StatusStrip.TabIndex = 7
        Me.StatusStrip.Text = "StatusStrip"
        '
        'ToolStripStatusLabel
        '
        Me.ToolStripStatusLabel.Name = "ToolStripStatusLabel"
        Me.ToolStripStatusLabel.Size = New System.Drawing.Size(49, 20)
        Me.ToolStripStatusLabel.Text = "Status"
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'MDIParent1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1857, 870)
        Me.Controls.Add(Me.MenuStrip)
        Me.Controls.Add(Me.StatusStrip)
        Me.ForeColor = System.Drawing.Color.Black
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "MDIParent1"
        Me.Text = "MDIParent1"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip.ResumeLayout(False)
        Me.MenuStrip.PerformLayout()
        Me.StatusStrip.ResumeLayout(False)
        Me.StatusStrip.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolTip As System.Windows.Forms.ToolTip
    Friend WithEvents ToolStripStatusLabel As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents StatusStrip As System.Windows.Forms.StatusStrip
    Friend WithEvents MenuStrip As System.Windows.Forms.MenuStrip
    Friend WithEvents ComplaintToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ComplaintRegistrationToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ComplaintUpdateDeleteToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ComplaintViewToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FIRToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FIRRegistrationToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FIRViewToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CriminalsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CriminalsRegistrationToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CriminalUpdationToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CriminalViewToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CasesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CasesRegistrationToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CaseStatusUpdationToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CasesReportToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CaseReportToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PendingCasesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ProgressCaseesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DispossedCasesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CriminalsListToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ListOfCriminalsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PoliceStationToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PoliceStationDetailsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents StaffDetailsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents StaffRegistrationToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents StaffUpdationViewToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FingerPrintMatcherToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FingerPrintMatcherToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LogOutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents WantedCrininalsRegistrationToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ListOfWantedCriminalsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Timer1 As System.Windows.Forms.Timer

End Class
