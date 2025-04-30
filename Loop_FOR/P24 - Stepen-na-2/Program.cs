namespace P24___Stepen_na_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int result = 1;
            int i = 0;

            while (n>=0)
            {
                if (i==0)
                {
                    Console.WriteLine(1);
                    i++;
                }
                else
                {                    
                    Console.WriteLine(result*=2);                    
                }
                n--;
            }
        }
    }
}
