<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FIRregistrationForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FIRregistrationForm))
        Me.FIR = New System.Windows.Forms.Label()
        Me.Section = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TextBox1District = New System.Windows.Forms.TextBox()
        Me.TextBox2Policestation = New System.Windows.Forms.TextBox()
        Me.TextBox3FIRno = New System.Windows.Forms.TextBox()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.TextBox4timeOfFIR = New System.Windows.Forms.TextBox()
        Me.TextBox5ActsAndSections = New System.Windows.Forms.TextBox()
        Me.TextBox6placeOfIncident = New System.Windows.Forms.TextBox()
        Me.TextBox7FIRdetails = New System.Windows.Forms.TextBox()
        Me.TextBox8TimeOfIncident = New System.Windows.Forms.TextBox()
        Me.DateTimePicker2 = New System.Windows.Forms.DateTimePicker()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.TextBox9otherDetails = New System.Windows.Forms.TextBox()
        Me.TextBox10Name = New System.Windows.Forms.TextBox()
        Me.TextBox12PhNo = New System.Windows.Forms.TextBox()
        Me.TextBox14IDno = New System.Windows.Forms.TextBox()
        Me.TextBox11Age = New System.Windows.Forms.TextBox()
        Me.TextBox13Nationality = New System.Windows.Forms.TextBox()
        Me.TextBox15address = New System.Windows.Forms.TextBox()
        Me.ButtonSave = New System.Windows.Forms.Button()
        Me.ButtonCancel = New System.Windows.Forms.Button()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'FIR
        '
        Me.FIR.AutoSize = True
        Me.FIR.BackColor = System.Drawing.Color.White
        Me.FIR.Font = New System.Drawing.Font("Verdana", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FIR.ForeColor = System.Drawing.Color.Maroon
        Me.FIR.Location = New System.Drawing.Point(248, 10)
        Me.FIR.Name = "FIR"
        Me.FIR.Size = New System.Drawing.Size(575, 40)
        Me.FIR.TabIndex = 2
        Me.FIR.Text = "FIRST INFORMATION REPORT"
        '
        'Section
        '
        Me.Section.AutoSize = True
        Me.Section.BackColor = System.Drawing.Color.White
        Me.Section.Font = New System.Drawing.Font("Verdana", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Section.ForeColor = System.Drawing.Color.Maroon
        Me.Section.Location = New System.Drawing.Point(385, 50)
        Me.Section.Name = "Section"
        Me.Section.Size = New System.Drawing.Size(273, 23)
        Me.Section.TabIndex = 4
        Me.Section.Text = "(Under Section 154 Cr.P.C.)"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(56, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(78, 20)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "District:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(55, 72)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(132, 20)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Police Station:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(57, 113)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(115, 20)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "FIR Number:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(55, 169)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(116, 20)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Date Of FIR:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(632, 176)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(117, 20)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "Time Of FIR:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(56, 212)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(158, 20)
        Me.Label6.TabIndex = 7
        Me.Label6.Text = "Acts and Section:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(55, 254)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(160, 20)
        Me.Label7.TabIndex = 8
        Me.Label7.Text = "Place Of Incident:"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(56, 514)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(204, 20)
        Me.Label12.TabIndex = 9
        Me.Label12.Text = "Complainant/Informant:"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(129, 560)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(63, 20)
        Me.Label13.TabIndex = 10
        Me.Label13.Text = "Name:"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(129, 644)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(85, 20)
        Me.Label18.TabIndex = 12
        Me.Label18.Text = "ID Proof:"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(620, 557)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(47, 20)
        Me.Label14.TabIndex = 13
        Me.Label14.Text = "Age:"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(620, 608)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(104, 20)
        Me.Label17.TabIndex = 14
        Me.Label17.Text = "Nationality:"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.Location = New System.Drawing.Point(131, 692)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(84, 20)
        Me.Label20.TabIndex = 15
        Me.Label20.Text = "Address:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(61, 299)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(110, 20)
        Me.Label8.TabIndex = 16
        Me.Label8.Text = "FIR Details:"
        '
        'TextBox1District
        '
        Me.TextBox1District.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1District.Location = New System.Drawing.Point(238, 18)
        Me.TextBox1District.Name = "TextBox1District"
        Me.TextBox1District.Size = New System.Drawing.Size(261, 27)
        Me.TextBox1District.TabIndex = 17
        '
        'TextBox2Policestation
        '
        Me.TextBox2Policestation.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox2Policestation.Location = New System.Drawing.Point(238, 65)
        Me.TextBox2Policestation.Name = "TextBox2Policestation"
        Me.TextBox2Policestation.Size = New System.Drawing.Size(261, 27)
        Me.TextBox2Policestation.TabIndex = 18
        '
        'TextBox3FIRno
        '
        Me.TextBox3FIRno.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox3FIRno.Location = New System.Drawing.Point(238, 113)
        Me.TextBox3FIRno.Name = "TextBox3FIRno"
        Me.TextBox3FIRno.Size = New System.Drawing.Size(261, 27)
        Me.TextBox3FIRno.TabIndex = 19
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(238, 169)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(261, 22)
        Me.DateTimePicker1.TabIndex = 20
        '
        'TextBox4timeOfFIR
        '
        Me.TextBox4timeOfFIR.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox4timeOfFIR.Location = New System.Drawing.Point(791, 169)
        Me.TextBox4timeOfFIR.Name = "TextBox4timeOfFIR"
        Me.TextBox4timeOfFIR.ReadOnly = True
        Me.TextBox4timeOfFIR.Size = New System.Drawing.Size(182, 27)
        Me.TextBox4timeOfFIR.TabIndex = 21
        '
        'TextBox5ActsAndSections
        '
        Me.TextBox5ActsAndSections.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox5ActsAndSections.Location = New System.Drawing.Point(238, 212)
        Me.TextBox5ActsAndSections.Name = "TextBox5ActsAndSections"
        Me.TextBox5ActsAndSections.Size = New System.Drawing.Size(261, 27)
        Me.TextBox5ActsAndSections.TabIndex = 22
        '
        'TextBox6placeOfIncident
        '
        Me.TextBox6placeOfIncident.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox6placeOfIncident.Location = New System.Drawing.Point(238, 254)
        Me.TextBox6placeOfIncident.Multiline = True
        Me.TextBox6placeOfIncident.Name = "TextBox6placeOfIncident"
        Me.TextBox6placeOfIncident.Size = New System.Drawing.Size(420, 34)
        Me.TextBox6placeOfIncident.TabIndex = 23
        '
        'TextBox7FIRdetails
        '
        Me.TextBox7FIRdetails.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox7FIRdetails.Location = New System.Drawing.Point(238, 299)
        Me.TextBox7FIRdetails.Multiline = True
        Me.TextBox7FIRdetails.Name = "TextBox7FIRdetails"
        Me.TextBox7FIRdetails.Size = New System.Drawing.Size(420, 63)
        Me.TextBox7FIRdetails.TabIndex = 24
        '
        'TextBox8TimeOfIncident
        '
        Me.TextBox8TimeOfIncident.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox8TimeOfIncident.Location = New System.Drawing.Point(791, 388)
        Me.TextBox8TimeOfIncident.Name = "TextBox8TimeOfIncident"
        Me.TextBox8TimeOfIncident.Size = New System.Drawing.Size(182, 27)
        Me.TextBox8TimeOfIncident.TabIndex = 25
        '
        'DateTimePicker2
        '
        Me.DateTimePicker2.Location = New System.Drawing.Point(238, 389)
        Me.DateTimePicker2.Name = "DateTimePicker2"
        Me.DateTimePicker2.Size = New System.Drawing.Size(261, 22)
        Me.DateTimePicker2.TabIndex = 26
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(54, 389)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(153, 20)
        Me.Label9.TabIndex = 27
        Me.Label9.Text = "Date Of Incident:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(595, 391)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(154, 20)
        Me.Label10.TabIndex = 28
        Me.Label10.Text = "Time Of Incident:"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(129, 604)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(96, 20)
        Me.Label16.TabIndex = 29
        Me.Label16.Text = "Phone No:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(57, 440)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(135, 40)
        Me.Label11.TabIndex = 30
        Me.Label11.Text = "Other Details" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "About Incident:"
        '
        'TextBox9otherDetails
        '
        Me.TextBox9otherDetails.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox9otherDetails.Location = New System.Drawing.Point(238, 440)
        Me.TextBox9otherDetails.Multiline = True
        Me.TextBox9otherDetails.Name = "TextBox9otherDetails"
        Me.TextBox9otherDetails.Size = New System.Drawing.Size(420, 57)
        Me.TextBox9otherDetails.TabIndex = 31
        '
        'TextBox10Name
        '
        Me.TextBox10Name.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox10Name.Location = New System.Drawing.Point(238, 557)
        Me.TextBox10Name.Name = "TextBox10Name"
        Me.TextBox10Name.Size = New System.Drawing.Size(336, 27)
        Me.TextBox10Name.TabIndex = 32
        '
        'TextBox12PhNo
        '
        Me.TextBox12PhNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox12PhNo.Location = New System.Drawing.Point(238, 601)
        Me.TextBox12PhNo.Name = "TextBox12PhNo"
        Me.TextBox12PhNo.Size = New System.Drawing.Size(336, 27)
        Me.TextBox12PhNo.TabIndex = 33
        '
        'TextBox14IDno
        '
        Me.TextBox14IDno.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox14IDno.Location = New System.Drawing.Point(749, 644)
        Me.TextBox14IDno.Name = "TextBox14IDno"
        Me.TextBox14IDno.Size = New System.Drawing.Size(224, 27)
        Me.TextBox14IDno.TabIndex = 34
        '
        'TextBox11Age
        '
        Me.TextBox11Age.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox11Age.Location = New System.Drawing.Point(686, 560)
        Me.TextBox11Age.Name = "TextBox11Age"
        Me.TextBox11Age.Size = New System.Drawing.Size(63, 27)
        Me.TextBox11Age.TabIndex = 35
        '
        'TextBox13Nationality
        '
        Me.TextBox13Nationality.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox13Nationality.Location = New System.Drawing.Point(749, 601)
        Me.TextBox13Nationality.Name = "TextBox13Nationality"
        Me.TextBox13Nationality.Size = New System.Drawing.Size(224, 27)
        Me.TextBox13Nationality.TabIndex = 36
        '
        'TextBox15address
        '
        Me.TextBox15address.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox15address.Location = New System.Drawing.Point(238, 692)
        Me.TextBox15address.Multiline = True
        Me.TextBox15address.Name = "TextBox15address"
        Me.TextBox15address.Size = New System.Drawing.Size(336, 35)
        Me.TextBox15address.TabIndex = 37
        '
        'ButtonSave
        '
        Me.ButtonSave.BackColor = System.Drawing.Color.Maroon
        Me.ButtonSave.Font = New System.Drawing.Font("Microsoft YaHei UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonSave.ForeColor = System.Drawing.Color.White
        Me.ButtonSave.Location = New System.Drawing.Point(719, 702)
        Me.ButtonSave.Name = "ButtonSave"
        Me.ButtonSave.Size = New System.Drawing.Size(104, 36)
        Me.ButtonSave.TabIndex = 38
        Me.ButtonSave.Text = "SAVE"
        Me.ButtonSave.UseVisualStyleBackColor = False
        '
        'ButtonCancel
        '
        Me.ButtonCancel.BackColor = System.Drawing.Color.Maroon
        Me.ButtonCancel.Font = New System.Drawing.Font("Microsoft YaHei UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonCancel.ForeColor = System.Drawing.Color.White
        Me.ButtonCancel.Location = New System.Drawing.Point(853, 702)
        Me.ButtonCancel.Name = "ButtonCancel"
        Me.ButtonCancel.Size = New System.Drawing.Size(105, 36)
        Me.ButtonCancel.TabIndex = 39
        Me.ButtonCancel.Text = "CANCEL"
        Me.ButtonCancel.UseVisualStyleBackColor = False
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(655, 644)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(69, 20)
        Me.Label19.TabIndex = 41
        Me.Label19.Text = "ID No :"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.ComboBox2)
        Me.Panel1.Controls.Add(Me.Label15)
        Me.Panel1.Controls.Add(Me.ComboBox1)
        Me.Panel1.Controls.Add(Me.Label21)
        Me.Panel1.Controls.Add(Me.Label19)
        Me.Panel1.Controls.Add(Me.ButtonCancel)
        Me.Panel1.Controls.Add(Me.ButtonSave)
        Me.Panel1.Controls.Add(Me.TextBox15address)
        Me.Panel1.Controls.Add(Me.TextBox13Nationality)
        Me.Panel1.Controls.Add(Me.TextBox11Age)
        Me.Panel1.Controls.Add(Me.TextBox14IDno)
        Me.Panel1.Controls.Add(Me.TextBox12PhNo)
        Me.Panel1.Controls.Add(Me.TextBox10Name)
        Me.Panel1.Controls.Add(Me.TextBox9otherDetails)
        Me.Panel1.Controls.Add(Me.Label11)
        Me.Panel1.Controls.Add(Me.Label16)
        Me.Panel1.Controls.Add(Me.Label10)
        Me.Panel1.Controls.Add(Me.Label9)
        Me.Panel1.Controls.Add(Me.DateTimePicker2)
        Me.Panel1.Controls.Add(Me.TextBox8TimeOfIncident)
        Me.Panel1.Controls.Add(Me.TextBox7FIRdetails)
        Me.Panel1.Controls.Add(Me.TextBox6placeOfIncident)
        Me.Panel1.Controls.Add(Me.TextBox5ActsAndSections)
        Me.Panel1.Controls.Add(Me.TextBox4timeOfFIR)
        Me.Panel1.Controls.Add(Me.DateTimePicker1)
        Me.Panel1.Controls.Add(Me.TextBox3FIRno)
        Me.Panel1.Controls.Add(Me.TextBox2Policestation)
        Me.Panel1.Controls.Add(Me.TextBox1District)
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.Label20)
        Me.Panel1.Controls.Add(Me.Label17)
        Me.Panel1.Controls.Add(Me.Label14)
        Me.Panel1.Controls.Add(Me.Label18)
        Me.Panel1.Controls.Add(Me.Label13)
        Me.Panel1.Controls.Add(Me.Label12)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(120, 85)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1072, 776)
        Me.Panel1.TabIndex = 3
        '
        'ComboBox2
        '
        Me.ComboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Items.AddRange(New Object() {"Aadhaar Card", "Voter ID Card", "PAN Card", "Ration Card"})
        Me.ComboBox2.Location = New System.Drawing.Point(238, 647)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(336, 24)
        Me.ComboBox2.TabIndex = 45
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(787, 563)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(76, 20)
        Me.Label15.TabIndex = 44
        Me.Label15.Text = "Gender:"
        '
        'ComboBox1
        '
        Me.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"Male", "Female", "Other"})
        Me.ComboBox1.Location = New System.Drawing.Point(883, 563)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(90, 24)
        Me.ComboBox1.TabIndex = 43
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.ForeColor = System.Drawing.Color.Red
        Me.Label21.Location = New System.Drawing.Point(62, 480)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(63, 17)
        Me.Label21.TabIndex = 42
        Me.Label21.Text = "optional*"
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Location = New System.Drawing.Point(167, 4)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(75, 78)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox1.TabIndex = 43
        Me.PictureBox1.TabStop = False
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.White
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.PictureBox1)
        Me.Panel2.Controls.Add(Me.FIR)
        Me.Panel2.Controls.Add(Me.Section)
        Me.Panel2.Location = New System.Drawing.Point(120, 11)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1072, 87)
        Me.Panel2.TabIndex = 44
        '
        'FIRregistrationForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Maroon
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1341, 1055)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.DoubleBuffered = True
        Me.Name = "FIRregistrationForm"
        Me.Text = "FIRregistrationForm"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents FIR As System.Windows.Forms.Label
    Friend WithEvents Section As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents TextBox1District As System.Windows.Forms.TextBox
    Friend WithEvents TextBox2Policestation As System.Windows.Forms.TextBox
    Friend WithEvents TextBox3FIRno As System.Windows.Forms.TextBox
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents TextBox4timeOfFIR As System.Windows.Forms.TextBox
    Friend WithEvents TextBox5ActsAndSections As System.Windows.Forms.TextBox
    Friend WithEvents TextBox6placeOfIncident As System.Windows.Forms.TextBox
    Friend WithEvents TextBox7FIRdetails As System.Windows.Forms.TextBox
    Friend WithEvents TextBox8TimeOfIncident As System.Windows.Forms.TextBox
    Friend WithEvents DateTimePicker2 As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents TextBox9otherDetails As System.Windows.Forms.TextBox
    Friend WithEvents TextBox10Name As System.Windows.Forms.TextBox
    Friend WithEvents TextBox12PhNo As System.Windows.Forms.TextBox
    Friend WithEvents TextBox14IDno As System.Windows.Forms.TextBox
    Friend WithEvents TextBox11Age As System.Windows.Forms.TextBox
    Friend WithEvents TextBox13Nationality As System.Windows.Forms.TextBox
    Friend WithEvents TextBox15address As System.Windows.Forms.TextBox
    Friend WithEvents ButtonSave As System.Windows.Forms.Button
    Friend WithEvents ButtonCancel As System.Windows.Forms.Button
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents ComboBox2 As System.Windows.Forms.ComboBox
End Class
