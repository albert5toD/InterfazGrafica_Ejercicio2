using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InterfazGrafica_Ejercicio2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtValor1.Clear();
            txtValor2.Clear();
            txtSuma.Clear();
            txtResta.Clear();
            txtMulti.Clear();
            txtDivision.Clear();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double valor1, valor2;

            valor1 = double.Parse(txtValor1.Text);
            valor2 = double.Parse(txtValor2.Text);

            double suma, resta, multiplicación, division;

            suma = valor1 + valor2;
            resta = valor1 - valor2;
            multiplicación = valor1 * valor2;
            division = valor1 / valor2;

            txtSuma.Text = suma.ToString();
            txtResta.Text = resta.ToString();
            txtMulti.Text = multiplicación.ToString();
            txtDivision.Text = division.ToString();
        }
    }
}
