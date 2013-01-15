namespace runnerManager
{
    partial class FormSimulationState
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
            this.lblNameState = new System.Windows.Forms.Label();
            this.txtNameState = new System.Windows.Forms.TextBox();
            this.btnAddState = new System.Windows.Forms.Button();
            this.btnDiscard = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtShortNameState = new System.Windows.Forms.TextBox();
            this.bindingSourceSimulationStates = new System.Windows.Forms.BindingSource(this.components);
            this.webappDBDataSet = new runnerManager.WebappDBDataSet();
            this.estadoSimulacionTableAdapter1 = new runnerManager.WebappDBDataSetTableAdapters.EstadoSimulacionTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceSimulationStates)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.webappDBDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNameState
            // 
            this.lblNameState.AutoSize = true;
            this.lblNameState.Location = new System.Drawing.Point(12, 9);
            this.lblNameState.Name = "lblNameState";
            this.lblNameState.Size = new System.Drawing.Size(35, 13);
            this.lblNameState.TabIndex = 0;
            this.lblNameState.Text = "Name";
            // 
            // txtNameState
            // 
            this.txtNameState.Location = new System.Drawing.Point(15, 25);
            this.txtNameState.Name = "txtNameState";
            this.txtNameState.Size = new System.Drawing.Size(235, 20);
            this.txtNameState.TabIndex = 1;
            // 
            // btnAddState
            // 
            this.btnAddState.Location = new System.Drawing.Point(175, 101);
            this.btnAddState.Name = "btnAddState";
            this.btnAddState.Size = new System.Drawing.Size(75, 23);
            this.btnAddState.TabIndex = 2;
            this.btnAddState.Text = "Add";
            this.btnAddState.UseVisualStyleBackColor = true;
            this.btnAddState.Click += new System.EventHandler(this.btnAddState_Click);
            // 
            // btnDiscard
            // 
            this.btnDiscard.Location = new System.Drawing.Point(12, 101);
            this.btnDiscard.Name = "btnDiscard";
            this.btnDiscard.Size = new System.Drawing.Size(75, 23);
            this.btnDiscard.TabIndex = 3;
            this.btnDiscard.Text = "Discard";
            this.btnDiscard.UseVisualStyleBackColor = true;
            this.btnDiscard.Click += new System.EventHandler(this.btnDiscard_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Short name";
            // 
            // txtShortNameState
            // 
            this.txtShortNameState.Location = new System.Drawing.Point(15, 65);
            this.txtShortNameState.Name = "txtShortNameState";
            this.txtShortNameState.Size = new System.Drawing.Size(235, 20);
            this.txtShortNameState.TabIndex = 4;
            // 
            // bindingSourceSimulationStates
            // 
            this.bindingSourceSimulationStates.DataSource = this.webappDBDataSet;
            this.bindingSourceSimulationStates.Position = 0;
            // 
            // webappDBDataSet
            // 
            this.webappDBDataSet.DataSetName = "WebappDBDataSet";
            this.webappDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // estadoSimulacionTableAdapter1
            // 
            this.estadoSimulacionTableAdapter1.ClearBeforeFill = true;
            // 
            // FormNewSimulationState
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(262, 136);
            this.Controls.Add(this.txtShortNameState);
            this.Controls.Add(this.btnDiscard);
            this.Controls.Add(this.btnAddState);
            this.Controls.Add(this.txtNameState);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblNameState);
            this.Name = "FormNewSimulationState";
            this.Text = "New State";
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceSimulationStates)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.webappDBDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNameState;
        private System.Windows.Forms.TextBox txtNameState;
        private System.Windows.Forms.Button btnAddState;
        private System.Windows.Forms.Button btnDiscard;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtShortNameState;
        private System.Windows.Forms.BindingSource bindingSourceSimulationStates;
        private WebappDBDataSet webappDBDataSet;
        private WebappDBDataSetTableAdapters.EstadoSimulacionTableAdapter estadoSimulacionTableAdapter1;
    }
}