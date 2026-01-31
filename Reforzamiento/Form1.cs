using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Reforzamiento
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        
        {
            double n1, n2, n3, n4;
            double promedio, completivo, extraordinario;

            n1 = Convert.ToDouble(txtNota1.Text);
            n2 = Convert.ToDouble(txtNota2.Text);
            n3 = Convert.ToDouble(txtNota3.Text);
            n4 = Convert.ToDouble(txtNota4.Text);

            // Calcular promedio
            promedio = (n1 + n2 + n3 + n4) / 4;
            txtPromedio.Text = promedio.ToString("0.00");

            // Verificar promedio
            if (promedio <= 69)
            {
                txtCompletivo.Enabled = true;
                MessageBox.Show("Debe ir a completivo");
            }
            else
            {
                txtResultado.Text = "Aprobado";
                return;
            }

            // Calcular completivo
            if (txtCompletivo.Text != "")
            {
                completivo = (promedio * 0.50) + (Convert.ToDouble(txtCompletivo.Text) * 0.50);

                if (completivo <= 69)
                {
                    txtExtraordinario.Enabled = true;
                    MessageBox.Show("Debe ir a extraordinario");
                }
                else
                {
                    txtResultado.Text = "Aprobado por completivo";
                    return;
                }
            }

            // Calcular extraordinario
            if (txtExtraordinario.Text != "")
            {
                extraordinario = (promedio * 0.30) + (Convert.ToDouble(txtExtraordinario.Text) * 0.70);

                if (extraordinario <= 69)
                {
                    txtResultado.Text = "Reprobado";
                }
                else
                {
                    txtResultado.Text = "Aprobado por extraordinario";
                }
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        
        {
            txtNota1.Clear();
            txtNota2.Clear();
            txtNota3.Clear();
            txtNota4.Clear();
            txtPromedio.Clear();
            txtCompletivo.Clear();
            txtExtraordinario.Clear();
            txtResultado.Clear();

            txtCompletivo.Enabled = false;
            txtExtraordinario.Enabled = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtCompletivo.Enabled = false;
            txtExtraordinario.Enabled = false;
            txtPromedio.ReadOnly = true;
            txtResultado.ReadOnly = true;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}


