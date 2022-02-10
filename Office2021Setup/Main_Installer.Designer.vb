<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Main_Installer
    Inherits System.Windows.Forms.Form

    'Form 覆寫 Dispose 以清除元件清單。
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

    '為 Windows Form 設計工具的必要項
    Private components As System.ComponentModel.IContainer

    '注意: 以下為 Windows Form 設計工具所需的程序
    '可以使用 Windows Form 設計工具進行修改。
    '請勿使用程式碼編輯器進行修改。
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Main_Installer))
        Me.sel_world = New System.Windows.Forms.CheckBox()
        Me.sel_excel = New System.Windows.Forms.CheckBox()
        Me.sel_powerpoint = New System.Windows.Forms.CheckBox()
        Me.sel_access = New System.Windows.Forms.CheckBox()
        Me.sel_outlook = New System.Windows.Forms.CheckBox()
        Me.sel_publisher = New System.Windows.Forms.CheckBox()
        Me.sel_skype = New System.Windows.Forms.CheckBox()
        Me.lng_zh = New System.Windows.Forms.RadioButton()
        Me.lng_en = New System.Windows.Forms.RadioButton()
        Me.sys_32 = New System.Windows.Forms.RadioButton()
        Me.sys_64 = New System.Windows.Forms.RadioButton()
        Me.sel_onenote = New System.Windows.Forms.CheckBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Btn_Install = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Btn_Back = New System.Windows.Forms.Button()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.sel_project = New System.Windows.Forms.CheckBox()
        Me.sel_visio = New System.Windows.Forms.CheckBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.Btn_Exit = New System.Windows.Forms.PictureBox()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox7 = New System.Windows.Forms.PictureBox()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Btn_Exit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'sel_world
        '
        resources.ApplyResources(Me.sel_world, "sel_world")
        Me.sel_world.Checked = True
        Me.sel_world.CheckState = System.Windows.Forms.CheckState.Checked
        Me.sel_world.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.sel_world.Name = "sel_world"
        Me.sel_world.Tag = "0"
        Me.sel_world.UseVisualStyleBackColor = True
        '
        'sel_excel
        '
        resources.ApplyResources(Me.sel_excel, "sel_excel")
        Me.sel_excel.Checked = True
        Me.sel_excel.CheckState = System.Windows.Forms.CheckState.Checked
        Me.sel_excel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.sel_excel.Name = "sel_excel"
        Me.sel_excel.Tag = "1"
        Me.sel_excel.UseVisualStyleBackColor = True
        '
        'sel_powerpoint
        '
        resources.ApplyResources(Me.sel_powerpoint, "sel_powerpoint")
        Me.sel_powerpoint.Checked = True
        Me.sel_powerpoint.CheckState = System.Windows.Forms.CheckState.Checked
        Me.sel_powerpoint.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.sel_powerpoint.Name = "sel_powerpoint"
        Me.sel_powerpoint.Tag = "2"
        Me.sel_powerpoint.UseVisualStyleBackColor = True
        '
        'sel_access
        '
        resources.ApplyResources(Me.sel_access, "sel_access")
        Me.sel_access.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.sel_access.Name = "sel_access"
        Me.sel_access.Tag = "5"
        Me.sel_access.UseVisualStyleBackColor = True
        '
        'sel_outlook
        '
        resources.ApplyResources(Me.sel_outlook, "sel_outlook")
        Me.sel_outlook.Checked = True
        Me.sel_outlook.CheckState = System.Windows.Forms.CheckState.Checked
        Me.sel_outlook.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.sel_outlook.Name = "sel_outlook"
        Me.sel_outlook.Tag = "3"
        Me.sel_outlook.UseVisualStyleBackColor = True
        '
        'sel_publisher
        '
        resources.ApplyResources(Me.sel_publisher, "sel_publisher")
        Me.sel_publisher.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.sel_publisher.Name = "sel_publisher"
        Me.sel_publisher.Tag = "6"
        Me.sel_publisher.UseVisualStyleBackColor = True
        '
        'sel_skype
        '
        resources.ApplyResources(Me.sel_skype, "sel_skype")
        Me.sel_skype.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.sel_skype.Name = "sel_skype"
        Me.sel_skype.Tag = "7"
        Me.sel_skype.UseVisualStyleBackColor = True
        '
        'lng_zh
        '
        resources.ApplyResources(Me.lng_zh, "lng_zh")
        Me.lng_zh.Checked = True
        Me.lng_zh.Name = "lng_zh"
        Me.lng_zh.TabStop = True
        Me.lng_zh.UseVisualStyleBackColor = True
        '
        'lng_en
        '
        resources.ApplyResources(Me.lng_en, "lng_en")
        Me.lng_en.Name = "lng_en"
        Me.lng_en.UseVisualStyleBackColor = True
        '
        'sys_32
        '
        resources.ApplyResources(Me.sys_32, "sys_32")
        Me.sys_32.Name = "sys_32"
        Me.sys_32.UseVisualStyleBackColor = True
        '
        'sys_64
        '
        resources.ApplyResources(Me.sys_64, "sys_64")
        Me.sys_64.Checked = True
        Me.sys_64.Name = "sys_64"
        Me.sys_64.TabStop = True
        Me.sys_64.UseVisualStyleBackColor = True
        '
        'sel_onenote
        '
        resources.ApplyResources(Me.sel_onenote, "sel_onenote")
        Me.sel_onenote.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.sel_onenote.Name = "sel_onenote"
        Me.sel_onenote.Tag = "4"
        Me.sel_onenote.UseVisualStyleBackColor = True
        '
        'Label1
        '
        resources.ApplyResources(Me.Label1, "Label1")
        Me.Label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label1.Name = "Label1"
        '
        'Btn_Install
        '
        Me.Btn_Install.BackColor = System.Drawing.Color.FromArgb(CType(CType(87, Byte), Integer), CType(CType(96, Byte), Integer), CType(CType(111, Byte), Integer))
        resources.ApplyResources(Me.Btn_Install, "Btn_Install")
        Me.Btn_Install.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Btn_Install.Name = "Btn_Install"
        Me.Btn_Install.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.sys_32)
        Me.GroupBox1.Controls.Add(Me.sys_64)
        Me.GroupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        resources.ApplyResources(Me.GroupBox1, "GroupBox1")
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.TabStop = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.lng_zh)
        Me.GroupBox2.Controls.Add(Me.lng_en)
        Me.GroupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        resources.ApplyResources(Me.GroupBox2, "GroupBox2")
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.TabStop = False
        '
        'Label2
        '
        resources.ApplyResources(Me.Label2, "Label2")
        Me.Label2.Name = "Label2"
        '
        'Label3
        '
        resources.ApplyResources(Me.Label3, "Label3")
        Me.Label3.Name = "Label3"
        '
        'Btn_Back
        '
        Me.Btn_Back.BackColor = System.Drawing.Color.FromArgb(CType(CType(164, Byte), Integer), CType(CType(176, Byte), Integer), CType(CType(190, Byte), Integer))
        resources.ApplyResources(Me.Btn_Back, "Btn_Back")
        Me.Btn_Back.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Btn_Back.Name = "Btn_Back"
        Me.Btn_Back.UseVisualStyleBackColor = False
        '
        'PictureBox4
        '
        Me.PictureBox4.BackColor = System.Drawing.Color.FromArgb(CType(CType(116, Byte), Integer), CType(CType(125, Byte), Integer), CType(CType(140, Byte), Integer))
        resources.ApplyResources(Me.PictureBox4, "PictureBox4")
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.TabStop = False
        '
        'Label4
        '
        resources.ApplyResources(Me.Label4, "Label4")
        Me.Label4.Name = "Label4"
        '
        'sel_project
        '
        resources.ApplyResources(Me.sel_project, "sel_project")
        Me.sel_project.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.sel_project.Name = "sel_project"
        Me.sel_project.Tag = "8"
        Me.sel_project.UseVisualStyleBackColor = True
        '
        'sel_visio
        '
        resources.ApplyResources(Me.sel_visio, "sel_visio")
        Me.sel_visio.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.sel_visio.Name = "sel_visio"
        Me.sel_visio.Tag = "9"
        Me.sel_visio.UseVisualStyleBackColor = True
        '
        'PictureBox3
        '
        Me.PictureBox3.BackColor = System.Drawing.Color.FromArgb(CType(CType(116, Byte), Integer), CType(CType(125, Byte), Integer), CType(CType(140, Byte), Integer))
        resources.ApplyResources(Me.PictureBox3, "PictureBox3")
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.TabStop = False
        '
        'Btn_Exit
        '
        Me.Btn_Exit.BackColor = System.Drawing.Color.FromArgb(CType(CType(116, Byte), Integer), CType(CType(125, Byte), Integer), CType(CType(140, Byte), Integer))
        resources.ApplyResources(Me.Btn_Exit, "Btn_Exit")
        Me.Btn_Exit.Name = "Btn_Exit"
        Me.Btn_Exit.TabStop = False
        '
        'PictureBox5
        '
        Me.PictureBox5.BackColor = System.Drawing.Color.FromArgb(CType(CType(116, Byte), Integer), CType(CType(125, Byte), Integer), CType(CType(140, Byte), Integer))
        resources.ApplyResources(Me.PictureBox5, "PictureBox5")
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.FromArgb(CType(CType(116, Byte), Integer), CType(CType(125, Byte), Integer), CType(CType(140, Byte), Integer))
        resources.ApplyResources(Me.PictureBox2, "PictureBox2")
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.TabStop = False
        '
        'PictureBox7
        '
        resources.ApplyResources(Me.PictureBox7, "PictureBox7")
        Me.PictureBox7.Name = "PictureBox7"
        Me.PictureBox7.TabStop = False
        '
        'Main_Installer
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Controls.Add(Me.PictureBox7)
        Me.Controls.Add(Me.Btn_Exit)
        Me.Controls.Add(Me.PictureBox5)
        Me.Controls.Add(Me.PictureBox4)
        Me.Controls.Add(Me.sel_project)
        Me.Controls.Add(Me.sel_visio)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Btn_Back)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Btn_Install)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.sel_onenote)
        Me.Controls.Add(Me.sel_skype)
        Me.Controls.Add(Me.sel_publisher)
        Me.Controls.Add(Me.sel_outlook)
        Me.Controls.Add(Me.sel_access)
        Me.Controls.Add(Me.sel_powerpoint)
        Me.Controls.Add(Me.sel_excel)
        Me.Controls.Add(Me.sel_world)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.PictureBox2)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Main_Installer"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Btn_Exit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents sel_world As CheckBox
    Friend WithEvents sel_excel As CheckBox
    Friend WithEvents sel_powerpoint As CheckBox
    Friend WithEvents sel_access As CheckBox
    Friend WithEvents sel_outlook As CheckBox
    Friend WithEvents sel_publisher As CheckBox
    Friend WithEvents sel_skype As CheckBox
    Friend WithEvents lng_zh As RadioButton
    Friend WithEvents lng_en As RadioButton
    Friend WithEvents sys_32 As RadioButton
    Friend WithEvents sys_64 As RadioButton
    Friend WithEvents sel_onenote As CheckBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Btn_Install As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents PictureBox4 As System.Windows.Forms.PictureBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Btn_Back As System.Windows.Forms.Button
    Friend WithEvents Label4 As Label
    Friend WithEvents sel_project As CheckBox
    Friend WithEvents sel_visio As CheckBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents Btn_Exit As PictureBox
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox7 As PictureBox
End Class
