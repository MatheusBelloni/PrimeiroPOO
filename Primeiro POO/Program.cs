using System;

namespace Primeiro_POO
{
    class Program
    {
        static void Main(string[] args)
        {
            
            personagem Ichigo = new personagem();
            Ichigo.espada = "zangetsu";

            Console.WriteLine(Ichigo.nome);

            Console.WriteLine(Ichigo.espada);

            Console.WriteLine(Ichigo.reiryoku);

            Console.WriteLine(Ichigo.reiatsu);

            Console.WriteLine(Ichigo.Atacar());
        }
    }
}
