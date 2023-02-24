<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class WantedForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(WantedForm))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Criminal = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TextBox1CriminalID = New System.Windows.Forms.TextBox()
        Me.TextBox2CriminalName = New System.Windows.Forms.TextBox()
        Me.TextBox9CrimeCommitted = New System.Windows.Forms.TextBox()
        Me.TextBox10Description = New System.Windows.Forms.TextBox()
        Me.ButtonCancel = New System.Windows.Forms.Button()
        Me.ButtonSave = New System.Windows.Forms.Button()
        Me.ButtonImage = New System.Windows.Forms.Button()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Gray
        Me.PictureBox1.Location = New System.Drawing.Point(677, 168)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(320, 370)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Criminal
        '
        Me.Criminal.AutoSize = True
        Me.Criminal.BackColor = System.Drawing.Color.White
        Me.Criminal.Font = New System.Drawing.Font("Verdana", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Criminal.ForeColor = System.Drawing.Color.Maroon
        Me.Criminal.Location = New System.Drawing.Point(229, 79)
        Me.Criminal.Name = "Criminal"
        Me.Criminal.Size = New System.Drawing.Size(718, 40)
        Me.Criminal.TabIndex = 6
        Me.Criminal.Text = "WANTED CRIMINALS  REGISTRATION"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(80, 222)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(114, 20)
        Me.Label1.TabIndex = 22
        Me.Label1.Text = "Criminal No:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(68, 290)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(139, 20)
        Me.Label2.TabIndex = 24
        Me.Label2.Text = "Criminal Name:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(56, 377)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(161, 20)
        Me.Label3.TabIndex = 34
        Me.Label3.Text = "Crime Committed:"
        '
        'PictureBox2
        '
        Me.PictureBox2.BackgroundImage = CType(resources.GetObject("PictureBox2.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox2.Location = New System.Drawing.Point(109, 52)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(75, 77)
        Me.PictureBox2.TabIndex = 35
        Me.PictureBox2.TabStop = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(56, 478)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(210, 20)
        Me.Label4.TabIndex = 36
        Me.Label4.Text = "Description of Criminal:"
        '
        'TextBox1CriminalID
        '
        Me.TextBox1CriminalID.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1CriminalID.Location = New System.Drawing.Point(316, 215)
        Me.TextBox1CriminalID.Name = "TextBox1CriminalID"
        Me.TextBox1CriminalID.Size = New System.Drawing.Size(255, 27)
        Me.TextBox1CriminalID.TabIndex = 37
        '
        'TextBox2CriminalName
        '
        Me.TextBox2CriminalName.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox2CriminalName.Location = New System.Drawing.Point(316, 283)
        Me.TextBox2CriminalName.Name = "TextBox2CriminalName"
        Me.TextBox2CriminalName.Size = New System.Drawing.Size(255, 27)
        Me.TextBox2CriminalName.TabIndex = 54
        '
        'TextBox9CrimeCommitted
        '
        Me.TextBox9CrimeCommitted.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox9CrimeCommitted.Location = New System.Drawing.Point(316, 354)
        Me.TextBox9CrimeCommitted.Multiline = True
        Me.TextBox9CrimeCommitted.Name = "TextBox9CrimeCommitted"
        Me.TextBox9CrimeCommitted.Size = New System.Drawing.Size(255, 60)
        Me.TextBox9CrimeCommitted.TabIndex = 64
        '
        'TextBox10Description
        '
        Me.TextBox10Description.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox10Description.Location = New System.Drawing.Point(316, 465)
        Me.TextBox10Description.Multiline = True
        Me.TextBox10Description.Name = "TextBox10Description"
        Me.TextBox10Description.Size = New System.Drawing.Size(255, 110)
        Me.TextBox10Description.TabIndex = 65
        '
        'ButtonCancel
        '
        Me.ButtonCancel.BackColor = System.Drawing.Color.Maroon
        Me.ButtonCancel.Font = New System.Drawing.Font("Microsoft YaHei UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonCancel.ForeColor = System.Drawing.Color.White
        Me.ButtonCancel.Location = New System.Drawing.Point(367, 673)
        Me.ButtonCancel.Name = "ButtonCancel"
        Me.ButtonCancel.Size = New System.Drawing.Size(118, 36)
        Me.ButtonCancel.TabIndex = 67
        Me.ButtonCancel.Text = "CANCEL"
        Me.ButtonCancel.UseVisualStyleBackColor = False
        '
        'ButtonSave
        '
        Me.ButtonSave.BackColor = System.Drawing.Color.Maroon
        Me.ButtonSave.Font = New System.Drawing.Font("Microsoft YaHei UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonSave.ForeColor = System.Drawing.Color.White
        Me.ButtonSave.Location = New System.Drawing.Point(137, 673)
        Me.ButtonSave.Name = "ButtonSave"
        Me.ButtonSave.Size = New System.Drawing.Size(115, 36)
        Me.ButtonSave.TabIndex = 66
        Me.ButtonSave.Text = "SAVE"
        Me.ButtonSave.UseVisualStyleBackColor = False
        '
        'ButtonImage
        '
        Me.ButtonImage.Font = New System.Drawing.Font("Microsoft YaHei UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonImage.Location = New System.Drawing.Point(775, 559)
        Me.ButtonImage.Name = "ButtonImage"
        Me.ButtonImage.Size = New System.Drawing.Size(119, 36)
        Me.ButtonImage.TabIndex = 68
        Me.ButtonImage.Text = "UPLOAD"
        Me.ButtonImage.UseVisualStyleBackColor = True
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'WantedForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1314, 749)
        Me.Controls.Add(Me.ButtonImage)
        Me.Controls.Add(Me.ButtonCancel)
        Me.Controls.Add(Me.ButtonSave)
        Me.Controls.Add(Me.TextBox10Description)
        Me.Controls.Add(Me.TextBox9CrimeCommitted)
        Me.Controls.Add(Me.TextBox2CriminalName)
        Me.Controls.Add(Me.TextBox1CriminalID)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Criminal)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "WantedForm"
        Me.Text = "WantedForm"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Criminal As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents TextBox1CriminalID As System.Windows.Forms.TextBox
    Friend WithEvents TextBox2CriminalName As System.Windows.Forms.TextBox
    Friend WithEvents TextBox9CrimeCommitted As System.Windows.Forms.TextBox
    Friend WithEvents TextBox10Description As System.Windows.Forms.TextBox
    Friend WithEvents ButtonCancel As System.Windows.Forms.Button
    Friend WithEvents ButtonSave As System.Windows.Forms.Button
    Friend WithEvents ButtonImage As System.Windows.Forms.Button
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
End Class
