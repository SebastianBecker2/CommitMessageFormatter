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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.BtnNewHotkey = new System.Windows.Forms.Button();
            this.LblCurrentButton = new System.Windows.Forms.Label();
            this.ChbWindows = new System.Windows.Forms.CheckBox();
            this.ChbAlt = new System.Windows.Forms.CheckBox();
            this.ChbControl = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // BtnOkay
            // 
            this.BtnOkay.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnOkay.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.BtnOkay.Location = new System.Drawing.Point(61, 145);
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
            this.BtnCancel.Location = new System.Drawing.Point(142, 145);
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
            this.ChbShift.Location = new System.Drawing.Point(6, 22);
            this.ChbShift.Name = "ChbShift";
            this.ChbShift.Size = new System.Drawing.Size(50, 19);
            this.ChbShift.TabIndex = 2;
            this.ChbShift.Text = "Shift";
            this.ChbShift.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.BtnNewHotkey);
            this.groupBox1.Controls.Add(this.LblCurrentButton);
            this.groupBox1.Controls.Add(this.ChbWindows);
            this.groupBox1.Controls.Add(this.ChbAlt);
            this.groupBox1.Controls.Add(this.ChbControl);
            this.groupBox1.Controls.Add(this.ChbShift);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(205, 127);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Hotkey to show";
            // 
            // BtnNewHotkey
            // 
            this.BtnNewHotkey.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.BtnNewHotkey.Location = new System.Drawing.Point(106, 68);
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
            this.LblCurrentButton.Location = new System.Drawing.Point(100, 35);
            this.LblCurrentButton.Name = "LblCurrentButton";
            this.LblCurrentButton.Size = new System.Drawing.Size(87, 15);
            this.LblCurrentButton.TabIndex = 3;
            this.LblCurrentButton.Text = "Hotkey button:\r\n";
            this.LblCurrentButton.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // ChbWindows
            // 
            this.ChbWindows.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.ChbWindows.AutoSize = true;
            this.ChbWindows.Location = new System.Drawing.Point(6, 97);
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
            this.ChbAlt.Location = new System.Drawing.Point(6, 72);
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
            this.ChbControl.Location = new System.Drawing.Point(6, 47);
            this.ChbControl.Name = "ChbControl";
            this.ChbControl.Size = new System.Drawing.Size(66, 19);
            this.ChbControl.TabIndex = 2;
            this.ChbControl.Text = "Control";
            this.ChbControl.UseVisualStyleBackColor = true;
            // 
            // ConfigDlg
            // 
            this.AcceptButton = this.BtnOkay;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.BtnCancel;
            this.ClientSize = new System.Drawing.Size(229, 180);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.BtnCancel);
            this.Controls.Add(this.BtnOkay);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ConfigDlg";
            this.Text = "Commit Message Formatter Configuration";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnOkay;
        private System.Windows.Forms.Button BtnCancel;
        private System.Windows.Forms.CheckBox ChbShift;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox ChbWindows;
        private System.Windows.Forms.CheckBox ChbAlt;
        private System.Windows.Forms.CheckBox ChbControl;
        private System.Windows.Forms.Label LblCurrentButton;
        private System.Windows.Forms.Button BtnNewHotkey;
    }
}
