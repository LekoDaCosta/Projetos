using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;




namespace robo
{
    public partial class Form1 : Form
    {
          public Rosto MeuRosto { get; set; }




        public Form1()
        {
            InitializeComponent();

            MeuRosto = new Rosto();
            MeuRosto.Feliz();
            Ajustar();
        }

        public void Ajustar()
        {
            btnOlhoDireito.Text = MeuRosto.OlhoDireito.Estado;
            btnOlhoEsquerdo.Text = MeuRosto.OlhoEsquerdo.Estado;
            btnBoca.Text = MeuRosto.Estado;
        }

        private void btnFeliz_Click(object sender, EventArgs e)
        {
            MeuRosto.Feliz();
            Ajustar();
        }

        private void btnTriste_Click(object sender, EventArgs e)
        {
            MeuRosto.Triste();
            Ajustar();
        }

        private void btnEmocionado_Click(object sender, EventArgs e)
        {
            MeuRosto.Emocionado();
            Ajustar();
        }
    }
}
