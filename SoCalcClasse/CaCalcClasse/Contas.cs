using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaCalcClasse
{
    internal class Contas
    {
        //Propriedades
        private double num1;

        public double Num1
        {
            get { return num1; }
            set { num1 = value; }
        }

        private double num2;


        public double Num2
        {
            get { return num2; }
            set { num2 = value; }
        }

        //Construtores

        /// <summary>
        /// Construtor padrão, standard builder
        /// </summary>
        public Contas()
        {
            Num1 = 0;
            Num2 = 0;
        }

        public Contas(double num1, double num2)
        {
            Num1 = num1;
            Num2 = num2;
        }

        //Métodos
    }
}
