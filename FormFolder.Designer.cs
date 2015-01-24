namespace PBioManager
{
    partial class FormFolder
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
            this.btnSave = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.lblName = new System.Windows.Forms.Label();
            this.lblUser = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.lblRootFolder = new System.Windows.Forms.Label();
            this.cbxRootFolder = new System.Windows.Forms.ComboBox();
            this.carpetaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.webappDBDataSet = new PBioManager.WebappDBDataSet();
            this.lblLabelCreationDate = new System.Windows.Forms.Label();
            this.lblCreationDate = new System.Windows.Forms.Label();
            this.carpetaTableAdapter = new PBioManager.WebappDBDataSetTableAdapters.CarpetaTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.carpetaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.webappDBDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(197, 227);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Enabled = false;
            this.btnDelete.Location = new System.Drawing.Point(116, 227);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 1;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Visible = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(12, 9);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(35, 13);
            this.lblName.TabIndex = 2;
            this.lblName.Text = "Name";
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Location = new System.Drawing.Point(12, 49);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(29, 13);
            this.lblUser.TabIndex = 3;
            this.lblUser.Text = "User";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(15, 26);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(257, 20);
            this.txtName.TabIndex = 4;
            // 
            // txtUser
            // 
            this.txtUser.Location = new System.Drawing.Point(15, 65);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(257, 20);
            this.txtUser.TabIndex = 5;
            // 
            // lblRootFolder
            // 
            this.lblRootFolder.AutoSize = true;
            this.lblRootFolder.Location = new System.Drawing.Point(12, 88);
            this.lblRootFolder.Name = "lblRootFolder";
            this.lblRootFolder.Size = new System.Drawing.Size(59, 13);
            this.lblRootFolder.TabIndex = 6;
            this.lblRootFolder.Text = "Root folder";
            // 
            // cbxRootFolder
            // 
            this.cbxRootFolder.DataSource = this.carpetaBindingSource;
            this.cbxRootFolder.DisplayMember = "Nombre";
            this.cbxRootFolder.FormattingEnabled = true;
            this.cbxRootFolder.Location = new System.Drawing.Point(15, 109);
            this.cbxRootFolder.Name = "cbxRootFolder";
            this.cbxRootFolder.Size = new System.Drawing.Size(257, 21);
            this.cbxRootFolder.TabIndex = 7;
            this.cbxRootFolder.ValueMember = "IdCarpeta";
            // 
            // carpetaBindingSource
            // 
            this.carpetaBindingSource.DataMember = "Carpeta";
            this.carpetaBindingSource.DataSource = this.webappDBDataSet;
            // 
            // webappDBDataSet
            // 
            this.webappDBDataSet.DataSetName = "WebappDBDataSet";
            this.webappDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lblLabelCreationDate
            // 
            this.lblLabelCreationDate.AutoSize = true;
            this.lblLabelCreationDate.Location = new System.Drawing.Point(12, 133);
            this.lblLabelCreationDate.Name = "lblLabelCreationDate";
            this.lblLabelCreationDate.Size = new System.Drawing.Size(70, 13);
            this.lblLabelCreationDate.TabIndex = 8;
            this.lblLabelCreationDate.Text = "Creation date";
            // 
            // lblCreationDate
            // 
            this.lblCreationDate.AutoSize = true;
            this.lblCreationDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCreationDate.Location = new System.Drawing.Point(12, 146);
            this.lblCreationDate.Name = "lblCreationDate";
            this.lblCreationDate.Size = new System.Drawing.Size(47, 20);
            this.lblCreationDate.TabIndex = 9;
            this.lblCreationDate.Text = "None";
            // 
            // carpetaTableAdapter
            // 
            this.carpetaTableAdapter.ClearBeforeFill = true;
            // 
            // FormFolder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.lblCreationDate);
            this.Controls.Add(this.lblLabelCreationDate);
            this.Controls.Add(this.cbxRootFolder);
            this.Controls.Add(this.lblRootFolder);
            this.Controls.Add(this.txtUser);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblUser);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnSave);
            this.Name = "FormFolder";
            this.Text = "Folder";
            this.Load += new System.EventHandler(this.FormFolder_Load);
            ((System.ComponentModel.ISupportInitialize)(this.carpetaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.webappDBDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.Label lblRootFolder;
        private System.Windows.Forms.ComboBox cbxRootFolder;
        private System.Windows.Forms.Label lblLabelCreationDate;
        private System.Windows.Forms.Label lblCreationDate;
        private WebappDBDataSet webappDBDataSet;
        private System.Windows.Forms.BindingSource carpetaBindingSource;
        private WebappDBDataSetTableAdapters.CarpetaTableAdapter carpetaTableAdapter;
    }
}