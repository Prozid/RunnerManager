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
    public partial class FormProjectsGrid : Form
    {
        public FormProjectsGrid()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Guid idProject = (Guid)dataGridView1.Rows[e.RowIndex].Cells[0].Value;
            FormProject formProject = new FormProject(idProject);

            formProject.ShowDialog();

            if (formProject.DialogResult.Equals(DialogResult.OK))
            {
                proyectoTableAdapter.Fill(this.webappDBDataSet.Proyecto);
                dataGridView1.Update();
                dataGridView1.Refresh();
            }

            formProject.Dispose();
        }

        private void FormProjectsGrid_Load(object sender, EventArgs e)
        {
            this.proyectoTableAdapter.Fill(this.webappDBDataSet.Proyecto);
        }
    }
}
