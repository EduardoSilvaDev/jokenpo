using jokenpo.Model;
using jokenpo.Util;
using jokenpo.View;

namespace jokenpo.Controller
{
    public static class InGame
    {
        private static Gamer Jogador = new Gamer(){gamerType = GamerType.Player};
        private static Gamer Machine = new Gamer(){Nome = "Mrs. Robot",gamerType = GamerType.Machine};
        public static void Start()
        {
            SetName();
            while(true)
            {
                Options(Jogador);
                Options(Machine);
                Winner();
                if(GameOver() == 2)
                    break;
            }
        }
        private static void SetName()
        {
            Console.Clear();
            Console.Write("Digite seu nome: ");
            Jogador.Nome = Input.Read();
        }
        private static void Options(Gamer WhoChose)
        {
            switch(WhoChose.gamerType)
            {
                case GamerType.Player:
                    int option = 0;
                    while(option < 1 || option > 3)
                    {
                        Inicio:
                        Menu.InGame(Jogador);
                        option = Input.ReadInt();
                        if(option < 1 || option > 3)
                        {
                            option = -1;
                            goto Inicio;
                        }
                    }
                    Jogador.Play = (Play)option;
                break;
                case GamerType.Machine:
                    var rnd = new Random();
                    Machine.Play = (Play)rnd.Next(3)+1;
                break;
            }
        }
        public static void Winner()
        {   
            Menu.Choises(Jogador,Machine);
            
            switch(Jogador.Play,Machine.Play)
            {
                case (Play.Papel,Play.Pedra):
                case (Play.Pedra,Play.Tesoura):
                case (Play.Tesoura,Play.Papel):
                    Console.WriteLine($"\n{Jogador.Nome} Ganhou!");
                break;
                case (Play.Pedra,Play.Papel):
                case (Play.Tesoura,Play.Pedra):
                case (Play.Papel,Play.Tesoura):
                    Console.WriteLine($"\n{Machine.Nome} Ganhou!");
                break;
                default:
                    Console.WriteLine($"\nJogo Empatadou!");
                break;
            }
            Input.Wait();
        }
        public static int GameOver()
        {
            int option = 0;
            while(option < 1 || option > 2)
            {
                Menu.GameOver();
                option = Input.ReadInt();
            }
            return option;
        }
        
    }
}