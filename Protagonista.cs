using System;
using RPG.Banco_de_Dados;
using RPG.Sistemas;

namespace RPG.Personagens
{
    class Protagonista : Atirbutos
    {
        public string nome { get; set; }
        public string classse { get; set; }
        public string raca { get; set; }
        public bool vivo = true;
        public Ataques ataques = new Ataques();
        public int nivel = 1;
        public int xp_meta = 200;
        public int xp_atual = 0;
        public int atributos = 0;



        public Protagonista()
        {

            Console.WriteLine("Digite o seu Nome: ");

            nome = Console.ReadLine();

            Console.WriteLine("Escolha sua Raça: ");
            Console.WriteLine("0 - Humano");
            Console.WriteLine("1 - Elfo ");
            Console.WriteLine("2 - Orc ");
            Console.WriteLine("3 - Vampiro ");
            Console.WriteLine("4 - Draconiano");

            int escolha = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Escolha sua Classe: ");
            Console.WriteLine("0 - Espadachim");
            Console.WriteLine("1 - Mago ");
            Console.WriteLine("2 - Ladrão ");
            Console.WriteLine("3 - Barbaro ");
            Console.WriteLine("4 - Arqueiro");

            int escolha2 = Convert.ToInt32(Console.ReadLine());
    
            criar(escolha,escolha2);

        }


        public void verificarVida()
        {
            if (vida_atual < 0)
            {
                vivo = false;
            }
        }
        public void verificarVidaInimigo(Inimigos x)
        {
            if (x.vida_atual < 0)
            {
                x.vida = false;
                xp_atual += x.nivel * 10;
            }
        }
        public void verificarNivel()
        {
            if (xp_atual >= xp_meta)
            {
                nivel += 1;
                xp_atual = xp_atual - xp_meta;
                atributos = 5;
                xp_meta += 100;
            }
        }

        public void distribuicao()
        {
            while (atributos > 0)
            {

                Console.WriteLine("O que deseja Upar: ");
                Console.WriteLine("1 - Força");
                Console.WriteLine("2 - Velocidade ");
                Console.WriteLine("3 - Vigor ");
                Console.WriteLine("4 - Constituição ");
                Console.WriteLine("5 - Destreza");
                Console.WriteLine("6 - Carisma ");
                Console.WriteLine("7 - Inteligência ");
                Console.WriteLine("8 - Conhecimento");

                int escolha = Convert.ToInt32(Console.ReadLine());

                if (escolha == 1)
                {
                    Console.WriteLine("Quanto deseja aumentar: ");
                    int escolha2 = Convert.ToInt32(Console.ReadLine());
                    if (escolha2 <= atributos && escolha2 > 0)
                    {
                        forca += escolha2;
                        atributos -= escolha2;
                        atualizarStatus();
                        Console.WriteLine("Sua força agora é: " + forca);
                    }
                    else
                    {
                        Console.WriteLine("Valor inválido");
                    }
                }
                if (escolha == 2)
                {
                    Console.WriteLine("Quanto deseja aumentar: ");
                    int escolha2 = Convert.ToInt32(Console.ReadLine());
                    if (escolha2 <= atributos && escolha2 > 0)
                    {
                        velocidade += escolha2;
                        atributos -= escolha2;
                        atualizarStatus();
                    }
                    else
                    {
                        Console.WriteLine("Valor inválido");
                    }
                }
                if (escolha == 3)
                {
                    Console.WriteLine("Quanto deseja aumentar: ");
                    int escolha2 = Convert.ToInt32(Console.ReadLine());
                    if (escolha2 <= atributos && escolha2 > 0)
                    {
                        vigor += escolha2;
                        atributos -= escolha2;
                        atualizarStatus();
                    }
                    else
                    {
                        Console.WriteLine("Valor inválido");
                    }
                }
                if (escolha == 4)
                {
                    Console.WriteLine("Quanto deseja aumentar: ");
                    int escolha2 = Convert.ToInt32(Console.ReadLine());
                    if (escolha2 <= atributos && escolha2 > 0)
                    {
                        constituicao += escolha2;
                        atributos -= escolha2;
                        atualizarStatus();
                    }
                    else
                    {
                        Console.WriteLine("Valor inválido");
                    }
                }
                if (escolha == 5)
                {
                    Console.WriteLine("Quanto deseja aumentar: ");
                    int escolha2 = Convert.ToInt32(Console.ReadLine());
                    if (escolha2 <= atributos && escolha2 > 0)
                    {
                        destreza += escolha2;
                        atributos -= escolha2;
                        atualizarStatus();
                    }
                    else
                    {
                        Console.WriteLine("Valor inválido");
                    }
                }
                if (escolha == 6)
                {
                    Console.WriteLine("Quanto deseja aumentar: ");
                    int escolha2 = Convert.ToInt32(Console.ReadLine());
                    if (escolha2 <= atributos && escolha2 > 0)
                    {
                        carisma += escolha2;
                        atributos -= escolha2;
                        atualizarStatus();
                    }
                    else
                    {
                        Console.WriteLine("Valor inválido");
                    }
                }
                if (escolha == 7)
                {
                    Console.WriteLine("Quanto deseja aumentar: ");
                    int escolha2 = Convert.ToInt32(Console.ReadLine());
                    if (escolha2 <= atributos && escolha2 > 0)
                    {
                        inteligencia += escolha2;
                        atributos -= escolha2;
                        atualizarStatus();
                    }
                    else
                    {
                        Console.WriteLine("Valor inválido");
                    }
                }
                if (escolha == 8)
                {
                    Console.WriteLine("Quanto deseja aumentar: ");
                    int escolha2 = Convert.ToInt32(Console.ReadLine());
                    if (escolha2 <= atributos && escolha2 > 0)
                    {
                        conhecimento += escolha2;
                        atributos -= escolha2;
                        atualizarStatus();
                    }
                    else
                    {
                        Console.WriteLine("Valor inválido");
                    }
                }
            }
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

        public void status()
        {
            Console.WriteLine("┌────────────────────────────┐");
            Console.WriteLine(nome + " | Nível " + nivel);
            Console.WriteLine(" Xp " + xp_atual + "/" + xp_meta);
            Console.WriteLine(" Vida " + vida_atual + "/" + vida_max);
            Console.WriteLine(" Estamina " + estamina_atual + "/" + estamina_max);
            Console.WriteLine(" Mana " + mana_atual + "/" + mana_max);
            Console.WriteLine("└────────────────────────────┘");
        }

        public void atualizarStatus()
        {

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

    }
}

