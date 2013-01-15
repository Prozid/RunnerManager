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
    }
}
