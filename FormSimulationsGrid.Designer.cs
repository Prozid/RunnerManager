namespace runnerManager
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
            this.webappDBDataSet = new runnerManager.WebappDBDataSet();
            this.changeState_button = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idSimulacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaCreacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaCreacionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estadoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.métodoClasificaciónDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.métodoSelecciónDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usuarioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idSimulacionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vistaSimulaciónBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vistaSimulaciónTableAdapter = new runnerManager.WebappDBDataSetTableAdapters.VistaSimulaciónTableAdapter();
            this.estadoSimulacionTableAdapter = new runnerManager.WebappDBDataSetTableAdapters.EstadoSimulacionTableAdapter();
            this.simulacionTableAdapter = new runnerManager.WebappDBDataSetTableAdapters.SimulacionTableAdapter();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.SimStates_groupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.estadoSimulacionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.webappDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vistaSimulaciónBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // SimStates_groupBox
            // 
            this.SimStates_groupBox.Controls.Add(this.simStates_comboBox);
            this.SimStates_groupBox.Controls.Add(this.changeState_button);
            this.SimStates_groupBox.Location = new System.Drawing.Point(8, 343);
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
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nombre,
            this.idSimulacion,
            this.descripcion,
            this.fechaCreacion,
            this.dataGridViewTextBoxColumn1,
            this.usuario,
            this.nombreDataGridViewTextBoxColumn,
            this.descripcionDataGridViewTextBoxColumn,
            this.fechaCreacionDataGridViewTextBoxColumn,
            this.estadoDataGridViewTextBoxColumn,
            this.métodoClasificaciónDataGridViewTextBoxColumn,
            this.métodoSelecciónDataGridViewTextBoxColumn,
            this.usuarioDataGridViewTextBoxColumn,
            this.idSimulacionDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.vistaSimulaciónBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(8, 12);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(445, 325);
            this.dataGridView1.TabIndex = 2;
            // 
            // nombre
            // 
            this.nombre.DataPropertyName = "nombre";
            this.nombre.HeaderText = "nombre";
            this.nombre.Name = "nombre";
            this.nombre.ReadOnly = true;
            this.nombre.Width = 67;
            // 
            // idSimulacion
            // 
            this.idSimulacion.DataPropertyName = "idSimulacion";
            this.idSimulacion.HeaderText = "idSimulacion";
            this.idSimulacion.Name = "idSimulacion";
            this.idSimulacion.ReadOnly = true;
            this.idSimulacion.Visible = false;
            this.idSimulacion.Width = 91;
            // 
            // descripcion
            // 
            this.descripcion.DataPropertyName = "descripcion";
            this.descripcion.HeaderText = "descripcion";
            this.descripcion.Name = "descripcion";
            this.descripcion.ReadOnly = true;
            this.descripcion.Width = 86;
            // 
            // fechaCreacion
            // 
            this.fechaCreacion.DataPropertyName = "fechaCreacion";
            this.fechaCreacion.HeaderText = "fechaCreacion";
            this.fechaCreacion.Name = "fechaCreacion";
            this.fechaCreacion.ReadOnly = true;
            this.fechaCreacion.Width = 101;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Estado";
            this.dataGridViewTextBoxColumn1.HeaderText = "Estado";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 65;
            // 
            // usuario
            // 
            this.usuario.DataPropertyName = "usuario";
            this.usuario.HeaderText = "usuario";
            this.usuario.Name = "usuario";
            this.usuario.ReadOnly = true;
            this.usuario.Width = 66;
            // 
            // nombreDataGridViewTextBoxColumn
            // 
            this.nombreDataGridViewTextBoxColumn.DataPropertyName = "nombre";
            this.nombreDataGridViewTextBoxColumn.HeaderText = "nombre";
            this.nombreDataGridViewTextBoxColumn.Name = "nombreDataGridViewTextBoxColumn";
            this.nombreDataGridViewTextBoxColumn.ReadOnly = true;
            this.nombreDataGridViewTextBoxColumn.Width = 67;
            // 
            // descripcionDataGridViewTextBoxColumn
            // 
            this.descripcionDataGridViewTextBoxColumn.DataPropertyName = "descripcion";
            this.descripcionDataGridViewTextBoxColumn.HeaderText = "descripcion";
            this.descripcionDataGridViewTextBoxColumn.Name = "descripcionDataGridViewTextBoxColumn";
            this.descripcionDataGridViewTextBoxColumn.ReadOnly = true;
            this.descripcionDataGridViewTextBoxColumn.Width = 86;
            // 
            // fechaCreacionDataGridViewTextBoxColumn
            // 
            this.fechaCreacionDataGridViewTextBoxColumn.DataPropertyName = "fechaCreacion";
            this.fechaCreacionDataGridViewTextBoxColumn.HeaderText = "fechaCreacion";
            this.fechaCreacionDataGridViewTextBoxColumn.Name = "fechaCreacionDataGridViewTextBoxColumn";
            this.fechaCreacionDataGridViewTextBoxColumn.ReadOnly = true;
            this.fechaCreacionDataGridViewTextBoxColumn.Width = 101;
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
            // idSimulacionDataGridViewTextBoxColumn
            // 
            this.idSimulacionDataGridViewTextBoxColumn.DataPropertyName = "idSimulacion";
            this.idSimulacionDataGridViewTextBoxColumn.HeaderText = "idSimulacion";
            this.idSimulacionDataGridViewTextBoxColumn.Name = "idSimulacionDataGridViewTextBoxColumn";
            this.idSimulacionDataGridViewTextBoxColumn.ReadOnly = true;
            this.idSimulacionDataGridViewTextBoxColumn.Width = 91;
            // 
            // vistaSimulaciónBindingSource
            // 
            this.vistaSimulaciónBindingSource.DataMember = "VistaSimulación";
            this.vistaSimulaciónBindingSource.DataSource = this.webappDBDataSet;
            // 
            // vistaSimulaciónTableAdapter
            // 
            this.vistaSimulaciónTableAdapter.ClearBeforeFill = true;
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
            // FormSimulationsGrid
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(467, 401);
            this.Controls.Add(this.SimStates_groupBox);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FormSimulationsGrid";
            this.Text = "SimulationsForm";
            this.Load += new System.EventHandler(this.SimulationsForm_Load);
            this.SimStates_groupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.estadoSimulacionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.webappDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vistaSimulaciónBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox SimStates_groupBox;
        private System.Windows.Forms.ComboBox simStates_comboBox;
        private System.Windows.Forms.Button changeState_button;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn idSimulacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaCreacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn usuario;
        private WebappDBDataSet webappDBDataSet;
        private System.Windows.Forms.BindingSource vistaSimulaciónBindingSource;
        private WebappDBDataSetTableAdapters.VistaSimulaciónTableAdapter vistaSimulaciónTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaCreacionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn estadoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn métodoClasificaciónDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn métodoSelecciónDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn usuarioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idSimulacionDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource estadoSimulacionBindingSource;
        private WebappDBDataSetTableAdapters.EstadoSimulacionTableAdapter estadoSimulacionTableAdapter;
        private WebappDBDataSetTableAdapters.SimulacionTableAdapter simulacionTableAdapter;
        private System.Windows.Forms.BindingSource bindingSource1;
    }
}