
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
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(529, 216);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // LblStatus
            // 
            this.LblStatus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LblStatus.Location = new System.Drawing.Point(3, 193);
            this.LblStatus.Name = "LblStatus";
            this.LblStatus.Size = new System.Drawing.Size(523, 23);
            this.LblStatus.TabIndex = 1;
            this.LblStatus.Text = "label1";
            // 
            // RtbCommitMessage
            // 
            this.RtbCommitMessage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RtbCommitMessage.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.RtbCommitMessage.Location = new System.Drawing.Point(3, 3);
            this.RtbCommitMessage.Name = "RtbCommitMessage";
            this.RtbCommitMessage.Size = new System.Drawing.Size(523, 187);
            this.RtbCommitMessage.TabIndex = 2;
            this.RtbCommitMessage.Text = "";
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
            this.ClientSize = new System.Drawing.Size(529, 216);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CommitMessageFormatterDlg";
            this.Text = "Commit Message Formatter";
            this.TopMost = true;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CommitMessageFormatterDlg_FormClosing);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label LblStatus;
        private System.Windows.Forms.Timer TimClipboard;
        private System.Windows.Forms.RichTextBox RtbCommitMessage;
    }
}

