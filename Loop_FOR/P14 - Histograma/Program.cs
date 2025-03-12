namespace P14___Histograma
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int br1 = 0;
            int br2 = 0;
            int br3 = 0;
            int br4 = 0;
            int br5 = 0;
            
            for (int i = 0; i < n; i++)
            {
                int number = int.Parse(Console.ReadLine());

                if (number <200)
                {
                    br1++;
                }
                else if (number < 400)
                {
                    br2++;
                }
                else if (number < 600)
                {
                    br3++;
                }
                else if (number<800)
                {
                    br4++;
                }
                else
                {
                    br5++;
                }
            }

            Console.WriteLine($"br1={br1}");
            Console.WriteLine($"br2={br2}");
            Console.WriteLine($"br3={br3}");
            Console.WriteLine($"br4={br4}");
            Console.WriteLine($"br5={br5}");

            Console.WriteLine($"{((double)br1 / (double)n)*100.00:f2}%");
            Console.WriteLine($"{((double)br2 / (double)n) * 100.00:f2}%");
            Console.WriteLine($"{((double)br3 / (double)n) * 100.00:f2}%");
            Console.WriteLine($"{((double)br4 / (double)n) * 100.00:f2}%");
            Console.WriteLine($"{((double)br5 / (double)n) * 100.00:f2}%");
        }
    }
}
