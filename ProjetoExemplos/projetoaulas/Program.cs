using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aula1
{
    class Program
    {
        static void Main(string[] args)
        {
            var func1 = new Funcionario();
            func1.Id = 1;
            func1.Nome = "Funcionario 1";
            func1.Email = "funcionario1@teste.com.br";
            func1.Codigo = "FUNC0001";
            func1.ValorHora = (decimal)25.00;
            func1.QtdTrabalhada = 10;

            func1.MostrarDados();

            Console.WriteLine();

            var func2 = new Funcionario();
            func2.Id = 2;
            func2.Nome = "Funcionario 2";
            func2.Email = "funcionario2@teste.com.br";
            func2.Codigo = "FUNC0002";
            func2.ValorHora = (decimal)32.50;
            func2.QtdTrabalhada = 15;

            func2.MostrarDados();

            Console.ReadLine();
        }

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

        private static void Array()
        {
            Console.Write("Entre com os números do array separados por espaco: ");
            var numeros = Console.ReadLine();
            var array = numeros.Split(' ');

            for (var i = 0; i < array.Length - 1; i++)
            {
                Console.WriteLine(int.Parse(array[i]) * 10);
            }

            Console.ReadLine();
        }

        private static void MaiorMenos()
        {

            Console.Write("Digite quatro algarismos separados por espaço: ");
            var numeros1 = Console.ReadLine().Split(' ');

            var teste = "H e l l o w o r l d ";
            var teste1 = teste.Split(' ');

            Console.Write("Digite dois algarismos separados por espaço: ");
            var numeros2 = Console.ReadLine().Split(' ');

            var maiorQuePrimeiroConjunto = (int.Parse(numeros1[0]) + int.Parse(numeros1[1])) > int.Parse(numeros2[0]);

            Console.WriteLine("A soma dos dois primeiros números da primeira sequencia " + (maiorQuePrimeiroConjunto ? "" : "não ") + "é maior que o primeiro numero da segunda");

            var maiorQueSegundoConjunto = (int.Parse(numeros1[2]) + int.Parse(numeros1[3])) > int.Parse(numeros2[1]);

            Console.WriteLine("----------------------------------------------");

            Console.WriteLine("A soma dos dois últimos números da primeira sequencia " + (maiorQueSegundoConjunto ? new { } : new { }) + "é maior que o segundo numero da segunda");

            Console.ReadLine();


            var arr1 = new int[100000000000000000];
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
        }
    }
}
