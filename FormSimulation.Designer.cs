namespace runnerManager
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
            this.webappDBDataSet = new runnerManager.WebappDBDataSet();
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
            this.estadoSimulacionTableAdapter = new runnerManager.WebappDBDataSetTableAdapters.EstadoSimulacionTableAdapter();
            this.metodoSeleccionTableAdapter = new runnerManager.WebappDBDataSetTableAdapters.MetodoSeleccionTableAdapter();
            this.metodoClasificacionTableAdapter = new runnerManager.WebappDBDataSetTableAdapters.MetodoClasificacionTableAdapter();
            this.btnSave = new System.Windows.Forms.Button();
            this.lblProject = new System.Windows.Forms.Label();
            this.btnProject = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.estadoSimulacionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.webappDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.metodoSeleccionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.metodoClasificacionBindingSource)).BeginInit();
            this.gbxMethods.SuspendLayout();
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
            this.cbxStateSimulation.FormattingEnabled = true;
            this.cbxStateSimulation.Location = new System.Drawing.Point(286, 41);
            this.cbxStateSimulation.Name = "cbxStateSimulation";
            this.cbxStateSimulation.Size = new System.Drawing.Size(189, 21);
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
            this.gbxMethods.Location = new System.Drawing.Point(15, 202);
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
            this.btnSave.Location = new System.Drawing.Point(400, 296);
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
            // btnProject
            // 
            this.btnProject.Location = new System.Drawing.Point(294, 9);
            this.btnProject.Name = "btnProject";
            this.btnProject.Size = new System.Drawing.Size(75, 23);
            this.btnProject.TabIndex = 15;
            this.btnProject.Text = "Search";
            this.btnProject.UseVisualStyleBackColor = true;
            // 
            // FormSimulation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(487, 331);
            this.Controls.Add(this.btnProject);
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
        private System.Windows.Forms.Button btnProject;
    }
}