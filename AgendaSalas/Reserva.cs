using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgendaSalas
{
    class Reserva
    {
        List<DisponilidadeSala> _salasAlugadas;
        List<Equipamento> _equipamentos;
        List<Servico> _servicos;
        List<Objetos> _objetos;
        Sala _sala;

        public Reserva(List<DisponilidadeSala> salasAlugadas, List<Equipamento> equipamentos, List<Servico> servicos, List<Objetos> objetos, Sala sala)
        {
            SalasAlugadas = salasAlugadas;
            Equipamentos = equipamentos;
            Servicos = servicos;
            Objetos = objetos;
            Sala = sala;
        }

        internal List<DisponilidadeSala> SalasAlugadas { get => _salasAlugadas; set => _salasAlugadas = value; }
        internal List<Equipamento> Equipamentos { get => _equipamentos; set => _equipamentos = value; }
        internal List<Servico> Servicos { get => _servicos; set => _servicos = value; }
        internal List<Objetos> Objetos { get => _objetos; set => _objetos = value; }
        internal Sala Sala { get => _sala; set => _sala = value; }

        public bool FazerContratacao()
        {
            return true;
        }


    }
}
