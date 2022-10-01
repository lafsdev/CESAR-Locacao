using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgendaSalas
{
    enum DiaSemana
    {
        Domingo = 1,
        Segunda_Feira=2,
        Terca_Feira = 3,
        Quarta_Feira = 4,
        Quinta_Feira = 5,
        Sexta_Feira = 6,
        Sabado =7
    }
    class Periodo
    {
        DiaSemana diaSemana;
        Horario _horarios;
        float _preco;
        bool _estaAtiva;

        public Periodo()
        {

        }
        public Periodo(float preco, bool estaAtiva, DiaSemana diaSemana, Horario horarios)
        {
            Preco = preco;
            EstaAtiva = estaAtiva;
            DiaSemana = diaSemana;
            Horarios = horarios;
        }

        public float Preco { get => _preco; set => _preco = value; }
        public bool EstaAtiva { get => _estaAtiva; set => _estaAtiva = value; }
        internal DiaSemana DiaSemana { get => diaSemana; set => diaSemana = value; }
        internal Horario Horarios { get => _horarios; set => _horarios = value; }

        public override string ToString()
        {
            return "Preço: " + Preco + " \nAtiva: " + EstaAtiva + " \nDia da Semana: " + DiaSemana.ToString() + " \nHorario Inicio: " + Horarios.Inicio.ToString("HH:mm") + " \nHorario Fim: " + Horarios.Fim.ToString("HH:mm");

        }
    }
}
