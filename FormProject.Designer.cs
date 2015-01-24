namespace PBioManager
{
    partial class FormProject
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
            this.lblName = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            this.lblLabelLastExecution = new System.Windows.Forms.Label();
            this.lblLastExecution = new System.Windows.Forms.Label();
            this.lblLabelCreationDate = new System.Windows.Forms.Label();
            this.lblCreationDate = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.lblFolder = new System.Windows.Forms.Label();
            this.cbxFolder = new System.Windows.Forms.ComboBox();
            this.carpetaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.webappDBDataSet = new PBioManager.WebappDBDataSet();
            this.carpetaTableAdapter = new PBioManager.WebappDBDataSetTableAdapters.CarpetaTableAdapter();
            this.proyectoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.proyectoTableAdapter = new PBioManager.WebappDBDataSetTableAdapters.ProyectoTableAdapter();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.carpetaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.webappDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.proyectoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(9, 9);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(40, 13);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Project";
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(9, 48);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(60, 13);
            this.lblDescription.TabIndex = 1;
            this.lblDescription.Text = "Description";
            // 
            // lblLabelLastExecution
            // 
            this.lblLabelLastExecution.AutoSize = true;
            this.lblLabelLastExecution.Location = new System.Drawing.Point(196, 137);
            this.lblLabelLastExecution.Name = "lblLabelLastExecution";
            this.lblLabelLastExecution.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblLabelLastExecution.Size = new System.Drawing.Size(76, 13);
            this.lblLabelLastExecution.TabIndex = 2;
            this.lblLabelLastExecution.Text = "Last execution";
            this.lblLabelLastExecution.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblLastExecution
            // 
            this.lblLastExecution.AutoSize = true;
            this.lblLastExecution.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLastExecution.Location = new System.Drawing.Point(8, 150);
            this.lblLastExecution.Name = "lblLastExecution";
            this.lblLastExecution.Size = new System.Drawing.Size(47, 20);
            this.lblLastExecution.TabIndex = 3;
            this.lblLastExecution.Text = "None";
            // 
            // lblLabelCreationDate
            // 
            this.lblLabelCreationDate.AutoSize = true;
            this.lblLabelCreationDate.Location = new System.Drawing.Point(9, 137);
            this.lblLabelCreationDate.Name = "lblLabelCreationDate";
            this.lblLabelCreationDate.Size = new System.Drawing.Size(46, 13);
            this.lblLabelCreationDate.TabIndex = 4;
            this.lblLabelCreationDate.Text = "Creation";
            // 
            // lblCreationDate
            // 
            this.lblCreationDate.AutoSize = true;
            this.lblCreationDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCreationDate.Location = new System.Drawing.Point(224, 150);
            this.lblCreationDate.Name = "lblCreationDate";
            this.lblCreationDate.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblCreationDate.Size = new System.Drawing.Size(47, 20);
            this.lblCreationDate.TabIndex = 5;
            this.lblCreationDate.Text = "None";
            this.lblCreationDate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(12, 25);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(260, 20);
            this.txtName.TabIndex = 6;
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(12, 64);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(260, 20);
            this.txtDescription.TabIndex = 7;
            // 
            // lblFolder
            // 
            this.lblFolder.AutoSize = true;
            this.lblFolder.Location = new System.Drawing.Point(9, 87);
            this.lblFolder.Name = "lblFolder";
            this.lblFolder.Size = new System.Drawing.Size(36, 13);
            this.lblFolder.TabIndex = 8;
            this.lblFolder.Text = "Folder";
            // 
            // cbxFolder
            // 
            this.cbxFolder.DataSource = this.carpetaBindingSource;
            this.cbxFolder.DisplayMember = "Nombre";
            this.cbxFolder.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxFolder.FormattingEnabled = true;
            this.cbxFolder.Location = new System.Drawing.Point(12, 103);
            this.cbxFolder.Name = "cbxFolder";
            this.cbxFolder.Size = new System.Drawing.Size(260, 21);
            this.cbxFolder.TabIndex = 9;
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
            // carpetaTableAdapter
            // 
            this.carpetaTableAdapter.ClearBeforeFill = true;
            // 
            // proyectoBindingSource
            // 
            this.proyectoBindingSource.DataMember = "Proyecto";
            this.proyectoBindingSource.DataSource = this.webappDBDataSet;
            // 
            // proyectoTableAdapter
            // 
            this.proyectoTableAdapter.ClearBeforeFill = true;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(196, 227);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 10;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(115, 227);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 11;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Visible = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // FormProject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.cbxFolder);
            this.Controls.Add(this.lblFolder);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblCreationDate);
            this.Controls.Add(this.lblLabelCreationDate);
            this.Controls.Add(this.lblLastExecution);
            this.Controls.Add(this.lblLabelLastExecution);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.lblName);
            this.Name = "FormProject";
            this.Text = "Project";
            this.Load += new System.EventHandler(this.FormProject_Load);
            ((System.ComponentModel.ISupportInitialize)(this.carpetaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.webappDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.proyectoBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Label lblLabelLastExecution;
        private System.Windows.Forms.Label lblLastExecution;
        private System.Windows.Forms.Label lblLabelCreationDate;
        private System.Windows.Forms.Label lblCreationDate;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Label lblFolder;
        private System.Windows.Forms.ComboBox cbxFolder;
        private WebappDBDataSet webappDBDataSet;
        private System.Windows.Forms.BindingSource carpetaBindingSource;
        private WebappDBDataSetTableAdapters.CarpetaTableAdapter carpetaTableAdapter;
        private System.Windows.Forms.BindingSource proyectoBindingSource;
        private WebappDBDataSetTableAdapters.ProyectoTableAdapter proyectoTableAdapter;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnDelete;
    }
}