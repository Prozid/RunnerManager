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
    public partial class FormFilesGrid : Form
    {
        public FormFilesGrid()
        {
            InitializeComponent();
        }

        private void FormFilesGrid_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'webappDBDataSet.Archivo' Puede moverla o quitarla según sea necesario.
            this.archivoTableAdapter.Fill(this.webappDBDataSet.Archivo);

        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Guid idFile = (Guid)dataGridView1.Rows[e.RowIndex].Cells[0].Value;
            FormFile formFile = new FormFile(idFile);

            formFile.ShowDialog();

            if (formFile.DialogResult.Equals(DialogResult.OK))
            {
                archivoTableAdapter.Fill(this.webappDBDataSet.Archivo);
                dataGridView1.Update();
                dataGridView1.Refresh();
            }

            formFile.Dispose();
        }
    }
}
