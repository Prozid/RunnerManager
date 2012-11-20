namespace runnerManager
{
    partial class runnerManagerForm
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.startsvc_button = new System.Windows.Forms.Button();
            this.service_groupBox = new System.Windows.Forms.GroupBox();
            this.stopsvc_button = new System.Windows.Forms.Button();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.label_toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.svcState_toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.Sims_toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.simsState_toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.web_groupBox = new System.Windows.Forms.GroupBox();
            this.run_button = new System.Windows.Forms.Button();
            this.countSim_label = new System.Windows.Forms.Label();
            this.simCountLabel_label = new System.Windows.Forms.Label();
            this.thread_groupBox = new System.Windows.Forms.GroupBox();
            this.threadLog_listBox = new System.Windows.Forms.ListBox();
            this.simulacion_groupBox = new System.Windows.Forms.GroupBox();
            this.SimStates_groupBox = new System.Windows.Forms.GroupBox();
            this.simStates_comboBox = new System.Windows.Forms.ComboBox();
            this.estadoSimulacionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.changeState_button = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estadoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.métodoClasificaciónDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.métodoSelecciónDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usuarioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vistaSimulaciónBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.WebappDBDataSet = new runnerManager.WebappDBDataSet();
            this.timerUpdateSimGrid = new System.Windows.Forms.Timer(this.components);
            this.vistaSimulaciónTableAdapter = new runnerManager.WebappDBDataSetTableAdapters.VistaSimulaciónTableAdapter();
            this.estadoSimulacionTableAdapter = new runnerManager.WebappDBDataSetTableAdapters.EstadoSimulacionTableAdapter();
            this.service_groupBox.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.web_groupBox.SuspendLayout();
            this.thread_groupBox.SuspendLayout();
            this.simulacion_groupBox.SuspendLayout();
            this.SimStates_groupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.estadoSimulacionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vistaSimulaciónBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.WebappDBDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // startsvc_button
            // 
            this.startsvc_button.Location = new System.Drawing.Point(6, 19);
            this.startsvc_button.Name = "startsvc_button";
            this.startsvc_button.Size = new System.Drawing.Size(75, 23);
            this.startsvc_button.TabIndex = 0;
            this.startsvc_button.Text = "Iniciar";
            this.startsvc_button.UseVisualStyleBackColor = true;
            this.startsvc_button.Click += new System.EventHandler(this.startsvc_button_Click);
            // 
            // service_groupBox
            // 
            this.service_groupBox.Controls.Add(this.stopsvc_button);
            this.service_groupBox.Controls.Add(this.startsvc_button);
            this.service_groupBox.Location = new System.Drawing.Point(13, 13);
            this.service_groupBox.Name = "service_groupBox";
            this.service_groupBox.Size = new System.Drawing.Size(243, 53);
            this.service_groupBox.TabIndex = 1;
            this.service_groupBox.TabStop = false;
            this.service_groupBox.Text = "runnerService";
            // 
            // stopsvc_button
            // 
            this.stopsvc_button.Location = new System.Drawing.Point(88, 18);
            this.stopsvc_button.Name = "stopsvc_button";
            this.stopsvc_button.Size = new System.Drawing.Size(75, 23);
            this.stopsvc_button.TabIndex = 1;
            this.stopsvc_button.Text = "Detener";
            this.stopsvc_button.UseVisualStyleBackColor = true;
            this.stopsvc_button.Click += new System.EventHandler(this.stopsvc_button_Click);
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.label_toolStripStatusLabel,
            this.svcState_toolStripStatusLabel,
            this.Sims_toolStripStatusLabel,
            this.simsState_toolStripStatusLabel});
            this.statusStrip.Location = new System.Drawing.Point(0, 360);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(1148, 22);
            this.statusStrip.TabIndex = 3;
            this.statusStrip.Text = "statusStrip";
            // 
            // label_toolStripStatusLabel
            // 
            this.label_toolStripStatusLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_toolStripStatusLabel.Name = "label_toolStripStatusLabel";
            this.label_toolStripStatusLabel.Size = new System.Drawing.Size(60, 17);
            this.label_toolStripStatusLabel.Text = "Svc State";
            // 
            // svcState_toolStripStatusLabel
            // 
            this.svcState_toolStripStatusLabel.Name = "svcState_toolStripStatusLabel";
            this.svcState_toolStripStatusLabel.Size = new System.Drawing.Size(44, 17);
            this.svcState_toolStripStatusLabel.Text = "Parado";
            // 
            // Sims_toolStripStatusLabel
            // 
            this.Sims_toolStripStatusLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Sims_toolStripStatusLabel.Name = "Sims_toolStripStatusLabel";
            this.Sims_toolStripStatusLabel.Size = new System.Drawing.Size(55, 17);
            this.Sims_toolStripStatusLabel.Text = "Updated";
            // 
            // simsState_toolStripStatusLabel
            // 
            this.simsState_toolStripStatusLabel.Name = "simsState_toolStripStatusLabel";
            this.simsState_toolStripStatusLabel.Size = new System.Drawing.Size(51, 17);
            this.simsState_toolStripStatusLabel.Text = "Unknow";
            // 
            // web_groupBox
            // 
            this.web_groupBox.Controls.Add(this.run_button);
            this.web_groupBox.Location = new System.Drawing.Point(13, 73);
            this.web_groupBox.Name = "web_groupBox";
            this.web_groupBox.Size = new System.Drawing.Size(246, 54);
            this.web_groupBox.TabIndex = 4;
            this.web_groupBox.TabStop = false;
            this.web_groupBox.Text = "runnerWeb";
            // 
            // run_button
            // 
            this.run_button.Location = new System.Drawing.Point(7, 19);
            this.run_button.Name = "run_button";
            this.run_button.Size = new System.Drawing.Size(75, 23);
            this.run_button.TabIndex = 0;
            this.run_button.Text = "Run";
            this.run_button.UseVisualStyleBackColor = true;
            this.run_button.Click += new System.EventHandler(this.run_button_Click);
            // 
            // countSim_label
            // 
            this.countSim_label.AutoSize = true;
            this.countSim_label.Location = new System.Drawing.Point(89, 16);
            this.countSim_label.Name = "countSim_label";
            this.countSim_label.Size = new System.Drawing.Size(13, 13);
            this.countSim_label.TabIndex = 2;
            this.countSim_label.Text = "0";
            // 
            // simCountLabel_label
            // 
            this.simCountLabel_label.AutoSize = true;
            this.simCountLabel_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simCountLabel_label.Location = new System.Drawing.Point(6, 16);
            this.simCountLabel_label.Name = "simCountLabel_label";
            this.simCountLabel_label.Size = new System.Drawing.Size(77, 13);
            this.simCountLabel_label.TabIndex = 1;
            this.simCountLabel_label.Text = "Connections";
            // 
            // thread_groupBox
            // 
            this.thread_groupBox.Controls.Add(this.threadLog_listBox);
            this.thread_groupBox.Location = new System.Drawing.Point(13, 133);
            this.thread_groupBox.Name = "thread_groupBox";
            this.thread_groupBox.Size = new System.Drawing.Size(246, 224);
            this.thread_groupBox.TabIndex = 5;
            this.thread_groupBox.TabStop = false;
            this.thread_groupBox.Text = "threadLog";
            // 
            // threadLog_listBox
            // 
            this.threadLog_listBox.FormattingEnabled = true;
            this.threadLog_listBox.HorizontalScrollbar = true;
            this.threadLog_listBox.Location = new System.Drawing.Point(7, 20);
            this.threadLog_listBox.Name = "threadLog_listBox";
            this.threadLog_listBox.Size = new System.Drawing.Size(233, 199);
            this.threadLog_listBox.TabIndex = 3;
            // 
            // simulacion_groupBox
            // 
            this.simulacion_groupBox.Controls.Add(this.countSim_label);
            this.simulacion_groupBox.Controls.Add(this.SimStates_groupBox);
            this.simulacion_groupBox.Controls.Add(this.simCountLabel_label);
            this.simulacion_groupBox.Controls.Add(this.dataGridView1);
            this.simulacion_groupBox.Location = new System.Drawing.Point(265, 13);
            this.simulacion_groupBox.Name = "simulacion_groupBox";
            this.simulacion_groupBox.Size = new System.Drawing.Size(871, 344);
            this.simulacion_groupBox.TabIndex = 6;
            this.simulacion_groupBox.TabStop = false;
            this.simulacion_groupBox.Text = "Simulaciones";
            // 
            // SimStates_groupBox
            // 
            this.SimStates_groupBox.Controls.Add(this.simStates_comboBox);
            this.SimStates_groupBox.Controls.Add(this.changeState_button);
            this.SimStates_groupBox.Location = new System.Drawing.Point(659, 7);
            this.SimStates_groupBox.Name = "SimStates_groupBox";
            this.SimStates_groupBox.Size = new System.Drawing.Size(212, 46);
            this.SimStates_groupBox.TabIndex = 4;
            this.SimStates_groupBox.TabStop = false;
            this.SimStates_groupBox.Text = "Simulation States";
            // 
            // simStates_comboBox
            // 
            this.simStates_comboBox.DataSource = this.estadoSimulacionBindingSource;
            this.simStates_comboBox.DisplayMember = "nombre";
            this.simStates_comboBox.FormattingEnabled = true;
            this.simStates_comboBox.Location = new System.Drawing.Point(6, 14);
            this.simStates_comboBox.Name = "simStates_comboBox";
            this.simStates_comboBox.Size = new System.Drawing.Size(121, 21);
            this.simStates_comboBox.TabIndex = 8;
            this.simStates_comboBox.ValueMember = "idEstadoSimulacion";
            // 
            // estadoSimulacionBindingSource
            // 
            this.estadoSimulacionBindingSource.DataMember = "EstadoSimulacion";
            this.estadoSimulacionBindingSource.DataSource = this.WebappDBDataSet;
            // 
            // changeState_button
            // 
            this.changeState_button.Location = new System.Drawing.Point(133, 14);
            this.changeState_button.Name = "changeState_button";
            this.changeState_button.Size = new System.Drawing.Size(75, 23);
            this.changeState_button.TabIndex = 5;
            this.changeState_button.Text = "Update";
            this.changeState_button.UseVisualStyleBackColor = true;
            this.changeState_button.Click += new System.EventHandler(this.changeState_button_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.estadoDataGridViewTextBoxColumn,
            this.métodoClasificaciónDataGridViewTextBoxColumn,
            this.métodoSelecciónDataGridViewTextBoxColumn,
            this.usuarioDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.vistaSimulaciónBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(6, 60);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(859, 278);
            this.dataGridView1.TabIndex = 2;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "nombre";
            this.dataGridViewTextBoxColumn1.HeaderText = "nombre";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 67;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "descripcion";
            this.dataGridViewTextBoxColumn2.HeaderText = "descripcion";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 86;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "fechaCreacion";
            this.dataGridViewTextBoxColumn3.HeaderText = "fechaCreacion";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 101;
            // 
            // estadoDataGridViewTextBoxColumn
            // 
            this.estadoDataGridViewTextBoxColumn.DataPropertyName = "Estado";
            this.estadoDataGridViewTextBoxColumn.HeaderText = "Estado";
            this.estadoDataGridViewTextBoxColumn.Name = "estadoDataGridViewTextBoxColumn";
            this.estadoDataGridViewTextBoxColumn.ReadOnly = true;
            this.estadoDataGridViewTextBoxColumn.Width = 65;
            // 
            // métodoClasificaciónDataGridViewTextBoxColumn
            // 
            this.métodoClasificaciónDataGridViewTextBoxColumn.DataPropertyName = "Método Clasificación";
            this.métodoClasificaciónDataGridViewTextBoxColumn.HeaderText = "Método Clasificación";
            this.métodoClasificaciónDataGridViewTextBoxColumn.Name = "métodoClasificaciónDataGridViewTextBoxColumn";
            this.métodoClasificaciónDataGridViewTextBoxColumn.ReadOnly = true;
            this.métodoClasificaciónDataGridViewTextBoxColumn.Width = 119;
            // 
            // métodoSelecciónDataGridViewTextBoxColumn
            // 
            this.métodoSelecciónDataGridViewTextBoxColumn.DataPropertyName = "Método Selección";
            this.métodoSelecciónDataGridViewTextBoxColumn.HeaderText = "Método Selección";
            this.métodoSelecciónDataGridViewTextBoxColumn.Name = "métodoSelecciónDataGridViewTextBoxColumn";
            this.métodoSelecciónDataGridViewTextBoxColumn.ReadOnly = true;
            this.métodoSelecciónDataGridViewTextBoxColumn.Width = 108;
            // 
            // usuarioDataGridViewTextBoxColumn
            // 
            this.usuarioDataGridViewTextBoxColumn.DataPropertyName = "usuario";
            this.usuarioDataGridViewTextBoxColumn.HeaderText = "usuario";
            this.usuarioDataGridViewTextBoxColumn.Name = "usuarioDataGridViewTextBoxColumn";
            this.usuarioDataGridViewTextBoxColumn.ReadOnly = true;
            this.usuarioDataGridViewTextBoxColumn.Width = 66;
            // 
            // vistaSimulaciónBindingSource
            // 
            this.vistaSimulaciónBindingSource.DataMember = "VistaSimulación";
            this.vistaSimulaciónBindingSource.DataSource = this.WebappDBDataSet;
            // 
            // WebappDBDataSet
            // 
            this.WebappDBDataSet.DataSetName = "WebappDBDataSet";
            this.WebappDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // timerUpdateSimGrid
            // 
            this.timerUpdateSimGrid.Tick += new System.EventHandler(this.timerUpdateSimGrid_Tick);
            // 
            // vistaSimulaciónTableAdapter
            // 
            this.vistaSimulaciónTableAdapter.ClearBeforeFill = true;
            // 
            // estadoSimulacionTableAdapter
            // 
            this.estadoSimulacionTableAdapter.ClearBeforeFill = true;
            // 
            // runnerManagerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1148, 382);
            this.Controls.Add(this.simulacion_groupBox);
            this.Controls.Add(this.thread_groupBox);
            this.Controls.Add(this.web_groupBox);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.service_groupBox);
            this.Name = "runnerManagerForm";
            this.Text = "RunnerManager";
            this.Load += new System.EventHandler(this.runnerManagerForm_Load);
            this.service_groupBox.ResumeLayout(false);
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.web_groupBox.ResumeLayout(false);
            this.thread_groupBox.ResumeLayout(false);
            this.simulacion_groupBox.ResumeLayout(false);
            this.simulacion_groupBox.PerformLayout();
            this.SimStates_groupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.estadoSimulacionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vistaSimulaciónBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.WebappDBDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button startsvc_button;
        private System.Windows.Forms.GroupBox service_groupBox;
        private System.Windows.Forms.Button stopsvc_button;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel label_toolStripStatusLabel;
        private System.Windows.Forms.ToolStripStatusLabel svcState_toolStripStatusLabel;
        private System.Windows.Forms.GroupBox web_groupBox;
        private System.Windows.Forms.Button run_button;
        private System.Windows.Forms.GroupBox thread_groupBox;
        private System.Windows.Forms.ListBox threadLog_listBox;
        
        
        private System.Windows.Forms.GroupBox simulacion_groupBox;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Timer timerUpdateSimGrid;
        private System.Windows.Forms.ToolStripStatusLabel Sims_toolStripStatusLabel;
        private System.Windows.Forms.ToolStripStatusLabel simsState_toolStripStatusLabel;
        private WebappDBDataSet WebappDBDataSet;
        private System.Windows.Forms.BindingSource vistaSimulaciónBindingSource;
        private WebappDBDataSetTableAdapters.VistaSimulaciónTableAdapter vistaSimulaciónTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn estadoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn métodoClasificaciónDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn métodoSelecciónDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn usuarioDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label countSim_label;
        private System.Windows.Forms.Label simCountLabel_label;
        private System.Windows.Forms.GroupBox SimStates_groupBox;
        private System.Windows.Forms.Button changeState_button;
        private System.Windows.Forms.ComboBox simStates_comboBox;
        private System.Windows.Forms.BindingSource estadoSimulacionBindingSource;
        private WebappDBDataSetTableAdapters.EstadoSimulacionTableAdapter estadoSimulacionTableAdapter;

    }
}

