using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgendaSalas
{
    class Endereco
    {
        string _logradouro;
        string _bairro;
        string _numero;
        string _complemento;

        public Endereco(string logradouro, string bairro, string numero, string complemento)
        {
            Logradouro = logradouro;
            Bairro = bairro;
            Numero = numero;
            Complemento = complemento;
        }

        public string Logradouro { get => _logradouro; set => _logradouro = value; }
        public string Bairro { get => _bairro; set => _bairro = value; }
        public string Numero { get => _numero; set => _numero = value; }
        public string Complemento { get => _complemento; set => _complemento = value; }

        public override string ToString()
        {
            return "Logradouro: " + Logradouro + " \nBairro: " + Bairro + " \nNumero: " + Numero + " \nComplemento: " + Complemento;
        }
    }
}
