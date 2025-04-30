namespace P26___Number_In_1_100
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Еnter a number in the range [1...100]:");
            int n = int.Parse(Console.ReadLine());
            while (n <= 0 || n>100)
            {
                Console.WriteLine("Invalid number!");
                Console.Write("Еnter a number in the range [1...100]:");
                n = int.Parse(Console.ReadLine());
            }
            Console.WriteLine($"Chisloto e {n}");
        }
    }
}
