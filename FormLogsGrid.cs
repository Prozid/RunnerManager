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
    public partial class FormLogsGrid : Form
    {
        public FormLogsGrid()
        {
            InitializeComponent();
        }

        private void FormLog_Load(object sender, EventArgs e)
        {

        }

        private void dataGridViewLog_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Guid idLog = (Guid)dataGridViewLog.Rows[e.RowIndex].Cells[0].Value;
            FormLog formLog = new FormLog(idLog);

            formLog.ShowDialog();

            if (formLog.DialogResult.Equals(DialogResult.OK))
            {
                logTableAdapter.Fill(this.webappDBDataSet.Log);
                dataGridViewLog.Update();
                dataGridViewLog.Refresh();
            }

            formLog.Dispose();
        }
    }
}
