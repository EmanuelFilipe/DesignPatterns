using Builder.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Builder
{
    public class AndroidBuilder : ICelular
    {
        Celular celular;

        public AndroidBuilder()
        {
            celular = new Celular("Android");
        }

        public void BuildBateria()
        {
            celular.Bateria = "MAH_1500";
        }

        public void BuildCamera()
        {
            celular.Camera = "15 mp";
        }

        public void BuildSistema()
        {
            celular.SistemaOperacional = "Android 4.5";
        }

        public void BuildTela()
        {
            celular.Tela = "7";
        }

        public Celular Celular
        {
            get { return celular; }
        }
    }
}
