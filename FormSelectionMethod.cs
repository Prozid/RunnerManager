using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace runnerManager
{
    public partial class FormSelectionMethod : Form
    {
        public FormSelectionMethod()
        {
            InitializeComponent();
        }

        private void Save()
        {
            if (txtName.Text != null && txtName.Text != "")
            {
                metodoSeleccionTableAdapter1.Insert(
                    Guid.NewGuid(),
                    txtName.Text,
                    txtDescription.Text,
                    txtArgs.Text
                );
            }
            else
            {
                MessageBox.Show(
                    "Introduce the method's name.",
                    "Field empty",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Save();
        }
    }
}
