using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgendaSalas
{
    class Sala
    {
        int _id;
        string _identificacao;
        string _descricao;
        int _estado;
        int _voltagem;
        int _medidaLado1EmMetros;
        int _medidalado2EmMetros;
        int _numeroMaximoDePessoas;
        int _janelas;
        Endereco _localizacao;
        bool _temBanheiro;
        bool _temEstacionamento;
        bool _temArCondicionado;
        bool _temSeguro;
        List<string> _fotos;

        public Sala(int id, string identificacao, string descricao, int estado, int voltagem, int medidaLado1EmMetros, int medidalado2EmMetros, int numeroMaximoDePessoas, int janelas, bool temBanheiro, bool temEstacionamento, bool temArCondicionado, bool temSeguro, List<string> fotos, Endereco localizacao)
        {
            Id = id;
            Identificacao = identificacao;
            Descricao = descricao;
            Estado = estado;
            Voltagem = voltagem;
            MedidaLado1EmMetros = medidaLado1EmMetros;
            Medidalado2EmMetros = medidalado2EmMetros;
            NumeroMaximoDePessoas = numeroMaximoDePessoas;
            Janelas = janelas;
            TemBanheiro = temBanheiro;
            TemEstacionamento = temEstacionamento;
            TemArCondicionado = temArCondicionado;
            TemSeguro = temSeguro;
            Fotos = fotos;
            Localizacao = localizacao;
        }

        public int Id { get => _id; set => _id = value; }
        public string Identificacao { get => _identificacao; set => _identificacao = value; }
        public string Descricao { get => _descricao; set => _descricao = value; }
        public int Estado { get => _estado; set => _estado = value; }
        public int Voltagem { get => _voltagem; set => _voltagem = value; }
        public int MedidaLado1EmMetros { get => _medidaLado1EmMetros; set => _medidaLado1EmMetros = value; }
        public int Medidalado2EmMetros { get => _medidalado2EmMetros; set => _medidalado2EmMetros = value; }
        public int NumeroMaximoDePessoas { get => _numeroMaximoDePessoas; set => _numeroMaximoDePessoas = value; }
        public int Janelas { get => _janelas; set => _janelas = value; }
        public bool TemBanheiro { get => _temBanheiro; set => _temBanheiro = value; }
        public bool TemEstacionamento { get => _temEstacionamento; set => _temEstacionamento = value; }
        public bool TemArCondicionado { get => _temArCondicionado; set => _temArCondicionado = value; }
        public bool TemSeguro { get => _temSeguro; set => _temSeguro = value; }
        public List<string> Fotos { get => _fotos; set => _fotos = value; }
        internal Endereco Localizacao { get => _localizacao; set => _localizacao = value; }

       
    }
}
