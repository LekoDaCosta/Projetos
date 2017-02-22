using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace robo
{
   public class Rosto
    {
        // Atributos da classe 

        public Olho OlhoDireito { get; set; }
        public Olho OlhoEsquerdo { get; set; }
        public string Estado { get; set; }

        //  Metodos da classes

        public void Feliz()
        {
            OlhoDireito.AbrirOlho();
            OlhoEsquerdo.AbrirOlho();
            Estado = " (_____) ";
      }

        public void Triste()
        {
            OlhoDireito.FecharOlho();
            OlhoEsquerdo.FecharOlho();
            Estado = " ----- ";
        }

        public void Emocionado()
        {
            OlhoDireito.AbrirOlho();
            OlhoEsquerdo.FecharOlho();
            Estado = " ------)";
        }

        // Construtor da Classe

        public Rosto()
        {
            OlhoDireito = new Olho();
            OlhoEsquerdo = new Olho();
            Feliz();
        }
    }



}
