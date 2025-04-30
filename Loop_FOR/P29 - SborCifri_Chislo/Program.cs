namespace P29___SborCifri_Chislo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());//1234
            int s = 0;

            while (true)
            {
                int ost = n % 10;
                if (ost % 2 == 0)
                {
                    s += ost;
                }
                n = n / 10;   
                
                
               
                if (n==0)
                {
                    break;
                }
            }

            Console.WriteLine(s);
        }
    }
}
