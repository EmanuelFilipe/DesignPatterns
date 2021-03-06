using Builder.Interfaces;
using System;

namespace Builder
{
    class Program
    {
        static void Main(string[] args)
        {
            Fabricante f = new Fabricante();

            ICelular celularBuilder = null;

            celularBuilder = new AndroidBuilder();
            f.Construtor(celularBuilder);
            Console.WriteLine("um novo celular foi construido: " + celularBuilder.Celular.Nome);


            Console.ReadLine();
        }
    }
}
