using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgendaSalas
{
    internal static class ObjGenerator
    {
        //----------------------------------------------------------------
        // Criação de um Cliente.
        //----------------------------------------------------------------
        public static Cliente CriarCliente()
        {
            Cliente cliente01 = new Cliente("Cliente Modelo", "email@email.com", "(xx)99999-9999", "000.000.000-00", "0.000.000-0");
            return cliente01;
        }
        //----------------------------------------------------------------
        // Criação de um Endereço.
        //----------------------------------------------------------------
        public static Endereco CriarEndereco()
        {
            Endereco endereco01 = new Endereco("Rua Modelo", "Bairro Modelo", "123", "Esquina");
            return endereco01;
        }
        //----------------------------------------------------------------
        // Criação de uma Sala.
        //----------------------------------------------------------------
        public static Sala CriarSala()
        {
            Sala sala01 = new Sala(1, "Sala Comercial", 15, 15, 12, 2, true, true, true, true, CriarEndereco());
            return sala01;
        }
        //----------------------------------------------------------------
        // Criação de Períodos.
        //----------------------------------------------------------------
        public static List<Periodo> CriarPeriodos()
        {
            List<Periodo> periodos = new List<Periodo>();
            Periodo periodo01 = new Periodo(100, true, DiaSemana.Segunda_Feira, new Horario(DateTime.Parse("07:00"), DateTime.Parse("18:00")));
            periodos.Add(periodo01);
            Periodo periodo02 = new Periodo(100, true, DiaSemana.Terca_Feira, new Horario(DateTime.Parse("07:00"), DateTime.Parse("18:00")));
            periodos.Add(periodo02);
            Periodo periodo03 = new Periodo(100, true, DiaSemana.Quarta_Feira, new Horario(DateTime.Parse("07:00"), DateTime.Parse("18:00")));
            periodos.Add(periodo03);
            Periodo periodo04 = new Periodo(100, true, DiaSemana.Quinta_Feira, new Horario(DateTime.Parse("07:00"), DateTime.Parse("18:00")));
            periodos.Add(periodo04);
            Periodo periodo05 = new Periodo(100, true, DiaSemana.Sexta_Feira, new Horario(DateTime.Parse("07:00"), DateTime.Parse("18:00")));
            periodos.Add(periodo05);
            Periodo periodo06 = new Periodo(100, true, DiaSemana.Sabado, new Horario(DateTime.Parse("07:00"), DateTime.Parse("12:00")));
            periodos.Add(periodo06);
            Periodo periodo07 = new Periodo(100, true, DiaSemana.Domingo, new Horario(DateTime.Parse("07:00"), DateTime.Parse("12:00")));
            periodos.Add(periodo07);

            return periodos;
        }
        //----------------------------------------------------------------
        // Criação da disponibilidade.
        //----------------------------------------------------------------
        public static DisponilidadeSala CriarDisponilidadeSala()
        {
            DisponilidadeSala disponilidadeSala01 = new DisponilidadeSala(CriarSala(), CriarPeriodos());
            return disponilidadeSala01;
        }
    }
}
