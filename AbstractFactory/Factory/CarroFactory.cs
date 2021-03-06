using AbstractFactory.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory.Factory
{
    public abstract class CarroFactory
    {
        public abstract Roda MontarRoda();
        public abstract Som MontarSom();
    }
}
