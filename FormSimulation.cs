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
    public partial class FormSimulation : Form
    {
        private Guid _IdSimulation;
        private DateTime _CreationDate;

        public FormSimulation()
        {
            InitializeComponent();
            _IdSimulation = Guid.Empty;
            _CreationDate = DateTime.Now;
        }

        public FormSimulation(Guid IdSimulation)
        {
            InitializeComponent();
            _IdSimulation = IdSimulation;
        }

        private void FormSimulation_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'webappDBDataSet.Proyecto' Puede moverla o quitarla según sea necesario.
            this.proyectoTableAdapter.Fill(this.webappDBDataSet.Proyecto);
            // TODO: esta línea de código carga datos en la tabla 'webappDBDataSet.Carpeta' Puede moverla o quitarla según sea necesario.
            this.carpetaTableAdapter.Fill(this.webappDBDataSet.Carpeta);
            // TODO: esta línea de código carga datos en la tabla 'webappDBDataSet.Archivo' Puede moverla o quitarla según sea necesario.
            this.archivoTableAdapter.Fill(this.webappDBDataSet.Archivo);
            // TODO: esta línea de código carga datos en la tabla 'webappDBDataSet.MetodoClasificacion' Puede moverla o quitarla según sea necesario.
            this.metodoClasificacionTableAdapter.Fill(this.webappDBDataSet.MetodoClasificacion);
            // TODO: esta línea de código carga datos en la tabla 'webappDBDataSet.MetodoSeleccion' Puede moverla o quitarla según sea necesario.
            this.metodoSeleccionTableAdapter.Fill(this.webappDBDataSet.MetodoSeleccion);
            // TODO: esta línea de código carga datos en la tabla 'webappDBDataSet.EstadoSimulacion' Puede moverla o quitarla según sea necesario.
            this.estadoSimulacionTableAdapter.Fill(this.webappDBDataSet.EstadoSimulacion);

            if (!_IdSimulation.Equals(Guid.Empty))
            {
                // Relleno los campos
                this.simulacionTableAdapter.Fill(this.webappDBDataSet.Simulacion);

                WebappDBDataSet.SimulacionRow simulation = this.webappDBDataSet.Simulacion.Where(sim => sim.IdSimulacion.Equals(_IdSimulation)).Single();

                _CreationDate = simulation.FechaCreacionSimulacion;

                txtName.Text = simulation.Nombre;
                txtDescription.Text = simulation.Descripcion;
                txtUser.Text = simulation.Usuario;

                cbxClasification.SelectedValue = simulation.IdMetodoClasificacion;
                txtArgsClasification.Text = simulation.ParametrosClasificacion;
                cbxSelection.SelectedValue = simulation.IdMetodoSeleccion;
                txtArgsSelection.Text = simulation.ParametrosSeleccion;
                cbxStateSimulation.SelectedValue = simulation.IdEstadoSimulacion;

                cbxArchivo.SelectedValue = simulation.IdArchivo;
                cbxCarpeta.SelectedValue = simulation.IdCarpeta;

                btnDelete.Visible = true;
                //btnProject.Text = simulation.ProyectoRow.Nombre;

            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Save();
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void Save()
        {
            if (txtName.Text != ""
                && txtUser.Text != ""
                && cbxClasification.SelectedValue != ""
                && cbxSelection.SelectedValue != ""
                && cbxStateSimulation.SelectedValue != ""
                && cbxProject.SelectedValue != "")
            {
                Guid idProyecto = (Guid)cbxProject.SelectedValue;

                if (_IdSimulation.Equals(Guid.Empty))
                {
                    WebappDBDataSetTableAdapters.SimulacionTableAdapter newSimulation = new WebappDBDataSetTableAdapters.SimulacionTableAdapter();
                    _IdSimulation = Guid.NewGuid();

                    newSimulation.Insert(
                        _IdSimulation,
                        idProyecto, txtName.Text,
                        txtDescription.Text,
                        _CreationDate,
                        (Guid)cbxSelection.SelectedValue,
                        (Guid)cbxClasification.SelectedValue,
                        (Guid)cbxStateSimulation.SelectedValue,
                        txtArgsSelection.Text,
                        txtArgsClasification.Text,
                        txtUser.Text,
                        null,
                        (Guid)cbxArchivo.SelectedValue,
                        (Guid)cbxCarpeta.SelectedValue
                    );
                }
                else
                {
                    WebappDBDataSet.SimulacionRow simulation = this.webappDBDataSet.Simulacion.Where(sim => sim.IdSimulacion.Equals(_IdSimulation)).Single();

                    simulation.Nombre = txtName.Text;
                    simulation.Descripcion = txtDescription.Text;
                    simulation.IdMetodoSeleccion = (Guid)cbxSelection.SelectedValue;
                    simulation.IdMetodoClasificacion = (Guid)cbxClasification.SelectedValue;
                    simulation.IdEstadoSimulacion = (Guid)cbxStateSimulation.SelectedValue;
                    simulation.ParametrosSeleccion = txtArgsSelection.Text;
                    simulation.ParametrosClasificacion = txtArgsClasification.Text;
                    simulation.Usuario = txtUser.Text;
                    simulation.IdArchivo = (Guid)cbxArchivo.SelectedValue;
                    simulation.IdCarpeta = (Guid)cbxCarpeta.SelectedValue;

                    this.simulacionTableAdapter.Update(simulation);
                }


            }

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult resp = MessageBox.Show(
                   "Do you want to delete this simulation?",
                   "Close",
                   MessageBoxButtons.YesNoCancel,
                   MessageBoxIcon.Question
                );

            if (resp.Equals(DialogResult.Yes))
            {
                WebappDBDataSet.SimulacionRow simulation = this.webappDBDataSet.Simulacion.Where(sim => sim.IdSimulacion.Equals(_IdSimulation)).Single();

                simulation.BeginEdit();
                simulation.Delete();
                simulation.EndEdit();

                this.simulacionTableAdapter.Update(simulation);

                this.DialogResult = DialogResult.OK;
                this.Close();
            }          
        }
    }

}
