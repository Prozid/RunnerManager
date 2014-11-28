namespace PBioManager
{
    partial class FormLog
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
            this.threadLog_listBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // threadLog_listBox
            // 
            this.threadLog_listBox.FormattingEnabled = true;
            this.threadLog_listBox.HorizontalScrollbar = true;
            this.threadLog_listBox.Location = new System.Drawing.Point(26, 32);
            this.threadLog_listBox.Name = "threadLog_listBox";
            this.threadLog_listBox.Size = new System.Drawing.Size(233, 199);
            this.threadLog_listBox.TabIndex = 4;
            // 
            // LogForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.threadLog_listBox);
            this.Name = "LogForm";
            this.Text = "LogForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox threadLog_listBox;
    }
}