namespace P13___Sbor_M_to_N
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int s = 0;
            int m = int.Parse(Console.ReadLine());
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <=10; i++)
            {
                //s = s + i;
                 s += i;
            }

            Console.WriteLine(s);
        }
    }
}
