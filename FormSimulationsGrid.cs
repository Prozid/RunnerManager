using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PBioManager
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
            this.vistaSimulacionTableAdapter.Fill(this.webappDBDataSet.VistaSimulacion);

            this.simulacionTableAdapter.Fill(this.webappDBDataSet.Simulacion);

        }

        private void changeState_button_Click(object sender, EventArgs e)
        {
            // Obtenemos las filas seleccionadas. Normalmente una sólo ya que 
            // el DataGridView está en modo SingleSelection
            DataGridViewSelectedRowCollection filas = dataGridView1.SelectedRows;

            // Obtenemos el estado de simulación seleccionado en el combobox.
            WebappDBDataSet.EstadoSimulacionRow es = webappDBDataSet.EstadoSimulacion.Where(state => state.IdEstadoSimulacion.Equals(simStates_comboBox.SelectedValue)).Single();


            // Declaramos variables
            WebappDBDataSet.SimulacionRow simulation;
            String oldEs, newEs;

            // Iteramos entre las filas seleccionadas
            foreach (DataGridViewRow f in filas)
            {
                Guid gRow = (Guid)f.Cells["IdSimulacion"].Value;
                // Obtenemos la simulacion
                simulation = webappDBDataSet.Simulacion.Where(sim => sim.IdSimulacion.Equals(gRow)).Single();

                // Guardamos los nombres de los estados para mostrarlos en el listBox
                oldEs = simulation.EstadoSimulacionRow.Nombre;
                newEs = es.Nombre;

                // Modificamos el estado de la simulacion
                simulation.BeginEdit();
                simulation.EstadoSimulacionRow = es;
                simulation.EndEdit();

                try
                {
                    // Guardamos los cambios
                    simulacionTableAdapter.Update(simulation);
                    vistaSimulacionTableAdapter.Fill(this.webappDBDataSet.VistaSimulacion);

                    // Lo mostramos en el ListBox
                    //threadLog_listBox.Items.Add(simulation.nombre + ": " + oldEs + " a " + newEs);
                }
                catch (Exception exc)
                {
                    MessageBox.Show("[CHANGE STATE] Error: " + exc, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Guid idSimulacion = (Guid)dataGridView1.Rows[e.RowIndex].Cells[0].Value;
            FormSimulation formSimulation = new FormSimulation(idSimulacion);

            formSimulation.ShowDialog();

            if (formSimulation.DialogResult.Equals(DialogResult.OK))
            {
                vistaSimulacionTableAdapter.Fill(this.webappDBDataSet.VistaSimulacion);
                dataGridView1.Update();
                dataGridView1.Refresh();                
            }

            formSimulation.Dispose();
        }
    }
}
