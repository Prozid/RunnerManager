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
    public partial class FormResultsGrid : Form
    {
        public FormResultsGrid()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Guid idResult = (Guid)dataGridViewResults.Rows[e.RowIndex].Cells[0].Value;
            FormResult formResult = new FormResult(idResult);

            formResult.ShowDialog();

            if (formResult.DialogResult.Equals(DialogResult.OK))
            {
                resultadoTableAdapter.Fill(this.webappDBDataSet.Resultado);
                dataGridViewResults.Update();
                dataGridViewResults.Refresh();
            }

            formResult.Dispose();
        }
    }
}
