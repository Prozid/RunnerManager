namespace PBioManager
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
            this.idMetodoClasificacionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.parametrosXDefectoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.metodoClasificacionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.webappDBDataSet = new PBioManager.WebappDBDataSet();
            this.metodoClasificacionTableAdapter = new PBioManager.WebappDBDataSetTableAdapters.MetodoClasificacionTableAdapter();
            this.btnDiscard = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.metodoClasificacionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.webappDBDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AutoGenerateColumns = false;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idMetodoClasificacionDataGridViewTextBoxColumn,
            this.nombreDataGridViewTextBoxColumn,
            this.descripcionDataGridViewTextBoxColumn,
            this.parametrosXDefectoDataGridViewTextBoxColumn});
            this.dataGridView.DataSource = this.metodoClasificacionBindingSource;
            this.dataGridView.Location = new System.Drawing.Point(12, 12);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.Size = new System.Drawing.Size(492, 177);
            this.dataGridView.TabIndex = 0;
            // 
            // idMetodoClasificacionDataGridViewTextBoxColumn
            // 
            this.idMetodoClasificacionDataGridViewTextBoxColumn.DataPropertyName = "IdMetodoClasificacion";
            this.idMetodoClasificacionDataGridViewTextBoxColumn.HeaderText = "IdMetodoClasificacion";
            this.idMetodoClasificacionDataGridViewTextBoxColumn.Name = "idMetodoClasificacionDataGridViewTextBoxColumn";
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
            // metodoClasificacionBindingSource
            // 
            this.metodoClasificacionBindingSource.DataMember = "MetodoClasificacion";
            this.metodoClasificacionBindingSource.DataSource = this.webappDBDataSet;
            // 
            // webappDBDataSet
            // 
            this.webappDBDataSet.DataSetName = "WebappDBDataSet";
            this.webappDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // metodoClasificacionTableAdapter
            // 
            this.metodoClasificacionTableAdapter.ClearBeforeFill = true;
            // 
            // btnDiscard
            // 
            this.btnDiscard.Location = new System.Drawing.Point(348, 196);
            this.btnDiscard.Name = "btnDiscard";
            this.btnDiscard.Size = new System.Drawing.Size(75, 23);
            this.btnDiscard.TabIndex = 1;
            this.btnDiscard.Text = "Discard";
            this.btnDiscard.UseVisualStyleBackColor = true;
            this.btnDiscard.Click += new System.EventHandler(this.btnDiscard_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(429, 196);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 2;
            this.btnSave.Text = "Save changes";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // FormClasificationMethodsGrid
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(516, 231);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnDiscard);
            this.Controls.Add(this.dataGridView);
            this.Name = "FormClasificationMethodsGrid";
            this.Text = "Clasification Methods";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormClasificationMethodsGrid_FormClosing);
            this.Load += new System.EventHandler(this.FormClasificationMethods_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.metodoClasificacionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.webappDBDataSet)).EndInit();
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
        private System.Windows.Forms.DataGridViewTextBoxColumn parametrosXDefectoDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnDiscard;
        private System.Windows.Forms.Button btnSave;
    }
}