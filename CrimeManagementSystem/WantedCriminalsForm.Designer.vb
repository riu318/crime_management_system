<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class WantedCriminalsForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(WantedCriminalsForm))
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.Criminal = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBox1CriminalNo = New System.Windows.Forms.TextBox()
        Me.TextBox2CriminalName = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.TextBox3CrimeCommitted = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.TextBox4Description = New System.Windows.Forms.TextBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.ButtonImage = New System.Windows.Forms.Button()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.ButtonSave = New System.Windows.Forms.Button()
        Me.ButtonCancel = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'Criminal
        '
        Me.Criminal.AutoSize = True
        Me.Criminal.BackColor = System.Drawing.Color.Transparent
        Me.Criminal.Font = New System.Drawing.Font("Verdana", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Criminal.ForeColor = System.Drawing.Color.White
        Me.Criminal.Location = New System.Drawing.Point(359, 68)
        Me.Criminal.Name = "Criminal"
        Me.Criminal.Size = New System.Drawing.Size(872, 40)
        Me.Criminal.TabIndex = 6
        Me.Criminal.Text = "WANTED CRIMINAL RECORDS REGISTRATION"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Location = New System.Drawing.Point(224, 46)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(75, 77)
        Me.PictureBox1.TabIndex = 7
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(534, 191)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(114, 20)
        Me.Label1.TabIndex = 22
        Me.Label1.Text = "Criminal No:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(534, 290)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(139, 20)
        Me.Label2.TabIndex = 24
        Me.Label2.Text = "Criminal Name:"
        '
        'TextBox1CriminalNo
        '
        Me.TextBox1CriminalNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1CriminalNo.Location = New System.Drawing.Point(765, 188)
        Me.TextBox1CriminalNo.Name = "TextBox1CriminalNo"
        Me.TextBox1CriminalNo.Size = New System.Drawing.Size(255, 27)
        Me.TextBox1CriminalNo.TabIndex = 25
        '
        'TextBox2CriminalName
        '
        Me.TextBox2CriminalName.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox2CriminalName.Location = New System.Drawing.Point(765, 287)
        Me.TextBox2CriminalName.Name = "TextBox2CriminalName"
        Me.TextBox2CriminalName.Size = New System.Drawing.Size(255, 27)
        Me.TextBox2CriminalName.TabIndex = 54
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(534, 383)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(161, 20)
        Me.Label12.TabIndex = 55
        Me.Label12.Text = "Crime Committed:"
        '
        'TextBox3CrimeCommitted
        '
        Me.TextBox3CrimeCommitted.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox3CrimeCommitted.Location = New System.Drawing.Point(765, 376)
        Me.TextBox3CrimeCommitted.Name = "TextBox3CrimeCommitted"
        Me.TextBox3CrimeCommitted.Size = New System.Drawing.Size(255, 27)
        Me.TextBox3CrimeCommitted.TabIndex = 64
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(534, 465)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(112, 40)
        Me.Label13.TabIndex = 65
        Me.Label13.Text = "Description " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "of Criminal:"
        '
        'TextBox4Description
        '
        Me.TextBox4Description.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox4Description.Location = New System.Drawing.Point(765, 462)
        Me.TextBox4Description.Multiline = True
        Me.TextBox4Description.Name = "TextBox4Description"
        Me.TextBox4Description.Size = New System.Drawing.Size(255, 55)
        Me.TextBox4Description.TabIndex = 66
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.White
        Me.PictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox2.Location = New System.Drawing.Point(200, 211)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(197, 207)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 67
        Me.PictureBox2.TabStop = False
        '
        'ButtonImage
        '
        Me.ButtonImage.Font = New System.Drawing.Font("Microsoft YaHei UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonImage.Location = New System.Drawing.Point(239, 481)
        Me.ButtonImage.Name = "ButtonImage"
        Me.ButtonImage.Size = New System.Drawing.Size(119, 36)
        Me.ButtonImage.TabIndex = 68
        Me.ButtonImage.Text = "UPLOAD"
        Me.ButtonImage.UseVisualStyleBackColor = True
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.BackColor = System.Drawing.Color.DarkGray
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.ForeColor = System.Drawing.Color.Transparent
        Me.Label18.Location = New System.Drawing.Point(264, 440)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(67, 20)
        Me.Label18.TabIndex = 74
        Me.Label18.Text = "IMAGE"
        '
        'ButtonSave
        '
        Me.ButtonSave.BackColor = System.Drawing.Color.Black
        Me.ButtonSave.Font = New System.Drawing.Font("Microsoft YaHei UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonSave.ForeColor = System.Drawing.Color.White
        Me.ButtonSave.Location = New System.Drawing.Point(651, 589)
        Me.ButtonSave.Name = "ButtonSave"
        Me.ButtonSave.Size = New System.Drawing.Size(115, 36)
        Me.ButtonSave.TabIndex = 75
        Me.ButtonSave.Text = "SAVE"
        Me.ButtonSave.UseVisualStyleBackColor = False
        '
        'ButtonCancel
        '
        Me.ButtonCancel.BackColor = System.Drawing.Color.Black
        Me.ButtonCancel.Font = New System.Drawing.Font("Microsoft YaHei UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonCancel.ForeColor = System.Drawing.Color.White
        Me.ButtonCancel.Location = New System.Drawing.Point(845, 589)
        Me.ButtonCancel.Name = "ButtonCancel"
        Me.ButtonCancel.Size = New System.Drawing.Size(118, 36)
        Me.ButtonCancel.TabIndex = 76
        Me.ButtonCancel.Text = "CANCEL"
        Me.ButtonCancel.UseVisualStyleBackColor = False
        '
        'WantedCriminalsForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(1443, 660)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TextBox1CriminalNo)
        Me.Controls.Add(Me.TextBox2CriminalName)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.TextBox3CrimeCommitted)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.TextBox4Description)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.ButtonSave)
        Me.Controls.Add(Me.ButtonImage)
        Me.Controls.Add(Me.ButtonCancel)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.Criminal)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "WantedCriminalsForm"
        Me.Text = "WantedCriminalsForm"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents Criminal As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TextBox1CriminalNo As System.Windows.Forms.TextBox
    Friend WithEvents TextBox2CriminalName As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents TextBox3CrimeCommitted As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents TextBox4Description As System.Windows.Forms.TextBox
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents ButtonImage As System.Windows.Forms.Button
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents ButtonSave As System.Windows.Forms.Button
    Friend WithEvents ButtonCancel As System.Windows.Forms.Button
End Class
