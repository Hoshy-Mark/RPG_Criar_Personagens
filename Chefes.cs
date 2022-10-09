using RPG.Banco_de_Dados;
using RPG.Sistemas;

namespace RPG.Personagens
{
    internal class Chefes : Atirbutos
    {
        public string nome { get; set; }
        public string classse { get; set; }
        public string raca { get; set; }
        public bool vida = true;
        public Ataques ataques = new Ataques();
        public int nivel;


        public void verificarVida(Protagonista x)
        {
            if (vida_atual <= 0)
            {
                vida = false;
                x.xp_atual += nivel * 10;
            }
        }


        public Chefes()
        {
            Console.WriteLine("Digite o seu Nome: ");

            nome = "Chefes";

            Random rdn = new Random();

            int escolha = rdn.Next(1, 6);

            int escolha2 = rdn.Next(1, 6);

            criar(escolha,escolha2);
            nivelar();

 
        }

        private void nivelar()
        {
            Random rnd = new Random();

            nivel = rnd.Next(5, 20);

            forca += nivel;
            velocidade += nivel;
            vigor += nivel;
            constituicao += nivel;
            destreza += nivel;
            carisma += nivel;
            inteligencia += nivel;
            conhecimento += nivel;
            vida_max = constituicao * 5;
            estamina_max = vigor * 5;
            mana_max = inteligencia * 5;
            vida_atual = vida_max;
            estamina_atual = estamina_max;
            mana_atual = mana_max;
            dano = forca * 3;
            tempo = (float)(velocidade * 0.05);
            esquiva = (float)(destreza * 0.5);
            labia = (float)(carisma * 0.7);
        }

        public void status()
        {
            Console.WriteLine("┌────────────────────────────┐");
            Console.WriteLine(nome + " | Nível " + nivel);
            Console.WriteLine(" Vida " + vida_atual + "/" + vida_max);
            Console.WriteLine(" Estamina " + estamina_atual + "/" + estamina_max);
            Console.WriteLine(" Mana " + mana_atual + "/" + mana_max);
            Console.WriteLine("└────────────────────────────┘");
        }

        public void mostrarAtributos()

        {
            Console.WriteLine("┌────────────────────┐");
            Console.WriteLine(" Atribtuos do " + nome);
            Console.WriteLine(" Força = " + forca);
            Console.WriteLine(" Velocidade = " + velocidade);
            Console.WriteLine(" Vigor = " + vigor);
            Console.WriteLine(" Constituição = " + constituicao);
            Console.WriteLine(" Destreza = " + destreza);
            Console.WriteLine(" Carisma = " + carisma);
            Console.WriteLine(" Inteligencia = " + inteligencia);
            Console.WriteLine(" Conhecimento = " + conhecimento);
            Console.WriteLine(" Dano = " + dano);
            Console.WriteLine("└────────────────────┘");
        }

    }
}
