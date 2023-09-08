﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SaludoFormG2_2024_1
{
    internal partial class SaludoForm
    {
        public SaludoForm()
        {
            InitializeComponent();
        }

        internal void btnAceptar_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text;
            MessageBox.Show("Hola " +nombre);

            contador++;
            lbContador.Text = "Contador: " + contador;
        }

        internal void btnLimpiar_Click(object sender, EventArgs e)
        {
           
			txtNombre.Text = "";
            
        }
    }
}
