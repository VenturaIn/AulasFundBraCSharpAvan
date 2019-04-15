using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aulas
{
    public class Funcionario : Pessoa
    {
        private string _codigo;
        private int _qtdTrabalhada;
        private decimal _valorHora;


        public string Codigo
        {
            get { return _codigo; }
            set { _codigo = value; }
        }

        public int QtdTrabalhada
        {
            get { return _qtdTrabalhada; }
            set
            {
                if (value >= 0)
                    _qtdTrabalhada = value;
                else
                    _qtdTrabalhada = 0;
            }
        }
        public decimal ValorHora
        {
            get { return _valorHora; }
            set
            {
                if (value > 0)
                    _valorHora = value;
                else
                    _valorHora = 1;
            }
        }

        public void MostrarDados()
        {
            Console.WriteLine("Id: " + this.Id.ToString());
            Console.WriteLine("Nome: " + this.Nome);
            Console.WriteLine("Email: " + this.Email);
            Console.WriteLine("Codigo: " + this.Codigo);
            Console.WriteLine("Salario: " + this.CalcularSalario().ToString("N2"));
        }

        public decimal CalcularSalario()
        {
            return this._qtdTrabalhada * this.ValorHora;
        }
    }
}
