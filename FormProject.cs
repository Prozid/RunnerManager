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
    public partial class FormProject : Form
    {
        private Guid _IdProject;
        
        public FormProject()
        {
            InitializeComponent();
            _IdProject = Guid.Empty;
        }

        public FormProject(Guid IdProject)
        {
            InitializeComponent();
            _IdProject = IdProject;
        }

        private void FormProject_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'webappDBDataSet.Proyecto' Puede moverla o quitarla según sea necesario.
            this.proyectoTableAdapter.Fill(this.webappDBDataSet.Proyecto);
            // TODO: esta línea de código carga datos en la tabla 'webappDBDataSet.Carpeta' Puede moverla o quitarla según sea necesario.
            this.carpetaTableAdapter.Fill(this.webappDBDataSet.Carpeta);

            if (!_IdProject.Equals(Guid.Empty))
            {
                WebappDBDataSet.ProyectoRow project = this.webappDBDataSet.Proyecto.Where(proj => proj.IdProyecto.Equals(_IdProject)).Single();
                txtName.Text = project.Nombre;
                if (!project.IsDescripcionNull())
                    txtDescription.Text = project.Descripcion;
                cbxFolder.SelectedValue = project.IdCarpeta;
                lblCreationDate.Text = project.FechaCreacionProyecto.ToString();
                if (!project.IsFechaLanzUltSimulacionNull())
                    lblLastExecution.Text = project.FechaLanzUltSimulacion.ToString();

                btnDelete.Enabled = true;
                btnDelete.Visible = true;
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
            if (txtName.Text != "")
            {

                if (_IdProject.Equals(Guid.Empty))
                {
                    WebappDBDataSetTableAdapters.ProyectoTableAdapter newProject = new WebappDBDataSetTableAdapters.ProyectoTableAdapter();
                    _IdProject = Guid.NewGuid();

                    newProject.Insert(
                        _IdProject,
                        txtName.Text,
                        txtDescription.Text,
                        null,
                        DateTime.Now,
                        (Guid)cbxFolder.SelectedValue
                    );
                }
                else
                {
                    WebappDBDataSet.ProyectoRow project = this.webappDBDataSet.Proyecto.Where(proj => proj.IdProyecto.Equals(_IdProject)).Single();

                    project.Nombre = txtName.Text;
                    project.Descripcion = txtDescription.Text;
                    project.IdCarpeta = (Guid)cbxFolder.SelectedValue;

                    this.proyectoTableAdapter.Update(project);
                }


            }

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult resp = MessageBox.Show(
                   "Do you want to delete this project?",
                   "Close",
                   MessageBoxButtons.YesNoCancel,
                   MessageBoxIcon.Question
                );

            if (resp.Equals(DialogResult.Yes))
            {
                WebappDBDataSet.ProyectoRow project = this.webappDBDataSet.Proyecto.Where(proj => proj.IdProyecto.Equals(_IdProject)).Single();

                // TODO Implementar delete en cascada
                project.BeginEdit();
                project.Delete();
                project.EndEdit();

                this.proyectoTableAdapter.Update(project);

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }
    }
}
