namespace jokenpo.View
{
    public static class Menu
    {
        public static void Start()
        {
            string[] f = 
            {
                "- - - JOKENPO - - -\n",
                "1 - Começar",
                "2 - Instruções",
                "0 - Sair",
                "> "
            };
            Console.Clear();
            Console.Write(string.Join("\n",f));
        }
        public static void Instruções()
        {
            string[] f = 
            {
                "- - - Intruções - - -\n",
                "Voce pode escolher quais dos três objetos utilizar para ganhar o jogo,",
                "mas lembre-se da seguinte regra:",
                "Pedra      ganha de    Tesoura",
                "Tesoura    ganha de    Papel",
                "Papel      ganha de    Tesoura\n",
                "Se forem iguais é empate!"
            };
            Console.Clear();
            Console.Write(string.Join("\n",f));
            // Console.Write("\nPRESSIONE QUALQUER TECLA PARA VOLTAR");
            Util.Input.Wait();
        }
        public static void InGame(Model.Gamer Jogador)
        {
            string[] f =
            {
                $"{Jogador.Nome} escolhe:",
                "1 - Pedra",
                "2 - Papel",
                "3 - Tesoura",
                "> "
            };
            Console.Clear();
            Console.Write(string.Join("\n",f));
        }
        public static void Choises(Model.Gamer Player,Model.Gamer Machine)
        {
            Console.Clear();
            Console.WriteLine($"{Player.Nome} escolheu {Player.Play}");
            Console.WriteLine($"Mrs. Robot escolheu {Machine.Play}");
        }
        public static void GameOver()
        {
            string[] f =
            {
                "Deseja jogar de novo?",
                "1 - Sim",
                "2 - Não",
                "> "
            };
            Console.Clear();
            Console.Write(string.Join("\n",f));
        }
    }
}