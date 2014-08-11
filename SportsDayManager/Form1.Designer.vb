<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form 覆寫 Dispose 以清除元件清單。
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

    '為 Windows Form 設計工具的必要項
    Private components As System.ComponentModel.IContainer

    '注意: 以下為 Windows Form 設計工具所需的程序
    '可以使用 Windows Form 設計工具進行修改。
    '請不要使用程式碼編輯器進行修改。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim TreeNode1 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Instruction")
        Dim TreeNode2 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Notices")
        Dim TreeNode3 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Help")
        Dim TreeNode4 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("SportsDayManager", New System.Windows.Forms.TreeNode() {TreeNode1, TreeNode2, TreeNode3})
        Dim TreeNode5 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Competition Information")
        Dim TreeNode6 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Competition Settings")
        Dim TreeNode7 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Student")
        Dim TreeNode8 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Event")
        Dim TreeNode9 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Helper Team")
        Dim TreeNode10 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Data", New System.Windows.Forms.TreeNode() {TreeNode5, TreeNode6, TreeNode7, TreeNode8, TreeNode9})
        Dim TreeNode11 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Registered Event")
        Dim TreeNode12 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Student Registration")
        Dim TreeNode13 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Registered Helper")
        Dim TreeNode14 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Register", New System.Windows.Forms.TreeNode() {TreeNode11, TreeNode12, TreeNode13})
        Dim TreeNode15 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Participant and Group")
        Dim TreeNode16 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Lane Distribution")
        Dim TreeNode17 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("1st Day TimeTable")
        Dim TreeNode18 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("2nd Day Time Table")
        Dim TreeNode19 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Timetable", New System.Windows.Forms.TreeNode() {TreeNode15, TreeNode16, TreeNode17, TreeNode18})
        Dim TreeNode20 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Field Result")
        Dim TreeNode21 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Track Heat Result")
        Dim TreeNode22 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Track Finals Result")
        Dim TreeNode23 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Absentee")
        Dim TreeNode24 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Finals Lane Distribution")
        Dim TreeNode25 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Result", New System.Windows.Forms.TreeNode() {TreeNode20, TreeNode21, TreeNode22, TreeNode23, TreeNode24})
        Dim TreeNode26 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Award")
        Dim TreeNode27 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("House Score")
        Dim TreeNode28 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Personal Score")
        Dim TreeNode29 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Report", New System.Windows.Forms.TreeNode() {TreeNode26, TreeNode27, TreeNode28})
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.NewProjectToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.LoadProjectToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.EditProjectToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ProjectGuideToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator
        Me.DataEntryWizardToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.EventRegisterToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.HelperRegisterToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.GroupingandDistributeLaneToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.GenerateTimetableToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.UpdateResultsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ResultMonitorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.SettingToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ConnectionSettingsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.InstructionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.NoticesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.HelpToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer
        Me.TreeView1 = New System.Windows.Forms.TreeView
        Me.Label1 = New System.Windows.Forms.Label
        Me.TabControl0 = New System.Windows.Forms.TabControl
        Me.TabPage2 = New System.Windows.Forms.TabPage
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox
        Me.TabPage3 = New System.Windows.Forms.TabPage
        Me.RichTextBox2 = New System.Windows.Forms.RichTextBox
        Me.TabPage4 = New System.Windows.Forms.TabPage
        Me.RichTextBox3 = New System.Windows.Forms.RichTextBox
        Me.TabControl1 = New System.Windows.Forms.TabControl
        Me.TabPage12 = New System.Windows.Forms.TabPage
        Me.TextBox9 = New System.Windows.Forms.TextBox
        Me.TextBox10 = New System.Windows.Forms.TextBox
        Me.TextBox11 = New System.Windows.Forms.TextBox
        Me.TextBox12 = New System.Windows.Forms.TextBox
        Me.Label20 = New System.Windows.Forms.Label
        Me.Label19 = New System.Windows.Forms.Label
        Me.Label18 = New System.Windows.Forms.Label
        Me.Label17 = New System.Windows.Forms.Label
        Me.Panel3 = New System.Windows.Forms.Panel
        Me.RadioButton2 = New System.Windows.Forms.RadioButton
        Me.RadioButton1 = New System.Windows.Forms.RadioButton
        Me.TextBox8 = New System.Windows.Forms.TextBox
        Me.Label16 = New System.Windows.Forms.Label
        Me.DateTimePicker2 = New System.Windows.Forms.DateTimePicker
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker
        Me.TextBox4 = New System.Windows.Forms.TextBox
        Me.TextBox3 = New System.Windows.Forms.TextBox
        Me.TextBox2 = New System.Windows.Forms.TextBox
        Me.TextBox1 = New System.Windows.Forms.TextBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.TabPage13 = New System.Windows.Forms.TabPage
        Me.GroupBox7 = New System.Windows.Forms.GroupBox
        Me.Label29 = New System.Windows.Forms.Label
        Me.TextBox25 = New System.Windows.Forms.TextBox
        Me.TextBox27 = New System.Windows.Forms.TextBox
        Me.TextBox23 = New System.Windows.Forms.TextBox
        Me.TextBox29 = New System.Windows.Forms.TextBox
        Me.Label30 = New System.Windows.Forms.Label
        Me.TextBox24 = New System.Windows.Forms.TextBox
        Me.TextBox30 = New System.Windows.Forms.TextBox
        Me.Label31 = New System.Windows.Forms.Label
        Me.Label32 = New System.Windows.Forms.Label
        Me.TextBox28 = New System.Windows.Forms.TextBox
        Me.TextBox26 = New System.Windows.Forms.TextBox
        Me.Label33 = New System.Windows.Forms.Label
        Me.Label34 = New System.Windows.Forms.Label
        Me.Label35 = New System.Windows.Forms.Label
        Me.Label36 = New System.Windows.Forms.Label
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.DataGridView1 = New System.Windows.Forms.DataGridView
        Me.GroupBox8 = New System.Windows.Forms.GroupBox
        Me.DateTimePicker5 = New System.Windows.Forms.DateTimePicker
        Me.DateTimePicker4 = New System.Windows.Forms.DateTimePicker
        Me.DateTimePicker3 = New System.Windows.Forms.DateTimePicker
        Me.Label15 = New System.Windows.Forms.Label
        Me.Label14 = New System.Windows.Forms.Label
        Me.Label13 = New System.Windows.Forms.Label
        Me.TextBox7 = New System.Windows.Forms.TextBox
        Me.TextBox6 = New System.Windows.Forms.TextBox
        Me.TextBox5 = New System.Windows.Forms.TextBox
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.RadioButton5 = New System.Windows.Forms.RadioButton
        Me.RadioButton4 = New System.Windows.Forms.RadioButton
        Me.RadioButton3 = New System.Windows.Forms.RadioButton
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.CheckBox1 = New System.Windows.Forms.CheckBox
        Me.CheckBox3 = New System.Windows.Forms.CheckBox
        Me.CheckBox2 = New System.Windows.Forms.CheckBox
        Me.Label12 = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label21 = New System.Windows.Forms.Label
        Me.TabPage14 = New System.Windows.Forms.TabPage
        Me.Button23 = New System.Windows.Forms.Button
        Me.TextBox20 = New System.Windows.Forms.TextBox
        Me.Label39 = New System.Windows.Forms.Label
        Me.Label22 = New System.Windows.Forms.Label
        Me.TextBox13 = New System.Windows.Forms.TextBox
        Me.Button1 = New System.Windows.Forms.Button
        Me.DataGridView2 = New System.Windows.Forms.DataGridView
        Me.TabPage15 = New System.Windows.Forms.TabPage
        Me.Button24 = New System.Windows.Forms.Button
        Me.ComboBox3 = New System.Windows.Forms.ComboBox
        Me.ComboBox2 = New System.Windows.Forms.ComboBox
        Me.ComboBox1 = New System.Windows.Forms.ComboBox
        Me.Label47 = New System.Windows.Forms.Label
        Me.Label46 = New System.Windows.Forms.Label
        Me.Label45 = New System.Windows.Forms.Label
        Me.Label23 = New System.Windows.Forms.Label
        Me.TextBox14 = New System.Windows.Forms.TextBox
        Me.DataGridView3 = New System.Windows.Forms.DataGridView
        Me.Button2 = New System.Windows.Forms.Button
        Me.TabPage16 = New System.Windows.Forms.TabPage
        Me.Button25 = New System.Windows.Forms.Button
        Me.Label24 = New System.Windows.Forms.Label
        Me.TextBox15 = New System.Windows.Forms.TextBox
        Me.DataGridView4 = New System.Windows.Forms.DataGridView
        Me.Button3 = New System.Windows.Forms.Button
        Me.TabControl2 = New System.Windows.Forms.TabControl
        Me.TabPage22 = New System.Windows.Forms.TabPage
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.Button26 = New System.Windows.Forms.Button
        Me.DataGridView6 = New System.Windows.Forms.DataGridView
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Button7 = New System.Windows.Forms.Button
        Me.ListBox1 = New System.Windows.Forms.ListBox
        Me.TabPage23 = New System.Windows.Forms.TabPage
        Me.Button27 = New System.Windows.Forms.Button
        Me.TextBox33 = New System.Windows.Forms.TextBox
        Me.Label42 = New System.Windows.Forms.Label
        Me.Label26 = New System.Windows.Forms.Label
        Me.TextBox21 = New System.Windows.Forms.TextBox
        Me.Button9 = New System.Windows.Forms.Button
        Me.DataGridView13 = New System.Windows.Forms.DataGridView
        Me.TabPage24 = New System.Windows.Forms.TabPage
        Me.GroupBox4 = New System.Windows.Forms.GroupBox
        Me.Button28 = New System.Windows.Forms.Button
        Me.DataGridView5 = New System.Windows.Forms.DataGridView
        Me.GroupBox5 = New System.Windows.Forms.GroupBox
        Me.Button8 = New System.Windows.Forms.Button
        Me.ListBox2 = New System.Windows.Forms.ListBox
        Me.TabPage25 = New System.Windows.Forms.TabPage
        Me.Button29 = New System.Windows.Forms.Button
        Me.TextBox35 = New System.Windows.Forms.TextBox
        Me.Label44 = New System.Windows.Forms.Label
        Me.Label28 = New System.Windows.Forms.Label
        Me.TextBox22 = New System.Windows.Forms.TextBox
        Me.Button10 = New System.Windows.Forms.Button
        Me.DataGridView14 = New System.Windows.Forms.DataGridView
        Me.TabControl3 = New System.Windows.Forms.TabControl
        Me.TabPage32 = New System.Windows.Forms.TabPage
        Me.Button30 = New System.Windows.Forms.Button
        Me.ComboBox4 = New System.Windows.Forms.ComboBox
        Me.ComboBox5 = New System.Windows.Forms.ComboBox
        Me.ComboBox6 = New System.Windows.Forms.ComboBox
        Me.Label48 = New System.Windows.Forms.Label
        Me.Label49 = New System.Windows.Forms.Label
        Me.Label50 = New System.Windows.Forms.Label
        Me.Label25 = New System.Windows.Forms.Label
        Me.TextBox16 = New System.Windows.Forms.TextBox
        Me.Button4 = New System.Windows.Forms.Button
        Me.DataGridView7 = New System.Windows.Forms.DataGridView
        Me.TabPage33 = New System.Windows.Forms.TabPage
        Me.Button31 = New System.Windows.Forms.Button
        Me.ComboBox7 = New System.Windows.Forms.ComboBox
        Me.ComboBox8 = New System.Windows.Forms.ComboBox
        Me.ComboBox9 = New System.Windows.Forms.ComboBox
        Me.Label51 = New System.Windows.Forms.Label
        Me.Label52 = New System.Windows.Forms.Label
        Me.Label53 = New System.Windows.Forms.Label
        Me.Label27 = New System.Windows.Forms.Label
        Me.TextBox17 = New System.Windows.Forms.TextBox
        Me.Button5 = New System.Windows.Forms.Button
        Me.DataGridView8 = New System.Windows.Forms.DataGridView
        Me.TabPage34 = New System.Windows.Forms.TabPage
        Me.Button32 = New System.Windows.Forms.Button
        Me.Label37 = New System.Windows.Forms.Label
        Me.TextBox18 = New System.Windows.Forms.TextBox
        Me.Button6 = New System.Windows.Forms.Button
        Me.DataGridView9 = New System.Windows.Forms.DataGridView
        Me.TabPage35 = New System.Windows.Forms.TabPage
        Me.Button33 = New System.Windows.Forms.Button
        Me.Button12 = New System.Windows.Forms.Button
        Me.Button11 = New System.Windows.Forms.Button
        Me.DataGridView10 = New System.Windows.Forms.DataGridView
        Me.TabPage36 = New System.Windows.Forms.TabPage
        Me.Button34 = New System.Windows.Forms.Button
        Me.Button13 = New System.Windows.Forms.Button
        Me.Button14 = New System.Windows.Forms.Button
        Me.DataGridView11 = New System.Windows.Forms.DataGridView
        Me.TabControl4 = New System.Windows.Forms.TabControl
        Me.TabPage42 = New System.Windows.Forms.TabPage
        Me.GroupBox14 = New System.Windows.Forms.GroupBox
        Me.Button35 = New System.Windows.Forms.Button
        Me.DataGridView20 = New System.Windows.Forms.DataGridView
        Me.GroupBox15 = New System.Windows.Forms.GroupBox
        Me.Button19 = New System.Windows.Forms.Button
        Me.ListBox6 = New System.Windows.Forms.ListBox
        Me.TabPage43 = New System.Windows.Forms.TabPage
        Me.GroupBox6 = New System.Windows.Forms.GroupBox
        Me.Button36 = New System.Windows.Forms.Button
        Me.DataGridView12 = New System.Windows.Forms.DataGridView
        Me.GroupBox9 = New System.Windows.Forms.GroupBox
        Me.Button15 = New System.Windows.Forms.Button
        Me.ListBox3 = New System.Windows.Forms.ListBox
        Me.TabPage44 = New System.Windows.Forms.TabPage
        Me.GroupBox10 = New System.Windows.Forms.GroupBox
        Me.Button37 = New System.Windows.Forms.Button
        Me.DataGridView15 = New System.Windows.Forms.DataGridView
        Me.GroupBox11 = New System.Windows.Forms.GroupBox
        Me.Button16 = New System.Windows.Forms.Button
        Me.ListBox4 = New System.Windows.Forms.ListBox
        Me.TabPage45 = New System.Windows.Forms.TabPage
        Me.GroupBox12 = New System.Windows.Forms.GroupBox
        Me.Button38 = New System.Windows.Forms.Button
        Me.DataGridView16 = New System.Windows.Forms.DataGridView
        Me.GroupBox13 = New System.Windows.Forms.GroupBox
        Me.Button17 = New System.Windows.Forms.Button
        Me.ListBox5 = New System.Windows.Forms.ListBox
        Me.TabPage46 = New System.Windows.Forms.TabPage
        Me.Button39 = New System.Windows.Forms.Button
        Me.Label38 = New System.Windows.Forms.Label
        Me.TextBox19 = New System.Windows.Forms.TextBox
        Me.Button21 = New System.Windows.Forms.Button
        Me.DataGridView21 = New System.Windows.Forms.DataGridView
        Me.TabControl5 = New System.Windows.Forms.TabControl
        Me.TabPage52 = New System.Windows.Forms.TabPage
        Me.Button40 = New System.Windows.Forms.Button
        Me.Button18 = New System.Windows.Forms.Button
        Me.DataGridView17 = New System.Windows.Forms.DataGridView
        Me.TabPage53 = New System.Windows.Forms.TabPage
        Me.Button41 = New System.Windows.Forms.Button
        Me.DataGridView18 = New System.Windows.Forms.DataGridView
        Me.Button22 = New System.Windows.Forms.Button
        Me.TabPage54 = New System.Windows.Forms.TabPage
        Me.Button42 = New System.Windows.Forms.Button
        Me.DataGridView19 = New System.Windows.Forms.DataGridView
        Me.Button20 = New System.Windows.Forms.Button
        Me.MySqlConnection1 = New MySql.Data.MySqlClient.MySqlConnection
        Me.MySqlDataAdapter1 = New MySql.Data.MySqlClient.MySqlDataAdapter
        Me.MenuStrip1.SuspendLayout()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.TabControl0.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        Me.TabPage4.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage12.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.TabPage13.SuspendLayout()
        Me.GroupBox7.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox8.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.TabPage14.SuspendLayout()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage15.SuspendLayout()
        CType(Me.DataGridView3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage16.SuspendLayout()
        CType(Me.DataGridView4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl2.SuspendLayout()
        Me.TabPage22.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.DataGridView6, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.TabPage23.SuspendLayout()
        CType(Me.DataGridView13, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage24.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        CType(Me.DataGridView5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox5.SuspendLayout()
        Me.TabPage25.SuspendLayout()
        CType(Me.DataGridView14, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl3.SuspendLayout()
        Me.TabPage32.SuspendLayout()
        CType(Me.DataGridView7, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage33.SuspendLayout()
        CType(Me.DataGridView8, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage34.SuspendLayout()
        CType(Me.DataGridView9, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage35.SuspendLayout()
        CType(Me.DataGridView10, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage36.SuspendLayout()
        CType(Me.DataGridView11, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl4.SuspendLayout()
        Me.TabPage42.SuspendLayout()
        Me.GroupBox14.SuspendLayout()
        CType(Me.DataGridView20, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox15.SuspendLayout()
        Me.TabPage43.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        CType(Me.DataGridView12, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox9.SuspendLayout()
        Me.TabPage44.SuspendLayout()
        Me.GroupBox10.SuspendLayout()
        CType(Me.DataGridView15, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox11.SuspendLayout()
        Me.TabPage45.SuspendLayout()
        Me.GroupBox12.SuspendLayout()
        CType(Me.DataGridView16, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox13.SuspendLayout()
        Me.TabPage46.SuspendLayout()
        CType(Me.DataGridView21, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl5.SuspendLayout()
        Me.TabPage52.SuspendLayout()
        CType(Me.DataGridView17, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage53.SuspendLayout()
        CType(Me.DataGridView18, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage54.SuspendLayout()
        CType(Me.DataGridView19, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.ToolsToolStripMenuItem, Me.SettingToolStripMenuItem, Me.HelpToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(952, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NewProjectToolStripMenuItem, Me.LoadProjectToolStripMenuItem, Me.EditProjectToolStripMenuItem, Me.ToolStripSeparator1, Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(35, 20)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'NewProjectToolStripMenuItem
        '
        Me.NewProjectToolStripMenuItem.Name = "NewProjectToolStripMenuItem"
        Me.NewProjectToolStripMenuItem.Size = New System.Drawing.Size(134, 22)
        Me.NewProjectToolStripMenuItem.Text = "New Project"
        '
        'LoadProjectToolStripMenuItem
        '
        Me.LoadProjectToolStripMenuItem.Name = "LoadProjectToolStripMenuItem"
        Me.LoadProjectToolStripMenuItem.Size = New System.Drawing.Size(134, 22)
        Me.LoadProjectToolStripMenuItem.Text = "Load Project"
        '
        'EditProjectToolStripMenuItem
        '
        Me.EditProjectToolStripMenuItem.Enabled = False
        Me.EditProjectToolStripMenuItem.Name = "EditProjectToolStripMenuItem"
        Me.EditProjectToolStripMenuItem.Size = New System.Drawing.Size(134, 22)
        Me.EditProjectToolStripMenuItem.Text = "Edit Project"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(131, 6)
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(134, 22)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'ToolsToolStripMenuItem
        '
        Me.ToolsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ProjectGuideToolStripMenuItem, Me.ToolStripSeparator2, Me.DataEntryWizardToolStripMenuItem, Me.EventRegisterToolStripMenuItem, Me.HelperRegisterToolStripMenuItem, Me.GroupingandDistributeLaneToolStripMenuItem, Me.GenerateTimetableToolStripMenuItem, Me.UpdateResultsToolStripMenuItem, Me.ResultMonitorToolStripMenuItem})
        Me.ToolsToolStripMenuItem.Enabled = False
        Me.ToolsToolStripMenuItem.Name = "ToolsToolStripMenuItem"
        Me.ToolsToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
        Me.ToolsToolStripMenuItem.Text = "Tools"
        '
        'ProjectGuideToolStripMenuItem
        '
        Me.ProjectGuideToolStripMenuItem.Name = "ProjectGuideToolStripMenuItem"
        Me.ProjectGuideToolStripMenuItem.Size = New System.Drawing.Size(213, 22)
        Me.ProjectGuideToolStripMenuItem.Text = "Project Guide"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(210, 6)
        '
        'DataEntryWizardToolStripMenuItem
        '
        Me.DataEntryWizardToolStripMenuItem.Name = "DataEntryWizardToolStripMenuItem"
        Me.DataEntryWizardToolStripMenuItem.Size = New System.Drawing.Size(213, 22)
        Me.DataEntryWizardToolStripMenuItem.Text = "Data Entry Wizard"
        '
        'EventRegisterToolStripMenuItem
        '
        Me.EventRegisterToolStripMenuItem.Enabled = False
        Me.EventRegisterToolStripMenuItem.Name = "EventRegisterToolStripMenuItem"
        Me.EventRegisterToolStripMenuItem.Size = New System.Drawing.Size(213, 22)
        Me.EventRegisterToolStripMenuItem.Text = "Event Register"
        '
        'HelperRegisterToolStripMenuItem
        '
        Me.HelperRegisterToolStripMenuItem.Enabled = False
        Me.HelperRegisterToolStripMenuItem.Name = "HelperRegisterToolStripMenuItem"
        Me.HelperRegisterToolStripMenuItem.Size = New System.Drawing.Size(213, 22)
        Me.HelperRegisterToolStripMenuItem.Text = "Helper Register"
        '
        'GroupingandDistributeLaneToolStripMenuItem
        '
        Me.GroupingandDistributeLaneToolStripMenuItem.Enabled = False
        Me.GroupingandDistributeLaneToolStripMenuItem.Name = "GroupingandDistributeLaneToolStripMenuItem"
        Me.GroupingandDistributeLaneToolStripMenuItem.Size = New System.Drawing.Size(213, 22)
        Me.GroupingandDistributeLaneToolStripMenuItem.Text = "Grouping and Distribute Lane"
        '
        'GenerateTimetableToolStripMenuItem
        '
        Me.GenerateTimetableToolStripMenuItem.Enabled = False
        Me.GenerateTimetableToolStripMenuItem.Name = "GenerateTimetableToolStripMenuItem"
        Me.GenerateTimetableToolStripMenuItem.Size = New System.Drawing.Size(213, 22)
        Me.GenerateTimetableToolStripMenuItem.Text = "Generate Timetable"
        '
        'UpdateResultsToolStripMenuItem
        '
        Me.UpdateResultsToolStripMenuItem.Enabled = False
        Me.UpdateResultsToolStripMenuItem.Name = "UpdateResultsToolStripMenuItem"
        Me.UpdateResultsToolStripMenuItem.Size = New System.Drawing.Size(213, 22)
        Me.UpdateResultsToolStripMenuItem.Text = "Update Results"
        '
        'ResultMonitorToolStripMenuItem
        '
        Me.ResultMonitorToolStripMenuItem.Enabled = False
        Me.ResultMonitorToolStripMenuItem.Name = "ResultMonitorToolStripMenuItem"
        Me.ResultMonitorToolStripMenuItem.Size = New System.Drawing.Size(213, 22)
        Me.ResultMonitorToolStripMenuItem.Text = "Result Monitor"
        '
        'SettingToolStripMenuItem
        '
        Me.SettingToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ConnectionSettingsToolStripMenuItem})
        Me.SettingToolStripMenuItem.Name = "SettingToolStripMenuItem"
        Me.SettingToolStripMenuItem.Size = New System.Drawing.Size(53, 20)
        Me.SettingToolStripMenuItem.Text = "Setting"
        '
        'ConnectionSettingsToolStripMenuItem
        '
        Me.ConnectionSettingsToolStripMenuItem.Name = "ConnectionSettingsToolStripMenuItem"
        Me.ConnectionSettingsToolStripMenuItem.Size = New System.Drawing.Size(170, 22)
        Me.ConnectionSettingsToolStripMenuItem.Text = "Connection Settings"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.InstructionToolStripMenuItem, Me.NoticesToolStripMenuItem, Me.HelpToolStripMenuItem1})
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(40, 20)
        Me.HelpToolStripMenuItem.Text = "Help"
        '
        'InstructionToolStripMenuItem
        '
        Me.InstructionToolStripMenuItem.Name = "InstructionToolStripMenuItem"
        Me.InstructionToolStripMenuItem.Size = New System.Drawing.Size(126, 22)
        Me.InstructionToolStripMenuItem.Text = "Instruction"
        '
        'NoticesToolStripMenuItem
        '
        Me.NoticesToolStripMenuItem.Name = "NoticesToolStripMenuItem"
        Me.NoticesToolStripMenuItem.Size = New System.Drawing.Size(126, 22)
        Me.NoticesToolStripMenuItem.Text = "Notices"
        '
        'HelpToolStripMenuItem1
        '
        Me.HelpToolStripMenuItem1.Name = "HelpToolStripMenuItem1"
        Me.HelpToolStripMenuItem1.Size = New System.Drawing.Size(126, 22)
        Me.HelpToolStripMenuItem1.Text = "Help"
        '
        'SplitContainer1
        '
        Me.SplitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 24)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.TreeView1)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label1)
        Me.SplitContainer1.Panel1MinSize = 160
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.TabControl4)
        Me.SplitContainer1.Panel2.Controls.Add(Me.TabControl5)
        Me.SplitContainer1.Panel2.Controls.Add(Me.TabControl0)
        Me.SplitContainer1.Panel2.Controls.Add(Me.TabControl1)
        Me.SplitContainer1.Panel2.Controls.Add(Me.TabControl2)
        Me.SplitContainer1.Panel2.Controls.Add(Me.TabControl3)
        Me.SplitContainer1.Size = New System.Drawing.Size(952, 482)
        Me.SplitContainer1.SplitterDistance = 160
        Me.SplitContainer1.TabIndex = 1
        '
        'TreeView1
        '
        Me.TreeView1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.TreeView1.Location = New System.Drawing.Point(3, 23)
        Me.TreeView1.Name = "TreeView1"
        TreeNode1.Name = "Node2"
        TreeNode1.Text = "Instruction"
        TreeNode2.Name = "Node3"
        TreeNode2.Text = "Notices"
        TreeNode3.Name = "Node4"
        TreeNode3.Text = "Help"
        TreeNode4.Name = "Node1"
        TreeNode4.Text = "SportsDayManager"
        TreeNode5.Name = "Node12"
        TreeNode5.Text = "Competition Information"
        TreeNode6.Name = "Node13"
        TreeNode6.Text = "Competition Settings"
        TreeNode7.Name = "Node14"
        TreeNode7.Text = "Student"
        TreeNode8.Name = "Node15"
        TreeNode8.Text = "Event"
        TreeNode9.Name = "Node16"
        TreeNode9.Text = "Helper Team"
        TreeNode10.Name = "Node11"
        TreeNode10.Text = "Data"
        TreeNode11.Name = "Node22"
        TreeNode11.Text = "Registered Event"
        TreeNode12.Name = "Node23"
        TreeNode12.Text = "Student Registration"
        TreeNode13.Name = "Node24"
        TreeNode13.Text = "Registered Helper"
        TreeNode14.Name = "Node21"
        TreeNode14.Text = "Register"
        TreeNode15.Name = "Node32"
        TreeNode15.Text = "Participant and Group"
        TreeNode16.Name = "Node33"
        TreeNode16.Text = "Lane Distribution"
        TreeNode17.Name = "Node35"
        TreeNode17.Text = "1st Day TimeTable"
        TreeNode18.Name = "Node36"
        TreeNode18.Text = "2nd Day Time Table"
        TreeNode19.Name = "Node31"
        TreeNode19.Text = "Timetable"
        TreeNode20.Name = "Node42"
        TreeNode20.Text = "Field Result"
        TreeNode21.Name = "Node43"
        TreeNode21.Text = "Track Heat Result"
        TreeNode22.Name = "Node44"
        TreeNode22.Text = "Track Finals Result"
        TreeNode23.Name = "Node45"
        TreeNode23.Text = "Absentee"
        TreeNode24.Name = "Node46"
        TreeNode24.Text = "Finals Lane Distribution"
        TreeNode25.Name = "Node41"
        TreeNode25.Text = "Result"
        TreeNode26.Name = "Node52"
        TreeNode26.Text = "Award"
        TreeNode27.Name = "Node53"
        TreeNode27.Text = "House Score"
        TreeNode28.Name = "Node54"
        TreeNode28.Text = "Personal Score"
        TreeNode29.Name = "Node51"
        TreeNode29.Text = "Report"
        Me.TreeView1.Nodes.AddRange(New System.Windows.Forms.TreeNode() {TreeNode4, TreeNode10, TreeNode14, TreeNode19, TreeNode25, TreeNode29})
        Me.TreeView1.ShowNodeToolTips = True
        Me.TreeView1.ShowRootLines = False
        Me.TreeView1.Size = New System.Drawing.Size(150, 440)
        Me.TreeView1.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(156, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Selection"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TabControl0
        '
        Me.TabControl0.Controls.Add(Me.TabPage2)
        Me.TabControl0.Controls.Add(Me.TabPage3)
        Me.TabControl0.Controls.Add(Me.TabPage4)
        Me.TabControl0.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl0.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.TabControl0.Location = New System.Drawing.Point(0, 0)
        Me.TabControl0.Name = "TabControl0"
        Me.TabControl0.SelectedIndex = 0
        Me.TabControl0.Size = New System.Drawing.Size(784, 478)
        Me.TabControl0.TabIndex = 0
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.RichTextBox1)
        Me.TabPage2.Location = New System.Drawing.Point(4, 23)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(776, 451)
        Me.TabPage2.TabIndex = 0
        Me.TabPage2.Text = "Instruction"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'RichTextBox1
        '
        Me.RichTextBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RichTextBox1.Location = New System.Drawing.Point(3, 3)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.Size = New System.Drawing.Size(770, 445)
        Me.RichTextBox1.TabIndex = 0
        Me.RichTextBox1.Text = resources.GetString("RichTextBox1.Text")
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.RichTextBox2)
        Me.TabPage3.Location = New System.Drawing.Point(4, 23)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(776, 453)
        Me.TabPage3.TabIndex = 1
        Me.TabPage3.Text = "Notices"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'RichTextBox2
        '
        Me.RichTextBox2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RichTextBox2.Location = New System.Drawing.Point(3, 3)
        Me.RichTextBox2.Name = "RichTextBox2"
        Me.RichTextBox2.Size = New System.Drawing.Size(770, 447)
        Me.RichTextBox2.TabIndex = 0
        Me.RichTextBox2.Text = "The SportsDay Manager developer will not accept any liability for any loss arisin" & _
            "g from the use of the SportsDay Manager by the user." & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(10) & "AND" & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(10) & "All rights reserved b" & _
            "y the SportsDay Manager developer."
        '
        'TabPage4
        '
        Me.TabPage4.Controls.Add(Me.RichTextBox3)
        Me.TabPage4.Location = New System.Drawing.Point(4, 23)
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage4.Size = New System.Drawing.Size(776, 453)
        Me.TabPage4.TabIndex = 2
        Me.TabPage4.Text = "Help"
        Me.TabPage4.UseVisualStyleBackColor = True
        '
        'RichTextBox3
        '
        Me.RichTextBox3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RichTextBox3.Location = New System.Drawing.Point(3, 3)
        Me.RichTextBox3.Name = "RichTextBox3"
        Me.RichTextBox3.Size = New System.Drawing.Size(770, 447)
        Me.RichTextBox3.TabIndex = 0
        Me.RichTextBox3.Text = resources.GetString("RichTextBox3.Text")
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage12)
        Me.TabControl1.Controls.Add(Me.TabPage13)
        Me.TabControl1.Controls.Add(Me.TabPage14)
        Me.TabControl1.Controls.Add(Me.TabPage15)
        Me.TabControl1.Controls.Add(Me.TabPage16)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.TabControl1.Location = New System.Drawing.Point(0, 0)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(784, 478)
        Me.TabControl1.TabIndex = 0
        Me.TabControl1.Visible = False
        '
        'TabPage12
        '
        Me.TabPage12.Controls.Add(Me.TextBox9)
        Me.TabPage12.Controls.Add(Me.TextBox10)
        Me.TabPage12.Controls.Add(Me.TextBox11)
        Me.TabPage12.Controls.Add(Me.TextBox12)
        Me.TabPage12.Controls.Add(Me.Label20)
        Me.TabPage12.Controls.Add(Me.Label19)
        Me.TabPage12.Controls.Add(Me.Label18)
        Me.TabPage12.Controls.Add(Me.Label17)
        Me.TabPage12.Controls.Add(Me.Panel3)
        Me.TabPage12.Controls.Add(Me.TextBox8)
        Me.TabPage12.Controls.Add(Me.Label16)
        Me.TabPage12.Controls.Add(Me.DateTimePicker2)
        Me.TabPage12.Controls.Add(Me.DateTimePicker1)
        Me.TabPage12.Controls.Add(Me.TextBox4)
        Me.TabPage12.Controls.Add(Me.TextBox3)
        Me.TabPage12.Controls.Add(Me.TextBox2)
        Me.TabPage12.Controls.Add(Me.TextBox1)
        Me.TabPage12.Controls.Add(Me.Label7)
        Me.TabPage12.Controls.Add(Me.Label6)
        Me.TabPage12.Controls.Add(Me.Label5)
        Me.TabPage12.Controls.Add(Me.Label4)
        Me.TabPage12.Controls.Add(Me.Label3)
        Me.TabPage12.Controls.Add(Me.Label2)
        Me.TabPage12.Controls.Add(Me.Label8)
        Me.TabPage12.Font = New System.Drawing.Font("新細明體", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabPage12.Location = New System.Drawing.Point(4, 23)
        Me.TabPage12.Name = "TabPage12"
        Me.TabPage12.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage12.Size = New System.Drawing.Size(776, 451)
        Me.TabPage12.TabIndex = 0
        Me.TabPage12.Text = "Competition Information"
        Me.TabPage12.UseVisualStyleBackColor = True
        '
        'TextBox9
        '
        Me.TextBox9.Location = New System.Drawing.Point(118, 289)
        Me.TextBox9.Name = "TextBox9"
        Me.TextBox9.ReadOnly = True
        Me.TextBox9.Size = New System.Drawing.Size(100, 22)
        Me.TextBox9.TabIndex = 69
        '
        'TextBox10
        '
        Me.TextBox10.Location = New System.Drawing.Point(118, 329)
        Me.TextBox10.Name = "TextBox10"
        Me.TextBox10.ReadOnly = True
        Me.TextBox10.Size = New System.Drawing.Size(100, 22)
        Me.TextBox10.TabIndex = 68
        '
        'TextBox11
        '
        Me.TextBox11.Location = New System.Drawing.Point(426, 289)
        Me.TextBox11.Name = "TextBox11"
        Me.TextBox11.ReadOnly = True
        Me.TextBox11.Size = New System.Drawing.Size(100, 22)
        Me.TextBox11.TabIndex = 67
        '
        'TextBox12
        '
        Me.TextBox12.Location = New System.Drawing.Point(426, 329)
        Me.TextBox12.Name = "TextBox12"
        Me.TextBox12.ReadOnly = True
        Me.TextBox12.Size = New System.Drawing.Size(100, 22)
        Me.TextBox12.TabIndex = 66
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("新細明體", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.Location = New System.Drawing.Point(324, 332)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(94, 12)
        Me.Label20.TabIndex = 65
        Me.Label20.Text = "2nd Day End Time"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("新細明體", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(324, 292)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(96, 12)
        Me.Label19.TabIndex = 64
        Me.Label19.Text = "2nd Day Start Time"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("新細明體", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(12, 332)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(89, 12)
        Me.Label18.TabIndex = 63
        Me.Label18.Text = "1st Day End Time"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("新細明體", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(12, 292)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(91, 12)
        Me.Label17.TabIndex = 62
        Me.Label17.Text = "1st Day Start Time"
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.RadioButton2)
        Me.Panel3.Controls.Add(Me.RadioButton1)
        Me.Panel3.Enabled = False
        Me.Panel3.Location = New System.Drawing.Point(118, 209)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(146, 22)
        Me.Panel3.TabIndex = 61
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.Font = New System.Drawing.Font("新細明體", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButton2.Location = New System.Drawing.Point(73, 3)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(70, 16)
        Me.RadioButton2.TabIndex = 14
        Me.RadioButton2.Text = "Two Days"
        Me.RadioButton2.UseVisualStyleBackColor = True
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.Checked = True
        Me.RadioButton1.Font = New System.Drawing.Font("新細明體", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButton1.Location = New System.Drawing.Point(3, 3)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(64, 16)
        Me.RadioButton1.TabIndex = 13
        Me.RadioButton1.TabStop = True
        Me.RadioButton1.Text = "One Day"
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'TextBox8
        '
        Me.TextBox8.Location = New System.Drawing.Point(118, 169)
        Me.TextBox8.Name = "TextBox8"
        Me.TextBox8.ReadOnly = True
        Me.TextBox8.Size = New System.Drawing.Size(636, 22)
        Me.TextBox8.TabIndex = 60
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("新細明體", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(12, 172)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(75, 12)
        Me.Label16.TabIndex = 59
        Me.Label16.Text = "Venue Address"
        '
        'DateTimePicker2
        '
        Me.DateTimePicker2.CustomFormat = ""
        Me.DateTimePicker2.Enabled = False
        Me.DateTimePicker2.Location = New System.Drawing.Point(426, 249)
        Me.DateTimePicker2.Name = "DateTimePicker2"
        Me.DateTimePicker2.Size = New System.Drawing.Size(200, 22)
        Me.DateTimePicker2.TabIndex = 58
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.CustomFormat = ""
        Me.DateTimePicker1.Enabled = False
        Me.DateTimePicker1.Location = New System.Drawing.Point(118, 249)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(200, 22)
        Me.DateTimePicker1.TabIndex = 57
        '
        'TextBox4
        '
        Me.TextBox4.Location = New System.Drawing.Point(118, 129)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.ReadOnly = True
        Me.TextBox4.Size = New System.Drawing.Size(433, 22)
        Me.TextBox4.TabIndex = 56
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(118, 89)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.ReadOnly = True
        Me.TextBox3.Size = New System.Drawing.Size(240, 22)
        Me.TextBox3.TabIndex = 55
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(118, 49)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.ReadOnly = True
        Me.TextBox2.Size = New System.Drawing.Size(160, 22)
        Me.TextBox2.TabIndex = 54
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(118, 9)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ReadOnly = True
        Me.TextBox1.Size = New System.Drawing.Size(486, 22)
        Me.TextBox1.TabIndex = 53
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("新細明體", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(324, 253)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(82, 12)
        Me.Label7.TabIndex = 52
        Me.Label7.Text = "Date of 2nd Day"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("新細明體", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(12, 253)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(77, 12)
        Me.Label6.TabIndex = 51
        Me.Label6.Text = "Date of 1st Day"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("新細明體", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(12, 214)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(61, 12)
        Me.Label5.TabIndex = 50
        Me.Label5.Text = "No. of Days"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("新細明體", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(12, 132)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(35, 12)
        Me.Label4.TabIndex = 49
        Me.Label4.Text = "Venue"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("新細明體", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(12, 52)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(62, 12)
        Me.Label3.TabIndex = 48
        Me.Label3.Text = "School Year"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("新細明體", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 92)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(100, 12)
        Me.Label2.TabIndex = 47
        Me.Label2.Text = "Title of Competition"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("新細明體", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(12, 12)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(67, 12)
        Me.Label8.TabIndex = 46
        Me.Label8.Text = "School Name"
        '
        'TabPage13
        '
        Me.TabPage13.Controls.Add(Me.GroupBox7)
        Me.TabPage13.Controls.Add(Me.GroupBox3)
        Me.TabPage13.Controls.Add(Me.GroupBox8)
        Me.TabPage13.Controls.Add(Me.TextBox7)
        Me.TabPage13.Controls.Add(Me.TextBox6)
        Me.TabPage13.Controls.Add(Me.TextBox5)
        Me.TabPage13.Controls.Add(Me.Panel2)
        Me.TabPage13.Controls.Add(Me.Panel1)
        Me.TabPage13.Controls.Add(Me.Label12)
        Me.TabPage13.Controls.Add(Me.Label11)
        Me.TabPage13.Controls.Add(Me.Label10)
        Me.TabPage13.Controls.Add(Me.Label9)
        Me.TabPage13.Controls.Add(Me.Label21)
        Me.TabPage13.Location = New System.Drawing.Point(4, 23)
        Me.TabPage13.Name = "TabPage13"
        Me.TabPage13.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage13.Size = New System.Drawing.Size(776, 453)
        Me.TabPage13.TabIndex = 1
        Me.TabPage13.Text = "Competition Settings"
        Me.TabPage13.UseVisualStyleBackColor = True
        '
        'GroupBox7
        '
        Me.GroupBox7.Controls.Add(Me.Label29)
        Me.GroupBox7.Controls.Add(Me.TextBox25)
        Me.GroupBox7.Controls.Add(Me.TextBox27)
        Me.GroupBox7.Controls.Add(Me.TextBox23)
        Me.GroupBox7.Controls.Add(Me.TextBox29)
        Me.GroupBox7.Controls.Add(Me.Label30)
        Me.GroupBox7.Controls.Add(Me.TextBox24)
        Me.GroupBox7.Controls.Add(Me.TextBox30)
        Me.GroupBox7.Controls.Add(Me.Label31)
        Me.GroupBox7.Controls.Add(Me.Label32)
        Me.GroupBox7.Controls.Add(Me.TextBox28)
        Me.GroupBox7.Controls.Add(Me.TextBox26)
        Me.GroupBox7.Controls.Add(Me.Label33)
        Me.GroupBox7.Controls.Add(Me.Label34)
        Me.GroupBox7.Controls.Add(Me.Label35)
        Me.GroupBox7.Controls.Add(Me.Label36)
        Me.GroupBox7.Font = New System.Drawing.Font("新細明體", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox7.Location = New System.Drawing.Point(407, 6)
        Me.GroupBox7.Name = "GroupBox7"
        Me.GroupBox7.Size = New System.Drawing.Size(203, 339)
        Me.GroupBox7.TabIndex = 35
        Me.GroupBox7.TabStop = False
        Me.GroupBox7.Text = "Position Scores"
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.Location = New System.Drawing.Point(24, 304)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(80, 12)
        Me.Label29.TabIndex = 24
        Me.Label29.Text = "Position 8 Score"
        '
        'TextBox25
        '
        Me.TextBox25.Location = New System.Drawing.Point(137, 99)
        Me.TextBox25.Name = "TextBox25"
        Me.TextBox25.ReadOnly = True
        Me.TextBox25.Size = New System.Drawing.Size(50, 22)
        Me.TextBox25.TabIndex = 28
        '
        'TextBox27
        '
        Me.TextBox27.Location = New System.Drawing.Point(137, 181)
        Me.TextBox27.Name = "TextBox27"
        Me.TextBox27.ReadOnly = True
        Me.TextBox27.Size = New System.Drawing.Size(50, 22)
        Me.TextBox27.TabIndex = 27
        '
        'TextBox23
        '
        Me.TextBox23.Location = New System.Drawing.Point(137, 19)
        Me.TextBox23.Name = "TextBox23"
        Me.TextBox23.ReadOnly = True
        Me.TextBox23.Size = New System.Drawing.Size(50, 22)
        Me.TextBox23.TabIndex = 29
        '
        'TextBox29
        '
        Me.TextBox29.Location = New System.Drawing.Point(137, 261)
        Me.TextBox29.Name = "TextBox29"
        Me.TextBox29.ReadOnly = True
        Me.TextBox29.Size = New System.Drawing.Size(50, 22)
        Me.TextBox29.TabIndex = 26
        '
        'Label30
        '
        Me.Label30.AutoSize = True
        Me.Label30.Location = New System.Drawing.Point(24, 264)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(80, 12)
        Me.Label30.TabIndex = 23
        Me.Label30.Text = "Position 7 Score"
        '
        'TextBox24
        '
        Me.TextBox24.Location = New System.Drawing.Point(137, 59)
        Me.TextBox24.Name = "TextBox24"
        Me.TextBox24.ReadOnly = True
        Me.TextBox24.Size = New System.Drawing.Size(50, 22)
        Me.TextBox24.TabIndex = 30
        '
        'TextBox30
        '
        Me.TextBox30.Location = New System.Drawing.Point(137, 301)
        Me.TextBox30.Name = "TextBox30"
        Me.TextBox30.ReadOnly = True
        Me.TextBox30.Size = New System.Drawing.Size(50, 22)
        Me.TextBox30.TabIndex = 25
        '
        'Label31
        '
        Me.Label31.AutoSize = True
        Me.Label31.Location = New System.Drawing.Point(24, 224)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(80, 12)
        Me.Label31.TabIndex = 22
        Me.Label31.Text = "Position 6 Score"
        '
        'Label32
        '
        Me.Label32.AutoSize = True
        Me.Label32.Location = New System.Drawing.Point(24, 184)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(80, 12)
        Me.Label32.TabIndex = 21
        Me.Label32.Text = "Position 5 Score"
        '
        'TextBox28
        '
        Me.TextBox28.Location = New System.Drawing.Point(137, 221)
        Me.TextBox28.Name = "TextBox28"
        Me.TextBox28.ReadOnly = True
        Me.TextBox28.Size = New System.Drawing.Size(50, 22)
        Me.TextBox28.TabIndex = 32
        '
        'TextBox26
        '
        Me.TextBox26.Location = New System.Drawing.Point(137, 139)
        Me.TextBox26.Name = "TextBox26"
        Me.TextBox26.ReadOnly = True
        Me.TextBox26.Size = New System.Drawing.Size(50, 22)
        Me.TextBox26.TabIndex = 31
        '
        'Label33
        '
        Me.Label33.AutoSize = True
        Me.Label33.Location = New System.Drawing.Point(24, 64)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(102, 12)
        Me.Label33.TabIndex = 18
        Me.Label33.Text = "1st Runner Up Score"
        '
        'Label34
        '
        Me.Label34.AutoSize = True
        Me.Label34.Location = New System.Drawing.Point(24, 144)
        Me.Label34.Name = "Label34"
        Me.Label34.Size = New System.Drawing.Size(80, 12)
        Me.Label34.TabIndex = 20
        Me.Label34.Text = "Position 4 Score"
        '
        'Label35
        '
        Me.Label35.AutoSize = True
        Me.Label35.Location = New System.Drawing.Point(24, 24)
        Me.Label35.Name = "Label35"
        Me.Label35.Size = New System.Drawing.Size(83, 12)
        Me.Label35.TabIndex = 17
        Me.Label35.Text = "Champion Score"
        '
        'Label36
        '
        Me.Label36.AutoSize = True
        Me.Label36.Location = New System.Drawing.Point(24, 104)
        Me.Label36.Name = "Label36"
        Me.Label36.Size = New System.Drawing.Size(107, 12)
        Me.Label36.TabIndex = 19
        Me.Label36.Text = "2nd Runner Up Score"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.DataGridView1)
        Me.GroupBox3.Font = New System.Drawing.Font("新細明體", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(616, 6)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(157, 339)
        Me.GroupBox3.TabIndex = 34
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Houses"
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AllowUserToOrderColumns = True
        Me.DataGridView1.AllowUserToResizeRows = False
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(6, 19)
        Me.DataGridView1.MultiSelect = False
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowHeadersVisible = False
        Me.DataGridView1.RowHeadersWidth = 10
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(145, 314)
        Me.DataGridView1.TabIndex = 0
        '
        'GroupBox8
        '
        Me.GroupBox8.Controls.Add(Me.DateTimePicker5)
        Me.GroupBox8.Controls.Add(Me.DateTimePicker4)
        Me.GroupBox8.Controls.Add(Me.DateTimePicker3)
        Me.GroupBox8.Controls.Add(Me.Label15)
        Me.GroupBox8.Controls.Add(Me.Label14)
        Me.GroupBox8.Controls.Add(Me.Label13)
        Me.GroupBox8.Font = New System.Drawing.Font("新細明體", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox8.Location = New System.Drawing.Point(15, 201)
        Me.GroupBox8.Name = "GroupBox8"
        Me.GroupBox8.Size = New System.Drawing.Size(386, 135)
        Me.GroupBox8.TabIndex = 28
        Me.GroupBox8.TabStop = False
        Me.GroupBox8.Text = "Grading according to Birthdays"
        '
        'DateTimePicker5
        '
        Me.DateTimePicker5.Enabled = False
        Me.DateTimePicker5.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker5.Location = New System.Drawing.Point(180, 107)
        Me.DateTimePicker5.Name = "DateTimePicker5"
        Me.DateTimePicker5.Size = New System.Drawing.Size(200, 22)
        Me.DateTimePicker5.TabIndex = 5
        '
        'DateTimePicker4
        '
        Me.DateTimePicker4.Enabled = False
        Me.DateTimePicker4.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker4.Location = New System.Drawing.Point(180, 67)
        Me.DateTimePicker4.Name = "DateTimePicker4"
        Me.DateTimePicker4.Size = New System.Drawing.Size(200, 22)
        Me.DateTimePicker4.TabIndex = 4
        '
        'DateTimePicker3
        '
        Me.DateTimePicker3.Enabled = False
        Me.DateTimePicker3.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker3.Location = New System.Drawing.Point(180, 27)
        Me.DateTimePicker3.Name = "DateTimePicker3"
        Me.DateTimePicker3.Size = New System.Drawing.Size(200, 22)
        Me.DateTimePicker3.TabIndex = 3
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(9, 111)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(150, 12)
        Me.Label15.TabIndex = 2
        Me.Label15.Text = "C GRADE Born In and Before"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(9, 71)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(150, 12)
        Me.Label14.TabIndex = 1
        Me.Label14.Text = "B GRADE Born In and Before"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(9, 31)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(150, 12)
        Me.Label13.TabIndex = 0
        Me.Label13.Text = "A GRADE Born In and Before"
        '
        'TextBox7
        '
        Me.TextBox7.Font = New System.Drawing.Font("新細明體", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox7.Location = New System.Drawing.Point(248, 89)
        Me.TextBox7.Name = "TextBox7"
        Me.TextBox7.ReadOnly = True
        Me.TextBox7.Size = New System.Drawing.Size(50, 22)
        Me.TextBox7.TabIndex = 27
        '
        'TextBox6
        '
        Me.TextBox6.Font = New System.Drawing.Font("新細明體", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox6.Location = New System.Drawing.Point(248, 49)
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.ReadOnly = True
        Me.TextBox6.Size = New System.Drawing.Size(50, 22)
        Me.TextBox6.TabIndex = 26
        '
        'TextBox5
        '
        Me.TextBox5.Font = New System.Drawing.Font("新細明體", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox5.Location = New System.Drawing.Point(248, 9)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.ReadOnly = True
        Me.TextBox5.Size = New System.Drawing.Size(50, 22)
        Me.TextBox5.TabIndex = 25
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.RadioButton5)
        Me.Panel2.Controls.Add(Me.RadioButton4)
        Me.Panel2.Controls.Add(Me.RadioButton3)
        Me.Panel2.Font = New System.Drawing.Font("新細明體", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel2.Location = New System.Drawing.Point(45, 129)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(162, 21)
        Me.Panel2.TabIndex = 24
        '
        'RadioButton5
        '
        Me.RadioButton5.AutoSize = True
        Me.RadioButton5.Checked = True
        Me.RadioButton5.Enabled = False
        Me.RadioButton5.Location = New System.Drawing.Point(107, 3)
        Me.RadioButton5.Name = "RadioButton5"
        Me.RadioButton5.Size = New System.Drawing.Size(52, 16)
        Me.RadioButton5.TabIndex = 12
        Me.RadioButton5.TabStop = True
        Me.RadioButton5.Text = "Co-ed"
        Me.RadioButton5.UseVisualStyleBackColor = True
        '
        'RadioButton4
        '
        Me.RadioButton4.AutoSize = True
        Me.RadioButton4.Enabled = False
        Me.RadioButton4.Location = New System.Drawing.Point(56, 3)
        Me.RadioButton4.Name = "RadioButton4"
        Me.RadioButton4.Size = New System.Drawing.Size(45, 16)
        Me.RadioButton4.TabIndex = 1
        Me.RadioButton4.Text = "Girls"
        Me.RadioButton4.UseVisualStyleBackColor = True
        '
        'RadioButton3
        '
        Me.RadioButton3.AutoSize = True
        Me.RadioButton3.Enabled = False
        Me.RadioButton3.Location = New System.Drawing.Point(3, 3)
        Me.RadioButton3.Name = "RadioButton3"
        Me.RadioButton3.Size = New System.Drawing.Size(47, 16)
        Me.RadioButton3.TabIndex = 0
        Me.RadioButton3.TabStop = True
        Me.RadioButton3.Text = "Boys"
        Me.RadioButton3.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.CheckBox1)
        Me.Panel1.Controls.Add(Me.CheckBox3)
        Me.Panel1.Controls.Add(Me.CheckBox2)
        Me.Panel1.Font = New System.Drawing.Font("新細明體", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel1.Location = New System.Drawing.Point(265, 129)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(80, 66)
        Me.Panel1.TabIndex = 23
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Location = New System.Drawing.Point(3, 3)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(74, 16)
        Me.CheckBox1.TabIndex = 7
        Me.CheckBox1.Text = "A GRADE"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'CheckBox3
        '
        Me.CheckBox3.AutoSize = True
        Me.CheckBox3.Location = New System.Drawing.Point(3, 47)
        Me.CheckBox3.Name = "CheckBox3"
        Me.CheckBox3.Size = New System.Drawing.Size(74, 16)
        Me.CheckBox3.TabIndex = 9
        Me.CheckBox3.Text = "C GRADE"
        Me.CheckBox3.UseVisualStyleBackColor = True
        '
        'CheckBox2
        '
        Me.CheckBox2.AutoSize = True
        Me.CheckBox2.Location = New System.Drawing.Point(3, 25)
        Me.CheckBox2.Name = "CheckBox2"
        Me.CheckBox2.Size = New System.Drawing.Size(74, 16)
        Me.CheckBox2.TabIndex = 8
        Me.CheckBox2.Text = "B GRADE"
        Me.CheckBox2.UseVisualStyleBackColor = True
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("新細明體", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(215, 133)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(37, 12)
        Me.Label12.TabIndex = 22
        Me.Label12.Text = "Grades"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("新細明體", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(12, 133)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(22, 12)
        Me.Label11.TabIndex = 21
        Me.Label11.Text = "Sex"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("新細明體", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(12, 92)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(196, 12)
        Me.Label10.TabIndex = 20
        Me.Label10.Text = "Bonus Score for Students Entering Finals"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("新細明體", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(12, 52)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(162, 12)
        Me.Label9.TabIndex = 19
        Me.Label9.Text = "Participant Absence Penalty Score"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("新細明體", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.Location = New System.Drawing.Point(12, 12)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(230, 12)
        Me.Label21.TabIndex = 18
        Me.Label21.Text = "Bonus Score for Students Participating in Events"
        '
        'TabPage14
        '
        Me.TabPage14.Controls.Add(Me.Button23)
        Me.TabPage14.Controls.Add(Me.TextBox20)
        Me.TabPage14.Controls.Add(Me.Label39)
        Me.TabPage14.Controls.Add(Me.Label22)
        Me.TabPage14.Controls.Add(Me.TextBox13)
        Me.TabPage14.Controls.Add(Me.Button1)
        Me.TabPage14.Controls.Add(Me.DataGridView2)
        Me.TabPage14.Location = New System.Drawing.Point(4, 23)
        Me.TabPage14.Name = "TabPage14"
        Me.TabPage14.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage14.Size = New System.Drawing.Size(776, 451)
        Me.TabPage14.TabIndex = 2
        Me.TabPage14.Text = "Student"
        Me.TabPage14.UseVisualStyleBackColor = True
        '
        'Button23
        '
        Me.Button23.Enabled = False
        Me.Button23.Location = New System.Drawing.Point(692, 419)
        Me.Button23.Name = "Button23"
        Me.Button23.Size = New System.Drawing.Size(75, 23)
        Me.Button23.TabIndex = 8
        Me.Button23.Text = "Print"
        Me.Button23.UseVisualStyleBackColor = True
        '
        'TextBox20
        '
        Me.TextBox20.Location = New System.Drawing.Point(589, 13)
        Me.TextBox20.Name = "TextBox20"
        Me.TextBox20.Size = New System.Drawing.Size(100, 22)
        Me.TextBox20.TabIndex = 7
        '
        'Label39
        '
        Me.Label39.AutoSize = True
        Me.Label39.Location = New System.Drawing.Point(551, 16)
        Me.Label39.Name = "Label39"
        Me.Label39.Size = New System.Drawing.Size(32, 14)
        Me.Label39.TabIndex = 5
        Me.Label39.Text = "Class"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Location = New System.Drawing.Point(6, 16)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(38, 14)
        Me.Label22.TabIndex = 4
        Me.Label22.Text = "Name"
        '
        'TextBox13
        '
        Me.TextBox13.Location = New System.Drawing.Point(50, 13)
        Me.TextBox13.Name = "TextBox13"
        Me.TextBox13.Size = New System.Drawing.Size(495, 22)
        Me.TextBox13.TabIndex = 3
        '
        'Button1
        '
        Me.Button1.Enabled = False
        Me.Button1.Location = New System.Drawing.Point(695, 12)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "Search"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'DataGridView2
        '
        Me.DataGridView2.AllowUserToAddRows = False
        Me.DataGridView2.AllowUserToDeleteRows = False
        Me.DataGridView2.AllowUserToOrderColumns = True
        Me.DataGridView2.AllowUserToResizeRows = False
        Me.DataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.Location = New System.Drawing.Point(6, 41)
        Me.DataGridView2.MultiSelect = False
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.ReadOnly = True
        Me.DataGridView2.RowHeadersVisible = False
        Me.DataGridView2.RowHeadersWidth = 10
        Me.DataGridView2.RowTemplate.Height = 24
        Me.DataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView2.Size = New System.Drawing.Size(764, 372)
        Me.DataGridView2.TabIndex = 1
        '
        'TabPage15
        '
        Me.TabPage15.Controls.Add(Me.Button24)
        Me.TabPage15.Controls.Add(Me.ComboBox3)
        Me.TabPage15.Controls.Add(Me.ComboBox2)
        Me.TabPage15.Controls.Add(Me.ComboBox1)
        Me.TabPage15.Controls.Add(Me.Label47)
        Me.TabPage15.Controls.Add(Me.Label46)
        Me.TabPage15.Controls.Add(Me.Label45)
        Me.TabPage15.Controls.Add(Me.Label23)
        Me.TabPage15.Controls.Add(Me.TextBox14)
        Me.TabPage15.Controls.Add(Me.DataGridView3)
        Me.TabPage15.Controls.Add(Me.Button2)
        Me.TabPage15.Location = New System.Drawing.Point(4, 23)
        Me.TabPage15.Name = "TabPage15"
        Me.TabPage15.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage15.Size = New System.Drawing.Size(776, 453)
        Me.TabPage15.TabIndex = 3
        Me.TabPage15.Text = "Event"
        Me.TabPage15.UseVisualStyleBackColor = True
        '
        'Button24
        '
        Me.Button24.Enabled = False
        Me.Button24.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Button24.Location = New System.Drawing.Point(692, 419)
        Me.Button24.Name = "Button24"
        Me.Button24.Size = New System.Drawing.Size(75, 23)
        Me.Button24.TabIndex = 15
        Me.Button24.Text = "Print"
        Me.Button24.UseVisualStyleBackColor = True
        '
        'ComboBox3
        '
        Me.ComboBox3.FormattingEnabled = True
        Me.ComboBox3.Items.AddRange(New Object() {"T", "F"})
        Me.ComboBox3.Location = New System.Drawing.Point(619, 13)
        Me.ComboBox3.Name = "ComboBox3"
        Me.ComboBox3.Size = New System.Drawing.Size(70, 22)
        Me.ComboBox3.TabIndex = 14
        '
        'ComboBox2
        '
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Items.AddRange(New Object() {"A", "B", "C"})
        Me.ComboBox2.Location = New System.Drawing.Point(457, 13)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(70, 22)
        Me.ComboBox2.TabIndex = 13
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"F", "M"})
        Me.ComboBox1.Location = New System.Drawing.Point(336, 13)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(70, 22)
        Me.ComboBox1.TabIndex = 12
        '
        'Label47
        '
        Me.Label47.AutoSize = True
        Me.Label47.Location = New System.Drawing.Point(533, 16)
        Me.Label47.Name = "Label47"
        Me.Label47.Size = New System.Drawing.Size(80, 14)
        Me.Label47.TabIndex = 11
        Me.Label47.Text = "Track or Field"
        '
        'Label46
        '
        Me.Label46.AutoSize = True
        Me.Label46.Location = New System.Drawing.Point(412, 16)
        Me.Label46.Name = "Label46"
        Me.Label46.Size = New System.Drawing.Size(39, 14)
        Me.Label46.TabIndex = 10
        Me.Label46.Text = "Grade"
        '
        'Label45
        '
        Me.Label45.AutoSize = True
        Me.Label45.Location = New System.Drawing.Point(303, 16)
        Me.Label45.Name = "Label45"
        Me.Label45.Size = New System.Drawing.Size(27, 14)
        Me.Label45.TabIndex = 9
        Me.Label45.Text = "Sex"
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Location = New System.Drawing.Point(6, 16)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(74, 14)
        Me.Label23.TabIndex = 8
        Me.Label23.Text = "Event Name"
        '
        'TextBox14
        '
        Me.TextBox14.Location = New System.Drawing.Point(86, 13)
        Me.TextBox14.Name = "TextBox14"
        Me.TextBox14.Size = New System.Drawing.Size(211, 22)
        Me.TextBox14.TabIndex = 7
        '
        'DataGridView3
        '
        Me.DataGridView3.AllowUserToAddRows = False
        Me.DataGridView3.AllowUserToDeleteRows = False
        Me.DataGridView3.AllowUserToOrderColumns = True
        Me.DataGridView3.AllowUserToResizeRows = False
        Me.DataGridView3.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView3.Location = New System.Drawing.Point(6, 41)
        Me.DataGridView3.MultiSelect = False
        Me.DataGridView3.Name = "DataGridView3"
        Me.DataGridView3.ReadOnly = True
        Me.DataGridView3.RowHeadersVisible = False
        Me.DataGridView3.RowHeadersWidth = 10
        Me.DataGridView3.RowTemplate.Height = 24
        Me.DataGridView3.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView3.Size = New System.Drawing.Size(764, 372)
        Me.DataGridView3.TabIndex = 6
        '
        'Button2
        '
        Me.Button2.Enabled = False
        Me.Button2.Location = New System.Drawing.Point(695, 12)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 5
        Me.Button2.Text = "Search"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'TabPage16
        '
        Me.TabPage16.Controls.Add(Me.Button25)
        Me.TabPage16.Controls.Add(Me.Label24)
        Me.TabPage16.Controls.Add(Me.TextBox15)
        Me.TabPage16.Controls.Add(Me.DataGridView4)
        Me.TabPage16.Controls.Add(Me.Button3)
        Me.TabPage16.Location = New System.Drawing.Point(4, 23)
        Me.TabPage16.Name = "TabPage16"
        Me.TabPage16.Size = New System.Drawing.Size(776, 453)
        Me.TabPage16.TabIndex = 4
        Me.TabPage16.Text = "Helper Team"
        Me.TabPage16.UseVisualStyleBackColor = True
        '
        'Button25
        '
        Me.Button25.Enabled = False
        Me.Button25.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Button25.Location = New System.Drawing.Point(692, 419)
        Me.Button25.Name = "Button25"
        Me.Button25.Size = New System.Drawing.Size(75, 23)
        Me.Button25.TabIndex = 16
        Me.Button25.Text = "Print"
        Me.Button25.UseVisualStyleBackColor = True
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Location = New System.Drawing.Point(6, 16)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(38, 14)
        Me.Label24.TabIndex = 11
        Me.Label24.Text = "Name"
        '
        'TextBox15
        '
        Me.TextBox15.Location = New System.Drawing.Point(50, 13)
        Me.TextBox15.Name = "TextBox15"
        Me.TextBox15.Size = New System.Drawing.Size(639, 22)
        Me.TextBox15.TabIndex = 10
        '
        'DataGridView4
        '
        Me.DataGridView4.AllowUserToAddRows = False
        Me.DataGridView4.AllowUserToDeleteRows = False
        Me.DataGridView4.AllowUserToOrderColumns = True
        Me.DataGridView4.AllowUserToResizeRows = False
        Me.DataGridView4.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView4.Location = New System.Drawing.Point(6, 41)
        Me.DataGridView4.MultiSelect = False
        Me.DataGridView4.Name = "DataGridView4"
        Me.DataGridView4.ReadOnly = True
        Me.DataGridView4.RowHeadersVisible = False
        Me.DataGridView4.RowHeadersWidth = 10
        Me.DataGridView4.RowTemplate.Height = 24
        Me.DataGridView4.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView4.Size = New System.Drawing.Size(764, 372)
        Me.DataGridView4.TabIndex = 9
        '
        'Button3
        '
        Me.Button3.Enabled = False
        Me.Button3.Location = New System.Drawing.Point(695, 12)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 23)
        Me.Button3.TabIndex = 8
        Me.Button3.Text = "Search"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'TabControl2
        '
        Me.TabControl2.Controls.Add(Me.TabPage22)
        Me.TabControl2.Controls.Add(Me.TabPage23)
        Me.TabControl2.Controls.Add(Me.TabPage24)
        Me.TabControl2.Controls.Add(Me.TabPage25)
        Me.TabControl2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl2.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabControl2.Location = New System.Drawing.Point(0, 0)
        Me.TabControl2.Name = "TabControl2"
        Me.TabControl2.SelectedIndex = 0
        Me.TabControl2.Size = New System.Drawing.Size(784, 478)
        Me.TabControl2.TabIndex = 1
        Me.TabControl2.Visible = False
        '
        'TabPage22
        '
        Me.TabPage22.Controls.Add(Me.GroupBox2)
        Me.TabPage22.Controls.Add(Me.GroupBox1)
        Me.TabPage22.Location = New System.Drawing.Point(4, 23)
        Me.TabPage22.Name = "TabPage22"
        Me.TabPage22.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage22.Size = New System.Drawing.Size(776, 451)
        Me.TabPage22.TabIndex = 0
        Me.TabPage22.Text = "Registered Event(by Event)"
        Me.TabPage22.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Button26)
        Me.GroupBox2.Controls.Add(Me.DataGridView6)
        Me.GroupBox2.Location = New System.Drawing.Point(249, 3)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(524, 445)
        Me.GroupBox2.TabIndex = 8
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Participants"
        '
        'Button26
        '
        Me.Button26.Enabled = False
        Me.Button26.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Button26.Location = New System.Drawing.Point(443, 416)
        Me.Button26.Name = "Button26"
        Me.Button26.Size = New System.Drawing.Size(75, 23)
        Me.Button26.TabIndex = 17
        Me.Button26.Text = "Print"
        Me.Button26.UseVisualStyleBackColor = True
        '
        'DataGridView6
        '
        Me.DataGridView6.AllowUserToAddRows = False
        Me.DataGridView6.AllowUserToDeleteRows = False
        Me.DataGridView6.AllowUserToOrderColumns = True
        Me.DataGridView6.AllowUserToResizeRows = False
        Me.DataGridView6.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView6.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView6.Location = New System.Drawing.Point(6, 21)
        Me.DataGridView6.MultiSelect = False
        Me.DataGridView6.Name = "DataGridView6"
        Me.DataGridView6.ReadOnly = True
        Me.DataGridView6.RowHeadersVisible = False
        Me.DataGridView6.RowHeadersWidth = 10
        Me.DataGridView6.RowTemplate.Height = 24
        Me.DataGridView6.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView6.Size = New System.Drawing.Size(515, 389)
        Me.DataGridView6.TabIndex = 1
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Button7)
        Me.GroupBox1.Controls.Add(Me.ListBox1)
        Me.GroupBox1.Location = New System.Drawing.Point(3, 3)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(240, 445)
        Me.GroupBox1.TabIndex = 7
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Event List"
        '
        'Button7
        '
        Me.Button7.AutoSize = True
        Me.Button7.Enabled = False
        Me.Button7.Location = New System.Drawing.Point(6, 21)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(101, 24)
        Me.Button7.TabIndex = 7
        Me.Button7.Text = "Load Event List"
        Me.Button7.UseVisualStyleBackColor = True
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.ItemHeight = 14
        Me.ListBox1.Location = New System.Drawing.Point(6, 51)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(228, 354)
        Me.ListBox1.TabIndex = 6
        '
        'TabPage23
        '
        Me.TabPage23.Controls.Add(Me.Button27)
        Me.TabPage23.Controls.Add(Me.TextBox33)
        Me.TabPage23.Controls.Add(Me.Label42)
        Me.TabPage23.Controls.Add(Me.Label26)
        Me.TabPage23.Controls.Add(Me.TextBox21)
        Me.TabPage23.Controls.Add(Me.Button9)
        Me.TabPage23.Controls.Add(Me.DataGridView13)
        Me.TabPage23.Location = New System.Drawing.Point(4, 23)
        Me.TabPage23.Name = "TabPage23"
        Me.TabPage23.Size = New System.Drawing.Size(776, 453)
        Me.TabPage23.TabIndex = 2
        Me.TabPage23.Text = "Registered Event(by Student)"
        Me.TabPage23.UseVisualStyleBackColor = True
        '
        'Button27
        '
        Me.Button27.Enabled = False
        Me.Button27.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Button27.Location = New System.Drawing.Point(692, 419)
        Me.Button27.Name = "Button27"
        Me.Button27.Size = New System.Drawing.Size(75, 23)
        Me.Button27.TabIndex = 18
        Me.Button27.Text = "Print"
        Me.Button27.UseVisualStyleBackColor = True
        '
        'TextBox33
        '
        Me.TextBox33.Location = New System.Drawing.Point(589, 13)
        Me.TextBox33.Name = "TextBox33"
        Me.TextBox33.Size = New System.Drawing.Size(100, 22)
        Me.TextBox33.TabIndex = 12
        '
        'Label42
        '
        Me.Label42.AutoSize = True
        Me.Label42.Location = New System.Drawing.Point(551, 16)
        Me.Label42.Name = "Label42"
        Me.Label42.Size = New System.Drawing.Size(32, 14)
        Me.Label42.TabIndex = 10
        Me.Label42.Text = "Class"
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Location = New System.Drawing.Point(6, 16)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(87, 14)
        Me.Label26.TabIndex = 9
        Me.Label26.Text = "Student Name"
        '
        'TextBox21
        '
        Me.TextBox21.Location = New System.Drawing.Point(99, 13)
        Me.TextBox21.Name = "TextBox21"
        Me.TextBox21.Size = New System.Drawing.Size(446, 22)
        Me.TextBox21.TabIndex = 8
        '
        'Button9
        '
        Me.Button9.Enabled = False
        Me.Button9.Location = New System.Drawing.Point(695, 12)
        Me.Button9.Name = "Button9"
        Me.Button9.Size = New System.Drawing.Size(75, 23)
        Me.Button9.TabIndex = 7
        Me.Button9.Text = "Search"
        Me.Button9.UseVisualStyleBackColor = True
        '
        'DataGridView13
        '
        Me.DataGridView13.AllowUserToAddRows = False
        Me.DataGridView13.AllowUserToDeleteRows = False
        Me.DataGridView13.AllowUserToOrderColumns = True
        Me.DataGridView13.AllowUserToResizeRows = False
        Me.DataGridView13.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView13.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView13.Location = New System.Drawing.Point(6, 41)
        Me.DataGridView13.MultiSelect = False
        Me.DataGridView13.Name = "DataGridView13"
        Me.DataGridView13.ReadOnly = True
        Me.DataGridView13.RowHeadersVisible = False
        Me.DataGridView13.RowHeadersWidth = 10
        Me.DataGridView13.RowTemplate.Height = 24
        Me.DataGridView13.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView13.Size = New System.Drawing.Size(764, 372)
        Me.DataGridView13.TabIndex = 6
        '
        'TabPage24
        '
        Me.TabPage24.Controls.Add(Me.GroupBox4)
        Me.TabPage24.Controls.Add(Me.GroupBox5)
        Me.TabPage24.Location = New System.Drawing.Point(4, 23)
        Me.TabPage24.Name = "TabPage24"
        Me.TabPage24.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage24.Size = New System.Drawing.Size(776, 453)
        Me.TabPage24.TabIndex = 1
        Me.TabPage24.Text = "Registered Helper(by Team)"
        Me.TabPage24.UseVisualStyleBackColor = True
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.Button28)
        Me.GroupBox4.Controls.Add(Me.DataGridView5)
        Me.GroupBox4.Location = New System.Drawing.Point(249, 3)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(524, 445)
        Me.GroupBox4.TabIndex = 10
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Helpers"
        '
        'Button28
        '
        Me.Button28.Enabled = False
        Me.Button28.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Button28.Location = New System.Drawing.Point(443, 416)
        Me.Button28.Name = "Button28"
        Me.Button28.Size = New System.Drawing.Size(75, 23)
        Me.Button28.TabIndex = 18
        Me.Button28.Text = "Print"
        Me.Button28.UseVisualStyleBackColor = True
        '
        'DataGridView5
        '
        Me.DataGridView5.AllowUserToAddRows = False
        Me.DataGridView5.AllowUserToDeleteRows = False
        Me.DataGridView5.AllowUserToOrderColumns = True
        Me.DataGridView5.AllowUserToResizeRows = False
        Me.DataGridView5.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView5.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView5.Location = New System.Drawing.Point(6, 21)
        Me.DataGridView5.MultiSelect = False
        Me.DataGridView5.Name = "DataGridView5"
        Me.DataGridView5.ReadOnly = True
        Me.DataGridView5.RowHeadersVisible = False
        Me.DataGridView5.RowHeadersWidth = 10
        Me.DataGridView5.RowTemplate.Height = 24
        Me.DataGridView5.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView5.Size = New System.Drawing.Size(515, 389)
        Me.DataGridView5.TabIndex = 1
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.Button8)
        Me.GroupBox5.Controls.Add(Me.ListBox2)
        Me.GroupBox5.Location = New System.Drawing.Point(3, 3)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(240, 445)
        Me.GroupBox5.TabIndex = 9
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Helper Team List"
        '
        'Button8
        '
        Me.Button8.AutoSize = True
        Me.Button8.Enabled = False
        Me.Button8.Location = New System.Drawing.Point(6, 21)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(139, 24)
        Me.Button8.TabIndex = 7
        Me.Button8.Text = "Load Helper Team List"
        Me.Button8.UseVisualStyleBackColor = True
        '
        'ListBox2
        '
        Me.ListBox2.FormattingEnabled = True
        Me.ListBox2.ItemHeight = 14
        Me.ListBox2.Location = New System.Drawing.Point(6, 51)
        Me.ListBox2.Name = "ListBox2"
        Me.ListBox2.Size = New System.Drawing.Size(228, 354)
        Me.ListBox2.TabIndex = 6
        '
        'TabPage25
        '
        Me.TabPage25.Controls.Add(Me.Button29)
        Me.TabPage25.Controls.Add(Me.TextBox35)
        Me.TabPage25.Controls.Add(Me.Label44)
        Me.TabPage25.Controls.Add(Me.Label28)
        Me.TabPage25.Controls.Add(Me.TextBox22)
        Me.TabPage25.Controls.Add(Me.Button10)
        Me.TabPage25.Controls.Add(Me.DataGridView14)
        Me.TabPage25.Location = New System.Drawing.Point(4, 23)
        Me.TabPage25.Name = "TabPage25"
        Me.TabPage25.Size = New System.Drawing.Size(776, 453)
        Me.TabPage25.TabIndex = 3
        Me.TabPage25.Text = "Registered Helper(by Student)"
        Me.TabPage25.UseVisualStyleBackColor = True
        '
        'Button29
        '
        Me.Button29.Enabled = False
        Me.Button29.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Button29.Location = New System.Drawing.Point(692, 419)
        Me.Button29.Name = "Button29"
        Me.Button29.Size = New System.Drawing.Size(75, 23)
        Me.Button29.TabIndex = 18
        Me.Button29.Text = "Print"
        Me.Button29.UseVisualStyleBackColor = True
        '
        'TextBox35
        '
        Me.TextBox35.Location = New System.Drawing.Point(589, 13)
        Me.TextBox35.Name = "TextBox35"
        Me.TextBox35.Size = New System.Drawing.Size(100, 22)
        Me.TextBox35.TabIndex = 16
        '
        'Label44
        '
        Me.Label44.AutoSize = True
        Me.Label44.Location = New System.Drawing.Point(551, 16)
        Me.Label44.Name = "Label44"
        Me.Label44.Size = New System.Drawing.Size(32, 14)
        Me.Label44.TabIndex = 14
        Me.Label44.Text = "Class"
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.Location = New System.Drawing.Point(6, 16)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(87, 14)
        Me.Label28.TabIndex = 13
        Me.Label28.Text = "Student Name"
        '
        'TextBox22
        '
        Me.TextBox22.Location = New System.Drawing.Point(99, 13)
        Me.TextBox22.Name = "TextBox22"
        Me.TextBox22.Size = New System.Drawing.Size(446, 22)
        Me.TextBox22.TabIndex = 12
        '
        'Button10
        '
        Me.Button10.Enabled = False
        Me.Button10.Location = New System.Drawing.Point(695, 12)
        Me.Button10.Name = "Button10"
        Me.Button10.Size = New System.Drawing.Size(75, 23)
        Me.Button10.TabIndex = 11
        Me.Button10.Text = "Search"
        Me.Button10.UseVisualStyleBackColor = True
        '
        'DataGridView14
        '
        Me.DataGridView14.AllowUserToAddRows = False
        Me.DataGridView14.AllowUserToDeleteRows = False
        Me.DataGridView14.AllowUserToOrderColumns = True
        Me.DataGridView14.AllowUserToResizeRows = False
        Me.DataGridView14.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView14.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView14.Location = New System.Drawing.Point(6, 41)
        Me.DataGridView14.MultiSelect = False
        Me.DataGridView14.Name = "DataGridView14"
        Me.DataGridView14.ReadOnly = True
        Me.DataGridView14.RowHeadersVisible = False
        Me.DataGridView14.RowHeadersWidth = 10
        Me.DataGridView14.RowTemplate.Height = 24
        Me.DataGridView14.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView14.Size = New System.Drawing.Size(764, 372)
        Me.DataGridView14.TabIndex = 10
        '
        'TabControl3
        '
        Me.TabControl3.Controls.Add(Me.TabPage32)
        Me.TabControl3.Controls.Add(Me.TabPage33)
        Me.TabControl3.Controls.Add(Me.TabPage34)
        Me.TabControl3.Controls.Add(Me.TabPage35)
        Me.TabControl3.Controls.Add(Me.TabPage36)
        Me.TabControl3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl3.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabControl3.Location = New System.Drawing.Point(0, 0)
        Me.TabControl3.Name = "TabControl3"
        Me.TabControl3.SelectedIndex = 0
        Me.TabControl3.Size = New System.Drawing.Size(784, 478)
        Me.TabControl3.TabIndex = 2
        Me.TabControl3.Visible = False
        '
        'TabPage32
        '
        Me.TabPage32.Controls.Add(Me.Button30)
        Me.TabPage32.Controls.Add(Me.ComboBox4)
        Me.TabPage32.Controls.Add(Me.ComboBox5)
        Me.TabPage32.Controls.Add(Me.ComboBox6)
        Me.TabPage32.Controls.Add(Me.Label48)
        Me.TabPage32.Controls.Add(Me.Label49)
        Me.TabPage32.Controls.Add(Me.Label50)
        Me.TabPage32.Controls.Add(Me.Label25)
        Me.TabPage32.Controls.Add(Me.TextBox16)
        Me.TabPage32.Controls.Add(Me.Button4)
        Me.TabPage32.Controls.Add(Me.DataGridView7)
        Me.TabPage32.Location = New System.Drawing.Point(4, 23)
        Me.TabPage32.Name = "TabPage32"
        Me.TabPage32.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage32.Size = New System.Drawing.Size(776, 451)
        Me.TabPage32.TabIndex = 0
        Me.TabPage32.Text = "Participant and Group"
        Me.TabPage32.UseVisualStyleBackColor = True
        '
        'Button30
        '
        Me.Button30.Enabled = False
        Me.Button30.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Button30.Location = New System.Drawing.Point(692, 419)
        Me.Button30.Name = "Button30"
        Me.Button30.Size = New System.Drawing.Size(75, 23)
        Me.Button30.TabIndex = 21
        Me.Button30.Text = "Print"
        Me.Button30.UseVisualStyleBackColor = True
        '
        'ComboBox4
        '
        Me.ComboBox4.FormattingEnabled = True
        Me.ComboBox4.Items.AddRange(New Object() {"T", "F"})
        Me.ComboBox4.Location = New System.Drawing.Point(619, 13)
        Me.ComboBox4.Name = "ComboBox4"
        Me.ComboBox4.Size = New System.Drawing.Size(70, 22)
        Me.ComboBox4.TabIndex = 20
        '
        'ComboBox5
        '
        Me.ComboBox5.FormattingEnabled = True
        Me.ComboBox5.Items.AddRange(New Object() {"A", "B", "C"})
        Me.ComboBox5.Location = New System.Drawing.Point(457, 13)
        Me.ComboBox5.Name = "ComboBox5"
        Me.ComboBox5.Size = New System.Drawing.Size(70, 22)
        Me.ComboBox5.TabIndex = 19
        '
        'ComboBox6
        '
        Me.ComboBox6.FormattingEnabled = True
        Me.ComboBox6.Items.AddRange(New Object() {"F", "M"})
        Me.ComboBox6.Location = New System.Drawing.Point(336, 13)
        Me.ComboBox6.Name = "ComboBox6"
        Me.ComboBox6.Size = New System.Drawing.Size(70, 22)
        Me.ComboBox6.TabIndex = 18
        '
        'Label48
        '
        Me.Label48.AutoSize = True
        Me.Label48.Location = New System.Drawing.Point(533, 16)
        Me.Label48.Name = "Label48"
        Me.Label48.Size = New System.Drawing.Size(80, 14)
        Me.Label48.TabIndex = 17
        Me.Label48.Text = "Track or Field"
        '
        'Label49
        '
        Me.Label49.AutoSize = True
        Me.Label49.Location = New System.Drawing.Point(412, 16)
        Me.Label49.Name = "Label49"
        Me.Label49.Size = New System.Drawing.Size(39, 14)
        Me.Label49.TabIndex = 16
        Me.Label49.Text = "Grade"
        '
        'Label50
        '
        Me.Label50.AutoSize = True
        Me.Label50.Location = New System.Drawing.Point(303, 16)
        Me.Label50.Name = "Label50"
        Me.Label50.Size = New System.Drawing.Size(27, 14)
        Me.Label50.TabIndex = 15
        Me.Label50.Text = "Sex"
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Location = New System.Drawing.Point(9, 16)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(74, 14)
        Me.Label25.TabIndex = 9
        Me.Label25.Text = "Event Name"
        '
        'TextBox16
        '
        Me.TextBox16.Location = New System.Drawing.Point(89, 13)
        Me.TextBox16.Name = "TextBox16"
        Me.TextBox16.Size = New System.Drawing.Size(208, 22)
        Me.TextBox16.TabIndex = 6
        '
        'Button4
        '
        Me.Button4.Enabled = False
        Me.Button4.Location = New System.Drawing.Point(695, 12)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(75, 23)
        Me.Button4.TabIndex = 5
        Me.Button4.Text = "Search"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'DataGridView7
        '
        Me.DataGridView7.AllowUserToAddRows = False
        Me.DataGridView7.AllowUserToDeleteRows = False
        Me.DataGridView7.AllowUserToOrderColumns = True
        Me.DataGridView7.AllowUserToResizeRows = False
        Me.DataGridView7.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView7.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView7.Location = New System.Drawing.Point(6, 41)
        Me.DataGridView7.MultiSelect = False
        Me.DataGridView7.Name = "DataGridView7"
        Me.DataGridView7.ReadOnly = True
        Me.DataGridView7.RowHeadersVisible = False
        Me.DataGridView7.RowHeadersWidth = 10
        Me.DataGridView7.RowTemplate.Height = 24
        Me.DataGridView7.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView7.Size = New System.Drawing.Size(764, 372)
        Me.DataGridView7.TabIndex = 4
        '
        'TabPage33
        '
        Me.TabPage33.Controls.Add(Me.Button31)
        Me.TabPage33.Controls.Add(Me.ComboBox7)
        Me.TabPage33.Controls.Add(Me.ComboBox8)
        Me.TabPage33.Controls.Add(Me.ComboBox9)
        Me.TabPage33.Controls.Add(Me.Label51)
        Me.TabPage33.Controls.Add(Me.Label52)
        Me.TabPage33.Controls.Add(Me.Label53)
        Me.TabPage33.Controls.Add(Me.Label27)
        Me.TabPage33.Controls.Add(Me.TextBox17)
        Me.TabPage33.Controls.Add(Me.Button5)
        Me.TabPage33.Controls.Add(Me.DataGridView8)
        Me.TabPage33.Location = New System.Drawing.Point(4, 23)
        Me.TabPage33.Name = "TabPage33"
        Me.TabPage33.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage33.Size = New System.Drawing.Size(776, 453)
        Me.TabPage33.TabIndex = 1
        Me.TabPage33.Text = "Lane Distribution(by Event)"
        Me.TabPage33.UseVisualStyleBackColor = True
        '
        'Button31
        '
        Me.Button31.Enabled = False
        Me.Button31.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Button31.Location = New System.Drawing.Point(692, 419)
        Me.Button31.Name = "Button31"
        Me.Button31.Size = New System.Drawing.Size(75, 23)
        Me.Button31.TabIndex = 27
        Me.Button31.Text = "Print"
        Me.Button31.UseVisualStyleBackColor = True
        '
        'ComboBox7
        '
        Me.ComboBox7.FormattingEnabled = True
        Me.ComboBox7.Items.AddRange(New Object() {"T", "F"})
        Me.ComboBox7.Location = New System.Drawing.Point(619, 13)
        Me.ComboBox7.Name = "ComboBox7"
        Me.ComboBox7.Size = New System.Drawing.Size(70, 22)
        Me.ComboBox7.TabIndex = 26
        '
        'ComboBox8
        '
        Me.ComboBox8.FormattingEnabled = True
        Me.ComboBox8.Items.AddRange(New Object() {"A", "B", "C"})
        Me.ComboBox8.Location = New System.Drawing.Point(457, 13)
        Me.ComboBox8.Name = "ComboBox8"
        Me.ComboBox8.Size = New System.Drawing.Size(70, 22)
        Me.ComboBox8.TabIndex = 25
        '
        'ComboBox9
        '
        Me.ComboBox9.FormattingEnabled = True
        Me.ComboBox9.Items.AddRange(New Object() {"F", "M"})
        Me.ComboBox9.Location = New System.Drawing.Point(336, 13)
        Me.ComboBox9.Name = "ComboBox9"
        Me.ComboBox9.Size = New System.Drawing.Size(70, 22)
        Me.ComboBox9.TabIndex = 24
        '
        'Label51
        '
        Me.Label51.AutoSize = True
        Me.Label51.Location = New System.Drawing.Point(533, 16)
        Me.Label51.Name = "Label51"
        Me.Label51.Size = New System.Drawing.Size(80, 14)
        Me.Label51.TabIndex = 23
        Me.Label51.Text = "Track or Field"
        '
        'Label52
        '
        Me.Label52.AutoSize = True
        Me.Label52.Location = New System.Drawing.Point(412, 16)
        Me.Label52.Name = "Label52"
        Me.Label52.Size = New System.Drawing.Size(39, 14)
        Me.Label52.TabIndex = 22
        Me.Label52.Text = "Grade"
        '
        'Label53
        '
        Me.Label53.AutoSize = True
        Me.Label53.Location = New System.Drawing.Point(303, 16)
        Me.Label53.Name = "Label53"
        Me.Label53.Size = New System.Drawing.Size(27, 14)
        Me.Label53.TabIndex = 21
        Me.Label53.Text = "Sex"
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Location = New System.Drawing.Point(9, 16)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(74, 14)
        Me.Label27.TabIndex = 10
        Me.Label27.Text = "Event Name"
        '
        'TextBox17
        '
        Me.TextBox17.Location = New System.Drawing.Point(89, 13)
        Me.TextBox17.Name = "TextBox17"
        Me.TextBox17.Size = New System.Drawing.Size(208, 22)
        Me.TextBox17.TabIndex = 9
        '
        'Button5
        '
        Me.Button5.Enabled = False
        Me.Button5.Location = New System.Drawing.Point(695, 12)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(75, 23)
        Me.Button5.TabIndex = 8
        Me.Button5.Text = "Search"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'DataGridView8
        '
        Me.DataGridView8.AllowUserToAddRows = False
        Me.DataGridView8.AllowUserToDeleteRows = False
        Me.DataGridView8.AllowUserToOrderColumns = True
        Me.DataGridView8.AllowUserToResizeRows = False
        Me.DataGridView8.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView8.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView8.Location = New System.Drawing.Point(6, 41)
        Me.DataGridView8.MultiSelect = False
        Me.DataGridView8.Name = "DataGridView8"
        Me.DataGridView8.ReadOnly = True
        Me.DataGridView8.RowHeadersVisible = False
        Me.DataGridView8.RowHeadersWidth = 10
        Me.DataGridView8.RowTemplate.Height = 24
        Me.DataGridView8.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView8.Size = New System.Drawing.Size(764, 372)
        Me.DataGridView8.TabIndex = 7
        '
        'TabPage34
        '
        Me.TabPage34.Controls.Add(Me.Button32)
        Me.TabPage34.Controls.Add(Me.Label37)
        Me.TabPage34.Controls.Add(Me.TextBox18)
        Me.TabPage34.Controls.Add(Me.Button6)
        Me.TabPage34.Controls.Add(Me.DataGridView9)
        Me.TabPage34.Location = New System.Drawing.Point(4, 23)
        Me.TabPage34.Name = "TabPage34"
        Me.TabPage34.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage34.Size = New System.Drawing.Size(776, 453)
        Me.TabPage34.TabIndex = 2
        Me.TabPage34.Text = "Lane Distribution(by Student)"
        Me.TabPage34.UseVisualStyleBackColor = True
        '
        'Button32
        '
        Me.Button32.Enabled = False
        Me.Button32.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Button32.Location = New System.Drawing.Point(692, 419)
        Me.Button32.Name = "Button32"
        Me.Button32.Size = New System.Drawing.Size(75, 23)
        Me.Button32.TabIndex = 19
        Me.Button32.Text = "Print"
        Me.Button32.UseVisualStyleBackColor = True
        '
        'Label37
        '
        Me.Label37.AutoSize = True
        Me.Label37.Location = New System.Drawing.Point(9, 16)
        Me.Label37.Name = "Label37"
        Me.Label37.Size = New System.Drawing.Size(87, 14)
        Me.Label37.TabIndex = 16
        Me.Label37.Text = "Student Name"
        '
        'TextBox18
        '
        Me.TextBox18.Location = New System.Drawing.Point(102, 13)
        Me.TextBox18.Name = "TextBox18"
        Me.TextBox18.Size = New System.Drawing.Size(587, 22)
        Me.TextBox18.TabIndex = 15
        '
        'Button6
        '
        Me.Button6.Enabled = False
        Me.Button6.Location = New System.Drawing.Point(695, 12)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(75, 23)
        Me.Button6.TabIndex = 14
        Me.Button6.Text = "Search"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'DataGridView9
        '
        Me.DataGridView9.AllowUserToAddRows = False
        Me.DataGridView9.AllowUserToDeleteRows = False
        Me.DataGridView9.AllowUserToOrderColumns = True
        Me.DataGridView9.AllowUserToResizeRows = False
        Me.DataGridView9.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView9.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView9.Location = New System.Drawing.Point(6, 41)
        Me.DataGridView9.MultiSelect = False
        Me.DataGridView9.Name = "DataGridView9"
        Me.DataGridView9.ReadOnly = True
        Me.DataGridView9.RowHeadersVisible = False
        Me.DataGridView9.RowHeadersWidth = 10
        Me.DataGridView9.RowTemplate.Height = 24
        Me.DataGridView9.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView9.Size = New System.Drawing.Size(764, 372)
        Me.DataGridView9.TabIndex = 13
        '
        'TabPage35
        '
        Me.TabPage35.Controls.Add(Me.Button33)
        Me.TabPage35.Controls.Add(Me.Button12)
        Me.TabPage35.Controls.Add(Me.Button11)
        Me.TabPage35.Controls.Add(Me.DataGridView10)
        Me.TabPage35.Location = New System.Drawing.Point(4, 23)
        Me.TabPage35.Name = "TabPage35"
        Me.TabPage35.Size = New System.Drawing.Size(776, 453)
        Me.TabPage35.TabIndex = 3
        Me.TabPage35.Text = "1st Day TimeTable"
        Me.TabPage35.UseVisualStyleBackColor = True
        '
        'Button33
        '
        Me.Button33.Enabled = False
        Me.Button33.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Button33.Location = New System.Drawing.Point(692, 419)
        Me.Button33.Name = "Button33"
        Me.Button33.Size = New System.Drawing.Size(75, 23)
        Me.Button33.TabIndex = 19
        Me.Button33.Text = "Print"
        Me.Button33.UseVisualStyleBackColor = True
        '
        'Button12
        '
        Me.Button12.AutoSize = True
        Me.Button12.Enabled = False
        Me.Button12.Location = New System.Drawing.Point(6, 12)
        Me.Button12.Name = "Button12"
        Me.Button12.Size = New System.Drawing.Size(158, 24)
        Me.Button12.TabIndex = 16
        Me.Button12.Text = "Show 1st Day Time Table"
        Me.Button12.UseVisualStyleBackColor = True
        '
        'Button11
        '
        Me.Button11.AutoSize = True
        Me.Button11.Enabled = False
        Me.Button11.Location = New System.Drawing.Point(692, 12)
        Me.Button11.Name = "Button11"
        Me.Button11.Size = New System.Drawing.Size(78, 24)
        Me.Button11.TabIndex = 15
        Me.Button11.Text = "Large View"
        Me.Button11.UseVisualStyleBackColor = True
        '
        'DataGridView10
        '
        Me.DataGridView10.AllowUserToAddRows = False
        Me.DataGridView10.AllowUserToDeleteRows = False
        Me.DataGridView10.AllowUserToOrderColumns = True
        Me.DataGridView10.AllowUserToResizeRows = False
        Me.DataGridView10.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView10.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView10.Location = New System.Drawing.Point(6, 41)
        Me.DataGridView10.MultiSelect = False
        Me.DataGridView10.Name = "DataGridView10"
        Me.DataGridView10.ReadOnly = True
        Me.DataGridView10.RowHeadersVisible = False
        Me.DataGridView10.RowHeadersWidth = 10
        Me.DataGridView10.RowTemplate.Height = 24
        Me.DataGridView10.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView10.Size = New System.Drawing.Size(764, 372)
        Me.DataGridView10.TabIndex = 14
        '
        'TabPage36
        '
        Me.TabPage36.Controls.Add(Me.Button34)
        Me.TabPage36.Controls.Add(Me.Button13)
        Me.TabPage36.Controls.Add(Me.Button14)
        Me.TabPage36.Controls.Add(Me.DataGridView11)
        Me.TabPage36.Location = New System.Drawing.Point(4, 23)
        Me.TabPage36.Name = "TabPage36"
        Me.TabPage36.Size = New System.Drawing.Size(776, 453)
        Me.TabPage36.TabIndex = 4
        Me.TabPage36.Text = "2nd Day Time Table"
        Me.TabPage36.UseVisualStyleBackColor = True
        '
        'Button34
        '
        Me.Button34.Enabled = False
        Me.Button34.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Button34.Location = New System.Drawing.Point(692, 419)
        Me.Button34.Name = "Button34"
        Me.Button34.Size = New System.Drawing.Size(75, 23)
        Me.Button34.TabIndex = 19
        Me.Button34.Text = "Print"
        Me.Button34.UseVisualStyleBackColor = True
        '
        'Button13
        '
        Me.Button13.AutoSize = True
        Me.Button13.Enabled = False
        Me.Button13.Location = New System.Drawing.Point(6, 12)
        Me.Button13.Name = "Button13"
        Me.Button13.Size = New System.Drawing.Size(162, 24)
        Me.Button13.TabIndex = 18
        Me.Button13.Text = "Show 2nd Day Time Table"
        Me.Button13.UseVisualStyleBackColor = True
        '
        'Button14
        '
        Me.Button14.AutoSize = True
        Me.Button14.Enabled = False
        Me.Button14.Location = New System.Drawing.Point(692, 12)
        Me.Button14.Name = "Button14"
        Me.Button14.Size = New System.Drawing.Size(78, 24)
        Me.Button14.TabIndex = 17
        Me.Button14.Text = "Large View"
        Me.Button14.UseVisualStyleBackColor = True
        '
        'DataGridView11
        '
        Me.DataGridView11.AllowUserToAddRows = False
        Me.DataGridView11.AllowUserToDeleteRows = False
        Me.DataGridView11.AllowUserToOrderColumns = True
        Me.DataGridView11.AllowUserToResizeRows = False
        Me.DataGridView11.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView11.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView11.Location = New System.Drawing.Point(6, 41)
        Me.DataGridView11.MultiSelect = False
        Me.DataGridView11.Name = "DataGridView11"
        Me.DataGridView11.ReadOnly = True
        Me.DataGridView11.RowHeadersVisible = False
        Me.DataGridView11.RowHeadersWidth = 10
        Me.DataGridView11.RowTemplate.Height = 24
        Me.DataGridView11.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView11.Size = New System.Drawing.Size(764, 372)
        Me.DataGridView11.TabIndex = 14
        '
        'TabControl4
        '
        Me.TabControl4.Controls.Add(Me.TabPage42)
        Me.TabControl4.Controls.Add(Me.TabPage43)
        Me.TabControl4.Controls.Add(Me.TabPage44)
        Me.TabControl4.Controls.Add(Me.TabPage45)
        Me.TabControl4.Controls.Add(Me.TabPage46)
        Me.TabControl4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl4.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabControl4.Location = New System.Drawing.Point(0, 0)
        Me.TabControl4.Name = "TabControl4"
        Me.TabControl4.SelectedIndex = 0
        Me.TabControl4.Size = New System.Drawing.Size(784, 478)
        Me.TabControl4.TabIndex = 3
        Me.TabControl4.Visible = False
        '
        'TabPage42
        '
        Me.TabPage42.Controls.Add(Me.GroupBox14)
        Me.TabPage42.Controls.Add(Me.GroupBox15)
        Me.TabPage42.Location = New System.Drawing.Point(4, 23)
        Me.TabPage42.Name = "TabPage42"
        Me.TabPage42.Size = New System.Drawing.Size(776, 451)
        Me.TabPage42.TabIndex = 3
        Me.TabPage42.Text = "Field Result"
        Me.TabPage42.UseVisualStyleBackColor = True
        '
        'GroupBox14
        '
        Me.GroupBox14.Controls.Add(Me.Button35)
        Me.GroupBox14.Controls.Add(Me.DataGridView20)
        Me.GroupBox14.Location = New System.Drawing.Point(249, 3)
        Me.GroupBox14.Name = "GroupBox14"
        Me.GroupBox14.Size = New System.Drawing.Size(524, 445)
        Me.GroupBox14.TabIndex = 9
        Me.GroupBox14.TabStop = False
        Me.GroupBox14.Text = "Results"
        '
        'Button35
        '
        Me.Button35.Enabled = False
        Me.Button35.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Button35.Location = New System.Drawing.Point(443, 416)
        Me.Button35.Name = "Button35"
        Me.Button35.Size = New System.Drawing.Size(75, 23)
        Me.Button35.TabIndex = 17
        Me.Button35.Text = "Print"
        Me.Button35.UseVisualStyleBackColor = True
        '
        'DataGridView20
        '
        Me.DataGridView20.AllowUserToAddRows = False
        Me.DataGridView20.AllowUserToDeleteRows = False
        Me.DataGridView20.AllowUserToOrderColumns = True
        Me.DataGridView20.AllowUserToResizeRows = False
        Me.DataGridView20.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView20.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView20.Location = New System.Drawing.Point(6, 21)
        Me.DataGridView20.MultiSelect = False
        Me.DataGridView20.Name = "DataGridView20"
        Me.DataGridView20.ReadOnly = True
        Me.DataGridView20.RowHeadersVisible = False
        Me.DataGridView20.RowHeadersWidth = 10
        Me.DataGridView20.RowTemplate.Height = 24
        Me.DataGridView20.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView20.Size = New System.Drawing.Size(512, 389)
        Me.DataGridView20.TabIndex = 2
        '
        'GroupBox15
        '
        Me.GroupBox15.Controls.Add(Me.Button19)
        Me.GroupBox15.Controls.Add(Me.ListBox6)
        Me.GroupBox15.Location = New System.Drawing.Point(3, 3)
        Me.GroupBox15.Name = "GroupBox15"
        Me.GroupBox15.Size = New System.Drawing.Size(240, 445)
        Me.GroupBox15.TabIndex = 8
        Me.GroupBox15.TabStop = False
        Me.GroupBox15.Text = "Event List"
        '
        'Button19
        '
        Me.Button19.AutoSize = True
        Me.Button19.Enabled = False
        Me.Button19.Location = New System.Drawing.Point(6, 21)
        Me.Button19.Name = "Button19"
        Me.Button19.Size = New System.Drawing.Size(107, 24)
        Me.Button19.TabIndex = 3
        Me.Button19.Text = "Show Event List"
        Me.Button19.UseVisualStyleBackColor = True
        '
        'ListBox6
        '
        Me.ListBox6.FormattingEnabled = True
        Me.ListBox6.ItemHeight = 14
        Me.ListBox6.Location = New System.Drawing.Point(6, 54)
        Me.ListBox6.Name = "ListBox6"
        Me.ListBox6.Size = New System.Drawing.Size(228, 354)
        Me.ListBox6.TabIndex = 3
        '
        'TabPage43
        '
        Me.TabPage43.Controls.Add(Me.GroupBox6)
        Me.TabPage43.Controls.Add(Me.GroupBox9)
        Me.TabPage43.Location = New System.Drawing.Point(4, 23)
        Me.TabPage43.Name = "TabPage43"
        Me.TabPage43.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage43.Size = New System.Drawing.Size(776, 453)
        Me.TabPage43.TabIndex = 0
        Me.TabPage43.Text = "Track Heat Result"
        Me.TabPage43.UseVisualStyleBackColor = True
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.Button36)
        Me.GroupBox6.Controls.Add(Me.DataGridView12)
        Me.GroupBox6.Location = New System.Drawing.Point(249, 3)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(524, 445)
        Me.GroupBox6.TabIndex = 7
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "Track Heats Results"
        '
        'Button36
        '
        Me.Button36.Enabled = False
        Me.Button36.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Button36.Location = New System.Drawing.Point(443, 416)
        Me.Button36.Name = "Button36"
        Me.Button36.Size = New System.Drawing.Size(75, 23)
        Me.Button36.TabIndex = 17
        Me.Button36.Text = "Print"
        Me.Button36.UseVisualStyleBackColor = True
        '
        'DataGridView12
        '
        Me.DataGridView12.AllowUserToAddRows = False
        Me.DataGridView12.AllowUserToDeleteRows = False
        Me.DataGridView12.AllowUserToOrderColumns = True
        Me.DataGridView12.AllowUserToResizeRows = False
        Me.DataGridView12.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView12.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView12.Location = New System.Drawing.Point(6, 21)
        Me.DataGridView12.MultiSelect = False
        Me.DataGridView12.Name = "DataGridView12"
        Me.DataGridView12.ReadOnly = True
        Me.DataGridView12.RowHeadersVisible = False
        Me.DataGridView12.RowHeadersWidth = 10
        Me.DataGridView12.RowTemplate.Height = 24
        Me.DataGridView12.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView12.Size = New System.Drawing.Size(512, 389)
        Me.DataGridView12.TabIndex = 2
        '
        'GroupBox9
        '
        Me.GroupBox9.Controls.Add(Me.Button15)
        Me.GroupBox9.Controls.Add(Me.ListBox3)
        Me.GroupBox9.Location = New System.Drawing.Point(3, 3)
        Me.GroupBox9.Name = "GroupBox9"
        Me.GroupBox9.Size = New System.Drawing.Size(240, 445)
        Me.GroupBox9.TabIndex = 6
        Me.GroupBox9.TabStop = False
        Me.GroupBox9.Text = "Event List"
        '
        'Button15
        '
        Me.Button15.AutoSize = True
        Me.Button15.Enabled = False
        Me.Button15.Location = New System.Drawing.Point(6, 21)
        Me.Button15.Name = "Button15"
        Me.Button15.Size = New System.Drawing.Size(107, 24)
        Me.Button15.TabIndex = 3
        Me.Button15.Text = "Show Event List"
        Me.Button15.UseVisualStyleBackColor = True
        '
        'ListBox3
        '
        Me.ListBox3.FormattingEnabled = True
        Me.ListBox3.ItemHeight = 14
        Me.ListBox3.Location = New System.Drawing.Point(6, 54)
        Me.ListBox3.Name = "ListBox3"
        Me.ListBox3.Size = New System.Drawing.Size(228, 354)
        Me.ListBox3.TabIndex = 3
        '
        'TabPage44
        '
        Me.TabPage44.Controls.Add(Me.GroupBox10)
        Me.TabPage44.Controls.Add(Me.GroupBox11)
        Me.TabPage44.Location = New System.Drawing.Point(4, 23)
        Me.TabPage44.Name = "TabPage44"
        Me.TabPage44.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage44.Size = New System.Drawing.Size(776, 453)
        Me.TabPage44.TabIndex = 1
        Me.TabPage44.Text = "Track Finals Result"
        Me.TabPage44.UseVisualStyleBackColor = True
        '
        'GroupBox10
        '
        Me.GroupBox10.Controls.Add(Me.Button37)
        Me.GroupBox10.Controls.Add(Me.DataGridView15)
        Me.GroupBox10.Location = New System.Drawing.Point(249, 3)
        Me.GroupBox10.Name = "GroupBox10"
        Me.GroupBox10.Size = New System.Drawing.Size(524, 445)
        Me.GroupBox10.TabIndex = 9
        Me.GroupBox10.TabStop = False
        Me.GroupBox10.Text = "Track Finals Results"
        '
        'Button37
        '
        Me.Button37.Enabled = False
        Me.Button37.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Button37.Location = New System.Drawing.Point(443, 416)
        Me.Button37.Name = "Button37"
        Me.Button37.Size = New System.Drawing.Size(75, 23)
        Me.Button37.TabIndex = 17
        Me.Button37.Text = "Print"
        Me.Button37.UseVisualStyleBackColor = True
        '
        'DataGridView15
        '
        Me.DataGridView15.AllowUserToAddRows = False
        Me.DataGridView15.AllowUserToDeleteRows = False
        Me.DataGridView15.AllowUserToOrderColumns = True
        Me.DataGridView15.AllowUserToResizeRows = False
        Me.DataGridView15.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView15.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView15.Location = New System.Drawing.Point(6, 21)
        Me.DataGridView15.MultiSelect = False
        Me.DataGridView15.Name = "DataGridView15"
        Me.DataGridView15.ReadOnly = True
        Me.DataGridView15.RowHeadersVisible = False
        Me.DataGridView15.RowHeadersWidth = 10
        Me.DataGridView15.RowTemplate.Height = 24
        Me.DataGridView15.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView15.Size = New System.Drawing.Size(512, 389)
        Me.DataGridView15.TabIndex = 2
        '
        'GroupBox11
        '
        Me.GroupBox11.Controls.Add(Me.Button16)
        Me.GroupBox11.Controls.Add(Me.ListBox4)
        Me.GroupBox11.Location = New System.Drawing.Point(3, 3)
        Me.GroupBox11.Name = "GroupBox11"
        Me.GroupBox11.Size = New System.Drawing.Size(240, 445)
        Me.GroupBox11.TabIndex = 8
        Me.GroupBox11.TabStop = False
        Me.GroupBox11.Text = "Event List"
        '
        'Button16
        '
        Me.Button16.AutoSize = True
        Me.Button16.Enabled = False
        Me.Button16.Location = New System.Drawing.Point(6, 21)
        Me.Button16.Name = "Button16"
        Me.Button16.Size = New System.Drawing.Size(107, 24)
        Me.Button16.TabIndex = 3
        Me.Button16.Text = "Show Event List"
        Me.Button16.UseVisualStyleBackColor = True
        '
        'ListBox4
        '
        Me.ListBox4.FormattingEnabled = True
        Me.ListBox4.ItemHeight = 14
        Me.ListBox4.Location = New System.Drawing.Point(6, 54)
        Me.ListBox4.Name = "ListBox4"
        Me.ListBox4.Size = New System.Drawing.Size(228, 354)
        Me.ListBox4.TabIndex = 3
        '
        'TabPage45
        '
        Me.TabPage45.Controls.Add(Me.GroupBox12)
        Me.TabPage45.Controls.Add(Me.GroupBox13)
        Me.TabPage45.Location = New System.Drawing.Point(4, 23)
        Me.TabPage45.Name = "TabPage45"
        Me.TabPage45.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage45.Size = New System.Drawing.Size(776, 453)
        Me.TabPage45.TabIndex = 2
        Me.TabPage45.Text = "Absentee"
        Me.TabPage45.UseVisualStyleBackColor = True
        '
        'GroupBox12
        '
        Me.GroupBox12.Controls.Add(Me.Button38)
        Me.GroupBox12.Controls.Add(Me.DataGridView16)
        Me.GroupBox12.Location = New System.Drawing.Point(249, 3)
        Me.GroupBox12.Name = "GroupBox12"
        Me.GroupBox12.Size = New System.Drawing.Size(524, 445)
        Me.GroupBox12.TabIndex = 11
        Me.GroupBox12.TabStop = False
        Me.GroupBox12.Text = "Absentees"
        '
        'Button38
        '
        Me.Button38.Enabled = False
        Me.Button38.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Button38.Location = New System.Drawing.Point(443, 416)
        Me.Button38.Name = "Button38"
        Me.Button38.Size = New System.Drawing.Size(75, 23)
        Me.Button38.TabIndex = 17
        Me.Button38.Text = "Print"
        Me.Button38.UseVisualStyleBackColor = True
        '
        'DataGridView16
        '
        Me.DataGridView16.AllowUserToAddRows = False
        Me.DataGridView16.AllowUserToDeleteRows = False
        Me.DataGridView16.AllowUserToOrderColumns = True
        Me.DataGridView16.AllowUserToResizeRows = False
        Me.DataGridView16.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView16.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView16.Location = New System.Drawing.Point(6, 21)
        Me.DataGridView16.MultiSelect = False
        Me.DataGridView16.Name = "DataGridView16"
        Me.DataGridView16.ReadOnly = True
        Me.DataGridView16.RowHeadersVisible = False
        Me.DataGridView16.RowHeadersWidth = 10
        Me.DataGridView16.RowTemplate.Height = 24
        Me.DataGridView16.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView16.Size = New System.Drawing.Size(512, 389)
        Me.DataGridView16.TabIndex = 2
        '
        'GroupBox13
        '
        Me.GroupBox13.Controls.Add(Me.Button17)
        Me.GroupBox13.Controls.Add(Me.ListBox5)
        Me.GroupBox13.Location = New System.Drawing.Point(3, 3)
        Me.GroupBox13.Name = "GroupBox13"
        Me.GroupBox13.Size = New System.Drawing.Size(240, 445)
        Me.GroupBox13.TabIndex = 10
        Me.GroupBox13.TabStop = False
        Me.GroupBox13.Text = "Event List"
        '
        'Button17
        '
        Me.Button17.AutoSize = True
        Me.Button17.Enabled = False
        Me.Button17.Location = New System.Drawing.Point(6, 21)
        Me.Button17.Name = "Button17"
        Me.Button17.Size = New System.Drawing.Size(107, 24)
        Me.Button17.TabIndex = 3
        Me.Button17.Text = "Show Event List"
        Me.Button17.UseVisualStyleBackColor = True
        '
        'ListBox5
        '
        Me.ListBox5.FormattingEnabled = True
        Me.ListBox5.ItemHeight = 14
        Me.ListBox5.Location = New System.Drawing.Point(6, 54)
        Me.ListBox5.Name = "ListBox5"
        Me.ListBox5.Size = New System.Drawing.Size(228, 354)
        Me.ListBox5.TabIndex = 3
        '
        'TabPage46
        '
        Me.TabPage46.Controls.Add(Me.Button39)
        Me.TabPage46.Controls.Add(Me.Label38)
        Me.TabPage46.Controls.Add(Me.TextBox19)
        Me.TabPage46.Controls.Add(Me.Button21)
        Me.TabPage46.Controls.Add(Me.DataGridView21)
        Me.TabPage46.Location = New System.Drawing.Point(4, 23)
        Me.TabPage46.Name = "TabPage46"
        Me.TabPage46.Size = New System.Drawing.Size(776, 451)
        Me.TabPage46.TabIndex = 4
        Me.TabPage46.Text = "Finals Lane Distribution"
        Me.TabPage46.UseVisualStyleBackColor = True
        '
        'Button39
        '
        Me.Button39.Enabled = False
        Me.Button39.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Button39.Location = New System.Drawing.Point(692, 419)
        Me.Button39.Name = "Button39"
        Me.Button39.Size = New System.Drawing.Size(75, 23)
        Me.Button39.TabIndex = 17
        Me.Button39.Text = "Print"
        Me.Button39.UseVisualStyleBackColor = True
        '
        'Label38
        '
        Me.Label38.AutoSize = True
        Me.Label38.Location = New System.Drawing.Point(9, 16)
        Me.Label38.Name = "Label38"
        Me.Label38.Size = New System.Drawing.Size(74, 14)
        Me.Label38.TabIndex = 14
        Me.Label38.Text = "Event Name"
        '
        'TextBox19
        '
        Me.TextBox19.Location = New System.Drawing.Point(89, 13)
        Me.TextBox19.Name = "TextBox19"
        Me.TextBox19.Size = New System.Drawing.Size(600, 22)
        Me.TextBox19.TabIndex = 13
        '
        'Button21
        '
        Me.Button21.Enabled = False
        Me.Button21.Location = New System.Drawing.Point(695, 12)
        Me.Button21.Name = "Button21"
        Me.Button21.Size = New System.Drawing.Size(75, 23)
        Me.Button21.TabIndex = 12
        Me.Button21.Text = "Search"
        Me.Button21.UseVisualStyleBackColor = True
        '
        'DataGridView21
        '
        Me.DataGridView21.AllowUserToAddRows = False
        Me.DataGridView21.AllowUserToDeleteRows = False
        Me.DataGridView21.AllowUserToOrderColumns = True
        Me.DataGridView21.AllowUserToResizeRows = False
        Me.DataGridView21.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView21.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView21.Location = New System.Drawing.Point(6, 41)
        Me.DataGridView21.MultiSelect = False
        Me.DataGridView21.Name = "DataGridView21"
        Me.DataGridView21.ReadOnly = True
        Me.DataGridView21.RowHeadersVisible = False
        Me.DataGridView21.RowHeadersWidth = 10
        Me.DataGridView21.RowTemplate.Height = 24
        Me.DataGridView21.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView21.Size = New System.Drawing.Size(764, 372)
        Me.DataGridView21.TabIndex = 11
        '
        'TabControl5
        '
        Me.TabControl5.Controls.Add(Me.TabPage52)
        Me.TabControl5.Controls.Add(Me.TabPage53)
        Me.TabControl5.Controls.Add(Me.TabPage54)
        Me.TabControl5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl5.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabControl5.Location = New System.Drawing.Point(0, 0)
        Me.TabControl5.Name = "TabControl5"
        Me.TabControl5.SelectedIndex = 0
        Me.TabControl5.Size = New System.Drawing.Size(784, 478)
        Me.TabControl5.TabIndex = 4
        Me.TabControl5.Visible = False
        '
        'TabPage52
        '
        Me.TabPage52.Controls.Add(Me.Button40)
        Me.TabPage52.Controls.Add(Me.Button18)
        Me.TabPage52.Controls.Add(Me.DataGridView17)
        Me.TabPage52.Location = New System.Drawing.Point(4, 23)
        Me.TabPage52.Name = "TabPage52"
        Me.TabPage52.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage52.Size = New System.Drawing.Size(776, 451)
        Me.TabPage52.TabIndex = 1
        Me.TabPage52.Text = "Award"
        Me.TabPage52.UseVisualStyleBackColor = True
        '
        'Button40
        '
        Me.Button40.Enabled = False
        Me.Button40.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Button40.Location = New System.Drawing.Point(692, 419)
        Me.Button40.Name = "Button40"
        Me.Button40.Size = New System.Drawing.Size(75, 23)
        Me.Button40.TabIndex = 17
        Me.Button40.Text = "Print"
        Me.Button40.UseVisualStyleBackColor = True
        '
        'Button18
        '
        Me.Button18.Enabled = False
        Me.Button18.Location = New System.Drawing.Point(6, 12)
        Me.Button18.Name = "Button18"
        Me.Button18.Size = New System.Drawing.Size(75, 23)
        Me.Button18.TabIndex = 4
        Me.Button18.Text = "Show"
        Me.Button18.UseVisualStyleBackColor = True
        '
        'DataGridView17
        '
        Me.DataGridView17.AllowUserToAddRows = False
        Me.DataGridView17.AllowUserToDeleteRows = False
        Me.DataGridView17.AllowUserToOrderColumns = True
        Me.DataGridView17.AllowUserToResizeRows = False
        Me.DataGridView17.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView17.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView17.Location = New System.Drawing.Point(6, 41)
        Me.DataGridView17.MultiSelect = False
        Me.DataGridView17.Name = "DataGridView17"
        Me.DataGridView17.ReadOnly = True
        Me.DataGridView17.RowHeadersVisible = False
        Me.DataGridView17.RowHeadersWidth = 10
        Me.DataGridView17.RowTemplate.Height = 24
        Me.DataGridView17.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView17.Size = New System.Drawing.Size(764, 372)
        Me.DataGridView17.TabIndex = 3
        '
        'TabPage53
        '
        Me.TabPage53.Controls.Add(Me.Button41)
        Me.TabPage53.Controls.Add(Me.DataGridView18)
        Me.TabPage53.Controls.Add(Me.Button22)
        Me.TabPage53.Location = New System.Drawing.Point(4, 23)
        Me.TabPage53.Name = "TabPage53"
        Me.TabPage53.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage53.Size = New System.Drawing.Size(776, 453)
        Me.TabPage53.TabIndex = 0
        Me.TabPage53.Text = "House Score"
        Me.TabPage53.UseVisualStyleBackColor = True
        '
        'Button41
        '
        Me.Button41.Enabled = False
        Me.Button41.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Button41.Location = New System.Drawing.Point(692, 419)
        Me.Button41.Name = "Button41"
        Me.Button41.Size = New System.Drawing.Size(75, 23)
        Me.Button41.TabIndex = 17
        Me.Button41.Text = "Print"
        Me.Button41.UseVisualStyleBackColor = True
        '
        'DataGridView18
        '
        Me.DataGridView18.AllowUserToAddRows = False
        Me.DataGridView18.AllowUserToDeleteRows = False
        Me.DataGridView18.AllowUserToOrderColumns = True
        Me.DataGridView18.AllowUserToResizeRows = False
        Me.DataGridView18.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView18.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView18.Location = New System.Drawing.Point(6, 41)
        Me.DataGridView18.MultiSelect = False
        Me.DataGridView18.Name = "DataGridView18"
        Me.DataGridView18.ReadOnly = True
        Me.DataGridView18.RowHeadersVisible = False
        Me.DataGridView18.RowHeadersWidth = 10
        Me.DataGridView18.RowTemplate.Height = 24
        Me.DataGridView18.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView18.Size = New System.Drawing.Size(764, 372)
        Me.DataGridView18.TabIndex = 5
        '
        'Button22
        '
        Me.Button22.Enabled = False
        Me.Button22.Location = New System.Drawing.Point(6, 12)
        Me.Button22.Name = "Button22"
        Me.Button22.Size = New System.Drawing.Size(75, 23)
        Me.Button22.TabIndex = 4
        Me.Button22.Text = "Show"
        Me.Button22.UseVisualStyleBackColor = True
        '
        'TabPage54
        '
        Me.TabPage54.Controls.Add(Me.Button42)
        Me.TabPage54.Controls.Add(Me.DataGridView19)
        Me.TabPage54.Controls.Add(Me.Button20)
        Me.TabPage54.Location = New System.Drawing.Point(4, 23)
        Me.TabPage54.Name = "TabPage54"
        Me.TabPage54.Size = New System.Drawing.Size(776, 453)
        Me.TabPage54.TabIndex = 2
        Me.TabPage54.Text = "Personal Score"
        Me.TabPage54.UseVisualStyleBackColor = True
        '
        'Button42
        '
        Me.Button42.Enabled = False
        Me.Button42.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Button42.Location = New System.Drawing.Point(692, 419)
        Me.Button42.Name = "Button42"
        Me.Button42.Size = New System.Drawing.Size(75, 23)
        Me.Button42.TabIndex = 17
        Me.Button42.Text = "Print"
        Me.Button42.UseVisualStyleBackColor = True
        '
        'DataGridView19
        '
        Me.DataGridView19.AllowUserToAddRows = False
        Me.DataGridView19.AllowUserToDeleteRows = False
        Me.DataGridView19.AllowUserToOrderColumns = True
        Me.DataGridView19.AllowUserToResizeRows = False
        Me.DataGridView19.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView19.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView19.Location = New System.Drawing.Point(6, 41)
        Me.DataGridView19.MultiSelect = False
        Me.DataGridView19.Name = "DataGridView19"
        Me.DataGridView19.ReadOnly = True
        Me.DataGridView19.RowHeadersVisible = False
        Me.DataGridView19.RowHeadersWidth = 10
        Me.DataGridView19.RowTemplate.Height = 24
        Me.DataGridView19.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView19.Size = New System.Drawing.Size(764, 372)
        Me.DataGridView19.TabIndex = 6
        '
        'Button20
        '
        Me.Button20.Enabled = False
        Me.Button20.Location = New System.Drawing.Point(6, 12)
        Me.Button20.Name = "Button20"
        Me.Button20.Size = New System.Drawing.Size(75, 23)
        Me.Button20.TabIndex = 5
        Me.Button20.Text = "Show"
        Me.Button20.UseVisualStyleBackColor = True
        '
        'MySqlConnection1
        '
        Me.MySqlConnection1.ConnectionString = Nothing
        '
        'MySqlDataAdapter1
        '
        Me.MySqlDataAdapter1.DeleteCommand = Nothing
        Me.MySqlDataAdapter1.InsertCommand = Nothing
        Me.MySqlDataAdapter1.SelectCommand = Nothing
        Me.MySqlDataAdapter1.UpdateCommand = Nothing
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(952, 506)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MinimumSize = New System.Drawing.Size(400, 400)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "SportsDay Manager"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.ResumeLayout(False)
        Me.TabControl0.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage3.ResumeLayout(False)
        Me.TabPage4.ResumeLayout(False)
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage12.ResumeLayout(False)
        Me.TabPage12.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.TabPage13.ResumeLayout(False)
        Me.TabPage13.PerformLayout()
        Me.GroupBox7.ResumeLayout(False)
        Me.GroupBox7.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox8.ResumeLayout(False)
        Me.GroupBox8.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.TabPage14.ResumeLayout(False)
        Me.TabPage14.PerformLayout()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage15.ResumeLayout(False)
        Me.TabPage15.PerformLayout()
        CType(Me.DataGridView3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage16.ResumeLayout(False)
        Me.TabPage16.PerformLayout()
        CType(Me.DataGridView4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl2.ResumeLayout(False)
        Me.TabPage22.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.DataGridView6, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.TabPage23.ResumeLayout(False)
        Me.TabPage23.PerformLayout()
        CType(Me.DataGridView13, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage24.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        CType(Me.DataGridView5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.TabPage25.ResumeLayout(False)
        Me.TabPage25.PerformLayout()
        CType(Me.DataGridView14, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl3.ResumeLayout(False)
        Me.TabPage32.ResumeLayout(False)
        Me.TabPage32.PerformLayout()
        CType(Me.DataGridView7, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage33.ResumeLayout(False)
        Me.TabPage33.PerformLayout()
        CType(Me.DataGridView8, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage34.ResumeLayout(False)
        Me.TabPage34.PerformLayout()
        CType(Me.DataGridView9, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage35.ResumeLayout(False)
        Me.TabPage35.PerformLayout()
        CType(Me.DataGridView10, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage36.ResumeLayout(False)
        Me.TabPage36.PerformLayout()
        CType(Me.DataGridView11, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl4.ResumeLayout(False)
        Me.TabPage42.ResumeLayout(False)
        Me.GroupBox14.ResumeLayout(False)
        CType(Me.DataGridView20, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox15.ResumeLayout(False)
        Me.GroupBox15.PerformLayout()
        Me.TabPage43.ResumeLayout(False)
        Me.GroupBox6.ResumeLayout(False)
        CType(Me.DataGridView12, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox9.ResumeLayout(False)
        Me.GroupBox9.PerformLayout()
        Me.TabPage44.ResumeLayout(False)
        Me.GroupBox10.ResumeLayout(False)
        CType(Me.DataGridView15, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox11.ResumeLayout(False)
        Me.GroupBox11.PerformLayout()
        Me.TabPage45.ResumeLayout(False)
        Me.GroupBox12.ResumeLayout(False)
        CType(Me.DataGridView16, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox13.ResumeLayout(False)
        Me.GroupBox13.PerformLayout()
        Me.TabPage46.ResumeLayout(False)
        Me.TabPage46.PerformLayout()
        CType(Me.DataGridView21, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl5.ResumeLayout(False)
        Me.TabPage52.ResumeLayout(False)
        CType(Me.DataGridView17, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage53.ResumeLayout(False)
        CType(Me.DataGridView18, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage54.ResumeLayout(False)
        CType(Me.DataGridView19, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NewProjectToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LoadProjectToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents MySqlConnection1 As MySql.Data.MySqlClient.MySqlConnection
    Friend WithEvents TabControl0 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage3 As System.Windows.Forms.TabPage
    Friend WithEvents EditProjectToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EventRegisterToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GroupingandDistributeLaneToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GenerateTimetableToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents UpdateResultsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Private WithEvents MySqlDataAdapter1 As MySql.Data.MySqlClient.MySqlDataAdapter
    Friend WithEvents TreeView1 As System.Windows.Forms.TreeView
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents DataEntryWizardToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HelperRegisterToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TabControl5 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage53 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage52 As System.Windows.Forms.TabPage
    Friend WithEvents TabControl4 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage43 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage44 As System.Windows.Forms.TabPage
    Friend WithEvents TabControl3 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage32 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage33 As System.Windows.Forms.TabPage
    Friend WithEvents TabControl2 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage22 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage24 As System.Windows.Forms.TabPage
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage12 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage13 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage4 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage34 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage14 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage15 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage45 As System.Windows.Forms.TabPage
    Friend WithEvents ResultMonitorToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SettingToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ConnectionSettingsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TabPage35 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage36 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage16 As System.Windows.Forms.TabPage
    Friend WithEvents TextBox9 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox10 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox11 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox12 As System.Windows.Forms.TextBox
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents RadioButton2 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton1 As System.Windows.Forms.RadioButton
    Friend WithEvents TextBox8 As System.Windows.Forms.TextBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents DateTimePicker2 As System.Windows.Forms.DateTimePicker
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents TextBox4 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents GroupBox8 As System.Windows.Forms.GroupBox
    Friend WithEvents DateTimePicker5 As System.Windows.Forms.DateTimePicker
    Friend WithEvents DateTimePicker4 As System.Windows.Forms.DateTimePicker
    Friend WithEvents DateTimePicker3 As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents TextBox7 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox6 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox5 As System.Windows.Forms.TextBox
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents RadioButton5 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton4 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton3 As System.Windows.Forms.RadioButton
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox3 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox2 As System.Windows.Forms.CheckBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents TextBox13 As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents DataGridView2 As System.Windows.Forms.DataGridView
    Friend WithEvents TextBox14 As System.Windows.Forms.TextBox
    Friend WithEvents DataGridView3 As System.Windows.Forms.DataGridView
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents TextBox15 As System.Windows.Forms.TextBox
    Friend WithEvents DataGridView4 As System.Windows.Forms.DataGridView
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents TextBox16 As System.Windows.Forms.TextBox
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents DataGridView7 As System.Windows.Forms.DataGridView
    Friend WithEvents TextBox17 As System.Windows.Forms.TextBox
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents DataGridView8 As System.Windows.Forms.DataGridView
    Friend WithEvents TextBox18 As System.Windows.Forms.TextBox
    Friend WithEvents Button6 As System.Windows.Forms.Button
    Friend WithEvents DataGridView9 As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridView10 As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridView11 As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridView6 As System.Windows.Forms.DataGridView
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents TabPage23 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage25 As System.Windows.Forms.TabPage
    Friend WithEvents Label26 As System.Windows.Forms.Label
    Friend WithEvents TextBox21 As System.Windows.Forms.TextBox
    Friend WithEvents Button9 As System.Windows.Forms.Button
    Friend WithEvents DataGridView13 As System.Windows.Forms.DataGridView
    Friend WithEvents Label28 As System.Windows.Forms.Label
    Friend WithEvents TextBox22 As System.Windows.Forms.TextBox
    Friend WithEvents Button10 As System.Windows.Forms.Button
    Friend WithEvents DataGridView14 As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox7 As System.Windows.Forms.GroupBox
    Friend WithEvents Label29 As System.Windows.Forms.Label
    Friend WithEvents TextBox23 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox24 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox25 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox26 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox27 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox28 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox29 As System.Windows.Forms.TextBox
    Friend WithEvents Label30 As System.Windows.Forms.Label
    Friend WithEvents TextBox30 As System.Windows.Forms.TextBox
    Friend WithEvents Label31 As System.Windows.Forms.Label
    Friend WithEvents Label32 As System.Windows.Forms.Label
    Friend WithEvents Label33 As System.Windows.Forms.Label
    Friend WithEvents Label34 As System.Windows.Forms.Label
    Friend WithEvents Label35 As System.Windows.Forms.Label
    Friend WithEvents Label36 As System.Windows.Forms.Label
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents ListBox1 As System.Windows.Forms.ListBox
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents DataGridView5 As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents ListBox2 As System.Windows.Forms.ListBox
    Friend WithEvents Button7 As System.Windows.Forms.Button
    Friend WithEvents Button8 As System.Windows.Forms.Button
    Friend WithEvents Button11 As System.Windows.Forms.Button
    Friend WithEvents Button12 As System.Windows.Forms.Button
    Friend WithEvents Button13 As System.Windows.Forms.Button
    Friend WithEvents Button14 As System.Windows.Forms.Button
    Friend WithEvents GroupBox6 As System.Windows.Forms.GroupBox
    Friend WithEvents DataGridView12 As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox9 As System.Windows.Forms.GroupBox
    Friend WithEvents Button15 As System.Windows.Forms.Button
    Friend WithEvents ListBox3 As System.Windows.Forms.ListBox
    Friend WithEvents GroupBox10 As System.Windows.Forms.GroupBox
    Friend WithEvents DataGridView15 As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox11 As System.Windows.Forms.GroupBox
    Friend WithEvents Button16 As System.Windows.Forms.Button
    Friend WithEvents ListBox4 As System.Windows.Forms.ListBox
    Friend WithEvents GroupBox12 As System.Windows.Forms.GroupBox
    Friend WithEvents DataGridView16 As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox13 As System.Windows.Forms.GroupBox
    Friend WithEvents Button17 As System.Windows.Forms.Button
    Friend WithEvents ListBox5 As System.Windows.Forms.ListBox
    Friend WithEvents DataGridView17 As System.Windows.Forms.DataGridView
    Friend WithEvents Button18 As System.Windows.Forms.Button
    Friend WithEvents Button22 As System.Windows.Forms.Button
    Friend WithEvents TabPage54 As System.Windows.Forms.TabPage
    Friend WithEvents Button20 As System.Windows.Forms.Button
    Friend WithEvents DataGridView19 As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridView18 As System.Windows.Forms.DataGridView
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents Label27 As System.Windows.Forms.Label
    Friend WithEvents Label37 As System.Windows.Forms.Label
    Friend WithEvents TabPage42 As System.Windows.Forms.TabPage
    Friend WithEvents GroupBox14 As System.Windows.Forms.GroupBox
    Friend WithEvents DataGridView20 As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox15 As System.Windows.Forms.GroupBox
    Friend WithEvents Button19 As System.Windows.Forms.Button
    Friend WithEvents ListBox6 As System.Windows.Forms.ListBox
    Friend WithEvents RichTextBox1 As System.Windows.Forms.RichTextBox
    Friend WithEvents TabPage46 As System.Windows.Forms.TabPage
    Friend WithEvents Label38 As System.Windows.Forms.Label
    Friend WithEvents TextBox19 As System.Windows.Forms.TextBox
    Friend WithEvents Button21 As System.Windows.Forms.Button
    Friend WithEvents DataGridView21 As System.Windows.Forms.DataGridView
    Friend WithEvents RichTextBox2 As System.Windows.Forms.RichTextBox
    Friend WithEvents TextBox20 As System.Windows.Forms.TextBox
    Friend WithEvents Label39 As System.Windows.Forms.Label
    Friend WithEvents TextBox33 As System.Windows.Forms.TextBox
    Friend WithEvents Label42 As System.Windows.Forms.Label
    Friend WithEvents TextBox35 As System.Windows.Forms.TextBox
    Friend WithEvents Label44 As System.Windows.Forms.Label
    Friend WithEvents ComboBox3 As System.Windows.Forms.ComboBox
    Friend WithEvents ComboBox2 As System.Windows.Forms.ComboBox
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents Label47 As System.Windows.Forms.Label
    Friend WithEvents Label46 As System.Windows.Forms.Label
    Friend WithEvents Label45 As System.Windows.Forms.Label
    Friend WithEvents ComboBox4 As System.Windows.Forms.ComboBox
    Friend WithEvents ComboBox5 As System.Windows.Forms.ComboBox
    Friend WithEvents ComboBox6 As System.Windows.Forms.ComboBox
    Friend WithEvents Label48 As System.Windows.Forms.Label
    Friend WithEvents Label49 As System.Windows.Forms.Label
    Friend WithEvents Label50 As System.Windows.Forms.Label
    Friend WithEvents ComboBox7 As System.Windows.Forms.ComboBox
    Friend WithEvents ComboBox8 As System.Windows.Forms.ComboBox
    Friend WithEvents ComboBox9 As System.Windows.Forms.ComboBox
    Friend WithEvents Label51 As System.Windows.Forms.Label
    Friend WithEvents Label52 As System.Windows.Forms.Label
    Friend WithEvents Label53 As System.Windows.Forms.Label
    Friend WithEvents Button23 As System.Windows.Forms.Button
    Friend WithEvents Button24 As System.Windows.Forms.Button
    Friend WithEvents Button25 As System.Windows.Forms.Button
    Friend WithEvents Button26 As System.Windows.Forms.Button
    Friend WithEvents Button27 As System.Windows.Forms.Button
    Friend WithEvents Button28 As System.Windows.Forms.Button
    Friend WithEvents Button29 As System.Windows.Forms.Button
    Friend WithEvents Button30 As System.Windows.Forms.Button
    Friend WithEvents Button31 As System.Windows.Forms.Button
    Friend WithEvents Button32 As System.Windows.Forms.Button
    Friend WithEvents Button33 As System.Windows.Forms.Button
    Friend WithEvents Button34 As System.Windows.Forms.Button
    Friend WithEvents Button35 As System.Windows.Forms.Button
    Friend WithEvents Button36 As System.Windows.Forms.Button
    Friend WithEvents Button37 As System.Windows.Forms.Button
    Friend WithEvents Button38 As System.Windows.Forms.Button
    Friend WithEvents Button39 As System.Windows.Forms.Button
    Friend WithEvents Button40 As System.Windows.Forms.Button
    Friend WithEvents Button41 As System.Windows.Forms.Button
    Friend WithEvents Button42 As System.Windows.Forms.Button
    Friend WithEvents RichTextBox3 As System.Windows.Forms.RichTextBox
    Friend WithEvents InstructionToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NoticesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ProjectGuideToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator

End Class
