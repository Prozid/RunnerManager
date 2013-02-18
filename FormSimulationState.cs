﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace runnerManager
{
    public partial class FormSimulationState : Form
    {
        public FormSimulationState()
        {
            InitializeComponent();
        }

        private void btnDiscard_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Abort;
            this.Close();
        }

        private void btnAddState_Click(object sender, EventArgs e)
        {
            Guid idState = Guid.NewGuid();

            WebappDBDataSet.EstadoSimulacionRow newState = webappDBDataSet.EstadoSimulacion.NewEstadoSimulacionRow();
            newState.idEstadoSimulacion = idState;
            newState.nombre = txtNameState.Text;
            newState.nombreCorto = txtShortNameState.Text;
            estadoSimulacionTableAdapter1.Insert(
                newState.idEstadoSimulacion,
                newState.nombre,
                "",
                newState.nombreCorto
            );
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}