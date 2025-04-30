namespace P18___Proizvedenie_Nechetni_M_to_N
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int p = 1;
            int m = int.Parse(Console.ReadLine());
            int n = int.Parse(Console.ReadLine());

            for (int i = m; i <=n; i++)
            {
                if (i%2==1)
                {
                    p *= i;
                }
            }

            Console.WriteLine(p);
        }
    }
}
