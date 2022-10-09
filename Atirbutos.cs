namespace RPG.Banco_de_Dados
{
    class Atirbutos
    {
        public String Classe;
        public String Raca;
        public int forca;
        public int velocidade;
        public int vigor;
        public int constituicao;
        public int destreza;
        public int carisma;
        public int inteligencia;
        public int conhecimento;
        public int vida_max;
        public int estamina_max;
        public int mana_max;
        public int vida_atual;
        public int estamina_atual;
        public int mana_atual;
        public int dano;
        public float tempo;
        public float esquiva;
        public float labia;
        public String[] Classes = new string[5] { "Espadachim", "Mago", "Ladrão", "Barbaro", "Arqueiro" };
        public String[] Racas = new string[5] { "Humano", "Elfo", "Orc", "Vampiro", "Draconinano" };
        public int[,] AtributosClasse = new int[5, 8];
        public int[,] AtributosRaca = new int[5, 8];



        public void criar(int idRaca, int idClasse)
        {
            AtributosClasse[0, 0] = 5;
            AtributosClasse[0, 1] = 0;
            AtributosClasse[0, 2] = 2;
            AtributosClasse[0, 3] = 0;
            AtributosClasse[0, 4] = 3;
            AtributosClasse[0, 5] = 0;
            AtributosClasse[0, 6] = 0;
            AtributosClasse[0, 7] = 0;
            AtributosClasse[1, 0] = 0;
            AtributosClasse[1, 1] = 0;
            AtributosClasse[1, 2] = 0;
            AtributosClasse[1, 3] = 0;
            AtributosClasse[1, 4] = 0;
            AtributosClasse[1, 5] = 1;
            AtributosClasse[1, 6] = 5;
            AtributosClasse[1, 7] = 4;
            AtributosClasse[2, 0] = 0;
            AtributosClasse[2, 1] = 4;
            AtributosClasse[2, 2] = 4;
            AtributosClasse[2, 3] = 2;
            AtributosClasse[2, 4] = 0;
            AtributosClasse[2, 5] = 0;
            AtributosClasse[2, 6] = 0;
            AtributosClasse[2, 7] = 0;
            AtributosClasse[3, 0] = 6;
            AtributosClasse[3, 1] = 0;
            AtributosClasse[3, 2] = 2;
            AtributosClasse[3, 3] = 3;
            AtributosClasse[3, 4] = 0;
            AtributosClasse[3, 5] = 0;
            AtributosClasse[3, 6] = 0;
            AtributosClasse[3, 7] = 0;
            AtributosClasse[4, 0] = 0;
            AtributosClasse[4, 1] = 3;
            AtributosClasse[4, 2] = 3;
            AtributosClasse[4, 3] = 0;
            AtributosClasse[4, 4] = 0;
            AtributosClasse[4, 5] = 4;
            AtributosClasse[4, 6] = 0;
            AtributosClasse[4, 7] = 0;

            AtributosRaca[0, 0] = 5;
            AtributosRaca[0, 1] = 3;
            AtributosRaca[0, 2] = 5;
            AtributosRaca[0, 3] = 4;
            AtributosRaca[0, 4] = 6;
            AtributosRaca[0, 5] = 5;
            AtributosRaca[0, 6] = 2;
            AtributosRaca[0, 7] = 1;
            AtributosRaca[1, 0] = 4;
            AtributosRaca[1, 1] = 5;
            AtributosRaca[1, 2] = 3;
            AtributosRaca[1, 3] = 3;
            AtributosRaca[1, 4] = 7;
            AtributosRaca[1, 5] = 2;
            AtributosRaca[1, 6] = 4;
            AtributosRaca[1, 7] = 2;
            AtributosRaca[2, 0] = 10;
            AtributosRaca[2, 1] = 3;
            AtributosRaca[2, 2] = 5;
            AtributosRaca[2, 3] = 6;
            AtributosRaca[2, 4] = 2;
            AtributosRaca[2, 5] = 2;
            AtributosRaca[2, 6] = 1;
            AtributosRaca[2, 7] = 1;
            AtributosRaca[3, 0] = 5;
            AtributosRaca[3, 1] = 5;
            AtributosRaca[3, 2] = 5;
            AtributosRaca[3, 3] = 3;
            AtributosRaca[3, 4] = 5;
            AtributosRaca[3, 5] = 1;
            AtributosRaca[3, 6] = 3;
            AtributosRaca[3, 7] = 3;
            AtributosRaca[4, 0] = 5;
            AtributosRaca[4, 1] = 2;
            AtributosRaca[4, 2] = 2;
            AtributosRaca[4, 3] = 9;
            AtributosRaca[4, 4] = 3;
            AtributosRaca[4, 5] = 3;
            AtributosRaca[4, 6] = 2;
            AtributosRaca[4, 7] = 4;

            Classe = Classes[idClasse];
            Raca = Racas[idRaca];
            forca = AtributosRaca[idRaca, 0] + AtributosClasse[idClasse,0];
            velocidade = AtributosRaca[idRaca, 1] + AtributosClasse[idClasse, 1];
            vigor = AtributosRaca[idRaca, 2] + AtributosClasse[idClasse, 2];
            constituicao = AtributosRaca[idRaca, 3] + AtributosClasse[idClasse, 3];
            destreza = AtributosRaca[idRaca, 4] + AtributosClasse[idClasse, 4];
            carisma = AtributosRaca[idRaca, 5] + AtributosClasse[idClasse, 5];
            inteligencia = AtributosRaca[idRaca, 6] + AtributosClasse[idClasse, 6];
            conhecimento = AtributosRaca[idRaca, 7] + AtributosClasse[idClasse, 7];

            estamina_max = vigor * 5;
            mana_max = inteligencia * 5;
            estamina_atual = estamina_max;
            mana_atual = mana_max;
            vida_max = constituicao * 5;
            vida_atual = vida_max;
            dano = forca * 3;
            tempo = (float)(velocidade * 0.05);
            esquiva = (float)(destreza * 0.5);
        }

    }
}
