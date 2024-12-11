using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace windows_form_study_project
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAcao_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Seu nome completo é: " + txtNome.Text + " " + txtSobrenome.Text);
        }
    }
}
