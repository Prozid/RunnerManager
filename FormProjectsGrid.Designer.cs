namespace PBioManager
{
    partial class FormProjectsGrid
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
            this.idProyectoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaLanzUltSimulacionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaCreacionProyectoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idCarpetaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.proyectoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.webappDBDataSet = new PBioManager.WebappDBDataSet();
            this.proyectoTableAdapter = new PBioManager.WebappDBDataSetTableAdapters.ProyectoTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.proyectoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.webappDBDataSet)).BeginInit();
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
            this.idProyectoDataGridViewTextBoxColumn,
            this.nombreDataGridViewTextBoxColumn,
            this.descripcionDataGridViewTextBoxColumn,
            this.fechaLanzUltSimulacionDataGridViewTextBoxColumn,
            this.fechaCreacionProyectoDataGridViewTextBoxColumn,
            this.idCarpetaDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.proyectoBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(605, 348);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // idProyectoDataGridViewTextBoxColumn
            // 
            this.idProyectoDataGridViewTextBoxColumn.DataPropertyName = "IdProyecto";
            this.idProyectoDataGridViewTextBoxColumn.HeaderText = "IdProyecto";
            this.idProyectoDataGridViewTextBoxColumn.Name = "idProyectoDataGridViewTextBoxColumn";
            this.idProyectoDataGridViewTextBoxColumn.ReadOnly = true;
            this.idProyectoDataGridViewTextBoxColumn.Visible = false;
            // 
            // nombreDataGridViewTextBoxColumn
            // 
            this.nombreDataGridViewTextBoxColumn.DataPropertyName = "Nombre";
            this.nombreDataGridViewTextBoxColumn.HeaderText = "Nombre";
            this.nombreDataGridViewTextBoxColumn.Name = "nombreDataGridViewTextBoxColumn";
            this.nombreDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // descripcionDataGridViewTextBoxColumn
            // 
            this.descripcionDataGridViewTextBoxColumn.DataPropertyName = "Descripcion";
            this.descripcionDataGridViewTextBoxColumn.HeaderText = "Descripcion";
            this.descripcionDataGridViewTextBoxColumn.Name = "descripcionDataGridViewTextBoxColumn";
            this.descripcionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fechaLanzUltSimulacionDataGridViewTextBoxColumn
            // 
            this.fechaLanzUltSimulacionDataGridViewTextBoxColumn.DataPropertyName = "FechaLanzUltSimulacion";
            this.fechaLanzUltSimulacionDataGridViewTextBoxColumn.HeaderText = "FechaLanzUltSimulacion";
            this.fechaLanzUltSimulacionDataGridViewTextBoxColumn.Name = "fechaLanzUltSimulacionDataGridViewTextBoxColumn";
            this.fechaLanzUltSimulacionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fechaCreacionProyectoDataGridViewTextBoxColumn
            // 
            this.fechaCreacionProyectoDataGridViewTextBoxColumn.DataPropertyName = "FechaCreacionProyecto";
            this.fechaCreacionProyectoDataGridViewTextBoxColumn.HeaderText = "FechaCreacionProyecto";
            this.fechaCreacionProyectoDataGridViewTextBoxColumn.Name = "fechaCreacionProyectoDataGridViewTextBoxColumn";
            this.fechaCreacionProyectoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // idCarpetaDataGridViewTextBoxColumn
            // 
            this.idCarpetaDataGridViewTextBoxColumn.DataPropertyName = "IdCarpeta";
            this.idCarpetaDataGridViewTextBoxColumn.HeaderText = "IdCarpeta";
            this.idCarpetaDataGridViewTextBoxColumn.Name = "idCarpetaDataGridViewTextBoxColumn";
            this.idCarpetaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // proyectoBindingSource
            // 
            this.proyectoBindingSource.DataMember = "Proyecto";
            this.proyectoBindingSource.DataSource = this.webappDBDataSet;
            // 
            // webappDBDataSet
            // 
            this.webappDBDataSet.DataSetName = "WebappDBDataSet";
            this.webappDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // proyectoTableAdapter
            // 
            this.proyectoTableAdapter.ClearBeforeFill = true;
            // 
            // FormProjectsGrid
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(605, 348);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FormProjectsGrid";
            this.Text = "Projects";
            this.Load += new System.EventHandler(this.FormProjectsGrid_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.proyectoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.webappDBDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idProyectoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaLanzUltSimulacionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaCreacionProyectoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idCarpetaDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource proyectoBindingSource;
        private WebappDBDataSet webappDBDataSet;
        private WebappDBDataSetTableAdapters.ProyectoTableAdapter proyectoTableAdapter;
    }
}