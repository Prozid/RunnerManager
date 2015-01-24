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
    public partial class FormFoldersGrid : Form
    {
        public FormFoldersGrid()
        {
            InitializeComponent();
        }

        private void FormFoldersGrid_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'webappDBDataSet.Carpeta' Puede moverla o quitarla según sea necesario.
            this.carpetaTableAdapter.Fill(this.webappDBDataSet.Carpeta);

        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Guid idFolder = (Guid)dataGridView1.Rows[e.RowIndex].Cells[0].Value;
            FormFolder formFolder = new FormFolder(idFolder);

            formFolder.ShowDialog();

            if (formFolder.DialogResult.Equals(DialogResult.OK))
            {
                carpetaTableAdapter.Fill(this.webappDBDataSet.Carpeta);
                dataGridView1.Update();
                dataGridView1.Refresh();
            }

            formFolder.Dispose();
        }
    }
}
