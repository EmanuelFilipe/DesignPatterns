using System;
using System.Collections.Generic;
using System.Text;

namespace Builder
{
    public class Celular
    {
        public string Nome { get; set; }
        public string Tela { get; set; }
        public string Bateria { get; set; }
        public string SistemaOperacional { get; set; }
        public string Camera { get; set; }
        public Celular(string nome)
        {
            Nome = nome;
        }


    }
}
