namespace P20___DeleneBezOstatak_234
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Броят на числата
            int n = int.Parse(Console.ReadLine());
            int count2 = 0;
            int count3 = 0;
            int count4 = 0;

            for (int i = 0; i < n; i++)
            {
                //Прочитаме числото
                int number = int.Parse(Console.ReadLine());

                //Намираме броят на числата, които се делят на 2
                if (number % 2 == 0)
                {
                    count2++;
                }

                if (number % 3 == 0)
                {
                    count3++;
                }

               if (number % 4 == 0)
                {
                    count4++;
                }
            }

            Console.WriteLine($"{((double)(count2)/(double)(n))*100.0:f2}%");
            Console.WriteLine($"{((double)(count3) / (double)(n)) * 100.0:f2}%");
            Console.WriteLine($"{((double)(count4) / (double)(n)) * 100.0:f2}%");
        }
    }
}
