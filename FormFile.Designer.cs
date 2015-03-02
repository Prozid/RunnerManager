namespace PBioManager
{
    partial class FormFile
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
            this.lblFilename = new System.Windows.Forms.Label();
            this.txtFilename = new System.Windows.Forms.TextBox();
            this.lblDescription = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.lblFolder = new System.Windows.Forms.Label();
            this.cbxFolder = new System.Windows.Forms.ComboBox();
            this.carpetaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.webappDBDataSet = new PBioManager.WebappDBDataSet();
            this.lblUser = new System.Windows.Forms.Label();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.chkPublic = new System.Windows.Forms.CheckBox();
            this.chkData = new System.Windows.Forms.CheckBox();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.btnOpenFile = new System.Windows.Forms.Button();
            this.btnDeleteFile = new System.Windows.Forms.Button();
            this.carpetaTableAdapter = new PBioManager.WebappDBDataSetTableAdapters.CarpetaTableAdapter();
            this.lblFilenamePath = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.lblLabelCreationDate = new System.Windows.Forms.Label();
            this.lblCreationDate = new System.Windows.Forms.Label();
            this.archivoTableAdapter = new PBioManager.WebappDBDataSetTableAdapters.ArchivoTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.carpetaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.webappDBDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // lblFilename
            // 
            this.lblFilename.AutoSize = true;
            this.lblFilename.Location = new System.Drawing.Point(9, 13);
            this.lblFilename.Name = "lblFilename";
            this.lblFilename.Size = new System.Drawing.Size(49, 13);
            this.lblFilename.TabIndex = 0;
            this.lblFilename.Text = "Filename";
            // 
            // txtFilename
            // 
            this.txtFilename.Location = new System.Drawing.Point(12, 29);
            this.txtFilename.Name = "txtFilename";
            this.txtFilename.Size = new System.Drawing.Size(260, 20);
            this.txtFilename.TabIndex = 1;
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(9, 58);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(60, 13);
            this.lblDescription.TabIndex = 2;
            this.lblDescription.Text = "Description";
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(12, 74);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(260, 20);
            this.txtDescription.TabIndex = 3;
            // 
            // lblFolder
            // 
            this.lblFolder.AutoSize = true;
            this.lblFolder.Location = new System.Drawing.Point(9, 97);
            this.lblFolder.Name = "lblFolder";
            this.lblFolder.Size = new System.Drawing.Size(36, 13);
            this.lblFolder.TabIndex = 4;
            this.lblFolder.Text = "Folder";
            // 
            // cbxFolder
            // 
            this.cbxFolder.DataSource = this.carpetaBindingSource;
            this.cbxFolder.DisplayMember = "Nombre";
            this.cbxFolder.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxFolder.FormattingEnabled = true;
            this.cbxFolder.Location = new System.Drawing.Point(12, 113);
            this.cbxFolder.Name = "cbxFolder";
            this.cbxFolder.Size = new System.Drawing.Size(260, 21);
            this.cbxFolder.TabIndex = 5;
            this.cbxFolder.ValueMember = "IdCarpeta";
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
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Location = new System.Drawing.Point(9, 142);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(29, 13);
            this.lblUser.TabIndex = 6;
            this.lblUser.Text = "User";
            // 
            // txtUser
            // 
            this.txtUser.Location = new System.Drawing.Point(12, 158);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(260, 20);
            this.txtUser.TabIndex = 7;
            // 
            // chkPublic
            // 
            this.chkPublic.AutoSize = true;
            this.chkPublic.Location = new System.Drawing.Point(12, 184);
            this.chkPublic.Name = "chkPublic";
            this.chkPublic.Size = new System.Drawing.Size(55, 17);
            this.chkPublic.TabIndex = 11;
            this.chkPublic.Text = "Public";
            this.chkPublic.UseVisualStyleBackColor = true;
            // 
            // chkData
            // 
            this.chkData.AutoSize = true;
            this.chkData.Location = new System.Drawing.Point(12, 207);
            this.chkData.Name = "chkData";
            this.chkData.Size = new System.Drawing.Size(65, 17);
            this.chkData.TabIndex = 12;
            this.chkData.Text = "Data file";
            this.chkData.UseVisualStyleBackColor = true;
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog";
            // 
            // btnOpenFile
            // 
            this.btnOpenFile.Location = new System.Drawing.Point(12, 230);
            this.btnOpenFile.Name = "btnOpenFile";
            this.btnOpenFile.Size = new System.Drawing.Size(75, 23);
            this.btnOpenFile.TabIndex = 13;
            this.btnOpenFile.Text = "Open";
            this.btnOpenFile.UseVisualStyleBackColor = true;
            this.btnOpenFile.Click += new System.EventHandler(this.btnOpenFile_Click);
            // 
            // btnDeleteFile
            // 
            this.btnDeleteFile.Enabled = false;
            this.btnDeleteFile.Location = new System.Drawing.Point(93, 230);
            this.btnDeleteFile.Name = "btnDeleteFile";
            this.btnDeleteFile.Size = new System.Drawing.Size(75, 23);
            this.btnDeleteFile.TabIndex = 14;
            this.btnDeleteFile.Text = "Quit";
            this.btnDeleteFile.UseVisualStyleBackColor = true;
            this.btnDeleteFile.Visible = false;
            this.btnDeleteFile.Click += new System.EventHandler(this.btnDeleteFile_Click);
            // 
            // carpetaTableAdapter
            // 
            this.carpetaTableAdapter.ClearBeforeFill = true;
            // 
            // lblFilenamePath
            // 
            this.lblFilenamePath.AutoSize = true;
            this.lblFilenamePath.Enabled = false;
            this.lblFilenamePath.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFilenamePath.Location = new System.Drawing.Point(17, 267);
            this.lblFilenamePath.Name = "lblFilenamePath";
            this.lblFilenamePath.Size = new System.Drawing.Size(41, 20);
            this.lblFilenamePath.TabIndex = 15;
            this.lblFilenamePath.Text = "- - - -";
            this.lblFilenamePath.Visible = false;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(197, 359);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 16;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(116, 359);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 17;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // lblLabelCreationDate
            // 
            this.lblLabelCreationDate.AutoSize = true;
            this.lblLabelCreationDate.Location = new System.Drawing.Point(9, 313);
            this.lblLabelCreationDate.Name = "lblLabelCreationDate";
            this.lblLabelCreationDate.Size = new System.Drawing.Size(72, 13);
            this.lblLabelCreationDate.TabIndex = 18;
            this.lblLabelCreationDate.Text = "Creation Date";
            // 
            // lblCreationDate
            // 
            this.lblCreationDate.AutoSize = true;
            this.lblCreationDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCreationDate.Location = new System.Drawing.Point(8, 326);
            this.lblCreationDate.Name = "lblCreationDate";
            this.lblCreationDate.Size = new System.Drawing.Size(47, 20);
            this.lblCreationDate.TabIndex = 19;
            this.lblCreationDate.Text = "None";
            // 
            // archivoTableAdapter
            // 
            this.archivoTableAdapter.ClearBeforeFill = true;
            // 
            // FormFile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 394);
            this.Controls.Add(this.lblCreationDate);
            this.Controls.Add(this.lblLabelCreationDate);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.lblFilenamePath);
            this.Controls.Add(this.btnDeleteFile);
            this.Controls.Add(this.btnOpenFile);
            this.Controls.Add(this.chkData);
            this.Controls.Add(this.chkPublic);
            this.Controls.Add(this.txtUser);
            this.Controls.Add(this.lblUser);
            this.Controls.Add(this.cbxFolder);
            this.Controls.Add(this.lblFolder);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.txtFilename);
            this.Controls.Add(this.lblFilename);
            this.Name = "FormFile";
            this.Text = "File";
            this.Load += new System.EventHandler(this.FormFile_Load);
            ((System.ComponentModel.ISupportInitialize)(this.carpetaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.webappDBDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFilename;
        private System.Windows.Forms.TextBox txtFilename;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Label lblFolder;
        private System.Windows.Forms.ComboBox cbxFolder;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.CheckBox chkPublic;
        private System.Windows.Forms.CheckBox chkData;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.Button btnOpenFile;
        private System.Windows.Forms.Button btnDeleteFile;
        private WebappDBDataSet webappDBDataSet;
        private System.Windows.Forms.BindingSource carpetaBindingSource;
        private WebappDBDataSetTableAdapters.CarpetaTableAdapter carpetaTableAdapter;
        private System.Windows.Forms.Label lblFilenamePath;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label lblLabelCreationDate;
        private System.Windows.Forms.Label lblCreationDate;
        private WebappDBDataSetTableAdapters.ArchivoTableAdapter archivoTableAdapter;
    }
}