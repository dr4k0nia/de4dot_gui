namespace de4dot_gui
{
    sealed partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.lbFilesToDeobfuscate = new System.Windows.Forms.ListBox();
            this.cbEnableAdvStrings = new System.Windows.Forms.CheckBox();
            this.gbStringDecryption = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnAddDecryptionMethod = new System.Windows.Forms.Button();
            this.tbDecryptionMethod = new System.Windows.Forms.TextBox();
            this.lbDecryptionMethods = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.comboDeobfMethod = new System.Windows.Forms.ComboBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.gbGeneral = new System.Windows.Forms.GroupBox();
            this.cbUse64Bit = new System.Windows.Forms.CheckBox();
            this.comboObfuscators = new System.Windows.Forms.ComboBox();
            this.cbForceObf = new System.Windows.Forms.CheckBox();
            this.cbNoRenaming = new System.Windows.Forms.CheckBox();
            this.btnDeobfuscate = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label3 = new System.Windows.Forms.Label();
            this.btnBrowese64 = new System.Windows.Forms.Button();
            this.tbDeobfPath64 = new System.Windows.Forms.TextBox();
            this.lbl_credits = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.tbDeobfPath = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuDeleteBtn = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.gbStringDecryption.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.gbGeneral.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.contextMenuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbFilesToDeobfuscate
            // 
            this.lbFilesToDeobfuscate.FormattingEnabled = true;
            this.lbFilesToDeobfuscate.Location = new System.Drawing.Point(8, 384);
            this.lbFilesToDeobfuscate.Name = "lbFilesToDeobfuscate";
            this.lbFilesToDeobfuscate.Size = new System.Drawing.Size(547, 121);
            this.lbFilesToDeobfuscate.TabIndex = 0;
            this.lbFilesToDeobfuscate.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lbFilesToDeobfuscate_MouseDown);
            // 
            // cbEnableAdvStrings
            // 
            this.cbEnableAdvStrings.AutoSize = true;
            this.cbEnableAdvStrings.Location = new System.Drawing.Point(6, 19);
            this.cbEnableAdvStrings.Name = "cbEnableAdvStrings";
            this.cbEnableAdvStrings.Size = new System.Drawing.Size(59, 17);
            this.cbEnableAdvStrings.TabIndex = 1;
            this.cbEnableAdvStrings.Text = "Enable";
            this.cbEnableAdvStrings.UseVisualStyleBackColor = true;
            this.cbEnableAdvStrings.CheckedChanged += new System.EventHandler(this.cbEnableAdvStrings_CheckedChanged);
            // 
            // gbStringDecryption
            // 
            this.gbStringDecryption.Controls.Add(this.label5);
            this.gbStringDecryption.Controls.Add(this.btnAddDecryptionMethod);
            this.gbStringDecryption.Controls.Add(this.tbDecryptionMethod);
            this.gbStringDecryption.Controls.Add(this.lbDecryptionMethods);
            this.gbStringDecryption.Controls.Add(this.label4);
            this.gbStringDecryption.Controls.Add(this.comboDeobfMethod);
            this.gbStringDecryption.Controls.Add(this.cbEnableAdvStrings);
            this.gbStringDecryption.Location = new System.Drawing.Point(6, 133);
            this.gbStringDecryption.Name = "gbStringDecryption";
            this.gbStringDecryption.Size = new System.Drawing.Size(547, 232);
            this.gbStringDecryption.TabIndex = 2;
            this.gbStringDecryption.TabStop = false;
            this.gbStringDecryption.Text = "Advanced String Decryption";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 50);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Decryption methods";
            // 
            // btnAddDecryptionMethod
            // 
            this.btnAddDecryptionMethod.Enabled = false;
            this.btnAddDecryptionMethod.Location = new System.Drawing.Point(479, 192);
            this.btnAddDecryptionMethod.Name = "btnAddDecryptionMethod";
            this.btnAddDecryptionMethod.Size = new System.Drawing.Size(58, 21);
            this.btnAddDecryptionMethod.TabIndex = 6;
            this.btnAddDecryptionMethod.Text = "Add";
            this.btnAddDecryptionMethod.UseVisualStyleBackColor = true;
            this.btnAddDecryptionMethod.Click += new System.EventHandler(this.btnAddDecryptionMethod_Click);
            // 
            // tbDecryptionMethod
            // 
            this.tbDecryptionMethod.Enabled = false;
            this.tbDecryptionMethod.Location = new System.Drawing.Point(6, 193);
            this.tbDecryptionMethod.Name = "tbDecryptionMethod";
            this.tbDecryptionMethod.Size = new System.Drawing.Size(466, 20);
            this.tbDecryptionMethod.TabIndex = 5;
            // 
            // lbDecryptionMethods
            // 
            this.lbDecryptionMethods.Enabled = false;
            this.lbDecryptionMethods.FormattingEnabled = true;
            this.lbDecryptionMethods.Location = new System.Drawing.Point(6, 66);
            this.lbDecryptionMethods.Name = "lbDecryptionMethods";
            this.lbDecryptionMethods.Size = new System.Drawing.Size(531, 121);
            this.lbDecryptionMethods.TabIndex = 4;
            this.lbDecryptionMethods.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lbDecryptionMethods_MouseDown);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(71, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "deobfuscation method";
            // 
            // comboDeobfMethod
            // 
            this.comboDeobfMethod.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboDeobfMethod.Enabled = false;
            this.comboDeobfMethod.FormattingEnabled = true;
            this.comboDeobfMethod.Items.AddRange(new object[] {
            "delegate",
            "emulation"});
            this.comboDeobfMethod.Location = new System.Drawing.Point(189, 17);
            this.comboDeobfMethod.Name = "comboDeobfMethod";
            this.comboDeobfMethod.Size = new System.Drawing.Size(121, 21);
            this.comboDeobfMethod.TabIndex = 2;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(571, 562);
            this.tabControl1.TabIndex = 3;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.gbGeneral);
            this.tabPage1.Controls.Add(this.btnDeobfuscate);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.lbFilesToDeobfuscate);
            this.tabPage1.Controls.Add(this.gbStringDecryption);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(563, 536);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Main";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // gbGeneral
            // 
            this.gbGeneral.Controls.Add(this.cbUse64Bit);
            this.gbGeneral.Controls.Add(this.comboObfuscators);
            this.gbGeneral.Controls.Add(this.cbForceObf);
            this.gbGeneral.Controls.Add(this.cbNoRenaming);
            this.gbGeneral.Location = new System.Drawing.Point(6, 6);
            this.gbGeneral.Name = "gbGeneral";
            this.gbGeneral.Size = new System.Drawing.Size(547, 121);
            this.gbGeneral.TabIndex = 5;
            this.gbGeneral.TabStop = false;
            this.gbGeneral.Text = "General Settings";
            // 
            // cbUse64Bit
            // 
            this.cbUse64Bit.AutoSize = true;
            this.cbUse64Bit.Location = new System.Drawing.Point(6, 66);
            this.cbUse64Bit.Name = "cbUse64Bit";
            this.cbUse64Bit.Size = new System.Drawing.Size(79, 17);
            this.cbUse64Bit.TabIndex = 9;
            this.cbUse64Bit.Text = "64bit Mode";
            this.cbUse64Bit.UseVisualStyleBackColor = true;
            // 
            // comboObfuscators
            // 
            this.comboObfuscators.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboObfuscators.Enabled = false;
            this.comboObfuscators.FormattingEnabled = true;
            this.comboObfuscators.Items.AddRange(new object[] {
            "Unknown",
            "Agile.NET",
            "Babel.NET",
            "CodeFort",
            "CodeVeil",
            "CodeWall",
            "Confuser",
            "Crypto Obfuscator",
            "DeepSea",
            "Dotfuscator",
            ".NET Reactor 3",
            ".NET Reactor 4",
            "Eazfuscator.NET",
            "Goliath.NET",
            "ILProtector",
            "MaxtoCode",
            "MPress",
            "Rummage",
            "Skater.NET",
            "SmartAssembly",
            "Spices.NET",
            "Xenocode"});
            this.comboObfuscators.Location = new System.Drawing.Point(169, 41);
            this.comboObfuscators.Name = "comboObfuscators";
            this.comboObfuscators.Size = new System.Drawing.Size(197, 21);
            this.comboObfuscators.TabIndex = 8;
            // 
            // cbForceObf
            // 
            this.cbForceObf.AutoSize = true;
            this.cbForceObf.Location = new System.Drawing.Point(6, 43);
            this.cbForceObf.Name = "cbForceObf";
            this.cbForceObf.Size = new System.Drawing.Size(157, 17);
            this.cbForceObf.TabIndex = 1;
            this.cbForceObf.Text = "Force Obfuscator Detection";
            this.cbForceObf.UseVisualStyleBackColor = true;
            this.cbForceObf.CheckedChanged += new System.EventHandler(this.cbForceObf_CheckedChanged);
            // 
            // cbNoRenaming
            // 
            this.cbNoRenaming.AutoSize = true;
            this.cbNoRenaming.Location = new System.Drawing.Point(6, 20);
            this.cbNoRenaming.Name = "cbNoRenaming";
            this.cbNoRenaming.Size = new System.Drawing.Size(112, 17);
            this.cbNoRenaming.TabIndex = 0;
            this.cbNoRenaming.Text = "Disable Renaming";
            this.cbNoRenaming.UseVisualStyleBackColor = true;
            // 
            // btnDeobfuscate
            // 
            this.btnDeobfuscate.Location = new System.Drawing.Point(473, 507);
            this.btnDeobfuscate.Name = "btnDeobfuscate";
            this.btnDeobfuscate.Size = new System.Drawing.Size(82, 23);
            this.btnDeobfuscate.TabIndex = 4;
            this.btnDeobfuscate.Text = "Deobfuscate";
            this.btnDeobfuscate.UseVisualStyleBackColor = true;
            this.btnDeobfuscate.Click += new System.EventHandler(this.btnDeobfuscate_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 368);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Files to deobfuscate";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.btnBrowese64);
            this.tabPage2.Controls.Add(this.tbDeobfPath64);
            this.tabPage2.Controls.Add(this.lbl_credits);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.btnBrowse);
            this.tabPage2.Controls.Add(this.tbDeobfPath);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(563, 536);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Settings";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Path to de4dot (64bit)";
            // 
            // btnBrowese64
            // 
            this.btnBrowese64.Location = new System.Drawing.Point(494, 75);
            this.btnBrowese64.Name = "btnBrowese64";
            this.btnBrowese64.Size = new System.Drawing.Size(63, 21);
            this.btnBrowese64.TabIndex = 5;
            this.btnBrowese64.Text = "Browse...";
            this.btnBrowese64.UseVisualStyleBackColor = true;
            this.btnBrowese64.Click += new System.EventHandler(this.btnBrowse64_Click);
            // 
            // tbDeobfPath64
            // 
            this.tbDeobfPath64.Location = new System.Drawing.Point(8, 75);
            this.tbDeobfPath64.Name = "tbDeobfPath64";
            this.tbDeobfPath64.ReadOnly = true;
            this.tbDeobfPath64.Size = new System.Drawing.Size(482, 20);
            this.tbDeobfPath64.TabIndex = 4;
            this.tbDeobfPath64.Text = "de4dot64.exe";
            // 
            // lbl_credits
            // 
            this.lbl_credits.AutoSize = true;
            this.lbl_credits.Location = new System.Drawing.Point(214, 466);
            this.lbl_credits.Name = "lbl_credits";
            this.lbl_credits.Size = new System.Drawing.Size(127, 65);
            this.lbl_credits.TabIndex = 3;
            this.lbl_credits.Text = "Tool made by drakonia\r\n\r\nCredits:\r\n\r\n0xd4d - Creator of de4dot";
            this.lbl_credits.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Path to de4dot";
            // 
            // btnBrowse
            // 
            this.btnBrowse.Location = new System.Drawing.Point(494, 35);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(63, 21);
            this.btnBrowse.TabIndex = 1;
            this.btnBrowse.Text = "Browse...";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // tbDeobfPath
            // 
            this.tbDeobfPath.Location = new System.Drawing.Point(9, 36);
            this.tbDeobfPath.Name = "tbDeobfPath";
            this.tbDeobfPath.ReadOnly = true;
            this.tbDeobfPath.Size = new System.Drawing.Size(482, 20);
            this.tbDeobfPath.TabIndex = 0;
            this.tbDeobfPath.Text = "de4dot.exe";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuDeleteBtn});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(108, 26);
            // 
            // toolStripMenuDeleteBtn
            // 
            this.toolStripMenuDeleteBtn.Image = global::de4dot_gui.Properties.Resources.icons8_delete_48;
            this.toolStripMenuDeleteBtn.Name = "toolStripMenuDeleteBtn";
            this.toolStripMenuDeleteBtn.Size = new System.Drawing.Size(107, 22);
            this.toolStripMenuDeleteBtn.Text = "Delete";
            this.toolStripMenuDeleteBtn.Click += new System.EventHandler(this.toolStripMenuDeleteBtn_Click);
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1});
            this.contextMenuStrip2.Name = "contextMenuStrip1";
            this.contextMenuStrip2.Size = new System.Drawing.Size(108, 26);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Image = global::de4dot_gui.Properties.Resources.icons8_delete_48;
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(107, 22);
            this.toolStripMenuItem1.Text = "Delete";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(571, 562);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "de4dot GUI Utility";
            this.gbStringDecryption.ResumeLayout(false);
            this.gbStringDecryption.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.gbGeneral.ResumeLayout(false);
            this.gbGeneral.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.contextMenuStrip2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lbFilesToDeobfuscate;
        private System.Windows.Forms.CheckBox cbEnableAdvStrings;
        private System.Windows.Forms.GroupBox gbStringDecryption;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuDeleteBtn;
        private System.Windows.Forms.ComboBox comboDeobfMethod;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.TextBox tbDeobfPath;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_credits;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnBrowese64;
        private System.Windows.Forms.TextBox tbDeobfPath64;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnDeobfuscate;
        private System.Windows.Forms.ListBox lbDecryptionMethods;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnAddDecryptionMethod;
        private System.Windows.Forms.TextBox tbDecryptionMethod;
        private System.Windows.Forms.GroupBox gbGeneral;
        private System.Windows.Forms.ComboBox comboObfuscators;
        private System.Windows.Forms.CheckBox cbForceObf;
        private System.Windows.Forms.CheckBox cbNoRenaming;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.CheckBox cbUse64Bit;
    }
}

