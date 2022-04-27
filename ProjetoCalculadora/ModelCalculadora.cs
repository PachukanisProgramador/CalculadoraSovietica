using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoCalculadora
{
    class ModelCalculadora
    {

        public ModelCalculadora()
        {


        }// Fim do método construtor

        public double sumOperacao(double num1, double num2)
        {

            return num1 + num2;

        }

        public double SubtOperacao(double num1, double num2)
        {

            return num1 - num2;

        }

        public double DiviOperacao(double num1, double num2)
        {

            if (num2 == 0)
            {
                return -1;
            }
            else
            {
                return num1 / num2;

            }

        }

        public double MultOperacao(double num1, double num2)
        {

            return num1 * num2;

        }

        public double PoteOperacao(double bas, double expoente)
        {

            if (expoente == 1)
            {
                return bas;
            }
            else if (expoente == 0)
            {
                return 1;
            }
            else
            {
                return Math.Pow(bas, expoente);
            }

        }

        public double RadiOperacao(double num1)
        {

            if (num1 < 0)
            {
                return -1;
            }
            else
            {
                return Math.Sqrt(num1);
            }


        }

    }//Fim da classe
}// Fim do projeto
