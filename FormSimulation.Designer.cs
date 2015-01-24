namespace PBioManager
{
    partial class FormSimulation
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
            this.lblName = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            this.cbxStateSimulation = new System.Windows.Forms.ComboBox();
            this.estadoSimulacionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.webappDBDataSet = new PBioManager.WebappDBDataSet();
            this.cbxSelection = new System.Windows.Forms.ComboBox();
            this.metodoSeleccionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cbxClasification = new System.Windows.Forms.ComboBox();
            this.metodoClasificacionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lblState = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.gbxMethods = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtArgsSelection = new System.Windows.Forms.TextBox();
            this.txtArgsClasification = new System.Windows.Forms.TextBox();
            this.lblUser = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.estadoSimulacionTableAdapter = new PBioManager.WebappDBDataSetTableAdapters.EstadoSimulacionTableAdapter();
            this.metodoSeleccionTableAdapter = new PBioManager.WebappDBDataSetTableAdapters.MetodoSeleccionTableAdapter();
            this.metodoClasificacionTableAdapter = new PBioManager.WebappDBDataSetTableAdapters.MetodoClasificacionTableAdapter();
            this.btnSave = new System.Windows.Forms.Button();
            this.lblProject = new System.Windows.Forms.Label();
            this.cbxArchivo = new System.Windows.Forms.ComboBox();
            this.archivoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cbxCarpeta = new System.Windows.Forms.ComboBox();
            this.carpetaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.archivoTableAdapter = new PBioManager.WebappDBDataSetTableAdapters.ArchivoTableAdapter();
            this.carpetaTableAdapter = new PBioManager.WebappDBDataSetTableAdapters.CarpetaTableAdapter();
            this.simulacionTableAdapter = new PBioManager.WebappDBDataSetTableAdapters.SimulacionTableAdapter();
            this.simulacionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnDelete = new System.Windows.Forms.Button();
            this.cbxProject = new System.Windows.Forms.ComboBox();
            this.proyectoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.proyectoTableAdapter = new PBioManager.WebappDBDataSetTableAdapters.ProyectoTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.estadoSimulacionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.webappDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.metodoSeleccionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.metodoClasificacionBindingSource)).BeginInit();
            this.gbxMethods.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.archivoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.carpetaBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.simulacionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.proyectoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(12, 19);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(35, 13);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Name";
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(12, 79);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(60, 13);
            this.lblDescription.TabIndex = 1;
            this.lblDescription.Text = "Description";
            // 
            // cbxStateSimulation
            // 
            this.cbxStateSimulation.DataSource = this.estadoSimulacionBindingSource;
            this.cbxStateSimulation.DisplayMember = "nombre";
            this.cbxStateSimulation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxStateSimulation.FormattingEnabled = true;
            this.cbxStateSimulation.Location = new System.Drawing.Point(294, 41);
            this.cbxStateSimulation.Name = "cbxStateSimulation";
            this.cbxStateSimulation.Size = new System.Drawing.Size(181, 21);
            this.cbxStateSimulation.TabIndex = 2;
            this.cbxStateSimulation.ValueMember = "idEstadoSimulacion";
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
            // cbxSelection
            // 
            this.cbxSelection.DataSource = this.metodoSeleccionBindingSource;
            this.cbxSelection.DisplayMember = "nombre";
            this.cbxSelection.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxSelection.FormattingEnabled = true;
            this.cbxSelection.Location = new System.Drawing.Point(76, 56);
            this.cbxSelection.Name = "cbxSelection";
            this.cbxSelection.Size = new System.Drawing.Size(189, 21);
            this.cbxSelection.TabIndex = 3;
            this.cbxSelection.ValueMember = "idMetodoSeleccion";
            // 
            // metodoSeleccionBindingSource
            // 
            this.metodoSeleccionBindingSource.DataMember = "MetodoSeleccion";
            this.metodoSeleccionBindingSource.DataSource = this.webappDBDataSet;
            // 
            // cbxClasification
            // 
            this.cbxClasification.DataSource = this.metodoClasificacionBindingSource;
            this.cbxClasification.DisplayMember = "nombre";
            this.cbxClasification.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxClasification.FormattingEnabled = true;
            this.cbxClasification.Location = new System.Drawing.Point(76, 29);
            this.cbxClasification.Name = "cbxClasification";
            this.cbxClasification.Size = new System.Drawing.Size(189, 21);
            this.cbxClasification.TabIndex = 4;
            this.cbxClasification.ValueMember = "idMetodoClasificacion";
            // 
            // metodoClasificacionBindingSource
            // 
            this.metodoClasificacionBindingSource.DataMember = "MetodoClasificacion";
            this.metodoClasificacionBindingSource.DataSource = this.webappDBDataSet;
            // 
            // lblState
            // 
            this.lblState.AutoSize = true;
            this.lblState.Location = new System.Drawing.Point(248, 49);
            this.lblState.Name = "lblState";
            this.lblState.Size = new System.Drawing.Size(32, 13);
            this.lblState.TabIndex = 5;
            this.lblState.Text = "State";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 37);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Clasification";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 64);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Selection";
            // 
            // gbxMethods
            // 
            this.gbxMethods.Controls.Add(this.label7);
            this.gbxMethods.Controls.Add(this.txtArgsSelection);
            this.gbxMethods.Controls.Add(this.txtArgsClasification);
            this.gbxMethods.Controls.Add(this.label5);
            this.gbxMethods.Controls.Add(this.label4);
            this.gbxMethods.Controls.Add(this.cbxSelection);
            this.gbxMethods.Controls.Add(this.cbxClasification);
            this.gbxMethods.Location = new System.Drawing.Point(17, 178);
            this.gbxMethods.Name = "gbxMethods";
            this.gbxMethods.Size = new System.Drawing.Size(460, 88);
            this.gbxMethods.TabIndex = 8;
            this.gbxMethods.TabStop = false;
            this.gbxMethods.Text = "Methods";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(268, 13);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(28, 13);
            this.label7.TabIndex = 10;
            this.label7.Text = "Args";
            // 
            // txtArgsSelection
            // 
            this.txtArgsSelection.Location = new System.Drawing.Point(271, 56);
            this.txtArgsSelection.Name = "txtArgsSelection";
            this.txtArgsSelection.Size = new System.Drawing.Size(183, 20);
            this.txtArgsSelection.TabIndex = 9;
            // 
            // txtArgsClasification
            // 
            this.txtArgsClasification.Location = new System.Drawing.Point(271, 29);
            this.txtArgsClasification.Name = "txtArgsClasification";
            this.txtArgsClasification.Size = new System.Drawing.Size(183, 20);
            this.txtArgsClasification.TabIndex = 8;
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Location = new System.Drawing.Point(12, 49);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(29, 13);
            this.lblUser.TabIndex = 9;
            this.lblUser.Text = "User";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(53, 12);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(180, 20);
            this.txtName.TabIndex = 10;
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(15, 95);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(460, 77);
            this.txtDescription.TabIndex = 11;
            // 
            // txtUser
            // 
            this.txtUser.Location = new System.Drawing.Point(53, 42);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(180, 20);
            this.txtUser.TabIndex = 12;
            // 
            // estadoSimulacionTableAdapter
            // 
            this.estadoSimulacionTableAdapter.ClearBeforeFill = true;
            // 
            // metodoSeleccionTableAdapter
            // 
            this.metodoSeleccionTableAdapter.ClearBeforeFill = true;
            // 
            // metodoClasificacionTableAdapter
            // 
            this.metodoClasificacionTableAdapter.ClearBeforeFill = true;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(396, 326);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 13;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lblProject
            // 
            this.lblProject.AutoSize = true;
            this.lblProject.Location = new System.Drawing.Point(248, 15);
            this.lblProject.Name = "lblProject";
            this.lblProject.Size = new System.Drawing.Size(40, 13);
            this.lblProject.TabIndex = 14;
            this.lblProject.Text = "Project";
            // 
            // cbxArchivo
            // 
            this.cbxArchivo.DataSource = this.archivoBindingSource;
            this.cbxArchivo.DisplayMember = "NombreArchivo";
            this.cbxArchivo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxArchivo.FormattingEnabled = true;
            this.cbxArchivo.Location = new System.Drawing.Point(76, 19);
            this.cbxArchivo.Name = "cbxArchivo";
            this.cbxArchivo.Size = new System.Drawing.Size(189, 21);
            this.cbxArchivo.TabIndex = 16;
            this.cbxArchivo.ValueMember = "IdArchivo";
            // 
            // archivoBindingSource
            // 
            this.archivoBindingSource.DataMember = "Archivo";
            this.archivoBindingSource.DataSource = this.webappDBDataSet;
            // 
            // cbxCarpeta
            // 
            this.cbxCarpeta.DataSource = this.carpetaBindingSource;
            this.cbxCarpeta.DisplayMember = "Nombre";
            this.cbxCarpeta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxCarpeta.FormattingEnabled = true;
            this.cbxCarpeta.Location = new System.Drawing.Point(76, 51);
            this.cbxCarpeta.Name = "cbxCarpeta";
            this.cbxCarpeta.Size = new System.Drawing.Size(189, 21);
            this.cbxCarpeta.TabIndex = 17;
            this.cbxCarpeta.ValueMember = "IdCarpeta";
            // 
            // carpetaBindingSource
            // 
            this.carpetaBindingSource.DataMember = "Carpeta";
            this.carpetaBindingSource.DataSource = this.webappDBDataSet;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 18;
            this.label1.Text = "Archivo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 19;
            this.label2.Text = "Carpeta";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbxArchivo);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cbxCarpeta);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(17, 272);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(271, 89);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Data";
            // 
            // archivoTableAdapter
            // 
            this.archivoTableAdapter.ClearBeforeFill = true;
            // 
            // carpetaTableAdapter
            // 
            this.carpetaTableAdapter.ClearBeforeFill = true;
            // 
            // simulacionTableAdapter
            // 
            this.simulacionTableAdapter.ClearBeforeFill = true;
            // 
            // simulacionBindingSource
            // 
            this.simulacionBindingSource.DataMember = "Simulacion";
            this.simulacionBindingSource.DataSource = this.webappDBDataSet;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(315, 326);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 21;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Visible = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // cbxProject
            // 
            this.cbxProject.DataSource = this.proyectoBindingSource;
            this.cbxProject.DisplayMember = "Nombre";
            this.cbxProject.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxProject.FormattingEnabled = true;
            this.cbxProject.Location = new System.Drawing.Point(294, 11);
            this.cbxProject.Name = "cbxProject";
            this.cbxProject.Size = new System.Drawing.Size(181, 21);
            this.cbxProject.TabIndex = 22;
            this.cbxProject.ValueMember = "IdProyecto";
            // 
            // proyectoBindingSource
            // 
            this.proyectoBindingSource.DataMember = "Proyecto";
            this.proyectoBindingSource.DataSource = this.webappDBDataSet;
            // 
            // proyectoTableAdapter
            // 
            this.proyectoTableAdapter.ClearBeforeFill = true;
            // 
            // FormSimulation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(489, 370);
            this.Controls.Add(this.cbxProject);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblProject);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtUser);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblUser);
            this.Controls.Add(this.gbxMethods);
            this.Controls.Add(this.lblState);
            this.Controls.Add(this.cbxStateSimulation);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.lblName);
            this.Name = "FormSimulation";
            this.Text = "Simulation";
            this.Load += new System.EventHandler(this.FormSimulation_Load);
            ((System.ComponentModel.ISupportInitialize)(this.estadoSimulacionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.webappDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.metodoSeleccionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.metodoClasificacionBindingSource)).EndInit();
            this.gbxMethods.ResumeLayout(false);
            this.gbxMethods.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.archivoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.carpetaBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.simulacionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.proyectoBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.ComboBox cbxStateSimulation;
        private System.Windows.Forms.ComboBox cbxSelection;
        private System.Windows.Forms.ComboBox cbxClasification;
        private System.Windows.Forms.Label lblState;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox gbxMethods;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtArgsSelection;
        private System.Windows.Forms.TextBox txtArgsClasification;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.TextBox txtUser;
        private WebappDBDataSet webappDBDataSet;
        private System.Windows.Forms.BindingSource estadoSimulacionBindingSource;
        private WebappDBDataSetTableAdapters.EstadoSimulacionTableAdapter estadoSimulacionTableAdapter;
        private System.Windows.Forms.BindingSource metodoSeleccionBindingSource;
        private WebappDBDataSetTableAdapters.MetodoSeleccionTableAdapter metodoSeleccionTableAdapter;
        private System.Windows.Forms.BindingSource metodoClasificacionBindingSource;
        private WebappDBDataSetTableAdapters.MetodoClasificacionTableAdapter metodoClasificacionTableAdapter;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lblProject;
        private System.Windows.Forms.ComboBox cbxArchivo;
        private System.Windows.Forms.ComboBox cbxCarpeta;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.BindingSource archivoBindingSource;
        private WebappDBDataSetTableAdapters.ArchivoTableAdapter archivoTableAdapter;
        private System.Windows.Forms.BindingSource carpetaBindingSource;
        private WebappDBDataSetTableAdapters.CarpetaTableAdapter carpetaTableAdapter;
        private WebappDBDataSetTableAdapters.SimulacionTableAdapter simulacionTableAdapter;
        private System.Windows.Forms.BindingSource simulacionBindingSource;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.ComboBox cbxProject;
        private System.Windows.Forms.BindingSource proyectoBindingSource;
        private WebappDBDataSetTableAdapters.ProyectoTableAdapter proyectoTableAdapter;
    }
}