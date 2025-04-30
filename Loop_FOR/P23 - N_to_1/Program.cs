namespace P23___N_to_1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());

            for (int i = n; i >= 0; i-=2)
            {
                Console.WriteLine(i);
            }
        }
    }
}
