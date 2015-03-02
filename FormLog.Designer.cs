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
            this.lblText = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblLabelDate = new System.Windows.Forms.Label();
            this.txtText = new System.Windows.Forms.TextBox();
            this.webappDBDataSet = new PBioManager.WebappDBDataSet();
            this.btnClose = new System.Windows.Forms.Button();
            this.logTableAdapter = new PBioManager.WebappDBDataSetTableAdapters.LogTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.webappDBDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // lblText
            // 
            this.lblText.AutoSize = true;
            this.lblText.Location = new System.Drawing.Point(8, 42);
            this.lblText.Name = "lblText";
            this.lblText.Size = new System.Drawing.Size(28, 13);
            this.lblText.TabIndex = 1;
            this.lblText.Text = "Text";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.Location = new System.Drawing.Point(7, 22);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(47, 20);
            this.lblDate.TabIndex = 3;
            this.lblDate.Text = "None";
            // 
            // lblLabelDate
            // 
            this.lblLabelDate.AutoSize = true;
            this.lblLabelDate.Location = new System.Drawing.Point(8, 9);
            this.lblLabelDate.Name = "lblLabelDate";
            this.lblLabelDate.Size = new System.Drawing.Size(49, 13);
            this.lblLabelDate.TabIndex = 4;
            this.lblLabelDate.Text = "Datetime";
            // 
            // txtText
            // 
            this.txtText.Location = new System.Drawing.Point(11, 58);
            this.txtText.Multiline = true;
            this.txtText.Name = "txtText";
            this.txtText.Size = new System.Drawing.Size(260, 163);
            this.txtText.TabIndex = 7;
            // 
            // webappDBDataSet
            // 
            this.webappDBDataSet.DataSetName = "WebappDBDataSet";
            this.webappDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(196, 227);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 10;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // logTableAdapter
            // 
            this.logTableAdapter.ClearBeforeFill = true;
            // 
            // FormLog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.txtText);
            this.Controls.Add(this.lblLabelDate);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.lblText);
            this.Name = "FormLog";
            this.Text = "Project";
            this.Load += new System.EventHandler(this.FormLog_Load);
            ((System.ComponentModel.ISupportInitialize)(this.webappDBDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblText;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblLabelDate;
        private System.Windows.Forms.TextBox txtText;
        private WebappDBDataSet webappDBDataSet;
        private System.Windows.Forms.Button btnClose;
        private WebappDBDataSetTableAdapters.LogTableAdapter logTableAdapter;
    }
}