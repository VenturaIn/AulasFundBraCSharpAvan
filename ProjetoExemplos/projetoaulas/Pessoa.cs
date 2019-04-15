using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula1
{
    public class Pessoa
    {
        private int _id;
        private string _nome;
        private string _email;

        public int Id
        {
            get { return _id; }
            set
            {
                if (value > 0)
                    _id = value;
                else
                    _id = 1;
            }
        }

        public string Nome
        {
            get { return _nome; }
            set { _nome = value; }
        }

        public string Email
        {
            get { return _email; }
            set { _email = value; }
        }
    }
}
