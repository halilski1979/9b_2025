namespace P10___Sbor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int broy = int.Parse(Console.ReadLine());
            int s = 0;
           
            for (int i = 0; i < broy; i++)
            {
                int number = int.Parse(Console.ReadLine());
                s += number;
            }

            Console.WriteLine($"S={s}");
        }
    }
}
