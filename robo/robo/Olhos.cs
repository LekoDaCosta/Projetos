using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace robo
{
    public class Olho
    {
        // Propriedades da Classe
        public string    Cor { get; set; }
        public string Estado { get; set; }


        //Metodos da Classe

        public void AbrirOlho()
        {
            Estado = " O ";
        }

        public void FecharOlho()
        {

            Estado = " ----- ";
        }

        public void PiscarOlhos()
        {
            FecharOlho();
            AbrirOlho();
        }


        // Metodo construtor

        public Olho()
        {
            Cor    = " castanho ";
            Estado = " ----- ";
        }


    }
}
