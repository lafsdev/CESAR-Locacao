using System;
using System.Collections.Generic;

namespace AgendaSalas
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("------------- Criação de Clientes -------------");
            Console.WriteLine(ObjGenerator.CriarCliente().ToString());
            Console.WriteLine("------------- Criação de Endereço -------------");
            Console.WriteLine(ObjGenerator.CriarEndereco().ToString());
            Console.WriteLine("------------- Criação de Sala -------------");
            Console.WriteLine(ObjGenerator.CriarSala().ToString());
            Console.WriteLine("------------- Criação de Períodos -------------");
            List<Periodo> list = ObjGenerator.CriarPeriodos();
            foreach (var item in list)
            {
                Console.WriteLine(item.ToString());
            };
            Console.WriteLine("-------------");           
            
        }
    }
}
