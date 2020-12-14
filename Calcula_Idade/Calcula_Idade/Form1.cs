using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calcula_Idade
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcularIdade_Click(object sender, EventArgs e)
        {
            int resultado = CalculaIdade(dtpNascimento.Value);
            lblIdade.Text = $"{resultado} anos";
        }

        private static int CalcularIdade(DateTime dataNascimento)
        {
            int idade = DateTime.Now.Year - dataNascimento.Year;
            return idade;
        }
    }
}
