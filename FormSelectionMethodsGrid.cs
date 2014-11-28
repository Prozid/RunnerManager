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
    public partial class FormSelectionMethodsGrid : Form
    {
        public FormSelectionMethodsGrid()
        {
            InitializeComponent();
        }

        private void FormSelectionMethodsGrid_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'webappDBDataSet.MetodoSeleccion' Puede moverla o quitarla según sea necesario.
            this.metodoSeleccionTableAdapter.Fill(this.webappDBDataSet.MetodoSeleccion);
        }

        private void SaveChanges()
        {
            metodoSeleccionTableAdapter.Update(webappDBDataSet.MetodoSeleccion);
        }

        private void CheckExit(object sender, FormClosingEventArgs e)
        {
            if (webappDBDataSet.HasChanges())
            {
                DialogResult resp = MessageBox.Show(
                   "Do you want to save changes?",
                   "Close",
                   MessageBoxButtons.YesNoCancel,
                   MessageBoxIcon.Question
                );

                if (resp.Equals(DialogResult.Yes))
                    SaveChanges();
                else if (resp.Equals(DialogResult.Cancel))
                    e.Cancel = true;
            }
        }

        /*
         * EVENTOS
         */
        private void FormSelectionMethodsGrid_FormClosing(object sender, FormClosingEventArgs e)
        {
            CheckExit(sender, e);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SaveChanges();
            this.Close();
        }

        private void btnDiscard_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
