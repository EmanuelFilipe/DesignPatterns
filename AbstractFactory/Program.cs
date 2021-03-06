using AbstractFactory.Factory;
using AbstractFactory.Models;
using System;

namespace AbstractFactory
{
    class Program
    {
        /// <summary>
        /// Fornece uma interface para criar famílias de objetos relacionados ou dependentes sem especificar suas classes concretas
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Carro c1 = ExecutaAbstractFactory.MontarCarro("luxo");
            Carro c2 = ExecutaAbstractFactory.MontarCarro("popular");

            Console.ReadLine();
        }
    }
}
