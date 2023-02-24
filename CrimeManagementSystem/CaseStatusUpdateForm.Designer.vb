<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CaseStatusUpdateForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CaseStatusUpdateForm))
        Me.CASES = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.TextBox3contact3 = New System.Windows.Forms.TextBox()
        Me.TextBox3Witness3 = New System.Windows.Forms.TextBox()
        Me.TextBox2contact2 = New System.Windows.Forms.TextBox()
        Me.TextBox2Witness2 = New System.Windows.Forms.TextBox()
        Me.TextBox1Contact1 = New System.Windows.Forms.TextBox()
        Me.TextBox1Witness1 = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.ButtonDelete = New System.Windows.Forms.Button()
        Me.RadioButton3 = New System.Windows.Forms.RadioButton()
        Me.RadioButton2 = New System.Windows.Forms.RadioButton()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.ButtonView = New System.Windows.Forms.Button()
        Me.ButtonCancel = New System.Windows.Forms.Button()
        Me.ButtonUpdate = New System.Windows.Forms.Button()
        Me.TextBox5CaseDescription = New System.Windows.Forms.TextBox()
        Me.TextBox3FiledBy = New System.Windows.Forms.TextBox()
        Me.TextBox2CaseTitle = New System.Windows.Forms.TextBox()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.TextBox1CaseID = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBox6vitimName = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'CASES
        '
        Me.CASES.AutoSize = True
        Me.CASES.BackColor = System.Drawing.Color.Transparent
        Me.CASES.Font = New System.Drawing.Font("Verdana", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CASES.ForeColor = System.Drawing.Color.Black
        Me.CASES.Location = New System.Drawing.Point(163, 33)
        Me.CASES.Name = "CASES"
        Me.CASES.Size = New System.Drawing.Size(464, 40)
        Me.CASES.TabIndex = 8
        Me.CASES.Text = "CASES STATUS DETAILS" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.TextBox6vitimName)
        Me.Panel1.Controls.Add(Me.Label15)
        Me.Panel1.Controls.Add(Me.TextBox3contact3)
        Me.Panel1.Controls.Add(Me.TextBox3Witness3)
        Me.Panel1.Controls.Add(Me.TextBox2contact2)
        Me.Panel1.Controls.Add(Me.TextBox2Witness2)
        Me.Panel1.Controls.Add(Me.TextBox1Contact1)
        Me.Panel1.Controls.Add(Me.TextBox1Witness1)
        Me.Panel1.Controls.Add(Me.Label11)
        Me.Panel1.Controls.Add(Me.Label10)
        Me.Panel1.Controls.Add(Me.Label9)
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.Label12)
        Me.Panel1.Controls.Add(Me.Label13)
        Me.Panel1.Controls.Add(Me.Label14)
        Me.Panel1.Controls.Add(Me.ComboBox1)
        Me.Panel1.Controls.Add(Me.DataGridView1)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.ButtonDelete)
        Me.Panel1.Controls.Add(Me.RadioButton3)
        Me.Panel1.Controls.Add(Me.RadioButton2)
        Me.Panel1.Controls.Add(Me.CASES)
        Me.Panel1.Controls.Add(Me.RadioButton1)
        Me.Panel1.Controls.Add(Me.ButtonView)
        Me.Panel1.Controls.Add(Me.ButtonCancel)
        Me.Panel1.Controls.Add(Me.ButtonUpdate)
        Me.Panel1.Controls.Add(Me.TextBox5CaseDescription)
        Me.Panel1.Controls.Add(Me.TextBox3FiledBy)
        Me.Panel1.Controls.Add(Me.TextBox2CaseTitle)
        Me.Panel1.Controls.Add(Me.DateTimePicker1)
        Me.Panel1.Controls.Add(Me.TextBox1CaseID)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(12, 12)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1626, 758)
        Me.Panel1.TabIndex = 9
        '
        'TextBox3contact3
        '
        Me.TextBox3contact3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox3contact3.Location = New System.Drawing.Point(600, 668)
        Me.TextBox3contact3.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TextBox3contact3.Name = "TextBox3contact3"
        Me.TextBox3contact3.Size = New System.Drawing.Size(148, 27)
        Me.TextBox3contact3.TabIndex = 89
        '
        'TextBox3Witness3
        '
        Me.TextBox3Witness3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox3Witness3.Location = New System.Drawing.Point(246, 667)
        Me.TextBox3Witness3.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TextBox3Witness3.Name = "TextBox3Witness3"
        Me.TextBox3Witness3.Size = New System.Drawing.Size(166, 27)
        Me.TextBox3Witness3.TabIndex = 88
        '
        'TextBox2contact2
        '
        Me.TextBox2contact2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox2contact2.Location = New System.Drawing.Point(600, 626)
        Me.TextBox2contact2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TextBox2contact2.Name = "TextBox2contact2"
        Me.TextBox2contact2.Size = New System.Drawing.Size(148, 27)
        Me.TextBox2contact2.TabIndex = 87
        '
        'TextBox2Witness2
        '
        Me.TextBox2Witness2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox2Witness2.Location = New System.Drawing.Point(246, 621)
        Me.TextBox2Witness2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TextBox2Witness2.Name = "TextBox2Witness2"
        Me.TextBox2Witness2.Size = New System.Drawing.Size(166, 27)
        Me.TextBox2Witness2.TabIndex = 86
        '
        'TextBox1Contact1
        '
        Me.TextBox1Contact1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1Contact1.Location = New System.Drawing.Point(600, 580)
        Me.TextBox1Contact1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TextBox1Contact1.Name = "TextBox1Contact1"
        Me.TextBox1Contact1.Size = New System.Drawing.Size(148, 27)
        Me.TextBox1Contact1.TabIndex = 85
        '
        'TextBox1Witness1
        '
        Me.TextBox1Witness1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1Witness1.Location = New System.Drawing.Point(246, 579)
        Me.TextBox1Witness1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TextBox1Witness1.Name = "TextBox1Witness1"
        Me.TextBox1Witness1.Size = New System.Drawing.Size(166, 27)
        Me.TextBox1Witness1.TabIndex = 84
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(465, 669)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(106, 20)
        Me.Label11.TabIndex = 83
        Me.Label11.Text = "Contact no:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(62, 666)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(137, 20)
        Me.Label10.TabIndex = 82
        Me.Label10.Text = "Witness Name:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(465, 623)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(106, 20)
        Me.Label9.TabIndex = 81
        Me.Label9.Text = "Contact no:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(62, 627)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(137, 20)
        Me.Label8.TabIndex = 80
        Me.Label8.Text = "Witness Name:"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(465, 582)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(106, 20)
        Me.Label12.TabIndex = 79
        Me.Label12.Text = "Contact no:"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(62, 586)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(137, 20)
        Me.Label13.TabIndex = 78
        Me.Label13.Text = "Witness Name:"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(28, 541)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(149, 20)
        Me.Label14.TabIndex = 77
        Me.Label14.Text = "Witness Details:"
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(246, 390)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(200, 24)
        Me.ComboBox1.TabIndex = 63
        '
        'DataGridView1
        '
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.White
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(797, 82)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(734, 479)
        Me.DataGridView1.TabIndex = 10
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Location = New System.Drawing.Point(64, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(75, 77)
        Me.PictureBox1.TabIndex = 62
        Me.PictureBox1.TabStop = False
        '
        'ButtonDelete
        '
        Me.ButtonDelete.BackColor = System.Drawing.Color.Black
        Me.ButtonDelete.Font = New System.Drawing.Font("Microsoft YaHei UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonDelete.ForeColor = System.Drawing.Color.White
        Me.ButtonDelete.Location = New System.Drawing.Point(1214, 624)
        Me.ButtonDelete.Name = "ButtonDelete"
        Me.ButtonDelete.Size = New System.Drawing.Size(105, 36)
        Me.ButtonDelete.TabIndex = 57
        Me.ButtonDelete.Text = "DELETE"
        Me.ButtonDelete.UseVisualStyleBackColor = False
        '
        'RadioButton3
        '
        Me.RadioButton3.AutoSize = True
        Me.RadioButton3.Location = New System.Drawing.Point(580, 347)
        Me.RadioButton3.Name = "RadioButton3"
        Me.RadioButton3.Size = New System.Drawing.Size(124, 21)
        Me.RadioButton3.TabIndex = 56
        Me.RadioButton3.Text = "Disposed Case"
        Me.RadioButton3.UseVisualStyleBackColor = True
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.Location = New System.Drawing.Point(411, 347)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(122, 21)
        Me.RadioButton2.TabIndex = 55
        Me.RadioButton2.Text = "Progress Case"
        Me.RadioButton2.UseVisualStyleBackColor = True
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.Location = New System.Drawing.Point(246, 347)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(117, 21)
        Me.RadioButton1.TabIndex = 54
        Me.RadioButton1.Text = "Pending Case"
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'ButtonView
        '
        Me.ButtonView.BackColor = System.Drawing.Color.Black
        Me.ButtonView.Font = New System.Drawing.Font("Microsoft YaHei UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonView.ForeColor = System.Drawing.Color.White
        Me.ButtonView.Location = New System.Drawing.Point(850, 624)
        Me.ButtonView.Name = "ButtonView"
        Me.ButtonView.Size = New System.Drawing.Size(109, 36)
        Me.ButtonView.TabIndex = 53
        Me.ButtonView.Text = "VIEW"
        Me.ButtonView.UseVisualStyleBackColor = False
        '
        'ButtonCancel
        '
        Me.ButtonCancel.BackColor = System.Drawing.Color.Black
        Me.ButtonCancel.Font = New System.Drawing.Font("Microsoft YaHei UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonCancel.ForeColor = System.Drawing.Color.White
        Me.ButtonCancel.Location = New System.Drawing.Point(1391, 624)
        Me.ButtonCancel.Name = "ButtonCancel"
        Me.ButtonCancel.Size = New System.Drawing.Size(104, 36)
        Me.ButtonCancel.TabIndex = 51
        Me.ButtonCancel.Text = "CANCEL"
        Me.ButtonCancel.UseVisualStyleBackColor = False
        '
        'ButtonUpdate
        '
        Me.ButtonUpdate.BackColor = System.Drawing.Color.Black
        Me.ButtonUpdate.Font = New System.Drawing.Font("Microsoft YaHei UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonUpdate.ForeColor = System.Drawing.Color.White
        Me.ButtonUpdate.Location = New System.Drawing.Point(1020, 624)
        Me.ButtonUpdate.Name = "ButtonUpdate"
        Me.ButtonUpdate.Size = New System.Drawing.Size(109, 36)
        Me.ButtonUpdate.TabIndex = 50
        Me.ButtonUpdate.Text = "UPDATE"
        Me.ButtonUpdate.UseVisualStyleBackColor = False
        '
        'TextBox5CaseDescription
        '
        Me.TextBox5CaseDescription.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox5CaseDescription.Location = New System.Drawing.Point(246, 471)
        Me.TextBox5CaseDescription.Multiline = True
        Me.TextBox5CaseDescription.Name = "TextBox5CaseDescription"
        Me.TextBox5CaseDescription.Size = New System.Drawing.Size(465, 66)
        Me.TextBox5CaseDescription.TabIndex = 33
        '
        'TextBox3FiledBy
        '
        Me.TextBox3FiledBy.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox3FiledBy.Location = New System.Drawing.Point(246, 236)
        Me.TextBox3FiledBy.Name = "TextBox3FiledBy"
        Me.TextBox3FiledBy.Size = New System.Drawing.Size(200, 27)
        Me.TextBox3FiledBy.TabIndex = 31
        '
        'TextBox2CaseTitle
        '
        Me.TextBox2CaseTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox2CaseTitle.Location = New System.Drawing.Point(246, 188)
        Me.TextBox2CaseTitle.Name = "TextBox2CaseTitle"
        Me.TextBox2CaseTitle.Size = New System.Drawing.Size(200, 27)
        Me.TextBox2CaseTitle.TabIndex = 30
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(246, 296)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(200, 22)
        Me.DateTimePicker1.TabIndex = 29
        '
        'TextBox1CaseID
        '
        Me.TextBox1CaseID.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1CaseID.Location = New System.Drawing.Point(246, 131)
        Me.TextBox1CaseID.Name = "TextBox1CaseID"
        Me.TextBox1CaseID.Size = New System.Drawing.Size(200, 27)
        Me.TextBox1CaseID.TabIndex = 28
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(28, 494)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(161, 20)
        Me.Label7.TabIndex = 27
        Me.Label7.Text = "Case Description:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(38, 390)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(161, 20)
        Me.Label6.TabIndex = 26
        Me.Label6.Text = "Case Handled By:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(38, 348)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(118, 20)
        Me.Label5.TabIndex = 25
        Me.Label5.Text = "Case Status:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(38, 296)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(151, 20)
        Me.Label4.TabIndex = 24
        Me.Label4.Text = "Case Filed Date:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(38, 236)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(133, 20)
        Me.Label3.TabIndex = 23
        Me.Label3.Text = "Case Filed By:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(38, 188)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(101, 20)
        Me.Label2.TabIndex = 22
        Me.Label2.Text = "Case Title:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(38, 131)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(83, 20)
        Me.Label1.TabIndex = 21
        Me.Label1.Text = "Case ID:"
        '
        'TextBox6vitimName
        '
        Me.TextBox6vitimName.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox6vitimName.Location = New System.Drawing.Point(246, 431)
        Me.TextBox6vitimName.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TextBox6vitimName.Name = "TextBox6vitimName"
        Me.TextBox6vitimName.Size = New System.Drawing.Size(200, 27)
        Me.TextBox6vitimName.TabIndex = 91
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(38, 434)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(122, 20)
        Me.Label15.TabIndex = 90
        Me.Label15.Text = "Victim Name:"
        '
        'CaseStatusUpdateForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Maroon
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1924, 859)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "CaseStatusUpdateForm"
        Me.Text = "CaseStatusUpdateForm"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents CASES As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents ButtonView As System.Windows.Forms.Button
    Friend WithEvents ButtonCancel As System.Windows.Forms.Button
    Friend WithEvents ButtonUpdate As System.Windows.Forms.Button
    Friend WithEvents TextBox5CaseDescription As System.Windows.Forms.TextBox
    Friend WithEvents TextBox3FiledBy As System.Windows.Forms.TextBox
    Friend WithEvents TextBox2CaseTitle As System.Windows.Forms.TextBox
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents TextBox1CaseID As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents RadioButton3 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton2 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton1 As System.Windows.Forms.RadioButton
    Friend WithEvents ButtonDelete As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents TextBox3contact3 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox3Witness3 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox2contact2 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox2Witness2 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox1Contact1 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox1Witness1 As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents TextBox6vitimName As System.Windows.Forms.TextBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
End Class
