<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.ns = New System.Windows.Forms.TextBox()
        Me.td = New System.Windows.Forms.TextBox()
        Me.gs = New System.Windows.Forms.TextBox()
        Me.fullname = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.btn_okay = New System.Windows.Forms.Button()
        Me.btn_clear = New System.Windows.Forms.Button()
        Me.fName = New System.Windows.Forms.TextBox()
        Me.mInitial = New System.Windows.Forms.TextBox()
        Me.lName = New System.Windows.Forms.TextBox()
        Me.rph = New System.Windows.Forms.TextBox()
        Me.hpd = New System.Windows.Forms.TextBox()
        Me.dw = New System.Windows.Forms.TextBox()
        Me.tax = New System.Windows.Forms.TextBox()
        Me.gsis = New System.Windows.Forms.TextBox()
        Me.sss = New System.Windows.Forms.TextBox()
        Me.phil = New System.Windows.Forms.TextBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Sitka Banner", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(100, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(222, 39)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "PAYROLL SYSTEM"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Sitka Banner", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label2.Location = New System.Drawing.Point(33, 46)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(88, 23)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "First Name:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Sitka Banner", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label3.Location = New System.Drawing.Point(33, 73)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(101, 23)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Middle Initial:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Sitka Banner", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label4.Location = New System.Drawing.Point(33, 98)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(84, 23)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Last Name:"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(4, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(150, Byte), Integer))
        Me.Panel2.Controls.Add(Me.Panel3)
        Me.Panel2.Location = New System.Drawing.Point(388, 102)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(390, 195)
        Me.Panel2.TabIndex = 2
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.SystemColors.Control
        Me.Panel3.Controls.Add(Me.ns)
        Me.Panel3.Controls.Add(Me.td)
        Me.Panel3.Controls.Add(Me.gs)
        Me.Panel3.Controls.Add(Me.fullname)
        Me.Panel3.Controls.Add(Me.Label12)
        Me.Panel3.Controls.Add(Me.Label13)
        Me.Panel3.Controls.Add(Me.Label14)
        Me.Panel3.Controls.Add(Me.Label15)
        Me.Panel3.Location = New System.Drawing.Point(3, 3)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(384, 187)
        Me.Panel3.TabIndex = 3
        '
        'ns
        '
        Me.ns.Location = New System.Drawing.Point(174, 136)
        Me.ns.Name = "ns"
        Me.ns.ReadOnly = True
        Me.ns.Size = New System.Drawing.Size(195, 23)
        Me.ns.TabIndex = 30
        '
        'td
        '
        Me.td.Location = New System.Drawing.Point(174, 102)
        Me.td.Name = "td"
        Me.td.ReadOnly = True
        Me.td.Size = New System.Drawing.Size(195, 23)
        Me.td.TabIndex = 29
        '
        'gs
        '
        Me.gs.Location = New System.Drawing.Point(174, 64)
        Me.gs.Name = "gs"
        Me.gs.ReadOnly = True
        Me.gs.Size = New System.Drawing.Size(195, 23)
        Me.gs.TabIndex = 28
        '
        'fullname
        '
        Me.fullname.Location = New System.Drawing.Point(122, 26)
        Me.fullname.Name = "fullname"
        Me.fullname.ReadOnly = True
        Me.fullname.Size = New System.Drawing.Size(247, 23)
        Me.fullname.TabIndex = 27
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Segoe UI Historic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label12.Location = New System.Drawing.Point(22, 134)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(96, 21)
        Me.Label12.TabIndex = 11
        Me.Label12.Text = "Net Salary:"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Segoe UI Historic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label13.Location = New System.Drawing.Point(22, 104)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(138, 21)
        Me.Label13.TabIndex = 12
        Me.Label13.Text = "Total Deduction:"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Segoe UI Historic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label14.Location = New System.Drawing.Point(22, 66)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(113, 21)
        Me.Label14.TabIndex = 13
        Me.Label14.Text = "Gross Salary:"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Segoe UI Historic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label15.Location = New System.Drawing.Point(22, 28)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(94, 21)
        Me.Label15.TabIndex = 14
        Me.Label15.Text = "Full Name:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Sitka Banner", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label5.Location = New System.Drawing.Point(33, 306)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(83, 23)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "PhilHealth:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Sitka Banner", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label6.Location = New System.Drawing.Point(34, 277)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(39, 23)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "SSS:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Sitka Banner", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label7.Location = New System.Drawing.Point(34, 248)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(46, 23)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "GSIS:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Sitka Banner", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label8.Location = New System.Drawing.Point(34, 219)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(38, 23)
        Me.Label8.TabIndex = 7
        Me.Label8.Text = "Tax:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Sitka Banner", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label9.Location = New System.Drawing.Point(34, 186)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(101, 23)
        Me.Label9.TabIndex = 8
        Me.Label9.Text = "Days Worked:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Sitka Banner", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label10.Location = New System.Drawing.Point(34, 161)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(110, 23)
        Me.Label10.TabIndex = 9
        Me.Label10.Text = "Hours per Day:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Sitka Banner", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label11.Location = New System.Drawing.Point(34, 136)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(108, 23)
        Me.Label11.TabIndex = 10
        Me.Label11.Text = "Rate per Hour:"
        '
        'btn_okay
        '
        Me.btn_okay.Location = New System.Drawing.Point(451, 303)
        Me.btn_okay.Name = "btn_okay"
        Me.btn_okay.Size = New System.Drawing.Size(75, 23)
        Me.btn_okay.TabIndex = 15
        Me.btn_okay.Text = "OK"
        Me.btn_okay.UseVisualStyleBackColor = True
        '
        'btn_clear
        '
        Me.btn_clear.Location = New System.Drawing.Point(627, 303)
        Me.btn_clear.Name = "btn_clear"
        Me.btn_clear.Size = New System.Drawing.Size(75, 23)
        Me.btn_clear.TabIndex = 16
        Me.btn_clear.Text = "CLEAR"
        Me.btn_clear.UseVisualStyleBackColor = True
        '
        'fName
        '
        Me.fName.Location = New System.Drawing.Point(157, 44)
        Me.fName.Name = "fName"
        Me.fName.Size = New System.Drawing.Size(219, 23)
        Me.fName.TabIndex = 17
        '
        'mInitial
        '
        Me.mInitial.Location = New System.Drawing.Point(157, 73)
        Me.mInitial.Name = "mInitial"
        Me.mInitial.Size = New System.Drawing.Size(219, 23)
        Me.mInitial.TabIndex = 18
        '
        'lName
        '
        Me.lName.Location = New System.Drawing.Point(157, 96)
        Me.lName.Name = "lName"
        Me.lName.Size = New System.Drawing.Size(219, 23)
        Me.lName.TabIndex = 19
        '
        'rph
        '
        Me.rph.Location = New System.Drawing.Point(167, 134)
        Me.rph.Name = "rph"
        Me.rph.Size = New System.Drawing.Size(209, 23)
        Me.rph.TabIndex = 20
        '
        'hpd
        '
        Me.hpd.Location = New System.Drawing.Point(167, 159)
        Me.hpd.Name = "hpd"
        Me.hpd.Size = New System.Drawing.Size(209, 23)
        Me.hpd.TabIndex = 21
        '
        'dw
        '
        Me.dw.Location = New System.Drawing.Point(167, 188)
        Me.dw.Name = "dw"
        Me.dw.Size = New System.Drawing.Size(209, 23)
        Me.dw.TabIndex = 22
        '
        'tax
        '
        Me.tax.Location = New System.Drawing.Point(167, 217)
        Me.tax.Name = "tax"
        Me.tax.Size = New System.Drawing.Size(209, 23)
        Me.tax.TabIndex = 23
        '
        'gsis
        '
        Me.gsis.Location = New System.Drawing.Point(167, 246)
        Me.gsis.Name = "gsis"
        Me.gsis.Size = New System.Drawing.Size(209, 23)
        Me.gsis.TabIndex = 24
        '
        'sss
        '
        Me.sss.Location = New System.Drawing.Point(167, 275)
        Me.sss.Name = "sss"
        Me.sss.Size = New System.Drawing.Size(209, 23)
        Me.sss.TabIndex = 25
        '
        'phil
        '
        Me.phil.Location = New System.Drawing.Point(167, 304)
        Me.phil.Name = "phil"
        Me.phil.Size = New System.Drawing.Size(209, 23)
        Me.phil.TabIndex = 26
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(435, 16)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(203, 80)
        Me.PictureBox3.TabIndex = 35
        Me.PictureBox3.TabStop = False
        '
        'PictureBox4
        '
        Me.PictureBox4.Image = CType(resources.GetObject("PictureBox4.Image"), System.Drawing.Image)
        Me.PictureBox4.Location = New System.Drawing.Point(644, 9)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(83, 98)
        Me.PictureBox4.TabIndex = 36
        Me.PictureBox4.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 345)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.phil)
        Me.Controls.Add(Me.sss)
        Me.Controls.Add(Me.gsis)
        Me.Controls.Add(Me.tax)
        Me.Controls.Add(Me.dw)
        Me.Controls.Add(Me.hpd)
        Me.Controls.Add(Me.rph)
        Me.Controls.Add(Me.lName)
        Me.Controls.Add(Me.mInitial)
        Me.Controls.Add(Me.fName)
        Me.Controls.Add(Me.btn_okay)
        Me.Controls.Add(Me.btn_clear)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.PictureBox4)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.Panel2.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents btn_okay As Button
    Friend WithEvents btn_clear As Button
    Friend WithEvents ns As TextBox
    Friend WithEvents td As TextBox
    Friend WithEvents gs As TextBox
    Friend WithEvents fullname As TextBox
    Friend WithEvents fName As TextBox
    Friend WithEvents mInitial As TextBox
    Friend WithEvents lName As TextBox
    Friend WithEvents rph As TextBox
    Friend WithEvents hpd As TextBox
    Friend WithEvents dw As TextBox
    Friend WithEvents tax As TextBox
    Friend WithEvents gsis As TextBox
    Friend WithEvents sss As TextBox
    Friend WithEvents phil As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents Button7 As Button
    Friend WithEvents Button8 As Button
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox4 As PictureBox
End Class
