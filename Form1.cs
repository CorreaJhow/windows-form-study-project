using System;
using System.Windows.Forms;

namespace windows_form_study_project
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, System.EventArgs e)
        {
            lblResultado.Text = "";
        }

        private void button1_Click(object sender, System.EventArgs e)
        {
            DialogResult sair;
            sair = MessageBox.Show("Deseja mesmo sair do sistema?",
                                   "Pergunta",
                                   MessageBoxButtons.YesNo,
                                   MessageBoxIcon.Question);

            if (sair.Equals(DialogResult.Yes))
                Application.Exit();
        }

        private void btnCalc_Click(object sender, System.EventArgs e)
        {
            double n1, n2, resultado = 0;

            n1 = Convert.ToDouble(txtNumero1.Text);
            n2 = Convert.ToDouble(txtNumero2.Text);

            if (cboTipoConta.SelectedItem.ToString() == "Multiplicação")
            {
                resultado = n1 * n2;
            }
            else if (cboTipoConta.SelectedItem.ToString() == "Divisão")
            {
                if (n2 == 0)
                {
                    MessageBox.Show("Impossivel realizar divisão por 0");
                    txtNumero1.Clear();
                    txtNumero2.Clear();
                    lblResultado.Text = "";
                }
                else
                {
                    resultado = n1 / n2;
                }
            }
            else if (cboTipoConta.SelectedItem.ToString() == "Soma")
            {
                resultado = n1 + n2;
            }
            else if (cboTipoConta.SelectedItem.ToString() == "Subtração")
            {
                resultado = n1 - n2;
            }

            lblResultado.Text = Convert.ToString(resultado);
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtNumero1.Clear();
            txtNumero2.Clear();
            lblResultado.Text = "";
        }
    }
}
