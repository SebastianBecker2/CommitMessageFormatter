namespace CommitMessageFormatter
{

    partial class ConfigDlg
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConfigDlg));
            this.BtnOkay = new System.Windows.Forms.Button();
            this.BtnCancel = new System.Windows.Forms.Button();
            this.BtnNewHotkey = new System.Windows.Forms.Button();
            this.LblCurrentButton = new System.Windows.Forms.Label();
            this.NudLineCount = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.NudFontSize = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.CmbFontName = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.pibSeparator = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.pibForeground = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pibBackground = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.NudHeaderToBodySeparatorLines = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.NudMaxBodyLength = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.NudMaxHeaderLength = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.NudLineCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NudFontSize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pibSeparator)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pibForeground)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pibBackground)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NudHeaderToBodySeparatorLines)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NudMaxBodyLength)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NudMaxHeaderLength)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // BtnOkay
            // 
            this.BtnOkay.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnOkay.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.BtnOkay.Location = new System.Drawing.Point(288, 267);
            this.BtnOkay.Name = "BtnOkay";
            this.BtnOkay.Size = new System.Drawing.Size(75, 23);
            this.BtnOkay.TabIndex = 0;
            this.BtnOkay.Text = "OK";
            this.BtnOkay.UseVisualStyleBackColor = true;
            this.BtnOkay.Click += new System.EventHandler(this.BtnOkay_Click);
            // 
            // BtnCancel
            // 
            this.BtnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BtnCancel.Location = new System.Drawing.Point(369, 267);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(75, 23);
            this.BtnCancel.TabIndex = 1;
            this.BtnCancel.Text = "Cancel";
            this.BtnCancel.UseVisualStyleBackColor = true;
            // 
            // BtnNewHotkey
            // 
            this.BtnNewHotkey.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtnNewHotkey.Location = new System.Drawing.Point(46, 70);
            this.BtnNewHotkey.Name = "BtnNewHotkey";
            this.BtnNewHotkey.Size = new System.Drawing.Size(75, 23);
            this.BtnNewHotkey.TabIndex = 4;
            this.BtnNewHotkey.Text = "Assign new hotkey";
            this.BtnNewHotkey.UseVisualStyleBackColor = true;
            this.BtnNewHotkey.Click += new System.EventHandler(this.BtnNewHotkey_Click);
            // 
            // LblCurrentButton
            // 
            this.LblCurrentButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LblCurrentButton.Location = new System.Drawing.Point(3, 0);
            this.LblCurrentButton.Name = "LblCurrentButton";
            this.LblCurrentButton.Size = new System.Drawing.Size(162, 61);
            this.LblCurrentButton.TabIndex = 3;
            this.LblCurrentButton.Text = "Hotkey to format:\r\n";
            this.LblCurrentButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // NudLineCount
            // 
            this.NudLineCount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.NudLineCount.Location = new System.Drawing.Point(210, 65);
            this.NudLineCount.Maximum = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.NudLineCount.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NudLineCount.Name = "NudLineCount";
            this.NudLineCount.Size = new System.Drawing.Size(41, 23);
            this.NudLineCount.TabIndex = 11;
            this.NudLineCount.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(138, 69);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 15);
            this.label6.TabIndex = 10;
            this.label6.Text = "Line count:";
            // 
            // NudFontSize
            // 
            this.NudFontSize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.NudFontSize.Location = new System.Drawing.Point(84, 65);
            this.NudFontSize.Maximum = new decimal(new int[] {
            27,
            0,
            0,
            0});
            this.NudFontSize.Minimum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.NudFontSize.Name = "NudFontSize";
            this.NudFontSize.Size = new System.Drawing.Size(39, 23);
            this.NudFontSize.TabIndex = 9;
            this.NudFontSize.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 69);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 15);
            this.label5.TabIndex = 8;
            this.label5.Text = "Font size:";
            // 
            // CmbFontName
            // 
            this.CmbFontName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel5.SetColumnSpan(this.CmbFontName, 3);
            this.CmbFontName.FormattingEnabled = true;
            this.CmbFontName.Location = new System.Drawing.Point(84, 14);
            this.CmbFontName.Name = "CmbFontName";
            this.CmbFontName.Size = new System.Drawing.Size(167, 23);
            this.CmbFontName.TabIndex = 7;
            this.CmbFontName.DropDown += new System.EventHandler(this.CmbFontName_DropDown);
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 15);
            this.label4.TabIndex = 6;
            this.label4.Text = "Font name:";
            // 
            // pibSeparator
            // 
            this.pibSeparator.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.pibSeparator.BackColor = System.Drawing.Color.Black;
            this.pibSeparator.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pibSeparator.Location = new System.Drawing.Point(110, 74);
            this.pibSeparator.Name = "pibSeparator";
            this.pibSeparator.Size = new System.Drawing.Size(23, 23);
            this.pibSeparator.TabIndex = 5;
            this.pibSeparator.TabStop = false;
            this.pibSeparator.Click += new System.EventHandler(this.PictureBox_Click);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(44, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Separator:";
            // 
            // pibForeground
            // 
            this.pibForeground.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.pibForeground.BackColor = System.Drawing.Color.Black;
            this.pibForeground.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pibForeground.Location = new System.Drawing.Point(110, 39);
            this.pibForeground.Name = "pibForeground";
            this.pibForeground.Size = new System.Drawing.Size(23, 23);
            this.pibForeground.TabIndex = 3;
            this.pibForeground.TabStop = false;
            this.pibForeground.Click += new System.EventHandler(this.PictureBox_Click);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Foreground:";
            // 
            // pibBackground
            // 
            this.pibBackground.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.pibBackground.BackColor = System.Drawing.Color.Black;
            this.pibBackground.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pibBackground.Location = new System.Drawing.Point(110, 5);
            this.pibBackground.Name = "pibBackground";
            this.pibBackground.Size = new System.Drawing.Size(23, 23);
            this.pibBackground.TabIndex = 1;
            this.pibBackground.TabStop = false;
            this.pibBackground.Click += new System.EventHandler(this.PictureBox_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Background:";
            // 
            // NudHeaderToBodySeparatorLines
            // 
            this.NudHeaderToBodySeparatorLines.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.NudHeaderToBodySeparatorLines.Location = new System.Drawing.Point(204, 73);
            this.NudHeaderToBodySeparatorLines.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.NudHeaderToBodySeparatorLines.Name = "NudHeaderToBodySeparatorLines";
            this.NudHeaderToBodySeparatorLines.Size = new System.Drawing.Size(45, 23);
            this.NudHeaderToBodySeparatorLines.TabIndex = 5;
            this.NudHeaderToBodySeparatorLines.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(27, 77);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(171, 15);
            this.label9.TabIndex = 4;
            this.label9.Text = "Header to body separator lines:";
            // 
            // NudMaxBodyLength
            // 
            this.NudMaxBodyLength.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.NudMaxBodyLength.Location = new System.Drawing.Point(204, 39);
            this.NudMaxBodyLength.Maximum = new decimal(new int[] {
            300,
            0,
            0,
            0});
            this.NudMaxBodyLength.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NudMaxBodyLength.Name = "NudMaxBodyLength";
            this.NudMaxBodyLength.Size = new System.Drawing.Size(45, 23);
            this.NudMaxBodyLength.TabIndex = 3;
            this.NudMaxBodyLength.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(66, 43);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(132, 15);
            this.label8.TabIndex = 2;
            this.label8.Text = "Maximum body length:";
            // 
            // NudMaxHeaderLength
            // 
            this.NudMaxHeaderLength.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.NudMaxHeaderLength.Location = new System.Drawing.Point(204, 5);
            this.NudMaxHeaderLength.Maximum = new decimal(new int[] {
            300,
            0,
            0,
            0});
            this.NudMaxHeaderLength.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NudMaxHeaderLength.Name = "NudMaxHeaderLength";
            this.NudMaxHeaderLength.Size = new System.Drawing.Size(45, 23);
            this.NudMaxHeaderLength.TabIndex = 1;
            this.NudMaxHeaderLength.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(57, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(141, 15);
            this.label7.TabIndex = 0;
            this.label7.Text = "Maximum header length:";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel1.Controls.Add(this.groupBox3, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.groupBox4, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.groupBox1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.groupBox2, 2, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 12);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(432, 249);
            this.tableLayoutPanel1.TabIndex = 5;
            // 
            // groupBox3
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.groupBox3, 2);
            this.groupBox3.Controls.Add(this.tableLayoutPanel5);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox3.Location = new System.Drawing.Point(172, 124);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(0);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(260, 125);
            this.groupBox3.TabIndex = 7;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Fonts";
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 4;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 32F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 32F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18F));
            this.tableLayoutPanel5.Controls.Add(this.label4, 0, 0);
            this.tableLayoutPanel5.Controls.Add(this.CmbFontName, 1, 0);
            this.tableLayoutPanel5.Controls.Add(this.label5, 0, 1);
            this.tableLayoutPanel5.Controls.Add(this.NudFontSize, 1, 1);
            this.tableLayoutPanel5.Controls.Add(this.label6, 2, 1);
            this.tableLayoutPanel5.Controls.Add(this.NudLineCount, 3, 1);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(3, 19);
            this.tableLayoutPanel5.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 2;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 49.99999F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.00002F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(254, 103);
            this.tableLayoutPanel5.TabIndex = 3;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.tableLayoutPanel4);
            this.groupBox4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox4.Location = new System.Drawing.Point(0, 124);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(0);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(172, 125);
            this.groupBox4.TabIndex = 7;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Colors";
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 2;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 65F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.tableLayoutPanel4.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel4.Controls.Add(this.label3, 0, 2);
            this.tableLayoutPanel4.Controls.Add(this.pibSeparator, 1, 2);
            this.tableLayoutPanel4.Controls.Add(this.pibForeground, 1, 1);
            this.tableLayoutPanel4.Controls.Add(this.pibBackground, 1, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(3, 19);
            this.tableLayoutPanel4.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 3;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(166, 103);
            this.tableLayoutPanel4.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.groupBox1, 2);
            this.groupBox1.Controls.Add(this.tableLayoutPanel2);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(258, 124);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Rules";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.Controls.Add(this.label7, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.NudMaxHeaderLength, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.NudMaxBodyLength, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.NudHeaderToBodySeparatorLines, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.label8, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.label9, 0, 2);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 19);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(252, 102);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tableLayoutPanel3);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(258, 0);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(174, 124);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Hotkey";
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Controls.Add(this.LblCurrentButton, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.BtnNewHotkey, 0, 1);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 19);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(168, 102);
            this.tableLayoutPanel3.TabIndex = 1;
            // 
            // ConfigDlg
            // 
            this.AcceptButton = this.BtnOkay;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.BtnCancel;
            this.ClientSize = new System.Drawing.Size(456, 302);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.BtnCancel);
            this.Controls.Add(this.BtnOkay);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ConfigDlg";
            this.Text = "Commit Message Formatter Configuration";
            ((System.ComponentModel.ISupportInitialize)(this.NudLineCount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NudFontSize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pibSeparator)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pibForeground)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pibBackground)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NudHeaderToBodySeparatorLines)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NudMaxBodyLength)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NudMaxHeaderLength)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel5.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnOkay;
        private System.Windows.Forms.Button BtnCancel;
        private System.Windows.Forms.Label LblCurrentButton;
        private System.Windows.Forms.Button BtnNewHotkey;
        private System.Windows.Forms.PictureBox pibSeparator;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pibForeground;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pibBackground;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox CmbFontName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown NudFontSize;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown NudLineCount;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown NudMaxHeaderLength;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown NudHeaderToBodySeparatorLines;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.NumericUpDown NudMaxBodyLength;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
    }
}
