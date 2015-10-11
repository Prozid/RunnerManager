namespace PBioManager
{
    partial class FormResultsGrid
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
            this.dataGridViewResults = new System.Windows.Forms.DataGridView();
            this.idResultadoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numGenesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreGenesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idGenesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.accuracyMediaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.accuracyStdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sensitivityMediaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sensitivityStdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.specificityMediaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.specificityStdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaLanzamientoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaFinalizacionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.duracionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.accuracyXGenesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.medianaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idSimulacionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreGenesSolucionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idGenesSolucionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.resultadoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.webappDBDataSet = new PBioManager.WebappDBDataSet();
            this.resultadoTableAdapter = new PBioManager.WebappDBDataSetTableAdapters.ResultadoTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewResults)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.resultadoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.webappDBDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewResults
            // 
            this.dataGridViewResults.AllowUserToAddRows = false;
            this.dataGridViewResults.AllowUserToDeleteRows = false;
            this.dataGridViewResults.AutoGenerateColumns = false;
            this.dataGridViewResults.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewResults.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idResultadoDataGridViewTextBoxColumn,
            this.numGenesDataGridViewTextBoxColumn,
            this.nombreGenesDataGridViewTextBoxColumn,
            this.idGenesDataGridViewTextBoxColumn,
            this.accuracyMediaDataGridViewTextBoxColumn,
            this.accuracyStdDataGridViewTextBoxColumn,
            this.sensitivityMediaDataGridViewTextBoxColumn,
            this.sensitivityStdDataGridViewTextBoxColumn,
            this.specificityMediaDataGridViewTextBoxColumn,
            this.specificityStdDataGridViewTextBoxColumn,
            this.fechaLanzamientoDataGridViewTextBoxColumn,
            this.fechaFinalizacionDataGridViewTextBoxColumn,
            this.duracionDataGridViewTextBoxColumn,
            this.accuracyXGenesDataGridViewTextBoxColumn,
            this.medianaDataGridViewTextBoxColumn,
            this.idSimulacionDataGridViewTextBoxColumn,
            this.nombreGenesSolucionDataGridViewTextBoxColumn,
            this.idGenesSolucionDataGridViewTextBoxColumn});
            this.dataGridViewResults.DataSource = this.resultadoBindingSource;
            this.dataGridViewResults.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewResults.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewResults.Name = "dataGridViewResults";
            this.dataGridViewResults.ReadOnly = true;
            this.dataGridViewResults.Size = new System.Drawing.Size(1255, 344);
            this.dataGridViewResults.TabIndex = 0;
            this.dataGridViewResults.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // idResultadoDataGridViewTextBoxColumn
            // 
            this.idResultadoDataGridViewTextBoxColumn.DataPropertyName = "IdResultado";
            this.idResultadoDataGridViewTextBoxColumn.HeaderText = "IdResultado";
            this.idResultadoDataGridViewTextBoxColumn.Name = "idResultadoDataGridViewTextBoxColumn";
            this.idResultadoDataGridViewTextBoxColumn.ReadOnly = true;
            this.idResultadoDataGridViewTextBoxColumn.Visible = false;
            // 
            // numGenesDataGridViewTextBoxColumn
            // 
            this.numGenesDataGridViewTextBoxColumn.DataPropertyName = "NumGenes";
            this.numGenesDataGridViewTextBoxColumn.HeaderText = "NumGenes";
            this.numGenesDataGridViewTextBoxColumn.Name = "numGenesDataGridViewTextBoxColumn";
            this.numGenesDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nombreGenesDataGridViewTextBoxColumn
            // 
            this.nombreGenesDataGridViewTextBoxColumn.DataPropertyName = "NombreGenes";
            this.nombreGenesDataGridViewTextBoxColumn.HeaderText = "NombreGenes";
            this.nombreGenesDataGridViewTextBoxColumn.Name = "nombreGenesDataGridViewTextBoxColumn";
            this.nombreGenesDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // idGenesDataGridViewTextBoxColumn
            // 
            this.idGenesDataGridViewTextBoxColumn.DataPropertyName = "IdGenes";
            this.idGenesDataGridViewTextBoxColumn.HeaderText = "IdGenes";
            this.idGenesDataGridViewTextBoxColumn.Name = "idGenesDataGridViewTextBoxColumn";
            this.idGenesDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // accuracyMediaDataGridViewTextBoxColumn
            // 
            this.accuracyMediaDataGridViewTextBoxColumn.DataPropertyName = "Accuracy_Media";
            this.accuracyMediaDataGridViewTextBoxColumn.HeaderText = "Accuracy_Media";
            this.accuracyMediaDataGridViewTextBoxColumn.Name = "accuracyMediaDataGridViewTextBoxColumn";
            this.accuracyMediaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // accuracyStdDataGridViewTextBoxColumn
            // 
            this.accuracyStdDataGridViewTextBoxColumn.DataPropertyName = "Accuracy_Std";
            this.accuracyStdDataGridViewTextBoxColumn.HeaderText = "Accuracy_Std";
            this.accuracyStdDataGridViewTextBoxColumn.Name = "accuracyStdDataGridViewTextBoxColumn";
            this.accuracyStdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // sensitivityMediaDataGridViewTextBoxColumn
            // 
            this.sensitivityMediaDataGridViewTextBoxColumn.DataPropertyName = "Sensitivity_Media";
            this.sensitivityMediaDataGridViewTextBoxColumn.HeaderText = "Sensitivity_Media";
            this.sensitivityMediaDataGridViewTextBoxColumn.Name = "sensitivityMediaDataGridViewTextBoxColumn";
            this.sensitivityMediaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // sensitivityStdDataGridViewTextBoxColumn
            // 
            this.sensitivityStdDataGridViewTextBoxColumn.DataPropertyName = "Sensitivity_Std";
            this.sensitivityStdDataGridViewTextBoxColumn.HeaderText = "Sensitivity_Std";
            this.sensitivityStdDataGridViewTextBoxColumn.Name = "sensitivityStdDataGridViewTextBoxColumn";
            this.sensitivityStdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // specificityMediaDataGridViewTextBoxColumn
            // 
            this.specificityMediaDataGridViewTextBoxColumn.DataPropertyName = "Specificity_Media";
            this.specificityMediaDataGridViewTextBoxColumn.HeaderText = "Specificity_Media";
            this.specificityMediaDataGridViewTextBoxColumn.Name = "specificityMediaDataGridViewTextBoxColumn";
            this.specificityMediaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // specificityStdDataGridViewTextBoxColumn
            // 
            this.specificityStdDataGridViewTextBoxColumn.DataPropertyName = "Specificity_Std";
            this.specificityStdDataGridViewTextBoxColumn.HeaderText = "Specificity_Std";
            this.specificityStdDataGridViewTextBoxColumn.Name = "specificityStdDataGridViewTextBoxColumn";
            this.specificityStdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fechaLanzamientoDataGridViewTextBoxColumn
            // 
            this.fechaLanzamientoDataGridViewTextBoxColumn.DataPropertyName = "FechaLanzamiento";
            this.fechaLanzamientoDataGridViewTextBoxColumn.HeaderText = "FechaLanzamiento";
            this.fechaLanzamientoDataGridViewTextBoxColumn.Name = "fechaLanzamientoDataGridViewTextBoxColumn";
            this.fechaLanzamientoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fechaFinalizacionDataGridViewTextBoxColumn
            // 
            this.fechaFinalizacionDataGridViewTextBoxColumn.DataPropertyName = "FechaFinalizacion";
            this.fechaFinalizacionDataGridViewTextBoxColumn.HeaderText = "FechaFinalizacion";
            this.fechaFinalizacionDataGridViewTextBoxColumn.Name = "fechaFinalizacionDataGridViewTextBoxColumn";
            this.fechaFinalizacionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // duracionDataGridViewTextBoxColumn
            // 
            this.duracionDataGridViewTextBoxColumn.DataPropertyName = "Duracion";
            this.duracionDataGridViewTextBoxColumn.HeaderText = "Duracion";
            this.duracionDataGridViewTextBoxColumn.Name = "duracionDataGridViewTextBoxColumn";
            this.duracionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // accuracyXGenesDataGridViewTextBoxColumn
            // 
            this.accuracyXGenesDataGridViewTextBoxColumn.DataPropertyName = "AccuracyXGenes";
            this.accuracyXGenesDataGridViewTextBoxColumn.HeaderText = "AccuracyXGenes";
            this.accuracyXGenesDataGridViewTextBoxColumn.Name = "accuracyXGenesDataGridViewTextBoxColumn";
            this.accuracyXGenesDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // medianaDataGridViewTextBoxColumn
            // 
            this.medianaDataGridViewTextBoxColumn.DataPropertyName = "Mediana";
            this.medianaDataGridViewTextBoxColumn.HeaderText = "Mediana";
            this.medianaDataGridViewTextBoxColumn.Name = "medianaDataGridViewTextBoxColumn";
            this.medianaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // idSimulacionDataGridViewTextBoxColumn
            // 
            this.idSimulacionDataGridViewTextBoxColumn.DataPropertyName = "IdSimulacion";
            this.idSimulacionDataGridViewTextBoxColumn.HeaderText = "IdSimulacion";
            this.idSimulacionDataGridViewTextBoxColumn.Name = "idSimulacionDataGridViewTextBoxColumn";
            this.idSimulacionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nombreGenesSolucionDataGridViewTextBoxColumn
            // 
            this.nombreGenesSolucionDataGridViewTextBoxColumn.DataPropertyName = "NombreGenesSolucion";
            this.nombreGenesSolucionDataGridViewTextBoxColumn.HeaderText = "NombreGenesSolucion";
            this.nombreGenesSolucionDataGridViewTextBoxColumn.Name = "nombreGenesSolucionDataGridViewTextBoxColumn";
            this.nombreGenesSolucionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // idGenesSolucionDataGridViewTextBoxColumn
            // 
            this.idGenesSolucionDataGridViewTextBoxColumn.DataPropertyName = "IdGenesSolucion";
            this.idGenesSolucionDataGridViewTextBoxColumn.HeaderText = "IdGenesSolucion";
            this.idGenesSolucionDataGridViewTextBoxColumn.Name = "idGenesSolucionDataGridViewTextBoxColumn";
            this.idGenesSolucionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // resultadoBindingSource
            // 
            this.resultadoBindingSource.AllowNew = false;
            this.resultadoBindingSource.DataMember = "Resultado";
            this.resultadoBindingSource.DataSource = this.webappDBDataSet;
            // 
            // webappDBDataSet
            // 
            this.webappDBDataSet.DataSetName = "WebappDBDataSet";
            this.webappDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // resultadoTableAdapter
            // 
            this.resultadoTableAdapter.ClearBeforeFill = true;
            // 
            // FormResultsGrid
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1255, 344);
            this.Controls.Add(this.dataGridViewResults);
            this.Name = "FormResultsGrid";
            this.Text = "Results";
            this.Load += new System.EventHandler(this.FormResults_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewResults)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.resultadoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.webappDBDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private WebappDBDataSet webappDBDataSet;
        private WebappDBDataSetTableAdapters.ResultadoTableAdapter resultadoTableAdapter;
        private System.Windows.Forms.DataGridView dataGridViewResults;
        private System.Windows.Forms.DataGridViewTextBoxColumn idResultadoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numGenesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreGenesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idGenesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn accuracyMediaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn accuracyStdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sensitivityMediaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sensitivityStdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn specificityMediaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn specificityStdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaLanzamientoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaFinalizacionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn duracionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn accuracyXGenesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn medianaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idSimulacionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreGenesSolucionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idGenesSolucionDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource resultadoBindingSource;
    }
}