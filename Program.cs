using System;

namespace Primeiro_POO
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Personagem riri = new Personagem();
            riri.nome = "Riri Willians";
            riri.armadura = "Iron Heart";

            Console.WriteLine(riri.nome);
            Console.WriteLine(riri.Defender ());

            Console.WriteLine(riri.Atacar(34.5f , 20f ));



        }
    }
}
