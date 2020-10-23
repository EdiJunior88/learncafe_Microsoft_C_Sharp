using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Subrotinas_2
{
    public partial class Form1 : Form
    {

        double total;
        double ultimonumero;
        string operador;

        private void Limpar()
        {
            total = 0;
            ultimonumero = 0;
            operador = "+";
        }
        public Form1()
        {
            InitializeComponent();
            Limpar();
        }

        private void btlimpar_Click(object sender, EventArgs e)
        {
            Limpar();
        }

        private void bt0_Click(object sender, EventArgs e)
        {
            txtresultado.Text = txtresultado.Text + "0";
        }

        private void bt1_Click(object sender, EventArgs e)
        {
            txtresultado.Text = txtresultado.Text + "1";
        }
    }
}
