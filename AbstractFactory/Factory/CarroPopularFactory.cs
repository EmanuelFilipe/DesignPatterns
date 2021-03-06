using AbstractFactory.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory.Factory
{
    public class CarroPopularFactory : CarroFactory
    {
        public override Roda MontarRoda()
        {
            return new RodaSimples();
        }

        public override Som MontarSom()
        {
            return new CDPlayer();
        }
    }
}
