using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgendaSalas
{
    class DisponilidadeSala
    {
        Sala _sala;
        List<Periodo> _periodos;

        public DisponilidadeSala(Sala sala, List<Periodo> periodos)
        {
            Sala = sala;
            Periodos = periodos;
        }

        internal Sala Sala { get => _sala; set => _sala = value; }
        internal List<Periodo> Periodos { get => _periodos; set => _periodos = value; }
    }


}
