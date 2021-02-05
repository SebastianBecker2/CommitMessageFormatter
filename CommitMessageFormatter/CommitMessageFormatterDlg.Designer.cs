
namespace CommitMessageFormatter
{
    partial class CommitMessageFormatterDlg
    {
        /// <summary>
        ///  Required designer variable.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CommitMessageFormatterDlg));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.LblStatus = new System.Windows.Forms.Label();
            this.RtbCommitMessage = new System.Windows.Forms.RichTextBox();
            this.TimClipboard = new System.Windows.Forms.Timer(this.components);
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.LblStatus, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.RtbCommitMessage, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(364, 131);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // LblStatus
            // 
            this.LblStatus.AutoSize = true;
            this.LblStatus.BackColor = System.Drawing.Color.Black;
            this.LblStatus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LblStatus.Font = new System.Drawing.Font("Consolas", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblStatus.ForeColor = System.Drawing.Color.DarkGray;
            this.LblStatus.Location = new System.Drawing.Point(0, 119);
            this.LblStatus.Margin = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.LblStatus.Name = "LblStatus";
            this.LblStatus.Size = new System.Drawing.Size(364, 12);
            this.LblStatus.TabIndex = 1;
            this.LblStatus.Text = "label1";
            this.LblStatus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // RtbCommitMessage
            // 
            this.RtbCommitMessage.BackColor = System.Drawing.Color.Black;
            this.RtbCommitMessage.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.RtbCommitMessage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RtbCommitMessage.Font = new System.Drawing.Font("Georgia", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.RtbCommitMessage.ForeColor = System.Drawing.Color.DarkGray;
            this.RtbCommitMessage.Location = new System.Drawing.Point(0, 0);
            this.RtbCommitMessage.Margin = new System.Windows.Forms.Padding(0);
            this.RtbCommitMessage.Name = "RtbCommitMessage";
            this.RtbCommitMessage.Size = new System.Drawing.Size(364, 116);
            this.RtbCommitMessage.TabIndex = 2;
            this.RtbCommitMessage.Text = "111\nlll\nMMM\nqqq\niii";
            this.RtbCommitMessage.WordWrap = false;
            this.RtbCommitMessage.TextChanged += new System.EventHandler(this.RtbCommitMessage_TextChanged);
            // 
            // TimClipboard
            // 
            this.TimClipboard.Interval = 10;
            this.TimClipboard.Tick += new System.EventHandler(this.TimClipboard_Tick);
            // 
            // CommitMessageFormatterDlg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MidnightBlue;
            this.ClientSize = new System.Drawing.Size(364, 131);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CommitMessageFormatterDlg";
            this.Text = "Commit Message Formatter";
            this.TopMost = true;
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label LblStatus;
        private System.Windows.Forms.Timer TimClipboard;
        private System.Windows.Forms.RichTextBox RtbCommitMessage;
    }
}

