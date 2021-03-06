using Builder.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Builder
{
    public class IphoneBuilder : ICelular
    {
        Celular celular;

        public IphoneBuilder()
        {
            celular = new Celular("Iphone");
        }

        public void BuildBateria()
        {
            celular.Bateria = "BiOS_1000";
        }

        public void BuildCamera()
        {
            celular.Camera = "16 mp";
        }

        public void BuildSistema()
        {
            celular.SistemaOperacional = "iOS 11";
        }

        public void BuildTela()
        {
            celular.Tela = "9";
        }

        public Celular Celular
        {
            get { return celular; }
        }
    }
}
