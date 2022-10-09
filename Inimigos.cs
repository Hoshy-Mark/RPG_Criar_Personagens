using RPG.Banco_de_Dados;

namespace RPG.Personagens
{
    internal class Inimigos : AtributosInimigos
    {
        public string nome;
        public int nivel;

        public void bater(Protagonista x)
        {
            int vidaAtual = x.vida_atual;
            int diminuir = vidaAtual - dano;
            x.vida_atual -= diminuir;
        }
        public void verificarVida(Protagonista x)
        {
            if (vida_atual <= 0)
            {
                vida = false;
                x.xp_atual += nivel * 10;
            }
        }

        public Inimigos()
        {

            nome = "Inimigo";

            Random rnd = new Random();

            int Idclasse = rnd.Next(1, 3);

            criar(Idclasse);
            nivelar();
 
        }

        public void status()
        {
            Console.WriteLine("┌────────────────┐");
            Console.WriteLine(" " + nome + "  | " + classe);
            Console.WriteLine(" Nível " + nivel);
            Console.WriteLine(" Vida " + vida_atual + "/" + vida_max);
            Console.WriteLine("└────────────────┘");
        }

        private void nivelar()
        {
            Random rnd = new Random();

            nivel = rnd.Next(1, 7);

            forca += nivel;
            constituicao += nivel;
            vida_max = constituicao * 5;
            vida_atual = vida_max;
            dano = forca * 3;
            tempo = (float)(velocidade * 0.05);
            esquiva = (float)(destreza * 0.5);
        }
    }
}
