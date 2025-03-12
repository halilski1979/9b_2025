namespace P11___SborChetni
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int s = 0;

            for (int i = 1; i < 11; i++)
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
