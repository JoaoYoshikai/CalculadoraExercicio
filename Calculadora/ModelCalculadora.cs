using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Configuration;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora
{
    class ModelCalculadora
    {
        //Declarando variáveis
        private double num1;
        private double num2;
        private double num3;
        private string binario;


        public ModelCalculadora()
        {
            GetSetNum1 = 0;
            GetSetNum2 = 0;
            GetSetNum3 = 0;
            GetSetBinario = "";
        }//Fim do construtor

        //Métodos gets e sets

        public double GetSetNum1
        {
            get { return this.num1; }
            set { this.num1 = value; }
        }//Fim do GetSetNum1

        public double GetSetNum2
        {
            get { return this.num2; }
            set { this.num2 = value; }
        }//Fim do GetSetNum2

        public double GetSetNum3
        {
            get { return this.num3; }
            set { this.num3 = value; }
        }//Fim do GetSetNum2

        public string GetSetBinario
        {
            get { return this.binario; }
            set { this.binario = value; }
        }//Fim do GetSetNum2



        //Métodos

        public double Somar()
        {
            return GetSetNum1 + GetSetNum2;
        }//Fim do método somar

        public double Subtrair()
        {
            return GetSetNum1 - GetSetNum2;
        }//Fim do método subtrair

        public double Dividir()
        {
            if (GetSetNum2 <= 0)
            {
                return -1;
            }
            else
            {
                return GetSetNum1 / GetSetNum2;
            }
        }//Fim do método dividir

        public double Multiplicar()
        {
            return GetSetNum1 * GetSetNum2;
        }//Fim do método multiplicar

        public double Potencia()
        {
            return Math.Pow(GetSetNum1, GetSetNum2);
        }//Fim da potência

        public string Raiz()
        {
            string msg = "Raiz do primeiro número:" + Math.Sqrt(GetSetNum1) +
                       "\nRaiz do segundo número:" + Math.Sqrt(GetSetNum2);
            return msg;
        }//Fim do método Raiz

        public string TabuadaNum1()
        {
            string resultado = "";
            for (int i = 0 ; i <= 10; i++)
                {
                resultado += "\n" + GetSetNum1 + " * " + i + " = " + (GetSetNum1 * i);
                }//Fim do For
            return resultado;
        }//Fim do método Tabuada1


        public string TabuadaNum2()
        {
            string resultado = "";
            for (int i = 0; i <= 10; i++)
            {
                resultado += "\n" + GetSetNum2 + " * " + i + " = " + (GetSetNum2 * i);
            }//Fim do For
            return resultado;
        }//Fim do método Tabuada2

        public string Bhaskara()
        {

            
            string msg = "X1 de delta:" + (-GetSetNum2 + (Math.Sqrt(Math.Pow(GetSetNum2, 2) - (4 * GetSetNum1 * GetSetNum3)))) / (2 * GetSetNum1)
                      +"\nX2 de delta:" + (-GetSetNum2 - (Math.Sqrt(Math.Pow(GetSetNum2, 2) - (4 * GetSetNum1 * GetSetNum3)))) / (2 * GetSetNum1);

            return msg;
        }//fim do metodo Bhaskara

        public string ConverterParaDecimal()
        {
            int i = 0;
            string dec = "0";

            for( i = 0; i < GetSetBinario.Length; i++)
            { 
                if (GetSetBinario.Substring(i, 1) == "1")
            {
                dec += Math.Pow(Convert.ToDouble(GetSetBinario), i); 
            }//Fim do if
            }//Fim do for

            return dec;
        }//Fim ConverterParaDecimal










    }//Fim da classe
}//Fim do projeto
