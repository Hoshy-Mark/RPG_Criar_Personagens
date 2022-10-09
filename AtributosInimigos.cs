namespace RPG.Banco_de_Dados
{
    internal class AtributosInimigos
    {
        public int forca;
        public string classe;
        public int Idclasse;
        public bool vida = true;
        public int constituicao;
        public int vida_max;
        public int vida_atual;
        public int dano;
        public int velocidade;
        public int destreza;
        public float tempo;
        public float esquiva;
        public int[,] Atributos = new int[5, 4];
        public String[] Classe = new String[5] {"Arqueiro","Barbaro","Guerreiro","Assassino","Necromante"};

        public void criar(int id){

            Atributos[0, 0] = 4;
            Atributos[0, 1] = 5;
            Atributos[0, 2] = 3;
            Atributos[0, 3] = 3;
            Atributos[1, 0] = 7;
            Atributos[1, 1] = 4;
            Atributos[1, 2] = 2;
            Atributos[1, 3] = 2;
            Atributos[2, 0] = 5;
            Atributos[2, 1] = 5;
            Atributos[2, 2] = 3;
            Atributos[2, 3] = 2;
            Atributos[3, 0] = 3;
            Atributos[3, 1] = 3;
            Atributos[3, 2] = 4;
            Atributos[3, 3] = 5;
            Atributos[4, 0] = 4;
            Atributos[4, 1] = 8;
            Atributos[4, 2] = 2;
            Atributos[4, 3] = 1;

            classe = Classe[id];
            forca = Atributos[id, 0];
            constituicao = Atributos[id, 1];
            velocidade = Atributos[id, 2];
            destreza = Atributos[id, 3];
            vida_max = constituicao * 5;
            vida_atual = vida_max;
            dano = forca * 3;
            tempo = (float)(velocidade * 0.05);
            esquiva = (float)(destreza * 0.5);


        }

    }
}
