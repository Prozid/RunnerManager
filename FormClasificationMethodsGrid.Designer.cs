namespace runnerManager
{
    partial class FormClasificationMethodsGrid
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
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.webappDBDataSet = new runnerManager.WebappDBDataSet();
            this.metodoClasificacionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.metodoClasificacionTableAdapter = new runnerManager.WebappDBDataSetTableAdapters.MetodoClasificacionTableAdapter();
            this.idMetodoClasificacionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.parametrosDefectoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.webappDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.metodoClasificacionBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView
            // 
            this.dataGridView.AutoGenerateColumns = false;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idMetodoClasificacionDataGridViewTextBoxColumn,
            this.nombreDataGridViewTextBoxColumn,
            this.descripcionDataGridViewTextBoxColumn,
            this.parametrosDefectoDataGridViewTextBoxColumn});
            this.dataGridView.DataSource = this.metodoClasificacionBindingSource;
            this.dataGridView.Location = new System.Drawing.Point(12, 12);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.Size = new System.Drawing.Size(492, 207);
            this.dataGridView.TabIndex = 0;
            // 
            // webappDBDataSet
            // 
            this.webappDBDataSet.DataSetName = "WebappDBDataSet";
            this.webappDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // metodoClasificacionBindingSource
            // 
            this.metodoClasificacionBindingSource.DataMember = "MetodoClasificacion";
            this.metodoClasificacionBindingSource.DataSource = this.webappDBDataSet;
            // 
            // metodoClasificacionTableAdapter
            // 
            this.metodoClasificacionTableAdapter.ClearBeforeFill = true;
            // 
            // idMetodoClasificacionDataGridViewTextBoxColumn
            // 
            this.idMetodoClasificacionDataGridViewTextBoxColumn.DataPropertyName = "idMetodoClasificacion";
            this.idMetodoClasificacionDataGridViewTextBoxColumn.HeaderText = "idMetodoClasificacion";
            this.idMetodoClasificacionDataGridViewTextBoxColumn.Name = "idMetodoClasificacionDataGridViewTextBoxColumn";
            this.idMetodoClasificacionDataGridViewTextBoxColumn.ReadOnly = true;
            this.idMetodoClasificacionDataGridViewTextBoxColumn.Visible = false;
            // 
            // nombreDataGridViewTextBoxColumn
            // 
            this.nombreDataGridViewTextBoxColumn.DataPropertyName = "nombre";
            this.nombreDataGridViewTextBoxColumn.HeaderText = "nombre";
            this.nombreDataGridViewTextBoxColumn.Name = "nombreDataGridViewTextBoxColumn";
            // 
            // descripcionDataGridViewTextBoxColumn
            // 
            this.descripcionDataGridViewTextBoxColumn.DataPropertyName = "descripcion";
            this.descripcionDataGridViewTextBoxColumn.HeaderText = "descripcion";
            this.descripcionDataGridViewTextBoxColumn.Name = "descripcionDataGridViewTextBoxColumn";
            // 
            // parametrosDefectoDataGridViewTextBoxColumn
            // 
            this.parametrosDefectoDataGridViewTextBoxColumn.DataPropertyName = "parametrosDefecto";
            this.parametrosDefectoDataGridViewTextBoxColumn.HeaderText = "parametrosDefecto";
            this.parametrosDefectoDataGridViewTextBoxColumn.Name = "parametrosDefectoDataGridViewTextBoxColumn";
            // 
            // FormClasificationMethodsGrid
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(516, 231);
            this.Controls.Add(this.dataGridView);
            this.Name = "FormClasificationMethodsGrid";
            this.Text = "Clasification Methods";
            this.Load += new System.EventHandler(this.FormClasificationMethods_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.webappDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.metodoClasificacionBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView;
        private WebappDBDataSet webappDBDataSet;
        private System.Windows.Forms.BindingSource metodoClasificacionBindingSource;
        private WebappDBDataSetTableAdapters.MetodoClasificacionTableAdapter metodoClasificacionTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idMetodoClasificacionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn parametrosDefectoDataGridViewTextBoxColumn;
    }
}