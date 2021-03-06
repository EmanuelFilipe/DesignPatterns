using System;

namespace Singleton
{
    public sealed class Singleton
    {
        private static Singleton _instancia = null;

        public static Singleton GetInstancia
        {
            get
            {
                if (_instancia == null)
                {
                    _instancia = new Singleton();
                    Console.WriteLine("bola em jogo");
                }
                return _instancia;
            }
        }

        public void Mensagem(string msg)
        {
            Console.WriteLine(msg);
        }
    }
}
