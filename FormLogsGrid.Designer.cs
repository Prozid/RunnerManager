namespace PBioManager
{
    partial class FormLogsGrid
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
            this.webappDBDataSet = new PBioManager.WebappDBDataSet();
            this.dataGridViewLog = new System.Windows.Forms.DataGridView();
            this.idLogDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaLogDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.logBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.logTableAdapter = new PBioManager.WebappDBDataSetTableAdapters.LogTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.webappDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLog)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // webappDBDataSet
            // 
            this.webappDBDataSet.DataSetName = "WebappDBDataSet";
            this.webappDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataGridViewLog
            // 
            this.dataGridViewLog.AllowUserToAddRows = false;
            this.dataGridViewLog.AllowUserToDeleteRows = false;
            this.dataGridViewLog.AutoGenerateColumns = false;
            this.dataGridViewLog.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewLog.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idLogDataGridViewTextBoxColumn,
            this.fechaLogDataGridViewTextBoxColumn,
            this.textoDataGridViewTextBoxColumn});
            this.dataGridViewLog.DataSource = this.logBindingSource;
            this.dataGridViewLog.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewLog.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewLog.Name = "dataGridViewLog";
            this.dataGridViewLog.ReadOnly = true;
            this.dataGridViewLog.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewLog.Size = new System.Drawing.Size(284, 262);
            this.dataGridViewLog.TabIndex = 0;
            this.dataGridViewLog.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewLog_CellDoubleClick);
            // 
            // idLogDataGridViewTextBoxColumn
            // 
            this.idLogDataGridViewTextBoxColumn.DataPropertyName = "IdLog";
            this.idLogDataGridViewTextBoxColumn.HeaderText = "IdLog";
            this.idLogDataGridViewTextBoxColumn.Name = "idLogDataGridViewTextBoxColumn";
            this.idLogDataGridViewTextBoxColumn.ReadOnly = true;
            this.idLogDataGridViewTextBoxColumn.Visible = false;
            // 
            // fechaLogDataGridViewTextBoxColumn
            // 
            this.fechaLogDataGridViewTextBoxColumn.DataPropertyName = "FechaLog";
            this.fechaLogDataGridViewTextBoxColumn.HeaderText = "Fecha";
            this.fechaLogDataGridViewTextBoxColumn.Name = "fechaLogDataGridViewTextBoxColumn";
            this.fechaLogDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // textoDataGridViewTextBoxColumn
            // 
            this.textoDataGridViewTextBoxColumn.DataPropertyName = "Texto";
            this.textoDataGridViewTextBoxColumn.HeaderText = "Texto";
            this.textoDataGridViewTextBoxColumn.Name = "textoDataGridViewTextBoxColumn";
            this.textoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // logBindingSource
            // 
            this.logBindingSource.DataMember = "Log";
            this.logBindingSource.DataSource = this.webappDBDataSet;
            // 
            // logTableAdapter
            // 
            this.logTableAdapter.ClearBeforeFill = true;
            // 
            // FormLogsGrid
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.dataGridViewLog);
            this.Name = "FormLogsGrid";
            this.Text = "Logs";
            this.Load += new System.EventHandler(this.FormLog_Load);
            ((System.ComponentModel.ISupportInitialize)(this.webappDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLog)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private WebappDBDataSet webappDBDataSet;
        private System.Windows.Forms.DataGridView dataGridViewLog;
        private System.Windows.Forms.DataGridViewTextBoxColumn idLogDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaLogDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn textoDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource logBindingSource;
        private WebappDBDataSetTableAdapters.LogTableAdapter logTableAdapter;

    }
}