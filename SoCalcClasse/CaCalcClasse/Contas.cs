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
        /// Construtor padrão
        /// </summary>
        public Contas()
        {
            Num1 = 0;
            Num2 = 0;
        }
        /// <summary>
        /// Construtor com parâmetros
        /// </summary>
        /// <param name="num1">1º número</param>
        /// <param name="num2">2º número</param>
        public Contas(double num1, double num2)
        {
            Num1 = num1;
            Num2 = num2;
        }

        //Métodos

        public string Somar()
        {
            return "A some é " + (Num1 + Num2);
        }
        public string Subtrair()
        {
            return "A diferença é " + (Num1 + Num2);
        }

        public override string ToString()
        {
            return base.ToString() + "\n" + 
                $"Num1: {Num1}\n" +
                $"Num2: " + Num2 + "\n";
        }
    }
}
