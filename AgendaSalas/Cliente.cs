,using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgendaSalas
{
    class Cliente
    {
        string _nome;
        string _email;
        string _celular;
        string _cpf;
        string _rg;

        public Cliente(string nome, string email, string celular, string cpf, string rg)
        {
            Nome = nome;
            Email = email;
            Celular = celular;
            Cpf = cpf;
            Rg = rg;
        }

        public string Nome { get => _nome; set => _nome = value; }
        public string Email { get => _email; set => _email = value; }
        public string Celular { get => _celular; set => _celular = value; }
        public string Cpf { get => _cpf; set => _cpf = value; }
        public string Rg { get => _rg; set => _rg = value; }



    }
}
