using AbstractFactory.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory.Factory
{
    public class ExecutaAbstractFactory
    {
        public static Carro MontarCarro(String tipo)
        {
            CarroFactory carroFactory = null;

            switch (tipo)
            {
                case "luxo":
                    carroFactory = new CarroLuxoFactory();
                    break;
                case "popular":
                    carroFactory = new CarroPopularFactory();
                    break;
            }

            Carro carro = new Carro();
            carro.Roda = carroFactory.MontarRoda();
            carro.Som = carroFactory.MontarSom();

            return carro;
        }

    }
}
