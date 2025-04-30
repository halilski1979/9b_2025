namespace P04___PrintPatametri
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Print3(1,30);
        }

        public static void Print(int start, int end)
        {
            for (int i = start; i <= end; i++)
            {
                Console.WriteLine(i);
            }
        }

        public static void Print3(int start, int end)
        {
            for (int i = start; i <= end; i++)
            {
                if (i%3==0)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
