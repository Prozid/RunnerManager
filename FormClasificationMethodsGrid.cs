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
    public partial class FormClasificationMethodsGrid : Form
    {
        public FormClasificationMethodsGrid()
        {
            InitializeComponent();
        }

        private void FormClasificationMethods_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'webappDBDataSet.MetodoClasificacion' Puede moverla o quitarla según sea necesario.
            this.metodoClasificacionTableAdapter.Fill(this.webappDBDataSet.MetodoClasificacion);

        }
    }
}
