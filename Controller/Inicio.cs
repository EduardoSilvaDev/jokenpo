using jokenpo.Util;
using jokenpo.View;

namespace jokenpo.Controller
{
    public static class Inicio
    {
        public static int option;
        public static void Start()
        {
            option = -1;
            while(option!=0)
            {
                Comeco:
                View.Menu.Start();
                option = Input.ReadInt();
                if(option < 0 || option > 2)
                {
                    Console.Write("Opção Invalida!");
                    Input.Wait();
                    goto Comeco;
                }
                    
                switch(option)
                {
                    case 1:
                        InGame.Start();
                    break;
                    case 2:
                        Menu.Instruções();
                    break;
                    case 0:
                        Console.Clear();
                        Environment.Exit(0); 
                    break;
                }
            }
        }
    }
}