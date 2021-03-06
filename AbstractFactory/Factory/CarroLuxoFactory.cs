using AbstractFactory.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory.Factory
{
    public class CarroLuxoFactory : CarroFactory
    {
        public override Roda MontarRoda()
        {
            return new RodaLigaLeve();
        }

        public override Som MontarSom()
        {
            return new BluetoohPlayer();
        }
    }
}
