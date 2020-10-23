using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Funcoes
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
            txtresult.Text = "";
        }

        private void Calcular()
        {
            switch (operador)
            {
                case "+": total = total + ultimonumero;
                    break;
                case "-": total = total + ultimonumero;
                    break;
                case "/": total = total + ultimonumero;
                    break;
                case "x": total = total + ultimonumero;
                    break;
            }

            ultimonumero = 0;
            txtresult.Text = total.ToString();
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

        private void gerarnumero(object sender, EventArgs e)
        {
            if(ultimonumero == 0)
            {

            }

            txtresult.Text = txtresult.Text + (sender as Button).Text;
            ultimonumero = Convert.ToDouble(txtresult.Text);
        }

        private void operadores(object sender, EventArgs e)
        {
            txtresult.Text = txtresult.Text + (sender as Button).Text;
        }

        private void btresult_Click(object sender, EventArgs e)
        {
            ultimonumero = Convert.ToDouble(txtresult.Text);
            Calcular();
            operador = "+";
            total = 0;
        }
    }
}
