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

namespace runnerManager
{
    public partial class runnerManagerForm : Form
    {
        private webappDBDataContext webappDB;
        private System.ServiceProcess.ServiceController sc;
        private Socket conexion;
        private Socket server;
        private int conexionesServidos;

        private static int puertoIn = 5959;
        private static int puertoOut = 1990;

        public runnerManagerForm()
        {
            InitializeComponent();
            sc = new System.ServiceProcess.ServiceController("runnerService");
            webappDB = new webappDBDataContext();
            conexionesServidos = 0;
                     
            timerUpdateSimGrid.Start();
        }

        private void setDisplay()
        {
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
        }

        private void startsvc_button_Click(object sender, EventArgs e)
        {
            if (sc.Status != System.ServiceProcess.ServiceControllerStatus.Running)
            {
                try
                {
                    sc.Start();
                    svcState_toolStripStatusLabel.Text = "Iniciando...";
                    sc.WaitForStatus(System.ServiceProcess.ServiceControllerStatus.Running);
                    setDisplay();
                }
                catch (Exception error)
                {
                    svcState_toolStripStatusLabel.Text = "ERROR al iniciar:" + error;
                }
            }
        }

        private void stopsvc_button_Click(object sender, EventArgs e)
        {
            if (sc.Status != System.ServiceProcess.ServiceControllerStatus.Stopped)
            {
                try
                {
                    sc.Stop();
                    svcState_toolStripStatusLabel.Text = "Parando...";
                    sc.WaitForStatus(System.ServiceProcess.ServiceControllerStatus.Stopped);
                    setDisplay();
                }
                catch (Exception error)
                {
                    svcState_toolStripStatusLabel.Text = "ERROR al parar:" + error;
                }
            }

        }

        private void run_button_Click(object sender, EventArgs e)
        {
           
        }

        private void runnerManagerForm_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'WebappDBDataSet.EstadoSimulacion' Puede moverla o quitarla según sea necesario.
            this.estadoSimulacionTableAdapter.Fill(this.WebappDBDataSet.EstadoSimulacion);
            // TODO: esta línea de código carga datos en la tabla 'WebappDBDataSet.VistaSimulación' Puede moverla o quitarla según sea necesario.
            this.vistaSimulaciónTableAdapter.Fill(this.WebappDBDataSet.VistaSimulación);
        }

        private void timerUpdateSimGrid_Tick(object sender, EventArgs e)
        {
            setDisplay();
            vistaSimulaciónTableAdapter.Fill(WebappDBDataSet.VistaSimulación);
            simsState_toolStripStatusLabel.Text = DateTime.Now.ToShortTimeString();
            countSim_label.Text = conexionesServidos.ToString();
        }

        private void changeState_button_Click(object sender, EventArgs e)
        {
            DataGridViewSelectedRowCollection filas = dataGridView1.SelectedRows;
            EstadoSimulacion es = webappDB.EstadoSimulacion.Where(state => state.idEstadoSimulacion.Equals(simStates_comboBox.SelectedValue)).Single();
            Simulacion simulation;
            String oldEs, newEs;
            foreach (DataGridViewRow f in filas)
            {
                simulation = webappDB.Simulacion
                    .Where( 
                        s=> 
                        s.nombre
                            .Equals( 
                            f.Cells[0].Value.ToString()
                        )
                    )
                    .Single();
                oldEs = simulation.EstadoSimulacion.nombre;
                newEs = es.nombre;
                simulation.EstadoSimulacion = es;
                threadLog_listBox.Items.Add(simulation.nombre + ": " + oldEs + " a " + newEs);
            }
            webappDB.SubmitChanges();
        }        
    }
}
