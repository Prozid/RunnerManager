namespace PBioManager
{
    partial class FormResult
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
            System.Windows.Forms.Label numGenesLabel;
            System.Windows.Forms.Label nombreGenesLabel;
            System.Windows.Forms.Label idGenesLabel;
            System.Windows.Forms.Label accuracy_MediaLabel;
            System.Windows.Forms.Label accuracy_StdLabel;
            System.Windows.Forms.Label sensitivity_MediaLabel;
            System.Windows.Forms.Label sensitivity_StdLabel;
            System.Windows.Forms.Label specificity_MediaLabel;
            System.Windows.Forms.Label specificity_StdLabel;
            System.Windows.Forms.Label fechaLanzamientoLabel;
            System.Windows.Forms.Label fechaFinalizacionLabel;
            System.Windows.Forms.Label duracionLabel;
            System.Windows.Forms.Label accuracyXGenesLabel;
            System.Windows.Forms.Label medianaLabel;
            System.Windows.Forms.Label nombreGenesSolucionLabel;
            System.Windows.Forms.Label idGenesSolucionLabel;
            this.numGenesTextBox = new System.Windows.Forms.TextBox();
            this.nombreGenesTextBox = new System.Windows.Forms.TextBox();
            this.idGenesTextBox = new System.Windows.Forms.TextBox();
            this.accuracy_MediaTextBox = new System.Windows.Forms.TextBox();
            this.accuracy_StdTextBox = new System.Windows.Forms.TextBox();
            this.sensitivity_MediaTextBox = new System.Windows.Forms.TextBox();
            this.sensitivity_StdTextBox = new System.Windows.Forms.TextBox();
            this.specificity_MediaTextBox = new System.Windows.Forms.TextBox();
            this.specificity_StdTextBox = new System.Windows.Forms.TextBox();
            this.fechaLanzamientoDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.fechaFinalizacionDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.accuracyXGenesTextBox = new System.Windows.Forms.TextBox();
            this.medianaTextBox = new System.Windows.Forms.TextBox();
            this.nombreGenesSolucionTextBox = new System.Windows.Forms.TextBox();
            this.idGenesSolucionTextBox = new System.Windows.Forms.TextBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnOpenSimulation = new System.Windows.Forms.Button();
            this.duracionTextBox = new System.Windows.Forms.TextBox();
            this.resultadoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.webappDBDataSet = new PBioManager.WebappDBDataSet();
            this.resultadoTableAdapter = new PBioManager.WebappDBDataSetTableAdapters.ResultadoTableAdapter();
            this.tableAdapterManager = new PBioManager.WebappDBDataSetTableAdapters.TableAdapterManager();
            numGenesLabel = new System.Windows.Forms.Label();
            nombreGenesLabel = new System.Windows.Forms.Label();
            idGenesLabel = new System.Windows.Forms.Label();
            accuracy_MediaLabel = new System.Windows.Forms.Label();
            accuracy_StdLabel = new System.Windows.Forms.Label();
            sensitivity_MediaLabel = new System.Windows.Forms.Label();
            sensitivity_StdLabel = new System.Windows.Forms.Label();
            specificity_MediaLabel = new System.Windows.Forms.Label();
            specificity_StdLabel = new System.Windows.Forms.Label();
            fechaLanzamientoLabel = new System.Windows.Forms.Label();
            fechaFinalizacionLabel = new System.Windows.Forms.Label();
            duracionLabel = new System.Windows.Forms.Label();
            accuracyXGenesLabel = new System.Windows.Forms.Label();
            medianaLabel = new System.Windows.Forms.Label();
            nombreGenesSolucionLabel = new System.Windows.Forms.Label();
            idGenesSolucionLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.resultadoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.webappDBDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // numGenesLabel
            // 
            numGenesLabel.AutoSize = true;
            numGenesLabel.Location = new System.Drawing.Point(70, 13);
            numGenesLabel.Name = "numGenesLabel";
            numGenesLabel.Size = new System.Drawing.Size(66, 13);
            numGenesLabel.TabIndex = 1;
            numGenesLabel.Text = "Num Genes:";
            // 
            // nombreGenesLabel
            // 
            nombreGenesLabel.AutoSize = true;
            nombreGenesLabel.Location = new System.Drawing.Point(55, 39);
            nombreGenesLabel.Name = "nombreGenesLabel";
            nombreGenesLabel.Size = new System.Drawing.Size(81, 13);
            nombreGenesLabel.TabIndex = 3;
            nombreGenesLabel.Text = "Nombre Genes:";
            // 
            // idGenesLabel
            // 
            idGenesLabel.AutoSize = true;
            idGenesLabel.Location = new System.Drawing.Point(83, 66);
            idGenesLabel.Name = "idGenesLabel";
            idGenesLabel.Size = new System.Drawing.Size(53, 13);
            idGenesLabel.TabIndex = 4;
            idGenesLabel.Text = "Id Genes:";
            // 
            // accuracy_MediaLabel
            // 
            accuracy_MediaLabel.AutoSize = true;
            accuracy_MediaLabel.Location = new System.Drawing.Point(49, 97);
            accuracy_MediaLabel.Name = "accuracy_MediaLabel";
            accuracy_MediaLabel.Size = new System.Drawing.Size(87, 13);
            accuracy_MediaLabel.TabIndex = 6;
            accuracy_MediaLabel.Text = "Accuracy Media:";
            // 
            // accuracy_StdLabel
            // 
            accuracy_StdLabel.AutoSize = true;
            accuracy_StdLabel.Location = new System.Drawing.Point(62, 125);
            accuracy_StdLabel.Name = "accuracy_StdLabel";
            accuracy_StdLabel.Size = new System.Drawing.Size(74, 13);
            accuracy_StdLabel.TabIndex = 8;
            accuracy_StdLabel.Text = "Accuracy Std:";
            // 
            // sensitivity_MediaLabel
            // 
            sensitivity_MediaLabel.AutoSize = true;
            sensitivity_MediaLabel.Location = new System.Drawing.Point(47, 152);
            sensitivity_MediaLabel.Name = "sensitivity_MediaLabel";
            sensitivity_MediaLabel.Size = new System.Drawing.Size(89, 13);
            sensitivity_MediaLabel.TabIndex = 10;
            sensitivity_MediaLabel.Text = "Sensitivity Media:";
            // 
            // sensitivity_StdLabel
            // 
            sensitivity_StdLabel.AutoSize = true;
            sensitivity_StdLabel.Location = new System.Drawing.Point(60, 178);
            sensitivity_StdLabel.Name = "sensitivity_StdLabel";
            sensitivity_StdLabel.Size = new System.Drawing.Size(76, 13);
            sensitivity_StdLabel.TabIndex = 12;
            sensitivity_StdLabel.Text = "Sensitivity Std:";
            // 
            // specificity_MediaLabel
            // 
            specificity_MediaLabel.AutoSize = true;
            specificity_MediaLabel.Location = new System.Drawing.Point(46, 204);
            specificity_MediaLabel.Name = "specificity_MediaLabel";
            specificity_MediaLabel.Size = new System.Drawing.Size(90, 13);
            specificity_MediaLabel.TabIndex = 14;
            specificity_MediaLabel.Text = "Specificity Media:";
            // 
            // specificity_StdLabel
            // 
            specificity_StdLabel.AutoSize = true;
            specificity_StdLabel.Location = new System.Drawing.Point(59, 230);
            specificity_StdLabel.Name = "specificity_StdLabel";
            specificity_StdLabel.Size = new System.Drawing.Size(77, 13);
            specificity_StdLabel.TabIndex = 16;
            specificity_StdLabel.Text = "Specificity Std:";
            // 
            // fechaLanzamientoLabel
            // 
            fechaLanzamientoLabel.AutoSize = true;
            fechaLanzamientoLabel.Location = new System.Drawing.Point(33, 257);
            fechaLanzamientoLabel.Name = "fechaLanzamientoLabel";
            fechaLanzamientoLabel.Size = new System.Drawing.Size(103, 13);
            fechaLanzamientoLabel.TabIndex = 18;
            fechaLanzamientoLabel.Text = "Fecha Lanzamiento:";
            // 
            // fechaFinalizacionLabel
            // 
            fechaFinalizacionLabel.AutoSize = true;
            fechaFinalizacionLabel.Location = new System.Drawing.Point(38, 283);
            fechaFinalizacionLabel.Name = "fechaFinalizacionLabel";
            fechaFinalizacionLabel.Size = new System.Drawing.Size(98, 13);
            fechaFinalizacionLabel.TabIndex = 20;
            fechaFinalizacionLabel.Text = "Fecha Finalizacion:";
            // 
            // duracionLabel
            // 
            duracionLabel.AutoSize = true;
            duracionLabel.Location = new System.Drawing.Point(83, 309);
            duracionLabel.Name = "duracionLabel";
            duracionLabel.Size = new System.Drawing.Size(53, 13);
            duracionLabel.TabIndex = 22;
            duracionLabel.Text = "Duracion:";
            // 
            // accuracyXGenesLabel
            // 
            accuracyXGenesLabel.AutoSize = true;
            accuracyXGenesLabel.Location = new System.Drawing.Point(40, 332);
            accuracyXGenesLabel.Name = "accuracyXGenesLabel";
            accuracyXGenesLabel.Size = new System.Drawing.Size(96, 13);
            accuracyXGenesLabel.TabIndex = 24;
            accuracyXGenesLabel.Text = "Accuracy XGenes:";
            // 
            // medianaLabel
            // 
            medianaLabel.AutoSize = true;
            medianaLabel.Location = new System.Drawing.Point(85, 356);
            medianaLabel.Name = "medianaLabel";
            medianaLabel.Size = new System.Drawing.Size(51, 13);
            medianaLabel.TabIndex = 26;
            medianaLabel.Text = "Mediana:";
            // 
            // nombreGenesSolucionLabel
            // 
            nombreGenesSolucionLabel.AutoSize = true;
            nombreGenesSolucionLabel.Location = new System.Drawing.Point(11, 380);
            nombreGenesSolucionLabel.Name = "nombreGenesSolucionLabel";
            nombreGenesSolucionLabel.Size = new System.Drawing.Size(125, 13);
            nombreGenesSolucionLabel.TabIndex = 28;
            nombreGenesSolucionLabel.Text = "Nombre Genes Solucion:";
            // 
            // idGenesSolucionLabel
            // 
            idGenesSolucionLabel.AutoSize = true;
            idGenesSolucionLabel.Location = new System.Drawing.Point(40, 408);
            idGenesSolucionLabel.Name = "idGenesSolucionLabel";
            idGenesSolucionLabel.Size = new System.Drawing.Size(97, 13);
            idGenesSolucionLabel.TabIndex = 30;
            idGenesSolucionLabel.Text = "Id Genes Solucion:";
            // 
            // numGenesTextBox
            // 
            this.numGenesTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.resultadoBindingSource, "NumGenes", true));
            this.numGenesTextBox.Location = new System.Drawing.Point(142, 10);
            this.numGenesTextBox.Name = "numGenesTextBox";
            this.numGenesTextBox.ReadOnly = true;
            this.numGenesTextBox.Size = new System.Drawing.Size(285, 20);
            this.numGenesTextBox.TabIndex = 2;
            // 
            // nombreGenesTextBox
            // 
            this.nombreGenesTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.resultadoBindingSource, "NombreGenes", true));
            this.nombreGenesTextBox.Location = new System.Drawing.Point(142, 36);
            this.nombreGenesTextBox.Name = "nombreGenesTextBox";
            this.nombreGenesTextBox.ReadOnly = true;
            this.nombreGenesTextBox.Size = new System.Drawing.Size(285, 20);
            this.nombreGenesTextBox.TabIndex = 4;
            // 
            // idGenesTextBox
            // 
            this.idGenesTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.resultadoBindingSource, "IdGenes", true));
            this.idGenesTextBox.Location = new System.Drawing.Point(142, 63);
            this.idGenesTextBox.Name = "idGenesTextBox";
            this.idGenesTextBox.ReadOnly = true;
            this.idGenesTextBox.Size = new System.Drawing.Size(285, 20);
            this.idGenesTextBox.TabIndex = 5;
            // 
            // accuracy_MediaTextBox
            // 
            this.accuracy_MediaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.resultadoBindingSource, "Accuracy_Media", true));
            this.accuracy_MediaTextBox.Location = new System.Drawing.Point(142, 94);
            this.accuracy_MediaTextBox.Name = "accuracy_MediaTextBox";
            this.accuracy_MediaTextBox.ReadOnly = true;
            this.accuracy_MediaTextBox.Size = new System.Drawing.Size(285, 20);
            this.accuracy_MediaTextBox.TabIndex = 7;
            // 
            // accuracy_StdTextBox
            // 
            this.accuracy_StdTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.resultadoBindingSource, "Accuracy_Std", true));
            this.accuracy_StdTextBox.Location = new System.Drawing.Point(142, 122);
            this.accuracy_StdTextBox.Name = "accuracy_StdTextBox";
            this.accuracy_StdTextBox.ReadOnly = true;
            this.accuracy_StdTextBox.Size = new System.Drawing.Size(285, 20);
            this.accuracy_StdTextBox.TabIndex = 9;
            // 
            // sensitivity_MediaTextBox
            // 
            this.sensitivity_MediaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.resultadoBindingSource, "Sensitivity_Media", true));
            this.sensitivity_MediaTextBox.Location = new System.Drawing.Point(142, 149);
            this.sensitivity_MediaTextBox.Name = "sensitivity_MediaTextBox";
            this.sensitivity_MediaTextBox.ReadOnly = true;
            this.sensitivity_MediaTextBox.Size = new System.Drawing.Size(285, 20);
            this.sensitivity_MediaTextBox.TabIndex = 11;
            // 
            // sensitivity_StdTextBox
            // 
            this.sensitivity_StdTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.resultadoBindingSource, "Sensitivity_Std", true));
            this.sensitivity_StdTextBox.Location = new System.Drawing.Point(142, 175);
            this.sensitivity_StdTextBox.Name = "sensitivity_StdTextBox";
            this.sensitivity_StdTextBox.ReadOnly = true;
            this.sensitivity_StdTextBox.Size = new System.Drawing.Size(285, 20);
            this.sensitivity_StdTextBox.TabIndex = 13;
            // 
            // specificity_MediaTextBox
            // 
            this.specificity_MediaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.resultadoBindingSource, "Specificity_Media", true));
            this.specificity_MediaTextBox.Location = new System.Drawing.Point(142, 201);
            this.specificity_MediaTextBox.Name = "specificity_MediaTextBox";
            this.specificity_MediaTextBox.ReadOnly = true;
            this.specificity_MediaTextBox.Size = new System.Drawing.Size(285, 20);
            this.specificity_MediaTextBox.TabIndex = 15;
            // 
            // specificity_StdTextBox
            // 
            this.specificity_StdTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.resultadoBindingSource, "Specificity_Std", true));
            this.specificity_StdTextBox.Location = new System.Drawing.Point(142, 227);
            this.specificity_StdTextBox.Name = "specificity_StdTextBox";
            this.specificity_StdTextBox.ReadOnly = true;
            this.specificity_StdTextBox.Size = new System.Drawing.Size(285, 20);
            this.specificity_StdTextBox.TabIndex = 17;
            // 
            // fechaLanzamientoDateTimePicker
            // 
            this.fechaLanzamientoDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.resultadoBindingSource, "FechaLanzamiento", true));
            this.fechaLanzamientoDateTimePicker.Enabled = false;
            this.fechaLanzamientoDateTimePicker.Location = new System.Drawing.Point(142, 253);
            this.fechaLanzamientoDateTimePicker.Name = "fechaLanzamientoDateTimePicker";
            this.fechaLanzamientoDateTimePicker.Size = new System.Drawing.Size(285, 20);
            this.fechaLanzamientoDateTimePicker.TabIndex = 19;
            // 
            // fechaFinalizacionDateTimePicker
            // 
            this.fechaFinalizacionDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.resultadoBindingSource, "FechaFinalizacion", true));
            this.fechaFinalizacionDateTimePicker.Enabled = false;
            this.fechaFinalizacionDateTimePicker.Location = new System.Drawing.Point(142, 279);
            this.fechaFinalizacionDateTimePicker.Name = "fechaFinalizacionDateTimePicker";
            this.fechaFinalizacionDateTimePicker.Size = new System.Drawing.Size(285, 20);
            this.fechaFinalizacionDateTimePicker.TabIndex = 21;
            // 
            // accuracyXGenesTextBox
            // 
            this.accuracyXGenesTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.resultadoBindingSource, "AccuracyXGenes", true));
            this.accuracyXGenesTextBox.Location = new System.Drawing.Point(142, 329);
            this.accuracyXGenesTextBox.Name = "accuracyXGenesTextBox";
            this.accuracyXGenesTextBox.ReadOnly = true;
            this.accuracyXGenesTextBox.Size = new System.Drawing.Size(285, 20);
            this.accuracyXGenesTextBox.TabIndex = 25;
            // 
            // medianaTextBox
            // 
            this.medianaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.resultadoBindingSource, "Mediana", true));
            this.medianaTextBox.Location = new System.Drawing.Point(142, 353);
            this.medianaTextBox.Name = "medianaTextBox";
            this.medianaTextBox.ReadOnly = true;
            this.medianaTextBox.Size = new System.Drawing.Size(285, 20);
            this.medianaTextBox.TabIndex = 27;
            // 
            // nombreGenesSolucionTextBox
            // 
            this.nombreGenesSolucionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.resultadoBindingSource, "NombreGenesSolucion", true));
            this.nombreGenesSolucionTextBox.Location = new System.Drawing.Point(142, 377);
            this.nombreGenesSolucionTextBox.Name = "nombreGenesSolucionTextBox";
            this.nombreGenesSolucionTextBox.ReadOnly = true;
            this.nombreGenesSolucionTextBox.Size = new System.Drawing.Size(285, 20);
            this.nombreGenesSolucionTextBox.TabIndex = 29;
            // 
            // idGenesSolucionTextBox
            // 
            this.idGenesSolucionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.resultadoBindingSource, "IdGenesSolucion", true));
            this.idGenesSolucionTextBox.Location = new System.Drawing.Point(143, 405);
            this.idGenesSolucionTextBox.Name = "idGenesSolucionTextBox";
            this.idGenesSolucionTextBox.ReadOnly = true;
            this.idGenesSolucionTextBox.Size = new System.Drawing.Size(284, 20);
            this.idGenesSolucionTextBox.TabIndex = 31;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(352, 464);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 33;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnOpenSimulation
            // 
            this.btnOpenSimulation.Location = new System.Drawing.Point(12, 464);
            this.btnOpenSimulation.Name = "btnOpenSimulation";
            this.btnOpenSimulation.Size = new System.Drawing.Size(95, 23);
            this.btnOpenSimulation.TabIndex = 34;
            this.btnOpenSimulation.Text = "Open simulation";
            this.btnOpenSimulation.UseVisualStyleBackColor = true;
            this.btnOpenSimulation.Click += new System.EventHandler(this.btnOpenSimulation_Click);
            // 
            // duracionTextBox
            // 
            this.duracionTextBox.Location = new System.Drawing.Point(142, 304);
            this.duracionTextBox.Name = "duracionTextBox";
            this.duracionTextBox.ReadOnly = true;
            this.duracionTextBox.Size = new System.Drawing.Size(285, 20);
            this.duracionTextBox.TabIndex = 35;
            // 
            // resultadoBindingSource
            // 
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
            // tableAdapterManager
            // 
            this.tableAdapterManager.ArchivoTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CarpetaTableAdapter = null;
            this.tableAdapterManager.EstadoSimulacionTableAdapter = null;
            this.tableAdapterManager.LogTableAdapter = null;
            this.tableAdapterManager.MetodoClasificacionTableAdapter = null;
            this.tableAdapterManager.MetodoSeleccionTableAdapter = null;
            this.tableAdapterManager.ProyectoTableAdapter = null;
            this.tableAdapterManager.ResultadoTableAdapter = this.resultadoTableAdapter;
            this.tableAdapterManager.SimulacionTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = PBioManager.WebappDBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // FormResult
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(439, 499);
            this.Controls.Add(this.duracionTextBox);
            this.Controls.Add(this.btnOpenSimulation);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(idGenesSolucionLabel);
            this.Controls.Add(this.idGenesSolucionTextBox);
            this.Controls.Add(nombreGenesSolucionLabel);
            this.Controls.Add(this.nombreGenesSolucionTextBox);
            this.Controls.Add(medianaLabel);
            this.Controls.Add(this.medianaTextBox);
            this.Controls.Add(accuracyXGenesLabel);
            this.Controls.Add(this.accuracyXGenesTextBox);
            this.Controls.Add(duracionLabel);
            this.Controls.Add(fechaFinalizacionLabel);
            this.Controls.Add(this.fechaFinalizacionDateTimePicker);
            this.Controls.Add(fechaLanzamientoLabel);
            this.Controls.Add(this.fechaLanzamientoDateTimePicker);
            this.Controls.Add(specificity_StdLabel);
            this.Controls.Add(this.specificity_StdTextBox);
            this.Controls.Add(specificity_MediaLabel);
            this.Controls.Add(this.specificity_MediaTextBox);
            this.Controls.Add(sensitivity_StdLabel);
            this.Controls.Add(this.sensitivity_StdTextBox);
            this.Controls.Add(sensitivity_MediaLabel);
            this.Controls.Add(this.sensitivity_MediaTextBox);
            this.Controls.Add(accuracy_StdLabel);
            this.Controls.Add(this.accuracy_StdTextBox);
            this.Controls.Add(accuracy_MediaLabel);
            this.Controls.Add(this.accuracy_MediaTextBox);
            this.Controls.Add(idGenesLabel);
            this.Controls.Add(this.idGenesTextBox);
            this.Controls.Add(nombreGenesLabel);
            this.Controls.Add(this.nombreGenesTextBox);
            this.Controls.Add(numGenesLabel);
            this.Controls.Add(this.numGenesTextBox);
            this.Name = "FormResult";
            this.Text = "Result";
            this.Load += new System.EventHandler(this.FormResult_Load);
            ((System.ComponentModel.ISupportInitialize)(this.resultadoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.webappDBDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private WebappDBDataSet webappDBDataSet;
        private System.Windows.Forms.BindingSource resultadoBindingSource;
        private WebappDBDataSetTableAdapters.ResultadoTableAdapter resultadoTableAdapter;
        private WebappDBDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox numGenesTextBox;
        private System.Windows.Forms.TextBox nombreGenesTextBox;
        private System.Windows.Forms.TextBox idGenesTextBox;
        private System.Windows.Forms.TextBox accuracy_MediaTextBox;
        private System.Windows.Forms.TextBox accuracy_StdTextBox;
        private System.Windows.Forms.TextBox sensitivity_MediaTextBox;
        private System.Windows.Forms.TextBox sensitivity_StdTextBox;
        private System.Windows.Forms.TextBox specificity_MediaTextBox;
        private System.Windows.Forms.TextBox specificity_StdTextBox;
        private System.Windows.Forms.DateTimePicker fechaLanzamientoDateTimePicker;
        private System.Windows.Forms.DateTimePicker fechaFinalizacionDateTimePicker;
        private System.Windows.Forms.TextBox accuracyXGenesTextBox;
        private System.Windows.Forms.TextBox medianaTextBox;
        private System.Windows.Forms.TextBox nombreGenesSolucionTextBox;
        private System.Windows.Forms.TextBox idGenesSolucionTextBox;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnOpenSimulation;
        private System.Windows.Forms.TextBox duracionTextBox;
    }
}