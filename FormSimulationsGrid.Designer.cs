namespace PBioManager
{
    partial class FormSimulationsGrid
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
            this.SimStates_groupBox = new System.Windows.Forms.GroupBox();
            this.simStates_comboBox = new System.Windows.Forms.ComboBox();
            this.estadoSimulacionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.webappDBDataSet = new PBioManager.WebappDBDataSet();
            this.changeState_button = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idSimulacionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaCreacionSimulacionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usuarioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.metodoSeleccionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.metodoClasificacionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estadoSimulacionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vistaSimulacionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.estadoSimulacionTableAdapter = new PBioManager.WebappDBDataSetTableAdapters.EstadoSimulacionTableAdapter();
            this.simulacionTableAdapter = new PBioManager.WebappDBDataSetTableAdapters.SimulacionTableAdapter();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.simulacionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vistaSimulacionTableAdapter = new PBioManager.WebappDBDataSetTableAdapters.VistaSimulacionTableAdapter();
            this.SimStates_groupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.estadoSimulacionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.webappDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vistaSimulacionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.simulacionBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // SimStates_groupBox
            // 
            this.SimStates_groupBox.Controls.Add(this.simStates_comboBox);
            this.SimStates_groupBox.Controls.Add(this.changeState_button);
            this.SimStates_groupBox.Location = new System.Drawing.Point(12, 343);
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
            this.simStates_comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
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
            this.estadoSimulacionBindingSource.DataSource = this.webappDBDataSet;
            // 
            // webappDBDataSet
            // 
            this.webappDBDataSet.DataSetName = "WebappDBDataSet";
            this.webappDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idSimulacionDataGridViewTextBoxColumn,
            this.nombreDataGridViewTextBoxColumn,
            this.descripcionDataGridViewTextBoxColumn,
            this.fechaCreacionSimulacionDataGridViewTextBoxColumn,
            this.usuarioDataGridViewTextBoxColumn,
            this.metodoSeleccionDataGridViewTextBoxColumn,
            this.metodoClasificacionDataGridViewTextBoxColumn,
            this.estadoSimulacionDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.vistaSimulacionBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(595, 325);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // idSimulacionDataGridViewTextBoxColumn
            // 
            this.idSimulacionDataGridViewTextBoxColumn.DataPropertyName = "IdSimulacion";
            this.idSimulacionDataGridViewTextBoxColumn.HeaderText = "Id Simulation";
            this.idSimulacionDataGridViewTextBoxColumn.Name = "idSimulacionDataGridViewTextBoxColumn";
            this.idSimulacionDataGridViewTextBoxColumn.ReadOnly = true;
            this.idSimulacionDataGridViewTextBoxColumn.Visible = false;
            // 
            // nombreDataGridViewTextBoxColumn
            // 
            this.nombreDataGridViewTextBoxColumn.DataPropertyName = "Nombre";
            this.nombreDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nombreDataGridViewTextBoxColumn.Name = "nombreDataGridViewTextBoxColumn";
            this.nombreDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // descripcionDataGridViewTextBoxColumn
            // 
            this.descripcionDataGridViewTextBoxColumn.DataPropertyName = "Descripcion";
            this.descripcionDataGridViewTextBoxColumn.HeaderText = "Description";
            this.descripcionDataGridViewTextBoxColumn.Name = "descripcionDataGridViewTextBoxColumn";
            this.descripcionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fechaCreacionSimulacionDataGridViewTextBoxColumn
            // 
            this.fechaCreacionSimulacionDataGridViewTextBoxColumn.DataPropertyName = "FechaCreacionSimulacion";
            this.fechaCreacionSimulacionDataGridViewTextBoxColumn.HeaderText = "Creation date";
            this.fechaCreacionSimulacionDataGridViewTextBoxColumn.Name = "fechaCreacionSimulacionDataGridViewTextBoxColumn";
            this.fechaCreacionSimulacionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // usuarioDataGridViewTextBoxColumn
            // 
            this.usuarioDataGridViewTextBoxColumn.DataPropertyName = "Usuario";
            this.usuarioDataGridViewTextBoxColumn.HeaderText = "User";
            this.usuarioDataGridViewTextBoxColumn.Name = "usuarioDataGridViewTextBoxColumn";
            this.usuarioDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // metodoSeleccionDataGridViewTextBoxColumn
            // 
            this.metodoSeleccionDataGridViewTextBoxColumn.DataPropertyName = "MetodoSeleccion";
            this.metodoSeleccionDataGridViewTextBoxColumn.HeaderText = "Selection Method";
            this.metodoSeleccionDataGridViewTextBoxColumn.Name = "metodoSeleccionDataGridViewTextBoxColumn";
            this.metodoSeleccionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // metodoClasificacionDataGridViewTextBoxColumn
            // 
            this.metodoClasificacionDataGridViewTextBoxColumn.DataPropertyName = "MetodoClasificacion";
            this.metodoClasificacionDataGridViewTextBoxColumn.HeaderText = "Clasification Method";
            this.metodoClasificacionDataGridViewTextBoxColumn.Name = "metodoClasificacionDataGridViewTextBoxColumn";
            this.metodoClasificacionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // estadoSimulacionDataGridViewTextBoxColumn
            // 
            this.estadoSimulacionDataGridViewTextBoxColumn.DataPropertyName = "EstadoSimulacion";
            this.estadoSimulacionDataGridViewTextBoxColumn.HeaderText = "State";
            this.estadoSimulacionDataGridViewTextBoxColumn.Name = "estadoSimulacionDataGridViewTextBoxColumn";
            this.estadoSimulacionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // vistaSimulacionBindingSource
            // 
            this.vistaSimulacionBindingSource.DataMember = "VistaSimulacion";
            this.vistaSimulacionBindingSource.DataSource = this.webappDBDataSet;
            // 
            // estadoSimulacionTableAdapter
            // 
            this.estadoSimulacionTableAdapter.ClearBeforeFill = true;
            // 
            // simulacionTableAdapter
            // 
            this.simulacionTableAdapter.ClearBeforeFill = true;
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataMember = "Simulacion";
            this.bindingSource1.DataSource = this.webappDBDataSet;
            // 
            // simulacionBindingSource
            // 
            this.simulacionBindingSource.DataMember = "Simulacion";
            this.simulacionBindingSource.DataSource = this.webappDBDataSet;
            // 
            // vistaSimulacionTableAdapter
            // 
            this.vistaSimulacionTableAdapter.ClearBeforeFill = true;
            // 
            // FormSimulationsGrid
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(619, 401);
            this.Controls.Add(this.SimStates_groupBox);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FormSimulationsGrid";
            this.Text = "Simulations";
            this.Load += new System.EventHandler(this.SimulationsForm_Load);
            this.SimStates_groupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.estadoSimulacionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.webappDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vistaSimulacionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.simulacionBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox SimStates_groupBox;
        private System.Windows.Forms.ComboBox simStates_comboBox;
        private System.Windows.Forms.Button changeState_button;
        private System.Windows.Forms.DataGridView dataGridView1;
        private WebappDBDataSet webappDBDataSet;
        private System.Windows.Forms.BindingSource estadoSimulacionBindingSource;
        private WebappDBDataSetTableAdapters.EstadoSimulacionTableAdapter estadoSimulacionTableAdapter;
        private WebappDBDataSetTableAdapters.SimulacionTableAdapter simulacionTableAdapter;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.BindingSource simulacionBindingSource;
        private WebappDBDataSetTableAdapters.VistaSimulacionTableAdapter vistaSimulacionTableAdapter;
        private System.Windows.Forms.BindingSource vistaSimulacionBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn idSimulacionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaCreacionSimulacionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn usuarioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn metodoSeleccionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn metodoClasificacionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn estadoSimulacionDataGridViewTextBoxColumn;
    }
}