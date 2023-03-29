namespace jokenpo.Util
{
    public static class Input
    {
        public static void Wait()
        {
            Console.ReadKey();
        }
        public static string? Read()
        {
            return Console.ReadLine();
        }
        public static int ReadInt()
        {
            int op = -1;
            try
            {
                op = Convert.ToInt32(Read());
            }
            catch(Exception)
            {
                Console.Write("Apenas Numeros!");
                Wait();
            }
            return op;
        }
    }
}