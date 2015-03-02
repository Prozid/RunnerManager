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
    public partial class FormResult : Form
    {
        private Guid _IdResult;

        public FormResult(Guid IdResult)
        {
            InitializeComponent();
            _IdResult = IdResult;
        }

        private void FormResult_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'webappDBDataSet.Resultado' Puede moverla o quitarla según sea necesario.
            this.resultadoTableAdapter.Fill(this.webappDBDataSet.Resultado);

            WebappDBDataSet.ResultadoRow result = this.webappDBDataSet.Resultado.Where(r => r.IdResultado.Equals(_IdResult)).Single();

            numGenesTextBox.Text = result.NumGenes.ToString();
            nombreGenesTextBox.Text = result.NombreGenes;
            idGenesTextBox.Text = result.IdGenes;
            accuracy_MediaTextBox.Text = result.Accuracy_Media.ToString();
            accuracy_StdTextBox.Text = result.Accuracy_Std.ToString();
            sensitivity_MediaTextBox.Text = result.Sensitivity_Media.ToString();
            sensitivity_StdTextBox.Text = result.Sensitivity_Std.ToString();
            specificity_MediaTextBox.Text = result.Specificity_Media.ToString();
            specificity_StdTextBox.Text = result.Specificity_Std.ToString();
            fechaLanzamientoDateTimePicker.Value = result.FechaLanzamiento;
            fechaFinalizacionDateTimePicker.Value = result.FechaFinalizacion;
            duracionDateTimePicker.Value = result.Duracion;
            accuracyXGenesTextBox.Text = result.AccuracyXGenes;
            medianaTextBox.Text = result.Mediana.ToString();
            nombreGenesSolucionTextBox.Text = result.NombreGenesSolucion;
            idGenesSolucionTextBox.Text = result.IdGenesSolucion;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnOpenSimulation_Click(object sender, EventArgs e)
        {
            WebappDBDataSet.ResultadoRow result = this.webappDBDataSet.Resultado.Where(r => r.IdResultado.Equals(_IdResult)).Single();
            FormSimulation fSimulation = new FormSimulation(result.IdSimulacion);
            fSimulation.Show();
        }
    }
}
