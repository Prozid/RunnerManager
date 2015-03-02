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
    public partial class FormFolder : Form
    {
        private Guid _IdFolder;

        public FormFolder()
        {
            InitializeComponent();
            _IdFolder = Guid.Empty;
        }

        public FormFolder(Guid IdFolder)
        {
            InitializeComponent();
            _IdFolder = IdFolder;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Save();
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult resp = MessageBox.Show(
                   "Do you want to delete this folder?",
                   "Close",
                   MessageBoxButtons.YesNoCancel,
                   MessageBoxIcon.Question
                );

            if (resp.Equals(DialogResult.Yes))
            {
                WebappDBDataSet.CarpetaRow folder = this.webappDBDataSet.Carpeta.Where(f => f.IdCarpeta.Equals(_IdFolder)).Single();

                int childrens = this.webappDBDataSet.Carpeta.Where(f => !f.IsIdCarpetaPadreNull() && f.IdCarpetaPadre.Equals(folder.IdCarpeta)).Count();
                int files = this.webappDBDataSet.Archivo.Where(s => s.IdCarpeta.Equals(folder.IdCarpeta)).Count();
                int simulations = this.webappDBDataSet.Simulacion.Where(s => s.IdCarpeta.Equals(folder.IdCarpeta)).Count();
                //TODO Testear que no falle si intento borrar una carpeta que contenga archivos o alguna simulación

                if (childrens > 0 || files > 0)
                {
                    DialogResult alert = MessageBox.Show(
                      "There are childrens in this folder. Please delete them before delete the folder.",
                      "Close",
                      MessageBoxButtons.OK,
                      MessageBoxIcon.Stop
                   );

                }
                else if (simulations > 0)
                {
                    DialogResult alert = MessageBox.Show(
                      "There are simulations in this folder. Please delete them before delete the folder.",
                      "Close",
                      MessageBoxButtons.OK,
                      MessageBoxIcon.Stop
                   );

                }
                else
                {

                    folder.BeginEdit();
                    folder.Delete();
                    folder.EndEdit();

                    this.carpetaTableAdapter.Update(folder);

                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
            }
        }

        private void FormFolder_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'webappDBDataSet.Carpeta' Puede moverla o quitarla según sea necesario.
            this.carpetaTableAdapter.Fill(this.webappDBDataSet.Carpeta);

            if (!_IdFolder.Equals(Guid.Empty))
            {
                WebappDBDataSet.CarpetaRow folder = this.webappDBDataSet.Carpeta.Where(f => f.IdCarpeta.Equals(_IdFolder)).Single();

                txtName.Text = folder.Nombre;
                txtUser.Text = folder.Usuario;
                if (!folder.IsIdCarpetaPadreNull())
                    cbxRootFolder.SelectedValue = folder.IdCarpetaPadre;
                lblCreationDate.Text = folder.FechaCreac_on.ToString();

                btnDelete.Enabled = true;
                btnDelete.Visible = true;
            }
        }

        private void Save()
        {
            if (txtName.Text != "" && txtUser.Text != "")
            {

                if (_IdFolder.Equals(Guid.Empty))
                {
                    WebappDBDataSetTableAdapters.CarpetaTableAdapter newFolder = new WebappDBDataSetTableAdapters.CarpetaTableAdapter();
                    _IdFolder = Guid.NewGuid();

                    newFolder.Insert(
                        _IdFolder,
                        txtName.Text,
                        cbxRootFolder.SelectedValue == null ? (Guid?)null : (Guid)cbxRootFolder.SelectedValue,
                        txtUser.Text,
                        DateTime.Now                        
                    );
                }
                else
                {
                    WebappDBDataSet.CarpetaRow folder = this.webappDBDataSet.Carpeta.Where(f => f.IdCarpeta.Equals(_IdFolder)).Single();

                    folder.Nombre = txtName.Text;
                    folder.Usuario = txtUser.Text;
                    if (cbxRootFolder.SelectedValue != null)
                        folder.IdCarpetaPadre = (Guid)cbxRootFolder.SelectedValue;

                    this.carpetaTableAdapter.Update(folder);
                }


            }

        }
    }
}
