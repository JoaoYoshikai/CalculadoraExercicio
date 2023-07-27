using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora
{
     class ControlCalculadora
    {
        //Criando um objeto calculadora na memória
        ModelCalculadora calculadora;

        public ControlCalculadora() 
        {
            this.calculadora = new ModelCalculadora();
        }//Fim do construtor

        public void ColetarBinario()
        {
            Console.WriteLine("Informe o número binário:");
            this.calculadora.GetSetBinario = Convert.ToString(Console.ReadLine());
        }//Fim do coletar binário
        

        public void Coletar()
        {
            Console.WriteLine("Informe um número!");
            this.calculadora.GetSetNum1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Informe outro número!");
            this.calculadora.GetSetNum2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Informe mais um número!");
            this.calculadora.GetSetNum3 = Convert.ToDouble(Console.ReadLine());


        }//Fim do coletar

        public int menu()
        {
            Console.WriteLine("-----MENU-----"   +
                              "\n0. Sair" +  
                              "\n1. Somar"       +
                              "\n2. Subtrair"    +
                              "\n3. Dividir"     +
                              "\n4. Multiplicar" +
                              "\n5. Potência "   +
                              "\n6. Raiz Quadrada " +  
                              "\n7. Tabuada" +
                              "\n8. Bhaskara" +
                              "\n9. Binário - Decimal" +
                              "\n\nEscolha uma das opções acima : ");
            int opcao = Convert.ToInt32(Console.ReadLine());
            return opcao;
        }//Fim do método menu

        public void Operacao()
        {
            int opcao = 0;
            do
            {
                opcao = menu();
                Console.Clear();//Limpa tela
                switch (opcao)
                {
                    case 0:
                        Console.WriteLine("Obrigado!");
                        break;

                    case 1:
                        Coletar();
                        Console.WriteLine("A soma: " + this.calculadora.Somar());
                        break;
                    case 2:
                        Coletar();
                        Console.WriteLine("A subtração: " + this.calculadora.Somar());
                        break;
                    case 3:
                        Coletar();
                        if (this.calculadora.Dividir() == -1)
                        {
                            Console.WriteLine("Impossível dividir por zero");
                        }

                        else
                        {
                            Console.WriteLine("Divisão:" + this.calculadora.Dividir());
                        }//Fim do if
                        break;
                    case 4:
                        Coletar();
                        Console.WriteLine("Multiplicar:" + this.calculadora.Multiplicar());
                        break;
                    case 5:
                        Coletar();
                        Console.WriteLine("Potência:" + this.calculadora.Multiplicar());
                        break;
                    case 6:
                        Coletar();
                        Console.WriteLine("Raiz:" + this.calculadora.Multiplicar());
                        break;
                    case 7:
                        Console.WriteLine("Informe um número: ");
                        this.calculadora.GetSetNum1 = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine(this.calculadora.TabuadaNum1());
                        break;

                    case 8:
                        Coletar();
                        Console.WriteLine(this.calculadora.Bhaskara());
                        break;
                    case 9:
                        ColetarBinario();
                        Console.WriteLine(this.calculadora.ConverterParaDecimal());
                        break;
                    default:
                        Console.WriteLine("Opção escolhida nao é válida");
                        break;
                
                
                }//Fim do switch
            } while (opcao != 0); //Fim do Do While 
        }//Fim metodo operacao





    }//Fim da classe
}//Fim do projeto
