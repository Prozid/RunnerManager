namespace PBioManager
{
    partial class FormFilesGrid
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.webappDBDataSet = new PBioManager.WebappDBDataSet();
            this.archivoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.archivoTableAdapter = new PBioManager.WebappDBDataSetTableAdapters.ArchivoTableAdapter();
            this.idArchivoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idCarpetaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreArchivoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usuarioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.publicoDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.contentTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaCreacionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.baseDatosDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.datosDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.webappDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.archivoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idArchivoDataGridViewTextBoxColumn,
            this.idCarpetaDataGridViewTextBoxColumn,
            this.nombreArchivoDataGridViewTextBoxColumn,
            this.usuarioDataGridViewTextBoxColumn,
            this.publicoDataGridViewCheckBoxColumn,
            this.contentTypeDataGridViewTextBoxColumn,
            this.fechaCreacionDataGridViewTextBoxColumn,
            this.descripcionDataGridViewTextBoxColumn,
            this.baseDatosDataGridViewCheckBoxColumn,
            this.datosDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.archivoBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(860, 262);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // webappDBDataSet
            // 
            this.webappDBDataSet.DataSetName = "WebappDBDataSet";
            this.webappDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // archivoBindingSource
            // 
            this.archivoBindingSource.DataMember = "Archivo";
            this.archivoBindingSource.DataSource = this.webappDBDataSet;
            // 
            // archivoTableAdapter
            // 
            this.archivoTableAdapter.ClearBeforeFill = true;
            // 
            // idArchivoDataGridViewTextBoxColumn
            // 
            this.idArchivoDataGridViewTextBoxColumn.DataPropertyName = "IdArchivo";
            this.idArchivoDataGridViewTextBoxColumn.HeaderText = "IdArchivo";
            this.idArchivoDataGridViewTextBoxColumn.Name = "idArchivoDataGridViewTextBoxColumn";
            this.idArchivoDataGridViewTextBoxColumn.ReadOnly = true;
            this.idArchivoDataGridViewTextBoxColumn.Visible = false;
            // 
            // idCarpetaDataGridViewTextBoxColumn
            // 
            this.idCarpetaDataGridViewTextBoxColumn.DataPropertyName = "IdCarpeta";
            this.idCarpetaDataGridViewTextBoxColumn.HeaderText = "IdCarpeta";
            this.idCarpetaDataGridViewTextBoxColumn.Name = "idCarpetaDataGridViewTextBoxColumn";
            this.idCarpetaDataGridViewTextBoxColumn.ReadOnly = true;
            this.idCarpetaDataGridViewTextBoxColumn.Visible = false;
            // 
            // nombreArchivoDataGridViewTextBoxColumn
            // 
            this.nombreArchivoDataGridViewTextBoxColumn.DataPropertyName = "NombreArchivo";
            this.nombreArchivoDataGridViewTextBoxColumn.HeaderText = "Filename";
            this.nombreArchivoDataGridViewTextBoxColumn.Name = "nombreArchivoDataGridViewTextBoxColumn";
            this.nombreArchivoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // usuarioDataGridViewTextBoxColumn
            // 
            this.usuarioDataGridViewTextBoxColumn.DataPropertyName = "Usuario";
            this.usuarioDataGridViewTextBoxColumn.HeaderText = "User";
            this.usuarioDataGridViewTextBoxColumn.Name = "usuarioDataGridViewTextBoxColumn";
            this.usuarioDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // publicoDataGridViewCheckBoxColumn
            // 
            this.publicoDataGridViewCheckBoxColumn.DataPropertyName = "Publico";
            this.publicoDataGridViewCheckBoxColumn.HeaderText = "Public";
            this.publicoDataGridViewCheckBoxColumn.Name = "publicoDataGridViewCheckBoxColumn";
            this.publicoDataGridViewCheckBoxColumn.ReadOnly = true;
            // 
            // contentTypeDataGridViewTextBoxColumn
            // 
            this.contentTypeDataGridViewTextBoxColumn.DataPropertyName = "ContentType";
            this.contentTypeDataGridViewTextBoxColumn.HeaderText = "ContentType";
            this.contentTypeDataGridViewTextBoxColumn.Name = "contentTypeDataGridViewTextBoxColumn";
            this.contentTypeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fechaCreacionDataGridViewTextBoxColumn
            // 
            this.fechaCreacionDataGridViewTextBoxColumn.DataPropertyName = "FechaCreacion";
            this.fechaCreacionDataGridViewTextBoxColumn.HeaderText = "Creation Date";
            this.fechaCreacionDataGridViewTextBoxColumn.Name = "fechaCreacionDataGridViewTextBoxColumn";
            this.fechaCreacionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // descripcionDataGridViewTextBoxColumn
            // 
            this.descripcionDataGridViewTextBoxColumn.DataPropertyName = "Descripcion";
            this.descripcionDataGridViewTextBoxColumn.HeaderText = "Description";
            this.descripcionDataGridViewTextBoxColumn.Name = "descripcionDataGridViewTextBoxColumn";
            this.descripcionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // baseDatosDataGridViewCheckBoxColumn
            // 
            this.baseDatosDataGridViewCheckBoxColumn.DataPropertyName = "BaseDatos";
            this.baseDatosDataGridViewCheckBoxColumn.HeaderText = "Data file";
            this.baseDatosDataGridViewCheckBoxColumn.Name = "baseDatosDataGridViewCheckBoxColumn";
            this.baseDatosDataGridViewCheckBoxColumn.ReadOnly = true;
            // 
            // datosDataGridViewTextBoxColumn
            // 
            this.datosDataGridViewTextBoxColumn.DataPropertyName = "Datos";
            this.datosDataGridViewTextBoxColumn.HeaderText = "Datos";
            this.datosDataGridViewTextBoxColumn.Name = "datosDataGridViewTextBoxColumn";
            this.datosDataGridViewTextBoxColumn.ReadOnly = true;
            this.datosDataGridViewTextBoxColumn.Visible = false;
            // 
            // FormFilesGrid
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(860, 262);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FormFilesGrid";
            this.Text = "Files";
            this.Load += new System.EventHandler(this.FormFilesGrid_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.webappDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.archivoBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private WebappDBDataSet webappDBDataSet;
        private System.Windows.Forms.BindingSource archivoBindingSource;
        private WebappDBDataSetTableAdapters.ArchivoTableAdapter archivoTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idArchivoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idCarpetaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreArchivoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn usuarioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn publicoDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn contentTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaCreacionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn baseDatosDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datosDataGridViewTextBoxColumn;
    }
}