using System;
using RPG.Personagens;

namespace RPG.Sistemas
{
    internal class Ataques
    {

        public void shootingStar(Inimigos x, Protagonista y)
        {
            if (y.mana_atual - 20 > 0)
            {
                Console.WriteLine(y.nome + " lançou uma Shooting Star em " + x.nome + " causando " + (y.dano + y.dano * 2) + " de Dano");
                x.vida_atual = x.vida_atual - (y.dano + y.dano * 2);
                y.mana_atual -= 20;
                if (x.vida_atual < 0)
                {
                    x.vida_atual = 0;
                }
            }
        }
        public void corteDoVento(Inimigos x, Protagonista y)
        {
            if (y.estamina_atual - 10 >= 0 && x.vida)
            {
                float chances = x.esquiva * 10;
                Random rnd = new Random();

                if (rnd.Next(1, 101) <= chances)
                {
                    Console.WriteLine(y.nome + " desferiu um Corte do Vento em " + x.nome + ", mas ele desviou ");
                    y.estamina_atual -= 10;
                }
                else
                {
                    Console.WriteLine(y.nome + " desferiu um Corte do Vento em " + x.nome + ", causando " + (y.dano + y.dano * 2) + " de Dano");

                    x.vida_atual = x.vida_atual - (int)(y.dano + y.dano * 1.3);

                    y.estamina_atual -= 10;

                    if (x.vida_atual <= 0)
                    {
                        x.vida_atual = 0;
                        x.verificarVida(y);
                    }
                }
            }
            else
            {
                if (y.estamina_atual - 10 <= 0)
                {
                    Console.WriteLine("Seu ataque falhou, estamina insuficiente");
                }
                else if (x.vida == false)
                {
                    Console.WriteLine("O inimigo já foi derrotado.");
                }
            }

        }
        public void corteDoVento(Chefes x, Protagonista y)
        {
            if (y.estamina_atual - 10 >= 0 && x.vida)
            {
                float chances = x.esquiva * 10;
                Random rnd = new Random();

                if (rnd.Next(1, 101) <= chances)
                {
                    Console.WriteLine(y.nome + " desferiu um Corte do Vento em " + x.nome + ", mas ele desviou ");
                    y.estamina_atual -= 10;
                }
                else
                {
                    Console.WriteLine(y.nome + " desferiu um Corte do Vento em " + x.nome + ", causando " + (y.dano + y.dano * 2) + " de Dano");

                    x.vida_atual = x.vida_atual - (int)(y.dano + y.dano * 1.3);

                    y.estamina_atual -= 10;

                    if (x.vida_atual <= 0)
                    {
                        x.vida_atual = 0;
                        x.verificarVida(y);
                    }
                }
            }
            else
            {
                if (y.estamina_atual - 10 <= 0)
                {
                    Console.WriteLine("Seu ataque falhou, estamina insuficiente");
                }
                else if (x.vida == false)
                {
                    Console.WriteLine("O inimigo já foi derrotado.");
                }
            }

        }
        public void corteDoVento(Protagonista x, Chefes y)
        {
            if (y.estamina_atual - 10 >= 0 && x.vivo)
            {
                float chances = x.esquiva * 10;
                Random rnd = new Random();

                if (rnd.Next(1, 101) <= chances)
                {
                    Console.WriteLine(y.nome + " desferiu um Corte do Vento em " + x.nome + ", mas ele desviou ");
                    y.estamina_atual -= 10;
                }
                else
                {
                    Console.WriteLine(y.nome + " desferiu um Corte do Vento em " + x.nome + ", causando " + (y.dano + y.dano * 2) + " de Dano");

                    x.vida_atual = x.vida_atual - (int)(y.dano + y.dano * 1.3);

                    y.estamina_atual -= 10;

                    if (x.vida_atual <= 0)
                    {
                        x.vida_atual = 0;
                        x.verificarVida();
                    }
                }
            }
            else
            {
                if (y.estamina_atual - 10 <= 0)
                {
                    Console.WriteLine("Seu ataque falhou, estamina insuficiente");
                }
                else if (x.vivo == false)
                {
                    Console.WriteLine("O inimigo já foi derrotado.");
                }
            }

        }

    }
}
