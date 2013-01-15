using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace runnerManager
{
    public partial class FormSimulationsGrid : Form
    {
        public FormSimulationsGrid()
        {
            InitializeComponent();
        }

        private void SimulationsForm_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'webappDBDataSet.EstadoSimulacion' Puede moverla o quitarla según sea necesario.
            this.estadoSimulacionTableAdapter.Fill(this.webappDBDataSet.EstadoSimulacion);
            // TODO: esta línea de código carga datos en la tabla 'webappDBDataSet.VistaSimulación' Puede moverla o quitarla según sea necesario.
            this.vistaSimulaciónTableAdapter.Fill(this.webappDBDataSet.VistaSimulación);

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
                    simulacionTableAdapter1.Update(simulation);

                    // Lo mostramos en el ListBox
                    //threadLog_listBox.Items.Add(simulation.nombre + ": " + oldEs + " a " + newEs);
                }
                catch (Exception exc)
                {
                    MessageBox.Show("[CHANGE STATE] Error: " + exc, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
