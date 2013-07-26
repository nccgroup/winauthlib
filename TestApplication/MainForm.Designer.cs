namespace TestApplication
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.MainLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.CredsLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.UsernameTextBox = new System.Windows.Forms.TextBox();
            this.PasswordTextBox = new System.Windows.Forms.TextBox();
            this.DomainTextBox = new System.Windows.Forms.TextBox();
            this.AuthMethodGroupBox = new System.Windows.Forms.GroupBox();
            this.AuthMethodLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.WNetAuthRadioButton = new System.Windows.Forms.RadioButton();
            this.DCOMAuthRadioButton = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.LogonProviderCombo = new System.Windows.Forms.ComboBox();
            this.LogOnTypeComboBox = new System.Windows.Forms.ComboBox();
            this.TargetLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.TargetTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.TestsTabControl = new System.Windows.Forms.TabControl();
            this.ReadRegTestTab = new System.Windows.Forms.TabPage();
            this.RegKeyLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.RootKeyCombo = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.SubRegKeyGroupBox = new System.Windows.Forms.GroupBox();
            this.SubRegKeyTextBox = new System.Windows.Forms.RichTextBox();
            this.RegKeyResultGroupBox = new System.Windows.Forms.GroupBox();
            this.RegKeyReadtextBox = new System.Windows.Forms.RichTextBox();
            this.TestRegistryKeyButton = new System.Windows.Forms.Button();
            this.InitWindowsUpdateAgent = new System.Windows.Forms.TabPage();
            this.WinUpdatesTestLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.WinUpdatesTestGOButton = new System.Windows.Forms.Button();
            this.WinUpdateTestResultGroupBox = new System.Windows.Forms.GroupBox();
            this.WinUpdateTestTextBox = new System.Windows.Forms.RichTextBox();
            this.MainLayoutPanel.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.CredsLayoutPanel.SuspendLayout();
            this.AuthMethodGroupBox.SuspendLayout();
            this.AuthMethodLayoutPanel.SuspendLayout();
            this.TargetLayoutPanel.SuspendLayout();
            this.TestsTabControl.SuspendLayout();
            this.ReadRegTestTab.SuspendLayout();
            this.RegKeyLayoutPanel.SuspendLayout();
            this.SubRegKeyGroupBox.SuspendLayout();
            this.RegKeyResultGroupBox.SuspendLayout();
            this.InitWindowsUpdateAgent.SuspendLayout();
            this.WinUpdatesTestLayoutPanel.SuspendLayout();
            this.WinUpdateTestResultGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainLayoutPanel
            // 
            this.MainLayoutPanel.ColumnCount = 2;
            this.MainLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.MainLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.MainLayoutPanel.Controls.Add(this.groupBox1, 0, 1);
            this.MainLayoutPanel.Controls.Add(this.AuthMethodGroupBox, 1, 1);
            this.MainLayoutPanel.Controls.Add(this.TargetLayoutPanel, 0, 0);
            this.MainLayoutPanel.Controls.Add(this.TestsTabControl, 0, 2);
            this.MainLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.MainLayoutPanel.Name = "MainLayoutPanel";
            this.MainLayoutPanel.RowCount = 3;
            this.MainLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.MainLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.MainLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.MainLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.MainLayoutPanel.Size = new System.Drawing.Size(741, 360);
            this.MainLayoutPanel.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.CredsLayoutPanel);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(3, 33);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(364, 114);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Credentials";
            // 
            // CredsLayoutPanel
            // 
            this.CredsLayoutPanel.ColumnCount = 2;
            this.CredsLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.CredsLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.CredsLayoutPanel.Controls.Add(this.label1, 0, 0);
            this.CredsLayoutPanel.Controls.Add(this.label2, 0, 1);
            this.CredsLayoutPanel.Controls.Add(this.label3, 0, 2);
            this.CredsLayoutPanel.Controls.Add(this.UsernameTextBox, 1, 0);
            this.CredsLayoutPanel.Controls.Add(this.PasswordTextBox, 1, 1);
            this.CredsLayoutPanel.Controls.Add(this.DomainTextBox, 1, 2);
            this.CredsLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CredsLayoutPanel.Location = new System.Drawing.Point(3, 16);
            this.CredsLayoutPanel.Name = "CredsLayoutPanel";
            this.CredsLayoutPanel.RowCount = 3;
            this.CredsLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.CredsLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.CredsLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.CredsLayoutPanel.Size = new System.Drawing.Size(358, 95);
            this.CredsLayoutPanel.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Username:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Location = new System.Drawing.Point(3, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 31);
            this.label2.TabIndex = 1;
            this.label2.Text = "Password:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Location = new System.Drawing.Point(3, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 33);
            this.label3.TabIndex = 2;
            this.label3.Text = "Domain:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // UsernameTextBox
            // 
            this.UsernameTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.UsernameTextBox.Location = new System.Drawing.Point(103, 3);
            this.UsernameTextBox.Name = "UsernameTextBox";
            this.UsernameTextBox.Size = new System.Drawing.Size(252, 20);
            this.UsernameTextBox.TabIndex = 3;
            this.UsernameTextBox.Text = "temp";
            // 
            // PasswordTextBox
            // 
            this.PasswordTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PasswordTextBox.Location = new System.Drawing.Point(103, 34);
            this.PasswordTextBox.Name = "PasswordTextBox";
            this.PasswordTextBox.PasswordChar = '@';
            this.PasswordTextBox.Size = new System.Drawing.Size(252, 20);
            this.PasswordTextBox.TabIndex = 4;
            this.PasswordTextBox.Text = "b0bb1n$";
            // 
            // DomainTextBox
            // 
            this.DomainTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DomainTextBox.Location = new System.Drawing.Point(103, 65);
            this.DomainTextBox.Name = "DomainTextBox";
            this.DomainTextBox.Size = new System.Drawing.Size(252, 20);
            this.DomainTextBox.TabIndex = 5;
            // 
            // AuthMethodGroupBox
            // 
            this.AuthMethodGroupBox.Controls.Add(this.AuthMethodLayoutPanel);
            this.AuthMethodGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AuthMethodGroupBox.Location = new System.Drawing.Point(373, 33);
            this.AuthMethodGroupBox.Name = "AuthMethodGroupBox";
            this.AuthMethodGroupBox.Size = new System.Drawing.Size(365, 114);
            this.AuthMethodGroupBox.TabIndex = 1;
            this.AuthMethodGroupBox.TabStop = false;
            this.AuthMethodGroupBox.Text = "Authentication Method";
            // 
            // AuthMethodLayoutPanel
            // 
            this.AuthMethodLayoutPanel.ColumnCount = 2;
            this.AuthMethodLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.AuthMethodLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.AuthMethodLayoutPanel.Controls.Add(this.WNetAuthRadioButton, 0, 0);
            this.AuthMethodLayoutPanel.Controls.Add(this.DCOMAuthRadioButton, 1, 0);
            this.AuthMethodLayoutPanel.Controls.Add(this.label4, 0, 1);
            this.AuthMethodLayoutPanel.Controls.Add(this.label5, 0, 2);
            this.AuthMethodLayoutPanel.Controls.Add(this.LogonProviderCombo, 1, 1);
            this.AuthMethodLayoutPanel.Controls.Add(this.LogOnTypeComboBox, 1, 2);
            this.AuthMethodLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AuthMethodLayoutPanel.Location = new System.Drawing.Point(3, 16);
            this.AuthMethodLayoutPanel.Name = "AuthMethodLayoutPanel";
            this.AuthMethodLayoutPanel.RowCount = 3;
            this.AuthMethodLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.AuthMethodLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.AuthMethodLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.AuthMethodLayoutPanel.Size = new System.Drawing.Size(359, 95);
            this.AuthMethodLayoutPanel.TabIndex = 0;
            // 
            // WNetAuthRadioButton
            // 
            this.WNetAuthRadioButton.AutoSize = true;
            this.WNetAuthRadioButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.WNetAuthRadioButton.Location = new System.Drawing.Point(3, 3);
            this.WNetAuthRadioButton.Name = "WNetAuthRadioButton";
            this.WNetAuthRadioButton.Size = new System.Drawing.Size(94, 24);
            this.WNetAuthRadioButton.TabIndex = 0;
            this.WNetAuthRadioButton.TabStop = true;
            this.WNetAuthRadioButton.Text = "WNet Auth";
            this.WNetAuthRadioButton.UseVisualStyleBackColor = true;
            this.WNetAuthRadioButton.CheckedChanged += new System.EventHandler(this.WNetAuthRadioButton_CheckedChanged);
            // 
            // DCOMAuthRadioButton
            // 
            this.DCOMAuthRadioButton.AutoSize = true;
            this.DCOMAuthRadioButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DCOMAuthRadioButton.Location = new System.Drawing.Point(103, 3);
            this.DCOMAuthRadioButton.Name = "DCOMAuthRadioButton";
            this.DCOMAuthRadioButton.Size = new System.Drawing.Size(253, 24);
            this.DCOMAuthRadioButton.TabIndex = 1;
            this.DCOMAuthRadioButton.TabStop = true;
            this.DCOMAuthRadioButton.Text = "DCOM Auth";
            this.DCOMAuthRadioButton.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Location = new System.Drawing.Point(3, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 32);
            this.label4.TabIndex = 2;
            this.label4.Text = "LogonProvider:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label5.Location = new System.Drawing.Point(3, 62);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 33);
            this.label5.TabIndex = 3;
            this.label5.Text = "LogOnType:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // LogonProviderCombo
            // 
            this.LogonProviderCombo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LogonProviderCombo.FormattingEnabled = true;
            this.LogonProviderCombo.Items.AddRange(new object[] {
            "Default",
            "WinNT40",
            "WinNT50",
            "Virtual"});
            this.LogonProviderCombo.Location = new System.Drawing.Point(103, 33);
            this.LogonProviderCombo.Name = "LogonProviderCombo";
            this.LogonProviderCombo.Size = new System.Drawing.Size(253, 21);
            this.LogonProviderCombo.TabIndex = 4;
            // 
            // LogOnTypeComboBox
            // 
            this.LogOnTypeComboBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LogOnTypeComboBox.FormattingEnabled = true;
            this.LogOnTypeComboBox.Items.AddRange(new object[] {
            "None",
            "Interactive",
            "Network",
            "Batch",
            "Service",
            "Unlock",
            "NetworkClearText",
            "NewCredentials"});
            this.LogOnTypeComboBox.Location = new System.Drawing.Point(103, 65);
            this.LogOnTypeComboBox.Name = "LogOnTypeComboBox";
            this.LogOnTypeComboBox.Size = new System.Drawing.Size(253, 21);
            this.LogOnTypeComboBox.TabIndex = 5;
            // 
            // TargetLayoutPanel
            // 
            this.TargetLayoutPanel.ColumnCount = 2;
            this.MainLayoutPanel.SetColumnSpan(this.TargetLayoutPanel, 2);
            this.TargetLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.TargetLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TargetLayoutPanel.Controls.Add(this.TargetTextBox, 1, 0);
            this.TargetLayoutPanel.Controls.Add(this.label6, 0, 0);
            this.TargetLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TargetLayoutPanel.Location = new System.Drawing.Point(3, 3);
            this.TargetLayoutPanel.Name = "TargetLayoutPanel";
            this.TargetLayoutPanel.RowCount = 1;
            this.TargetLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TargetLayoutPanel.Size = new System.Drawing.Size(735, 24);
            this.TargetLayoutPanel.TabIndex = 2;
            // 
            // TargetTextBox
            // 
            this.TargetTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TargetTextBox.Location = new System.Drawing.Point(103, 3);
            this.TargetTextBox.Name = "TargetTextBox";
            this.TargetTextBox.Size = new System.Drawing.Size(629, 20);
            this.TargetTextBox.TabIndex = 0;
            this.TargetTextBox.Text = "192.168.71.137";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label6.Location = new System.Drawing.Point(3, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(94, 24);
            this.label6.TabIndex = 1;
            this.label6.Text = "Target:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // TestsTabControl
            // 
            this.MainLayoutPanel.SetColumnSpan(this.TestsTabControl, 2);
            this.TestsTabControl.Controls.Add(this.ReadRegTestTab);
            this.TestsTabControl.Controls.Add(this.InitWindowsUpdateAgent);
            this.TestsTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TestsTabControl.Location = new System.Drawing.Point(3, 153);
            this.TestsTabControl.Name = "TestsTabControl";
            this.TestsTabControl.SelectedIndex = 0;
            this.TestsTabControl.Size = new System.Drawing.Size(735, 204);
            this.TestsTabControl.TabIndex = 3;
            // 
            // ReadRegTestTab
            // 
            this.ReadRegTestTab.BackColor = System.Drawing.SystemColors.Control;
            this.ReadRegTestTab.Controls.Add(this.RegKeyLayoutPanel);
            this.ReadRegTestTab.Location = new System.Drawing.Point(4, 22);
            this.ReadRegTestTab.Name = "ReadRegTestTab";
            this.ReadRegTestTab.Padding = new System.Windows.Forms.Padding(3);
            this.ReadRegTestTab.Size = new System.Drawing.Size(727, 178);
            this.ReadRegTestTab.TabIndex = 0;
            this.ReadRegTestTab.Text = "Read A Registry Key";
            // 
            // RegKeyLayoutPanel
            // 
            this.RegKeyLayoutPanel.ColumnCount = 2;
            this.RegKeyLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.RegKeyLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.RegKeyLayoutPanel.Controls.Add(this.RootKeyCombo, 1, 0);
            this.RegKeyLayoutPanel.Controls.Add(this.label7, 0, 0);
            this.RegKeyLayoutPanel.Controls.Add(this.SubRegKeyGroupBox, 0, 1);
            this.RegKeyLayoutPanel.Controls.Add(this.RegKeyResultGroupBox, 0, 2);
            this.RegKeyLayoutPanel.Controls.Add(this.TestRegistryKeyButton, 1, 2);
            this.RegKeyLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RegKeyLayoutPanel.Location = new System.Drawing.Point(3, 3);
            this.RegKeyLayoutPanel.Name = "RegKeyLayoutPanel";
            this.RegKeyLayoutPanel.RowCount = 3;
            this.RegKeyLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.RegKeyLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.RegKeyLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.RegKeyLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.RegKeyLayoutPanel.Size = new System.Drawing.Size(721, 172);
            this.RegKeyLayoutPanel.TabIndex = 0;
            // 
            // RootKeyCombo
            // 
            this.RootKeyCombo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RootKeyCombo.FormattingEnabled = true;
            this.RootKeyCombo.Items.AddRange(new object[] {
            "ClassesRoot",
            "CurrentConfig",
            "CurrentUser",
            "LocalMachine",
            "Users"});
            this.RootKeyCombo.Location = new System.Drawing.Point(363, 3);
            this.RootKeyCombo.Name = "RootKeyCombo";
            this.RootKeyCombo.Size = new System.Drawing.Size(355, 21);
            this.RootKeyCombo.TabIndex = 2;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label7.Location = new System.Drawing.Point(3, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(354, 30);
            this.label7.TabIndex = 0;
            this.label7.Text = "Root Key:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // SubRegKeyGroupBox
            // 
            this.RegKeyLayoutPanel.SetColumnSpan(this.SubRegKeyGroupBox, 2);
            this.SubRegKeyGroupBox.Controls.Add(this.SubRegKeyTextBox);
            this.SubRegKeyGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SubRegKeyGroupBox.Location = new System.Drawing.Point(3, 33);
            this.SubRegKeyGroupBox.Name = "SubRegKeyGroupBox";
            this.SubRegKeyGroupBox.Size = new System.Drawing.Size(715, 65);
            this.SubRegKeyGroupBox.TabIndex = 3;
            this.SubRegKeyGroupBox.TabStop = false;
            this.SubRegKeyGroupBox.Text = "Sub Registry Key";
            // 
            // SubRegKeyTextBox
            // 
            this.SubRegKeyTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SubRegKeyTextBox.Location = new System.Drawing.Point(3, 16);
            this.SubRegKeyTextBox.Name = "SubRegKeyTextBox";
            this.SubRegKeyTextBox.Size = new System.Drawing.Size(709, 46);
            this.SubRegKeyTextBox.TabIndex = 0;
            this.SubRegKeyTextBox.Text = "";
            // 
            // RegKeyResultGroupBox
            // 
            this.RegKeyResultGroupBox.Controls.Add(this.RegKeyReadtextBox);
            this.RegKeyResultGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RegKeyResultGroupBox.Location = new System.Drawing.Point(3, 104);
            this.RegKeyResultGroupBox.Name = "RegKeyResultGroupBox";
            this.RegKeyResultGroupBox.Size = new System.Drawing.Size(354, 65);
            this.RegKeyResultGroupBox.TabIndex = 4;
            this.RegKeyResultGroupBox.TabStop = false;
            this.RegKeyResultGroupBox.Text = "Result";
            // 
            // RegKeyReadtextBox
            // 
            this.RegKeyReadtextBox.BackColor = System.Drawing.Color.White;
            this.RegKeyReadtextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RegKeyReadtextBox.Location = new System.Drawing.Point(3, 16);
            this.RegKeyReadtextBox.Name = "RegKeyReadtextBox";
            this.RegKeyReadtextBox.ReadOnly = true;
            this.RegKeyReadtextBox.Size = new System.Drawing.Size(348, 46);
            this.RegKeyReadtextBox.TabIndex = 0;
            this.RegKeyReadtextBox.Text = "";
            // 
            // TestRegistryKeyButton
            // 
            this.TestRegistryKeyButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TestRegistryKeyButton.Location = new System.Drawing.Point(363, 104);
            this.TestRegistryKeyButton.Name = "TestRegistryKeyButton";
            this.TestRegistryKeyButton.Size = new System.Drawing.Size(355, 65);
            this.TestRegistryKeyButton.TabIndex = 5;
            this.TestRegistryKeyButton.Text = "GO!";
            this.TestRegistryKeyButton.UseVisualStyleBackColor = true;
            this.TestRegistryKeyButton.Click += new System.EventHandler(this.TestRegistryKeyButton_Click);
            // 
            // InitWindowsUpdateAgent
            // 
            this.InitWindowsUpdateAgent.BackColor = System.Drawing.SystemColors.Control;
            this.InitWindowsUpdateAgent.Controls.Add(this.WinUpdatesTestLayoutPanel);
            this.InitWindowsUpdateAgent.Location = new System.Drawing.Point(4, 22);
            this.InitWindowsUpdateAgent.Name = "InitWindowsUpdateAgent";
            this.InitWindowsUpdateAgent.Padding = new System.Windows.Forms.Padding(3);
            this.InitWindowsUpdateAgent.Size = new System.Drawing.Size(727, 178);
            this.InitWindowsUpdateAgent.TabIndex = 1;
            this.InitWindowsUpdateAgent.Text = "Init Windows Update Agent";
            // 
            // WinUpdatesTestLayoutPanel
            // 
            this.WinUpdatesTestLayoutPanel.ColumnCount = 2;
            this.WinUpdatesTestLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.WinUpdatesTestLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.WinUpdatesTestLayoutPanel.Controls.Add(this.WinUpdatesTestGOButton, 1, 0);
            this.WinUpdatesTestLayoutPanel.Controls.Add(this.WinUpdateTestResultGroupBox, 0, 1);
            this.WinUpdatesTestLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.WinUpdatesTestLayoutPanel.Location = new System.Drawing.Point(3, 3);
            this.WinUpdatesTestLayoutPanel.Name = "WinUpdatesTestLayoutPanel";
            this.WinUpdatesTestLayoutPanel.RowCount = 2;
            this.WinUpdatesTestLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.WinUpdatesTestLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.WinUpdatesTestLayoutPanel.Size = new System.Drawing.Size(721, 172);
            this.WinUpdatesTestLayoutPanel.TabIndex = 0;
            // 
            // WinUpdatesTestGOButton
            // 
            this.WinUpdatesTestGOButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.WinUpdatesTestGOButton.Location = new System.Drawing.Point(363, 3);
            this.WinUpdatesTestGOButton.Name = "WinUpdatesTestGOButton";
            this.WinUpdatesTestGOButton.Size = new System.Drawing.Size(355, 80);
            this.WinUpdatesTestGOButton.TabIndex = 0;
            this.WinUpdatesTestGOButton.Text = "GO!";
            this.WinUpdatesTestGOButton.UseVisualStyleBackColor = true;
            this.WinUpdatesTestGOButton.Click += new System.EventHandler(this.WinUpdatesTestGOButton_Click);
            // 
            // WinUpdateTestResultGroupBox
            // 
            this.WinUpdatesTestLayoutPanel.SetColumnSpan(this.WinUpdateTestResultGroupBox, 2);
            this.WinUpdateTestResultGroupBox.Controls.Add(this.WinUpdateTestTextBox);
            this.WinUpdateTestResultGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.WinUpdateTestResultGroupBox.Location = new System.Drawing.Point(3, 89);
            this.WinUpdateTestResultGroupBox.Name = "WinUpdateTestResultGroupBox";
            this.WinUpdateTestResultGroupBox.Size = new System.Drawing.Size(715, 80);
            this.WinUpdateTestResultGroupBox.TabIndex = 1;
            this.WinUpdateTestResultGroupBox.TabStop = false;
            this.WinUpdateTestResultGroupBox.Text = "Results";
            // 
            // WinUpdateTestTextBox
            // 
            this.WinUpdateTestTextBox.BackColor = System.Drawing.Color.White;
            this.WinUpdateTestTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.WinUpdateTestTextBox.Location = new System.Drawing.Point(3, 16);
            this.WinUpdateTestTextBox.Name = "WinUpdateTestTextBox";
            this.WinUpdateTestTextBox.ReadOnly = true;
            this.WinUpdateTestTextBox.Size = new System.Drawing.Size(709, 61);
            this.WinUpdateTestTextBox.TabIndex = 0;
            this.WinUpdateTestTextBox.Text = "";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(741, 360);
            this.Controls.Add(this.MainLayoutPanel);
            this.Name = "MainForm";
            this.Text = "WinAuth Test App v1.0";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.MainLayoutPanel.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.CredsLayoutPanel.ResumeLayout(false);
            this.CredsLayoutPanel.PerformLayout();
            this.AuthMethodGroupBox.ResumeLayout(false);
            this.AuthMethodLayoutPanel.ResumeLayout(false);
            this.AuthMethodLayoutPanel.PerformLayout();
            this.TargetLayoutPanel.ResumeLayout(false);
            this.TargetLayoutPanel.PerformLayout();
            this.TestsTabControl.ResumeLayout(false);
            this.ReadRegTestTab.ResumeLayout(false);
            this.RegKeyLayoutPanel.ResumeLayout(false);
            this.RegKeyLayoutPanel.PerformLayout();
            this.SubRegKeyGroupBox.ResumeLayout(false);
            this.RegKeyResultGroupBox.ResumeLayout(false);
            this.InitWindowsUpdateAgent.ResumeLayout(false);
            this.WinUpdatesTestLayoutPanel.ResumeLayout(false);
            this.WinUpdateTestResultGroupBox.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel MainLayoutPanel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TableLayoutPanel CredsLayoutPanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox UsernameTextBox;
        private System.Windows.Forms.TextBox PasswordTextBox;
        private System.Windows.Forms.TextBox DomainTextBox;
        private System.Windows.Forms.GroupBox AuthMethodGroupBox;
        private System.Windows.Forms.TableLayoutPanel AuthMethodLayoutPanel;
        private System.Windows.Forms.RadioButton WNetAuthRadioButton;
        private System.Windows.Forms.RadioButton DCOMAuthRadioButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox LogonProviderCombo;
        private System.Windows.Forms.ComboBox LogOnTypeComboBox;
        private System.Windows.Forms.TableLayoutPanel TargetLayoutPanel;
        private System.Windows.Forms.TextBox TargetTextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TabControl TestsTabControl;
        private System.Windows.Forms.TabPage ReadRegTestTab;
        private System.Windows.Forms.TabPage InitWindowsUpdateAgent;
        private System.Windows.Forms.TableLayoutPanel RegKeyLayoutPanel;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox RootKeyCombo;
        private System.Windows.Forms.GroupBox SubRegKeyGroupBox;
        private System.Windows.Forms.RichTextBox SubRegKeyTextBox;
        private System.Windows.Forms.GroupBox RegKeyResultGroupBox;
        private System.Windows.Forms.Button TestRegistryKeyButton;
        private System.Windows.Forms.RichTextBox RegKeyReadtextBox;
        private System.Windows.Forms.TableLayoutPanel WinUpdatesTestLayoutPanel;
        private System.Windows.Forms.Button WinUpdatesTestGOButton;
        private System.Windows.Forms.GroupBox WinUpdateTestResultGroupBox;
        private System.Windows.Forms.RichTextBox WinUpdateTestTextBox;


    }
}

