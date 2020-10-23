using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Subrotinas
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
    }
}
