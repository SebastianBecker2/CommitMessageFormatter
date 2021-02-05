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
            this.ChbShift = new System.Windows.Forms.CheckBox();
            this.BtnNewHotkey = new System.Windows.Forms.Button();
            this.LblCurrentButton = new System.Windows.Forms.Label();
            this.ChbWindows = new System.Windows.Forms.CheckBox();
            this.ChbAlt = new System.Windows.Forms.CheckBox();
            this.ChbControl = new System.Windows.Forms.CheckBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.pibSeparator = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.pibForeground = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pibBackground = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pibSeparator)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pibForeground)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pibBackground)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnOkay
            // 
            this.BtnOkay.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnOkay.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.BtnOkay.Location = new System.Drawing.Point(114, 184);
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
            this.BtnCancel.Location = new System.Drawing.Point(195, 184);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(75, 23);
            this.BtnCancel.TabIndex = 1;
            this.BtnCancel.Text = "Cancel";
            this.BtnCancel.UseVisualStyleBackColor = true;
            // 
            // ChbShift
            // 
            this.ChbShift.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.ChbShift.AutoSize = true;
            this.ChbShift.Location = new System.Drawing.Point(27, 22);
            this.ChbShift.Name = "ChbShift";
            this.ChbShift.Size = new System.Drawing.Size(50, 19);
            this.ChbShift.TabIndex = 2;
            this.ChbShift.Text = "Shift";
            this.ChbShift.UseVisualStyleBackColor = true;
            // 
            // BtnNewHotkey
            // 
            this.BtnNewHotkey.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.BtnNewHotkey.Location = new System.Drawing.Point(134, 68);
            this.BtnNewHotkey.Name = "BtnNewHotkey";
            this.BtnNewHotkey.Size = new System.Drawing.Size(75, 23);
            this.BtnNewHotkey.TabIndex = 4;
            this.BtnNewHotkey.Text = "Assign new hotkey";
            this.BtnNewHotkey.UseVisualStyleBackColor = true;
            this.BtnNewHotkey.Click += new System.EventHandler(this.BtnNewHotkey_Click);
            // 
            // LblCurrentButton
            // 
            this.LblCurrentButton.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.LblCurrentButton.AutoSize = true;
            this.LblCurrentButton.Location = new System.Drawing.Point(121, 35);
            this.LblCurrentButton.Name = "LblCurrentButton";
            this.LblCurrentButton.Size = new System.Drawing.Size(101, 15);
            this.LblCurrentButton.TabIndex = 3;
            this.LblCurrentButton.Text = "Hotkey to format:\r\n";
            this.LblCurrentButton.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // ChbWindows
            // 
            this.ChbWindows.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.ChbWindows.AutoSize = true;
            this.ChbWindows.Location = new System.Drawing.Point(27, 97);
            this.ChbWindows.Name = "ChbWindows";
            this.ChbWindows.Size = new System.Drawing.Size(75, 19);
            this.ChbWindows.TabIndex = 2;
            this.ChbWindows.Text = "Windows";
            this.ChbWindows.UseVisualStyleBackColor = true;
            // 
            // ChbAlt
            // 
            this.ChbAlt.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.ChbAlt.AutoSize = true;
            this.ChbAlt.Location = new System.Drawing.Point(27, 72);
            this.ChbAlt.Name = "ChbAlt";
            this.ChbAlt.Size = new System.Drawing.Size(41, 19);
            this.ChbAlt.TabIndex = 2;
            this.ChbAlt.Text = "Alt";
            this.ChbAlt.UseVisualStyleBackColor = true;
            // 
            // ChbControl
            // 
            this.ChbControl.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.ChbControl.AutoSize = true;
            this.ChbControl.Location = new System.Drawing.Point(27, 47);
            this.ChbControl.Name = "ChbControl";
            this.ChbControl.Size = new System.Drawing.Size(66, 19);
            this.ChbControl.TabIndex = 2;
            this.ChbControl.Text = "Control";
            this.ChbControl.UseVisualStyleBackColor = true;
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(258, 166);
            this.tabControl1.TabIndex = 4;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.BtnNewHotkey);
            this.tabPage1.Controls.Add(this.LblCurrentButton);
            this.tabPage1.Controls.Add(this.ChbControl);
            this.tabPage1.Controls.Add(this.ChbWindows);
            this.tabPage1.Controls.Add(this.ChbShift);
            this.tabPage1.Controls.Add(this.ChbAlt);
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(250, 138);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Hotkey";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.pibSeparator);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.pibForeground);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.pibBackground);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(250, 138);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Colors";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // pibSeparator
            // 
            this.pibSeparator.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.pibSeparator.BackColor = System.Drawing.Color.Black;
            this.pibSeparator.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pibSeparator.Location = new System.Drawing.Point(111, 84);
            this.pibSeparator.Name = "pibSeparator";
            this.pibSeparator.Size = new System.Drawing.Size(23, 23);
            this.pibSeparator.TabIndex = 5;
            this.pibSeparator.TabStop = false;
            this.pibSeparator.Click += new System.EventHandler(this.PictureBox_Click);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(45, 88);
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
            this.pibForeground.Location = new System.Drawing.Point(111, 55);
            this.pibForeground.Name = "pibForeground";
            this.pibForeground.Size = new System.Drawing.Size(23, 23);
            this.pibForeground.TabIndex = 3;
            this.pibForeground.TabStop = false;
            this.pibForeground.Click += new System.EventHandler(this.PictureBox_Click);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 59);
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
            this.pibBackground.Location = new System.Drawing.Point(111, 26);
            this.pibBackground.Name = "pibBackground";
            this.pibBackground.Size = new System.Drawing.Size(23, 23);
            this.pibBackground.TabIndex = 1;
            this.pibBackground.TabStop = false;
            this.pibBackground.Click += new System.EventHandler(this.PictureBox_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Background:";
            // 
            // ConfigDlg
            // 
            this.AcceptButton = this.BtnOkay;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.BtnCancel;
            this.ClientSize = new System.Drawing.Size(282, 219);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.BtnCancel);
            this.Controls.Add(this.BtnOkay);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ConfigDlg";
            this.Text = "Commit Message Formatter Configuration";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pibSeparator)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pibForeground)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pibBackground)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnOkay;
        private System.Windows.Forms.Button BtnCancel;
        private System.Windows.Forms.CheckBox ChbShift;
        private System.Windows.Forms.CheckBox ChbWindows;
        private System.Windows.Forms.CheckBox ChbAlt;
        private System.Windows.Forms.CheckBox ChbControl;
        private System.Windows.Forms.Label LblCurrentButton;
        private System.Windows.Forms.Button BtnNewHotkey;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.PictureBox pibSeparator;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pibForeground;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pibBackground;
        private System.Windows.Forms.Label label1;
    }
}
