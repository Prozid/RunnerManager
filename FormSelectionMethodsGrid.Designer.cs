namespace PBioManager
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
            this.idMetodoSeleccionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.parametrosXDefectoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.metodoSeleccionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.webappDBDataSet = new PBioManager.WebappDBDataSet();
            this.metodoSeleccionTableAdapter = new PBioManager.WebappDBDataSetTableAdapters.MetodoSeleccionTableAdapter();
            this.btnDiscard = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.metodoSeleccionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.webappDBDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idMetodoSeleccionDataGridViewTextBoxColumn,
            this.nombreDataGridViewTextBoxColumn,
            this.descripcionDataGridViewTextBoxColumn,
            this.parametrosXDefectoDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.metodoSeleccionBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(450, 204);
            this.dataGridView1.TabIndex = 0;
            // 
            // idMetodoSeleccionDataGridViewTextBoxColumn
            // 
            this.idMetodoSeleccionDataGridViewTextBoxColumn.DataPropertyName = "IdMetodoSeleccion";
            this.idMetodoSeleccionDataGridViewTextBoxColumn.HeaderText = "IdMetodoSeleccion";
            this.idMetodoSeleccionDataGridViewTextBoxColumn.Name = "idMetodoSeleccionDataGridViewTextBoxColumn";
            // 
            // nombreDataGridViewTextBoxColumn
            // 
            this.nombreDataGridViewTextBoxColumn.DataPropertyName = "Nombre";
            this.nombreDataGridViewTextBoxColumn.HeaderText = "Nombre";
            this.nombreDataGridViewTextBoxColumn.Name = "nombreDataGridViewTextBoxColumn";
            // 
            // descripcionDataGridViewTextBoxColumn
            // 
            this.descripcionDataGridViewTextBoxColumn.DataPropertyName = "Descripcion";
            this.descripcionDataGridViewTextBoxColumn.HeaderText = "Descripcion";
            this.descripcionDataGridViewTextBoxColumn.Name = "descripcionDataGridViewTextBoxColumn";
            // 
            // parametrosXDefectoDataGridViewTextBoxColumn
            // 
            this.parametrosXDefectoDataGridViewTextBoxColumn.DataPropertyName = "ParametrosXDefecto";
            this.parametrosXDefectoDataGridViewTextBoxColumn.HeaderText = "ParametrosXDefecto";
            this.parametrosXDefectoDataGridViewTextBoxColumn.Name = "parametrosXDefectoDataGridViewTextBoxColumn";
            // 
            // metodoSeleccionBindingSource
            // 
            this.metodoSeleccionBindingSource.DataMember = "MetodoSeleccion";
            this.metodoSeleccionBindingSource.DataSource = this.webappDBDataSet;
            // 
            // webappDBDataSet
            // 
            this.webappDBDataSet.DataSetName = "WebappDBDataSet";
            this.webappDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // metodoSeleccionTableAdapter
            // 
            this.metodoSeleccionTableAdapter.ClearBeforeFill = true;
            // 
            // btnDiscard
            // 
            this.btnDiscard.Location = new System.Drawing.Point(306, 222);
            this.btnDiscard.Name = "btnDiscard";
            this.btnDiscard.Size = new System.Drawing.Size(75, 23);
            this.btnDiscard.TabIndex = 1;
            this.btnDiscard.Text = "Discard";
            this.btnDiscard.UseVisualStyleBackColor = true;
            this.btnDiscard.Click += new System.EventHandler(this.btnDiscard_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(387, 222);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 2;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // FormSelectionMethodsGrid
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(474, 254);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnDiscard);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FormSelectionMethodsGrid";
            this.Text = "Selection Methods";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormSelectionMethodsGrid_FormClosing);
            this.Load += new System.EventHandler(this.FormSelectionMethodsGrid_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.metodoSeleccionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.webappDBDataSet)).EndInit();
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
        private System.Windows.Forms.DataGridViewTextBoxColumn parametrosXDefectoDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnDiscard;
        private System.Windows.Forms.Button btnSave;
    }
}