namespace P12___Zavarshvat_NA_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int br = 0;
            
            for (int i = 0; i < 1000; i++)
            {
                if (i%10==7)
                {
                    Console.WriteLine(i);
                    br++;
                }
            }

            Console.WriteLine($"Broy: {br}");

        }
    }
}
