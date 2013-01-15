namespace runnerManager
{
    partial class FormSelectionMethodsGrid
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
            this.webappDBDataSet = new runnerManager.WebappDBDataSet();
            this.metodoSeleccionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.metodoSeleccionTableAdapter = new runnerManager.WebappDBDataSetTableAdapters.MetodoSeleccionTableAdapter();
            this.idMetodoSeleccionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.parametrosDefectoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.webappDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.metodoSeleccionBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idMetodoSeleccionDataGridViewTextBoxColumn,
            this.nombreDataGridViewTextBoxColumn,
            this.descripcionDataGridViewTextBoxColumn,
            this.parametrosDefectoDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.metodoSeleccionBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(398, 195);
            this.dataGridView1.TabIndex = 0;
            // 
            // webappDBDataSet
            // 
            this.webappDBDataSet.DataSetName = "WebappDBDataSet";
            this.webappDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // metodoSeleccionBindingSource
            // 
            this.metodoSeleccionBindingSource.DataMember = "MetodoSeleccion";
            this.metodoSeleccionBindingSource.DataSource = this.webappDBDataSet;
            // 
            // metodoSeleccionTableAdapter
            // 
            this.metodoSeleccionTableAdapter.ClearBeforeFill = true;
            // 
            // idMetodoSeleccionDataGridViewTextBoxColumn
            // 
            this.idMetodoSeleccionDataGridViewTextBoxColumn.DataPropertyName = "idMetodoSeleccion";
            this.idMetodoSeleccionDataGridViewTextBoxColumn.HeaderText = "idMetodoSeleccion";
            this.idMetodoSeleccionDataGridViewTextBoxColumn.Name = "idMetodoSeleccionDataGridViewTextBoxColumn";
            this.idMetodoSeleccionDataGridViewTextBoxColumn.ReadOnly = true;
            this.idMetodoSeleccionDataGridViewTextBoxColumn.Visible = false;
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
            // FormSelectionMethodsGrid
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(421, 254);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FormSelectionMethodsGrid";
            this.Text = "Selection Methods";
            this.Load += new System.EventHandler(this.FormSelectionMethodsGrid_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.webappDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.metodoSeleccionBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private WebappDBDataSet webappDBDataSet;
        private System.Windows.Forms.BindingSource metodoSeleccionBindingSource;
        private WebappDBDataSetTableAdapters.MetodoSeleccionTableAdapter metodoSeleccionTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idMetodoSeleccionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn parametrosDefectoDataGridViewTextBoxColumn;
    }
}