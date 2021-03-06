using System;

namespace Singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            Singleton p1 = Singleton.GetInstancia;
            p1.Mensagem("p1: a bola esta comigo no meio do campo");

            Singleton p2 = Singleton.GetInstancia;
            p1.Mensagem("p2: recebe a bola ");

            Singleton p3 = Singleton.GetInstancia;
            p3.Mensagem("p3: recebeu o lançamento na linha de fundo");


        }
    }
}
