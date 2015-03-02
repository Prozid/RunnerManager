using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using Microsoft.Win32;

namespace PBioManager
{
    public partial class FormFile : Form
    {
        private Guid _IdFile;
        private String filePath;

        public FormFile()
        {
            InitializeComponent();
            _IdFile = Guid.Empty;
            filePath = null;
        }

        public FormFile(Guid IdFile)
        {
            InitializeComponent();
            _IdFile = IdFile;
            filePath = null;
        }

        private void FormFile_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'webappDBDataSet.Carpeta' Puede moverla o quitarla según sea necesario.
            this.carpetaTableAdapter.Fill(this.webappDBDataSet.Carpeta);
            if (!_IdFile.Equals(Guid.Empty))
            {
                // TODO: No encuentra archivos nunca.  
                this.archivoTableAdapter.Fill(this.webappDBDataSet.Archivo);
                WebappDBDataSet.ArchivoRow file = this.archivoTableAdapter.GetData().Where(f => f.IdArchivo.Equals(_IdFile)).Single();
                //WebappDBDataSet.ArchivoRow file = this.webappDBDataSet.Archivo.Where(f => f.IdArchivo.Equals(_IdFile)).Single();

                txtFilename.Text = file.NombreArchivo;
                txtDescription.Text = file.Descripcion;
                cbxFolder.SelectedValue = file.IdCarpeta;
                txtUser.Text = file.Usuario;
                chkPublic.Checked = file.Publico;
                chkData.Checked = file.BaseDatos;
                lblCreationDate.Text = file.FechaCreacion.ToString();
                lblFilenamePath.Text = file.NombreArchivo;

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

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult resp = MessageBox.Show(
                   "Do you want to delete this file?",
                   "Close",
                   MessageBoxButtons.YesNoCancel,
                   MessageBoxIcon.Question
                );

            if (resp.Equals(DialogResult.Yes))
            {
                WebappDBDataSet.ArchivoRow file = this.webappDBDataSet.Archivo.Where(f => f.IdArchivo.Equals(_IdFile)).Single();

                file.BeginEdit();
                file.Delete();
                file.EndEdit();

                this.archivoTableAdapter.Update(file);

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private void Save()
        {
            if (txtFilename.Text != "" && txtUser.Text != "")
            {

                if (_IdFile.Equals(Guid.Empty))
                {
                    WebappDBDataSetTableAdapters.ArchivoTableAdapter newFile = new WebappDBDataSetTableAdapters.ArchivoTableAdapter();
                    _IdFile = Guid.NewGuid();

                    string stringFile = String.Empty;
                    string contenttype = "";
                    
                    if (filePath != null)
                    {
                        // Read file                        
                        stringFile = File.ReadAllText(filePath);
                        contenttype = GetContentType(filePath);
                        if (contenttype == null) contenttype = "";
                    }

                
                    int res = newFile.Insert(
                        _IdFile,
                        (Guid)cbxFolder.SelectedValue,
                        txtUser.Text,
                        chkPublic.Checked,
                        txtFilename.Text,
                        contenttype ,
                        DateTime.Now,
                        txtDescription.Text,
                        chkData.Checked,
                        stringFile           
                    );
                }
                else
                {
                    WebappDBDataSet.ArchivoRow file = this.webappDBDataSet.Archivo.Where(f => f.IdArchivo.Equals(_IdFile)).Single();

                    string stringFile = String.Empty;
                    string contenttype = "";

                    if (filePath != null)
                    {
                        // Read file
                        stringFile = File.ReadAllText(filePath);
                        contenttype = GetContentType(filePath);
                        if (contenttype == null) contenttype = "";
                    }

                    file.IdCarpeta = (Guid)cbxFolder.SelectedValue;
                    file.Usuario = txtUser.Text;
                    file.Publico = chkPublic.Checked;
                    file.NombreArchivo = txtFilename.Text;
                    file.ContentType = contenttype;
                    file.Descripcion = txtDescription.Text;
                    file.BaseDatos = chkData.Checked;
                    file.Datos = stringFile;

                    this.archivoTableAdapter.Update(file);
                }

            }
         }

        private void btnOpenFile_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                // Save file
                foreach (string fileName in openFileDialog.FileNames)
                {
                    lblFilenamePath.Text = fileName;
                    lblFilenamePath.Visible = true;
                    filePath = fileName;
                }
            }
        }

        private void btnDeleteFile_Click(object sender, EventArgs e)
        {
            lblFilenamePath.Text = "----";
            lblFilenamePath.Visible = false;
            filePath = null;
        }

        private string GetContentType(string fileName)
        {
            var extension = Path.GetExtension(fileName);

            if (String.IsNullOrWhiteSpace(extension))
            {
                return null;
            }

            var registryKey = Registry.ClassesRoot.OpenSubKey(extension);

            if (registryKey == null)
            {
                return null;
            }

            var value = registryKey.GetValue("Content Type") as string;

            return String.IsNullOrWhiteSpace(value) ? null : value;
        }
    }


}
