using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;
using System.Xml.Linq;
using System.Threading;
using System.Data.SqlClient;

namespace PBioManager
{
    public partial class PBioManagerForm : Form
    {
        private System.ServiceProcess.ServiceController sc;
        private int conexionesServidos;

        public PBioManagerForm()
        {
            InitializeComponent();
            try
            {
                sc = new System.ServiceProcess.ServiceController("PBioSvc");
            }
            catch{
                sc = null;
            }
            conexionesServidos = 0;                     
            timerUpdateSimGrid.Start();
        }

        private void timerUpdateSimGrid_Tick(object sender, EventArgs e)
        {
            if (sc != null) sc.Refresh();
            setDisplay();            
            //vistaSimulacionTableAdapter.Fill(this.webappDBDataSet.VistaSimulación);
            simsState_toolStripStatusLabel.Text = DateTime.Now.ToShortTimeString();
        }
 
        private void setDisplay()
        {
            if (sc != null)
            {
                svcState_toolStripStatusLabel.Text = sc.Status.ToString();

                if (sc.Status == System.ServiceProcess.ServiceControllerStatus.Running)
                {
                    this.runToolStripMenuItem.Enabled = false;
                    this.stopToolStripMenuItem.Enabled = true;
                }
                else
                {
                    this.runToolStripMenuItem.Enabled = true;
                    this.stopToolStripMenuItem.Enabled = false;
                }
            }
            else
            {
                svcState_toolStripStatusLabel.Text = "Unknown";
            }
        }

        /* EVENTOS
         *  
         */
        private void gridToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormSimulationsGrid simsForm = new FormSimulationsGrid();
            simsForm.MdiParent = this;
            simsForm.Show();
        }

        private void addToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FormSimulationState newSimStateForm = new FormSimulationState();
            newSimStateForm.MdiParent = this;
            newSimStateForm.Show();
        }

        private void gridToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FormSimulationStatesGrid simStates = new FormSimulationStatesGrid();
            simStates.MdiParent = this;
            simStates.Show();
        }

        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormSimulation sForm = new FormSimulation();
            sForm.MdiParent = this;
            sForm.Show();
        }

        private void addToolStripMenuItem5_Click(object sender, EventArgs e)
        {
            FormClasificationMethod cForm = new FormClasificationMethod();
            cForm.MdiParent = this;
            cForm.Show();
        }

        private void gridToolStripMenuItem5_Click(object sender, EventArgs e)
        {
            FormClasificationMethodsGrid clasificationForm = new FormClasificationMethodsGrid();
            clasificationForm.MdiParent = this;
            clasificationForm.Show();
        }

        private void addToolStripMenuItem6_Click(object sender, EventArgs e)
        {
            FormSelectionMethod sForm = new FormSelectionMethod();
            sForm.MdiParent = this;
            sForm.Show();
        }

        private void gridToolStripMenuItem6_Click(object sender, EventArgs e)
        {
            FormSelectionMethodsGrid sForm = new FormSelectionMethodsGrid();
            sForm.MdiParent = this;
            sForm.Show();
        }

        private void runToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (sc.Status != System.ServiceProcess.ServiceControllerStatus.Running)
            {
                sc.Start();
            }
        }

        private void stopToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (sc.Status == System.ServiceProcess.ServiceControllerStatus.Running)
            {
                try
                {
                    sc.Stop();
                }
                catch
                {
                  
                }
            }

        }

        private void gridToolStripMenuItem4_Click(object sender, EventArgs e)
        {
            FormProjectsGrid pgForm = new FormProjectsGrid();
            pgForm.MdiParent = this;
            pgForm.Show();
        }

        private void addToolStripMenuItem4_Click(object sender, EventArgs e)
        {
            FormProject pForm = new FormProject();
            pForm.MdiParent = this;
            pForm.Show();
        }

        private void gridToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            FormFoldersGrid fgForm = new FormFoldersGrid();
            fgForm.MdiParent = this;
            fgForm.Show();
        }

        private void addToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            FormFolder fFolder = new FormFolder();
            fFolder.MdiParent = this;
            fFolder.Show();
        }

        private void addToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            FormFile fFile = new FormFile();
            fFile.MdiParent = this;
            fFile.Show();
        }

        private void gridToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            FormFilesGrid fFilesGrid = new FormFilesGrid();
            fFilesGrid.MdiParent = this;
            fFilesGrid.Show();
        }
    }
}
