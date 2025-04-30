namespace P15___Proizvedenie_M_to_N
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int p = 1;
            int m = int.Parse(Console.ReadLine());
            int n = int.Parse(Console.ReadLine());

            for (int i = m; i <= n; i++)
            {
                p *= i;
            }

            Console.WriteLine(p);
        }
    }
}
