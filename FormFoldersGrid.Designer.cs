namespace PBioManager
{
    partial class FormFoldersGrid
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
            this.carpetaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.carpetaTableAdapter = new PBioManager.WebappDBDataSetTableAdapters.CarpetaTableAdapter();
            this.idCarpetaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idCarpetaPadreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usuarioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaCreaconDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.webappDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.carpetaBindingSource)).BeginInit();
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
            this.idCarpetaDataGridViewTextBoxColumn,
            this.nombreDataGridViewTextBoxColumn,
            this.idCarpetaPadreDataGridViewTextBoxColumn,
            this.usuarioDataGridViewTextBoxColumn,
            this.fechaCreaconDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.carpetaBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(284, 262);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // webappDBDataSet
            // 
            this.webappDBDataSet.DataSetName = "WebappDBDataSet";
            this.webappDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // carpetaBindingSource
            // 
            this.carpetaBindingSource.DataMember = "Carpeta";
            this.carpetaBindingSource.DataSource = this.webappDBDataSet;
            // 
            // carpetaTableAdapter
            // 
            this.carpetaTableAdapter.ClearBeforeFill = true;
            // 
            // idCarpetaDataGridViewTextBoxColumn
            // 
            this.idCarpetaDataGridViewTextBoxColumn.DataPropertyName = "IdCarpeta";
            this.idCarpetaDataGridViewTextBoxColumn.HeaderText = "IdCarpeta";
            this.idCarpetaDataGridViewTextBoxColumn.Name = "idCarpetaDataGridViewTextBoxColumn";
            this.idCarpetaDataGridViewTextBoxColumn.ReadOnly = true;
            this.idCarpetaDataGridViewTextBoxColumn.Visible = false;
            // 
            // nombreDataGridViewTextBoxColumn
            // 
            this.nombreDataGridViewTextBoxColumn.DataPropertyName = "Nombre";
            this.nombreDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nombreDataGridViewTextBoxColumn.Name = "nombreDataGridViewTextBoxColumn";
            this.nombreDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // idCarpetaPadreDataGridViewTextBoxColumn
            // 
            this.idCarpetaPadreDataGridViewTextBoxColumn.DataPropertyName = "IdCarpetaPadre";
            this.idCarpetaPadreDataGridViewTextBoxColumn.HeaderText = "Root folder";
            this.idCarpetaPadreDataGridViewTextBoxColumn.Name = "idCarpetaPadreDataGridViewTextBoxColumn";
            this.idCarpetaPadreDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // usuarioDataGridViewTextBoxColumn
            // 
            this.usuarioDataGridViewTextBoxColumn.DataPropertyName = "Usuario";
            this.usuarioDataGridViewTextBoxColumn.HeaderText = "User";
            this.usuarioDataGridViewTextBoxColumn.Name = "usuarioDataGridViewTextBoxColumn";
            this.usuarioDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fechaCreaconDataGridViewTextBoxColumn
            // 
            this.fechaCreaconDataGridViewTextBoxColumn.DataPropertyName = "FechaCreac_on";
            this.fechaCreaconDataGridViewTextBoxColumn.HeaderText = "Creation date";
            this.fechaCreaconDataGridViewTextBoxColumn.Name = "fechaCreaconDataGridViewTextBoxColumn";
            this.fechaCreaconDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // FormFoldersGrid
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FormFoldersGrid";
            this.Text = "Folders";
            this.Load += new System.EventHandler(this.FormFoldersGrid_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.webappDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.carpetaBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private WebappDBDataSet webappDBDataSet;
        private System.Windows.Forms.BindingSource carpetaBindingSource;
        private WebappDBDataSetTableAdapters.CarpetaTableAdapter carpetaTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idCarpetaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idCarpetaPadreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn usuarioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaCreaconDataGridViewTextBoxColumn;
    }
}