namespace P13___Chislo_V_Granici
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*  Да се напише програма, която чете цяло число, въведено от потребителя и 
             *  проверява, дали е под 100, между 100 и 200 или над 200. */

            int a=int.Parse(Console.ReadLine());


            if (a <100)
            {
                Console.WriteLine("Less than 100");
            }
            else if ( a < 200)
            {
                Console.WriteLine("Between 100 and 200");
            }
            else 
            {
                Console.WriteLine("Greater than 200");
            }
        }
    }
}
