using System;

namespace P28___PoznayChisloto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random();
            int winnerNumber = r.Next(1,100);


            Console.WriteLine(winnerNumber);

            while (true)
            {
                Console.Write("myNumber: ");
                int myNumber = int.Parse(Console.ReadLine());
            }
        }
    }
}
