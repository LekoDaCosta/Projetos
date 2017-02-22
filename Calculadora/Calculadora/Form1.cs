using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class Form1 : Form
    {

        Double Total;
        Double UltimoNumero;
        string Operador;


      

        private void Limpar()
        {
            Total = 0;
            UltimoNumero = 0;
            mtbResultado.Text = "0";
            Operador = " + ";
        }


        private void Calcular()
        {

            switch (Operador)
            {
                case "+": Total = Total + UltimoNumero;
                    break;
                case "-": Total = Total - UltimoNumero;
                    break;
                case "X": Total = Total * UltimoNumero;
                    break;
                case "/": Total = Total / UltimoNumero;
                    break; 
            }
            UltimoNumero = 0;
            mtbResultado.Text = Total.ToString();
        }


        public Form1()
        {
            InitializeComponent();

            Limpar();
        }

       
        private void btnNumero(object sender, EventArgs e)
        {
            if (UltimoNumero == 0)
            {
                mtbResultado.Text = (sender as Button).Text;
            }

            else{
                mtbResultado.Text = mtbResultado.Text + (sender as Button).Text;
                }

                 UltimoNumero = Convert.ToDouble(mtbResultado.Text);
        }

        private void btnOperador(object sender, EventArgs e)
        {
            UltimoNumero = Convert.ToDouble(mtbResultado.Text);
            Calcular();

            Operador = (sender as Button).Text;
        }


        private void btnIgual(object sender, EventArgs e)
        {

            UltimoNumero = Convert.ToDouble(mtbResultado.Text);
            Calcular();
            Operador = "+";
            Total = 0;
        }

        private void btnLimpar(object sender, EventArgs e)
        {
            Limpar();
        }
    }
}
