using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aulas
{
    class Program
    {
        static void Main(string[] args)
        {
            //Para chamar o método Operacoes basta descomentar o código abaixo
            //Operacoes();

            //Para chamar o método Array basta descomentar o código abaixo
            //Array();

            //Para chamar o método MaiorMenor basta descomentar o código abaixo
            //MaiorMenor();

            //Para chamar a Calculadora basta descomentar o codigo abaixo
            //Application.Run(new Calculadora());

            //Exercício para implementacao dos conceitos de Orientação a Objeto
            //Instancio uma variavel do tipo Funcionario que herda da classe Pessoa
            var func1 = new Funcionario();
            //Propriedade de Pessoa
            func1.Id = 1;
            //Propriedade de Pessoa
            func1.Nome = "Funcionario 1";
            //Propriedade de Pessoa
            func1.Email = "funcionario1@teste.com.br";
            //Propriedade exclusiva de Funcionario
            func1.Codigo = "FUNC0001";
            //Propriedade exclusiva de Funcionario
            func1.ValorHora = (decimal)25.00;
            //Propriedade exclusiva de Funcionario
            func1.QtdTrabalhada = 10;

            //Metodo exclusivo de Funcionario
            func1.MostrarDados();

            Console.WriteLine();

            var func2 = new Funcionario();
            //Propriedade de Pessoa
            func2.Id = 2;
            //Propriedade de Pessoa
            func2.Nome = "Funcionario 2";
            //Propriedade de Pessoa
            func2.Email = "funcionario2@teste.com.br";
            //Propriedade exclusiva de Funcionario
            func2.Codigo = "FUNC0002";
            //Propriedade exclusiva de Funcionario
            func2.ValorHora = (decimal)32.50;
            //Propriedade exclusiva de Funcionario
            func2.QtdTrabalhada = 15;

            //Metodo exclusivo de Funcionario
            func2.MostrarDados();

            Console.ReadLine();
        }

        /// <summary>
        /// Metodo para entendimento das operacoes matematicas e relacionais
        /// </summary>
        private static void Operacoes()
        {
            Console.Write("Entre com o primeiro numero: ");
            var num1 = int.Parse(Console.ReadLine());

            Console.Write("Entre com o segundo numero: ");
            var num2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Soma: " + (num1 + num2).ToString());
            Console.WriteLine("Subtracao: " + (num1 - num2).ToString());
            Console.WriteLine("Multiplicacao: " + (num1 * num2).ToString());
            Console.WriteLine("Divisao: " + (num1 / num2).ToString());
            Console.WriteLine("Maior que: " + (num1 > num2).ToString());
            Console.WriteLine("Menor que: " + (num1 < num2).ToString());
            Console.WriteLine("Iguais: " + (num1 == num2).ToString());
            Console.WriteLine("Diferentes: " + (num1 != num2).ToString());

            Console.ReadLine();
        }

        /// <summary>
        /// Metodo para entendimento do preenchimento de arrays
        /// </summary>
        private static void Array()
        {
            //Outra forma de implementacao
            /*
            
            //Quantidade de posicoes do array.
            //Caso queira outra quantidade, mude o numero abaixo
            var quant = 5;

            var array = new int[quant];

            for (var i = 0; i < quant; i++)
            {
                Console.Write(String.Format("Entre com a posicao {0} do array: ", i));
                array[i] = int.Parse(Console.ReadLine());
            }
            
            for (var i = 0; i < array.Length - 1; i++)
            {
                Console.Write(String.Format("Posicao {0}: {1} * 10 = ", i, array[i]));
                Console.WriteLine(int.Parse(array[i]) * 10);
            }

            Console.ReadLine();

            */

            Console.Write("Entre com os números do array separados por espaco: ");
            var numeros = Console.ReadLine();
            var array = numeros.Split(' ');

            for (var i = 0; i < array.Length - 1; i++)
            {
                Console.WriteLine(int.Parse(array[i]) * 10);
            }

            Console.ReadLine();
        }

        /// <summary>
        /// Metodo para visualizacao da interacao de operadores e arrays
        /// </summary>
        private static void MaiorMenor()
        {
            // Implementaco 1
            Console.Write("Digite quatro algarismos separados por espaço: ");
            var numeros1 = Console.ReadLine().Split(' ');

            Console.Write("Digite dois algarismos separados por espaço: ");
            var numeros2 = Console.ReadLine().Split(' ');

            var maiorQuePrimeiroConjunto = (int.Parse(numeros1[0]) + int.Parse(numeros1[1])) > int.Parse(numeros2[0]);

            Console.WriteLine("A soma dos dois primeiros números da primeira sequencia " + (maiorQuePrimeiroConjunto ? "" : "não ") + "é maior que o primeiro numero da segunda");

            var maiorQueSegundoConjunto = (int.Parse(numeros1[2]) + int.Parse(numeros1[3])) > int.Parse(numeros2[1]);

            Console.WriteLine("----------------------------------------------");

            Console.WriteLine("A soma dos dois últimos números da primeira sequencia " + (maiorQueSegundoConjunto ? new { } : new { }) + "é maior que o segundo numero da segunda");

            Console.ReadLine();

            // Implementaco 2
            var arr1 = new int[4];
            arr1[0] = int.Parse(Console.ReadLine());
            arr1[1] = int.Parse(Console.ReadLine());
            arr1[2] = int.Parse(Console.ReadLine());
            arr1[3] = int.Parse(Console.ReadLine());

            var arr2 = new int[2];
            arr2[0] = int.Parse(Console.ReadLine());
            arr2[1] = int.Parse(Console.ReadLine());

            var soma1 = arr1[0] + arr1[1];
            var soma2 = arr1[2] + arr1[3];

            var check1 = soma1 > arr2[0];
            var check2 = soma2 > arr2[1];

            if (check1)
                Console.Write("Maior");
            else
                Console.Write("Menor");

            if (check2)
                Console.Write("Maior");
            else
                Console.Write("Menor");

            //var teste = "H e l l o w o r l d ";
            //var teste1 = teste.Split(' ');
        }
    }
}
