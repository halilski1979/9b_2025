namespace P16___ChetniSbor_M_to_N
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int s = 0;
            int m = int.Parse(Console.ReadLine());
            int n = int.Parse(Console.ReadLine());

            for (int i = m; i <=n; i++)
            {
                if (i%2==0)
                {
                    s += i;
                }
            }

            Console.WriteLine(s);
        }
    }
}
