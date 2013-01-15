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
    public partial class FormSimulation : Form
    {
        public FormSimulation()
        {
            InitializeComponent();
        }

        private void FormSimulation_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'webappDBDataSet.MetodoClasificacion' Puede moverla o quitarla según sea necesario.
            this.metodoClasificacionTableAdapter.Fill(this.webappDBDataSet.MetodoClasificacion);
            // TODO: esta línea de código carga datos en la tabla 'webappDBDataSet.MetodoSeleccion' Puede moverla o quitarla según sea necesario.
            this.metodoSeleccionTableAdapter.Fill(this.webappDBDataSet.MetodoSeleccion);
            // TODO: esta línea de código carga datos en la tabla 'webappDBDataSet.EstadoSimulacion' Puede moverla o quitarla según sea necesario.
            this.estadoSimulacionTableAdapter.Fill(this.webappDBDataSet.EstadoSimulacion);

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            //Save();
        }

        private void Save()
        {
            if (txtName.Text != ""
                && txtUser.Text != ""
                && cbxClasification.SelectedValue != ""
                && cbxSelection.SelectedValue != ""
                && cbxStateSimulation.SelectedValue != "")
            {
                Guid idSimulation = Guid.NewGuid();


            }

        }
    }

}
