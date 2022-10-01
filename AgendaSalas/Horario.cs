using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgendaSalas
{
    class Horario
    {
        DateTime _inicio;
        DateTime _fim;

        public Horario(DateTime inicio, DateTime fim)
        {
            Inicio = inicio;
            Fim = fim;
        }

        public DateTime Inicio { get => _inicio; set => _inicio = value; }
        public DateTime Fim { get => _fim; set => _fim = value; }
    }
}
