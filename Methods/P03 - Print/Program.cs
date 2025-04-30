namespace P03___Print
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PrintNechetni();
        }

        private static void PrintChetni()
        {
            Console.Write("m=");
            int m = int.Parse(Console.ReadLine());
            Console.Write("n=");
            int n = int.Parse(Console.ReadLine());
            for (int i = m; i <= n; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i);
                }

            }
        }
        private static void PrintNechetni()
        {
            Console.Write("m=");
            int m = int.Parse(Console.ReadLine());
            Console.Write("n=");
            int n = int.Parse(Console.ReadLine());
            for (int i = m; i <= n; i++)
            {
                if (i % 2 != 0)
                {
                    Console.WriteLine(i);
                }

            }
        }
        public static void Print()
        {
            Console.Write("m=");
            int m = int.Parse(Console.ReadLine());
            Console.Write("n=");
            int n = int.Parse(Console.ReadLine());

            for (int i = m; i <= n; i++)
            {
                Console.WriteLine(i);
            }
        }
    }
}
