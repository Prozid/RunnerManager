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

namespace runnerManager
{
    public partial class runnerManagerForm : Form
    {
        private System.ServiceProcess.ServiceController sc;
        private int conexionesServidos;

        public runnerManagerForm()
        {
            InitializeComponent();
            //sc = new System.ServiceProcess.ServiceController("runnerService");
            conexionesServidos = 0;                     
            timerUpdateSimGrid.Start();
        }

        private void timerUpdateSimGrid_Tick(object sender, EventArgs e)
        {
            setDisplay();
            //vistaSimulacionTableAdapter.Fill(this.webappDBDataSet.VistaSimulación);
            simsState_toolStripStatusLabel.Text = DateTime.Now.ToShortTimeString();
        }
 
        private void setDisplay()
        {/*
            svcState_toolStripStatusLabel.Text = sc.Status.ToString();
            if (sc.Status == System.ServiceProcess.ServiceControllerStatus.Running)
            {
                startsvc_button.Enabled = false;
                stopsvc_button.Enabled = true;
            }
            else
            {
                startsvc_button.Enabled = true;
                stopsvc_button.Enabled = false;
            }
          */ 
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
    }
}
