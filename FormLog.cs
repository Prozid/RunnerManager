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
    public partial class FormLog : Form
    {
        private Guid _IdLog;
        
        public FormLog()
        {
            InitializeComponent();
            _IdLog = Guid.Empty;
        }

        public FormLog(Guid IdLog)
        {
            InitializeComponent();
            _IdLog = IdLog;
        }

        private void FormLog_Load(object sender, EventArgs e)
        {
            this.logTableAdapter.Fill(this.webappDBDataSet.Log);
            if (!_IdLog.Equals(Guid.Empty))
            {
                WebappDBDataSet.LogRow log = this.webappDBDataSet.Log.Where(l => l.IdLog.Equals(_IdLog)).Single();
                txtText.Text = log.Texto;
                lblDate.Text = log.FechaLog.ToString();
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }        
    }
}
