<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PoliceStationForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PoliceStationForm))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.ButtonDelete = New System.Windows.Forms.Button()
        Me.buttonCancel = New System.Windows.Forms.Button()
        Me.buttonSave = New System.Windows.Forms.Button()
        Me.buttonNew = New System.Windows.Forms.Button()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Complaint = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TextBox4phno = New System.Windows.Forms.TextBox()
        Me.TextBox3Address = New System.Windows.Forms.TextBox()
        Me.TextBox2StationName = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBox1StationCode = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.ButtonUpdate = New System.Windows.Forms.Button()
        Me.ButtonView = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.ButtonUpdate)
        Me.Panel1.Controls.Add(Me.ButtonDelete)
        Me.Panel1.Controls.Add(Me.buttonCancel)
        Me.Panel1.Controls.Add(Me.buttonSave)
        Me.Panel1.Controls.Add(Me.buttonNew)
        Me.Panel1.Controls.Add(Me.PictureBox2)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.Complaint)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.TextBox4phno)
        Me.Panel1.Controls.Add(Me.TextBox3Address)
        Me.Panel1.Controls.Add(Me.TextBox2StationName)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.TextBox1StationCode)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(25, 12)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(746, 605)
        Me.Panel1.TabIndex = 0
        '
        'ButtonDelete
        '
        Me.ButtonDelete.BackColor = System.Drawing.Color.Maroon
        Me.ButtonDelete.Enabled = False
        Me.ButtonDelete.ForeColor = System.Drawing.Color.White
        Me.ButtonDelete.Location = New System.Drawing.Point(433, 536)
        Me.ButtonDelete.Name = "ButtonDelete"
        Me.ButtonDelete.Size = New System.Drawing.Size(106, 48)
        Me.ButtonDelete.TabIndex = 36
        Me.ButtonDelete.Text = "Delete"
        Me.ButtonDelete.UseVisualStyleBackColor = False
        '
        'buttonCancel
        '
        Me.buttonCancel.BackColor = System.Drawing.Color.Maroon
        Me.buttonCancel.ForeColor = System.Drawing.Color.White
        Me.buttonCancel.Location = New System.Drawing.Point(598, 536)
        Me.buttonCancel.Name = "buttonCancel"
        Me.buttonCancel.Size = New System.Drawing.Size(106, 48)
        Me.buttonCancel.TabIndex = 38
        Me.buttonCancel.Text = "Cancel"
        Me.buttonCancel.UseVisualStyleBackColor = False
        '
        'buttonSave
        '
        Me.buttonSave.BackColor = System.Drawing.Color.Maroon
        Me.buttonSave.Enabled = False
        Me.buttonSave.ForeColor = System.Drawing.Color.White
        Me.buttonSave.Location = New System.Drawing.Point(153, 536)
        Me.buttonSave.Name = "buttonSave"
        Me.buttonSave.Size = New System.Drawing.Size(106, 48)
        Me.buttonSave.TabIndex = 33
        Me.buttonSave.Text = "Save"
        Me.buttonSave.UseVisualStyleBackColor = False
        '
        'buttonNew
        '
        Me.buttonNew.BackColor = System.Drawing.Color.Maroon
        Me.buttonNew.ForeColor = System.Drawing.Color.White
        Me.buttonNew.Location = New System.Drawing.Point(24, 536)
        Me.buttonNew.Name = "buttonNew"
        Me.buttonNew.Size = New System.Drawing.Size(106, 48)
        Me.buttonNew.TabIndex = 32
        Me.buttonNew.Text = "New"
        Me.buttonNew.UseVisualStyleBackColor = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PictureBox2.Location = New System.Drawing.Point(0, 486)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(746, 116)
        Me.PictureBox2.TabIndex = 31
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Location = New System.Drawing.Point(24, 3)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(75, 77)
        Me.PictureBox1.TabIndex = 30
        Me.PictureBox1.TabStop = False
        '
        'Complaint
        '
        Me.Complaint.AutoSize = True
        Me.Complaint.BackColor = System.Drawing.Color.White
        Me.Complaint.Font = New System.Drawing.Font("Verdana", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Complaint.ForeColor = System.Drawing.Color.Maroon
        Me.Complaint.Location = New System.Drawing.Point(105, 19)
        Me.Complaint.Name = "Complaint"
        Me.Complaint.Size = New System.Drawing.Size(507, 40)
        Me.Complaint.TabIndex = 29
        Me.Complaint.Text = "POLICE STATION DETAILS" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(20, 359)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(172, 20)
        Me.Label4.TabIndex = 28
        Me.Label4.Text = "Telephone Number:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(46, 243)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(84, 20)
        Me.Label3.TabIndex = 27
        Me.Label3.Text = "Address:"
        '
        'TextBox4phno
        '
        Me.TextBox4phno.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox4phno.Location = New System.Drawing.Point(227, 356)
        Me.TextBox4phno.Name = "TextBox4phno"
        Me.TextBox4phno.Size = New System.Drawing.Size(216, 27)
        Me.TextBox4phno.TabIndex = 26
        '
        'TextBox3Address
        '
        Me.TextBox3Address.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox3Address.Location = New System.Drawing.Point(227, 223)
        Me.TextBox3Address.Multiline = True
        Me.TextBox3Address.Name = "TextBox3Address"
        Me.TextBox3Address.Size = New System.Drawing.Size(360, 108)
        Me.TextBox3Address.TabIndex = 25
        '
        'TextBox2StationName
        '
        Me.TextBox2StationName.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox2StationName.Location = New System.Drawing.Point(227, 162)
        Me.TextBox2StationName.Name = "TextBox2StationName"
        Me.TextBox2StationName.Size = New System.Drawing.Size(216, 27)
        Me.TextBox2StationName.TabIndex = 24
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(42, 162)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(128, 20)
        Me.Label2.TabIndex = 23
        Me.Label2.Text = "Station Name:"
        '
        'TextBox1StationCode
        '
        Me.TextBox1StationCode.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1StationCode.Location = New System.Drawing.Point(227, 108)
        Me.TextBox1StationCode.MaxLength = 50
        Me.TextBox1StationCode.Name = "TextBox1StationCode"
        Me.TextBox1StationCode.Size = New System.Drawing.Size(216, 27)
        Me.TextBox1StationCode.TabIndex = 22
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(42, 108)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(129, 20)
        Me.Label1.TabIndex = 21
        Me.Label1.Text = "Station  Code:"
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(798, 31)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(618, 499)
        Me.DataGridView1.TabIndex = 1
        '
        'ButtonUpdate
        '
        Me.ButtonUpdate.BackColor = System.Drawing.Color.Maroon
        Me.ButtonUpdate.Enabled = False
        Me.ButtonUpdate.ForeColor = System.Drawing.Color.White
        Me.ButtonUpdate.Location = New System.Drawing.Point(293, 536)
        Me.ButtonUpdate.Name = "ButtonUpdate"
        Me.ButtonUpdate.Size = New System.Drawing.Size(106, 48)
        Me.ButtonUpdate.TabIndex = 39
        Me.ButtonUpdate.Text = "Update"
        Me.ButtonUpdate.UseVisualStyleBackColor = False
        '
        'ButtonView
        '
        Me.ButtonView.BackColor = System.Drawing.Color.Maroon
        Me.ButtonView.Font = New System.Drawing.Font("Microsoft YaHei UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonView.ForeColor = System.Drawing.Color.White
        Me.ButtonView.Location = New System.Drawing.Point(1054, 560)
        Me.ButtonView.Name = "ButtonView"
        Me.ButtonView.Size = New System.Drawing.Size(120, 36)
        Me.ButtonView.TabIndex = 59
        Me.ButtonView.Text = "VIEW"
        Me.ButtonView.UseVisualStyleBackColor = False
        '
        'PoliceStationForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Maroon
        Me.ClientSize = New System.Drawing.Size(1440, 629)
        Me.Controls.Add(Me.ButtonView)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "PoliceStationForm"
        Me.Text = "PoliceStationForm"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TextBox4phno As System.Windows.Forms.TextBox
    Friend WithEvents TextBox3Address As System.Windows.Forms.TextBox
    Friend WithEvents TextBox2StationName As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TextBox1StationCode As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Complaint As System.Windows.Forms.Label
    Friend WithEvents buttonCancel As System.Windows.Forms.Button
    Friend WithEvents ButtonDelete As System.Windows.Forms.Button
    Friend WithEvents buttonSave As System.Windows.Forms.Button
    Friend WithEvents buttonNew As System.Windows.Forms.Button
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents ButtonUpdate As System.Windows.Forms.Button
    Friend WithEvents ButtonView As System.Windows.Forms.Button
End Class
