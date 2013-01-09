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
            sc = new System.ServiceProcess.ServiceController("runnerService");
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
            // TODO: esta línea de código carga datos en la tabla 'webappDBDataSet.Simulacion' Puede moverla o quitarla según sea necesario.
            this.simulacionTableAdapter.Fill(this.webappDBDataSet.Simulacion);
            // TODO: esta línea de código carga datos en la tabla 'WebappDBDataSet.EstadoSimulacion' Puede moverla o quitarla según sea necesario.
            this.estadoSimulaciónTableAdapter.Fill(this.webappDBDataSet.EstadoSimulacion);
            // TODO: esta línea de código carga datos en la tabla 'WebappDBDataSet.VistaSimulación' Puede moverla o quitarla según sea necesario.
            this.vistaSimulacionTableAdapter.Fill(this.webappDBDataSet.VistaSimulación);
        }

        private void timerUpdateSimGrid_Tick(object sender, EventArgs e)
        {
            setDisplay();
            vistaSimulacionTableAdapter.Fill(this.webappDBDataSet.VistaSimulación);
            simsState_toolStripStatusLabel.Text = DateTime.Now.ToShortTimeString();
            countSim_label.Text = conexionesServidos.ToString();
        }

        private void changeState_button_Click(object sender, EventArgs e)
        {
            // Obtenemos las filas seleccionadas. Normalmente una sólo ya que 
            // el DataGridView está en modo SingleSelection
            DataGridViewSelectedRowCollection filas = dataGridView1.SelectedRows;
  
            // Obtenemos el estado de simulación seleccionado en el combobox.
            WebappDBDataSet.EstadoSimulacionRow es = webappDBDataSet.EstadoSimulacion.Where(state => state.idEstadoSimulacion.Equals(simStates_comboBox.SelectedValue)).Single();


            // Declaramos variables
            WebappDBDataSet.SimulacionRow simulation;
            String oldEs, newEs;


            // Iteramos entre las filas seleccionadas
            foreach (DataGridViewRow f in filas)
            {
                // Obtenemos la simulacion
                simulation = webappDBDataSet.Simulacion
                    .Where(
                        s =>
                        s.idSimulacion
                            .Equals(
                            (Guid)f.Cells["idSimulacion"].Value
                        )
                    )
                    .Single();

                // Guardamos los nombres de los estados para mostrarlos en el listBox
                oldEs = simulation.EstadoSimulacionRow.nombre;
                newEs = es.nombre;

                // Modificamos el estado de la simulacion
                simulation.BeginEdit();
                simulation.EstadoSimulacionRow = es;
                simulation.EndEdit(); 
               
                

                try
                {
                    // Guardamos los cambios
                    simulacionTableAdapter.Update(simulation);

                    // Lo mostramos en el ListBox
                    threadLog_listBox.Items.Add(simulation.nombre + ": " + oldEs + " a " + newEs);
                }
                catch (Exception exc)
                {
                    MessageBox.Show("[CHANGE STATE] Error: " + exc, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            
        }        
    }
}
