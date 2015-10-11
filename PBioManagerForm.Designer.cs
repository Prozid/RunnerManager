namespace PBioManager
{
    partial class PBioManagerForm
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
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.label_toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.svcState_toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.Sims_toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.simsState_toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.timerUpdateSimGrid = new System.Windows.Forms.Timer(this.components);
            this.nombreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.serviceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.runToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stopToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.simulaciónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gridToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.projectsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addToolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.gridToolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.foldersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.gridToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.filesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addToolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.gridToolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.simulationsStatesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.gridToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.methodsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clasificationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addToolStripMenuItem5 = new System.Windows.Forms.ToolStripMenuItem();
            this.gridToolStripMenuItem5 = new System.Windows.Forms.ToolStripMenuItem();
            this.selectionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addToolStripMenuItem6 = new System.Windows.Forms.ToolStripMenuItem();
            this.gridToolStripMenuItem6 = new System.Windows.Forms.ToolStripMenuItem();
            this.resultsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip.SuspendLayout();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.label_toolStripStatusLabel,
            this.svcState_toolStripStatusLabel,
            this.Sims_toolStripStatusLabel,
            this.simsState_toolStripStatusLabel});
            this.statusStrip.Location = new System.Drawing.Point(0, 393);
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
            // timerUpdateSimGrid
            // 
            this.timerUpdateSimGrid.Tick += new System.EventHandler(this.timerUpdateSimGrid_Tick);
            // 
            // nombreDataGridViewTextBoxColumn
            // 
            this.nombreDataGridViewTextBoxColumn.DataPropertyName = "nombre";
            this.nombreDataGridViewTextBoxColumn.HeaderText = "nombre";
            this.nombreDataGridViewTextBoxColumn.Name = "nombreDataGridViewTextBoxColumn";
            this.nombreDataGridViewTextBoxColumn.Width = 67;
            // 
            // Estado
            // 
            this.Estado.DataPropertyName = "Estado";
            this.Estado.HeaderText = "Estado";
            this.Estado.Name = "Estado";
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.serviceToolStripMenuItem,
            this.simulaciónToolStripMenuItem,
            this.projectsToolStripMenuItem,
            this.foldersToolStripMenuItem,
            this.filesToolStripMenuItem,
            this.simulationsStatesToolStripMenuItem,
            this.methodsToolStripMenuItem,
            this.resultsToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(1148, 24);
            this.menuStrip.TabIndex = 8;
            this.menuStrip.Text = "menuStrip1";
            // 
            // serviceToolStripMenuItem
            // 
            this.serviceToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.runToolStripMenuItem,
            this.stopToolStripMenuItem});
            this.serviceToolStripMenuItem.Name = "serviceToolStripMenuItem";
            this.serviceToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.serviceToolStripMenuItem.Text = "Service";
            // 
            // runToolStripMenuItem
            // 
            this.runToolStripMenuItem.Enabled = false;
            this.runToolStripMenuItem.Name = "runToolStripMenuItem";
            this.runToolStripMenuItem.Size = new System.Drawing.Size(98, 22);
            this.runToolStripMenuItem.Text = "Run";
            this.runToolStripMenuItem.Click += new System.EventHandler(this.runToolStripMenuItem_Click);
            // 
            // stopToolStripMenuItem
            // 
            this.stopToolStripMenuItem.Enabled = false;
            this.stopToolStripMenuItem.Name = "stopToolStripMenuItem";
            this.stopToolStripMenuItem.Size = new System.Drawing.Size(98, 22);
            this.stopToolStripMenuItem.Text = "Stop";
            this.stopToolStripMenuItem.Click += new System.EventHandler(this.stopToolStripMenuItem_Click);
            // 
            // simulaciónToolStripMenuItem
            // 
            this.simulaciónToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addToolStripMenuItem,
            this.gridToolStripMenuItem});
            this.simulaciónToolStripMenuItem.Name = "simulaciónToolStripMenuItem";
            this.simulaciónToolStripMenuItem.Size = new System.Drawing.Size(81, 20);
            this.simulaciónToolStripMenuItem.Text = "Simulations";
            // 
            // addToolStripMenuItem
            // 
            this.addToolStripMenuItem.Name = "addToolStripMenuItem";
            this.addToolStripMenuItem.Size = new System.Drawing.Size(96, 22);
            this.addToolStripMenuItem.Text = "Add";
            this.addToolStripMenuItem.Click += new System.EventHandler(this.addToolStripMenuItem_Click);
            // 
            // gridToolStripMenuItem
            // 
            this.gridToolStripMenuItem.Name = "gridToolStripMenuItem";
            this.gridToolStripMenuItem.Size = new System.Drawing.Size(96, 22);
            this.gridToolStripMenuItem.Text = "Grid";
            this.gridToolStripMenuItem.Click += new System.EventHandler(this.gridToolStripMenuItem_Click);
            // 
            // projectsToolStripMenuItem
            // 
            this.projectsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addToolStripMenuItem4,
            this.gridToolStripMenuItem4});
            this.projectsToolStripMenuItem.Name = "projectsToolStripMenuItem";
            this.projectsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.projectsToolStripMenuItem.Text = "Projects";
            // 
            // addToolStripMenuItem4
            // 
            this.addToolStripMenuItem4.Name = "addToolStripMenuItem4";
            this.addToolStripMenuItem4.Size = new System.Drawing.Size(96, 22);
            this.addToolStripMenuItem4.Text = "Add";
            this.addToolStripMenuItem4.Click += new System.EventHandler(this.addToolStripMenuItem4_Click);
            // 
            // gridToolStripMenuItem4
            // 
            this.gridToolStripMenuItem4.Name = "gridToolStripMenuItem4";
            this.gridToolStripMenuItem4.Size = new System.Drawing.Size(96, 22);
            this.gridToolStripMenuItem4.Text = "Grid";
            this.gridToolStripMenuItem4.Click += new System.EventHandler(this.gridToolStripMenuItem4_Click);
            // 
            // foldersToolStripMenuItem
            // 
            this.foldersToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addToolStripMenuItem2,
            this.gridToolStripMenuItem2});
            this.foldersToolStripMenuItem.Name = "foldersToolStripMenuItem";
            this.foldersToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.foldersToolStripMenuItem.Text = "Folders";
            // 
            // addToolStripMenuItem2
            // 
            this.addToolStripMenuItem2.Name = "addToolStripMenuItem2";
            this.addToolStripMenuItem2.Size = new System.Drawing.Size(96, 22);
            this.addToolStripMenuItem2.Text = "Add";
            this.addToolStripMenuItem2.Click += new System.EventHandler(this.addToolStripMenuItem2_Click);
            // 
            // gridToolStripMenuItem2
            // 
            this.gridToolStripMenuItem2.Name = "gridToolStripMenuItem2";
            this.gridToolStripMenuItem2.Size = new System.Drawing.Size(96, 22);
            this.gridToolStripMenuItem2.Text = "Grid";
            this.gridToolStripMenuItem2.Click += new System.EventHandler(this.gridToolStripMenuItem2_Click);
            // 
            // filesToolStripMenuItem
            // 
            this.filesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addToolStripMenuItem3,
            this.gridToolStripMenuItem3});
            this.filesToolStripMenuItem.Name = "filesToolStripMenuItem";
            this.filesToolStripMenuItem.Size = new System.Drawing.Size(42, 20);
            this.filesToolStripMenuItem.Text = "Files";
            // 
            // addToolStripMenuItem3
            // 
            this.addToolStripMenuItem3.Name = "addToolStripMenuItem3";
            this.addToolStripMenuItem3.Size = new System.Drawing.Size(96, 22);
            this.addToolStripMenuItem3.Text = "Add";
            this.addToolStripMenuItem3.Click += new System.EventHandler(this.addToolStripMenuItem3_Click);
            // 
            // gridToolStripMenuItem3
            // 
            this.gridToolStripMenuItem3.Name = "gridToolStripMenuItem3";
            this.gridToolStripMenuItem3.Size = new System.Drawing.Size(96, 22);
            this.gridToolStripMenuItem3.Text = "Grid";
            this.gridToolStripMenuItem3.Click += new System.EventHandler(this.gridToolStripMenuItem3_Click);
            // 
            // simulationsStatesToolStripMenuItem
            // 
            this.simulationsStatesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addToolStripMenuItem1,
            this.gridToolStripMenuItem1});
            this.simulationsStatesToolStripMenuItem.Name = "simulationsStatesToolStripMenuItem";
            this.simulationsStatesToolStripMenuItem.Size = new System.Drawing.Size(110, 20);
            this.simulationsStatesToolStripMenuItem.Text = "Simulation States";
            // 
            // addToolStripMenuItem1
            // 
            this.addToolStripMenuItem1.Name = "addToolStripMenuItem1";
            this.addToolStripMenuItem1.Size = new System.Drawing.Size(96, 22);
            this.addToolStripMenuItem1.Text = "Add";
            this.addToolStripMenuItem1.Click += new System.EventHandler(this.addToolStripMenuItem1_Click);
            // 
            // gridToolStripMenuItem1
            // 
            this.gridToolStripMenuItem1.Name = "gridToolStripMenuItem1";
            this.gridToolStripMenuItem1.Size = new System.Drawing.Size(96, 22);
            this.gridToolStripMenuItem1.Text = "Grid";
            this.gridToolStripMenuItem1.Click += new System.EventHandler(this.gridToolStripMenuItem1_Click);
            // 
            // methodsToolStripMenuItem
            // 
            this.methodsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clasificationToolStripMenuItem,
            this.selectionToolStripMenuItem});
            this.methodsToolStripMenuItem.Name = "methodsToolStripMenuItem";
            this.methodsToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.methodsToolStripMenuItem.Text = "Methods";
            // 
            // clasificationToolStripMenuItem
            // 
            this.clasificationToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addToolStripMenuItem5,
            this.gridToolStripMenuItem5});
            this.clasificationToolStripMenuItem.Name = "clasificationToolStripMenuItem";
            this.clasificationToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.clasificationToolStripMenuItem.Text = "Clasification";
            // 
            // addToolStripMenuItem5
            // 
            this.addToolStripMenuItem5.Name = "addToolStripMenuItem5";
            this.addToolStripMenuItem5.Size = new System.Drawing.Size(96, 22);
            this.addToolStripMenuItem5.Text = "Add";
            this.addToolStripMenuItem5.Click += new System.EventHandler(this.addToolStripMenuItem5_Click);
            // 
            // gridToolStripMenuItem5
            // 
            this.gridToolStripMenuItem5.Name = "gridToolStripMenuItem5";
            this.gridToolStripMenuItem5.Size = new System.Drawing.Size(96, 22);
            this.gridToolStripMenuItem5.Text = "Grid";
            this.gridToolStripMenuItem5.Click += new System.EventHandler(this.gridToolStripMenuItem5_Click);
            // 
            // selectionToolStripMenuItem
            // 
            this.selectionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addToolStripMenuItem6,
            this.gridToolStripMenuItem6});
            this.selectionToolStripMenuItem.Name = "selectionToolStripMenuItem";
            this.selectionToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.selectionToolStripMenuItem.Text = "Selection";
            // 
            // addToolStripMenuItem6
            // 
            this.addToolStripMenuItem6.Name = "addToolStripMenuItem6";
            this.addToolStripMenuItem6.Size = new System.Drawing.Size(96, 22);
            this.addToolStripMenuItem6.Text = "Add";
            this.addToolStripMenuItem6.Click += new System.EventHandler(this.addToolStripMenuItem6_Click);
            // 
            // gridToolStripMenuItem6
            // 
            this.gridToolStripMenuItem6.Name = "gridToolStripMenuItem6";
            this.gridToolStripMenuItem6.Size = new System.Drawing.Size(96, 22);
            this.gridToolStripMenuItem6.Text = "Grid";
            this.gridToolStripMenuItem6.Click += new System.EventHandler(this.gridToolStripMenuItem6_Click);
            // 
            // resultsToolStripMenuItem
            // 
            this.resultsToolStripMenuItem.Name = "resultsToolStripMenuItem";
            this.resultsToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.resultsToolStripMenuItem.Text = "Results";
            this.resultsToolStripMenuItem.Click += new System.EventHandler(this.resultsToolStripMenuItem_Click);
            // 
            // PBioManagerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1148, 415);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.menuStrip);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip;
            this.Name = "PBioManagerForm";
            this.Text = "P-Bio Manager";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel label_toolStripStatusLabel;
        private System.Windows.Forms.ToolStripStatusLabel svcState_toolStripStatusLabel;
        private System.Windows.Forms.Timer timerUpdateSimGrid;
        private System.Windows.Forms.ToolStripStatusLabel Sims_toolStripStatusLabel;
        private System.Windows.Forms.ToolStripStatusLabel simsState_toolStripStatusLabel;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estado;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem simulaciónToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gridToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem simulationsStatesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem gridToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem serviceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem runToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stopToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem projectsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem gridToolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem methodsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clasificationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem5;
        private System.Windows.Forms.ToolStripMenuItem gridToolStripMenuItem5;
        private System.Windows.Forms.ToolStripMenuItem selectionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem6;
        private System.Windows.Forms.ToolStripMenuItem gridToolStripMenuItem6;
        private System.Windows.Forms.ToolStripMenuItem foldersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem gridToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem filesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem gridToolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem resultsToolStripMenuItem;

    }
}

