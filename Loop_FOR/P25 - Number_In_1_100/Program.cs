namespace P25___Number_In_1_100
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Write("Еnter a number in the range [1...100]:");
                int n = int.Parse(Console.ReadLine());

                if (n>=0 && n<=100)
                {
                    Console.WriteLine($"The number is {n}");
                    break;
                }
            }
        }
    }
}
