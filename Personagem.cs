namespace Primeiro_POO
{
    public class Personagem
    {
        
        public string nome;
        public int idade;
        public string armadura;


        public float Atacar(float forca , float potencia)
        {
            return forca *  potencia;
        }

        public string Defender()
        {
            return "O personagem atacou! com o dano de:";
        }

    }
}