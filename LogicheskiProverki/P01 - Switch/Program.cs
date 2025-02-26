namespace P01___Switch
{
    internal class Program
    {
        static void Main(string[] args)
        {
           string n = Console.ReadLine();

            if (n=="1")
            {
                Console.WriteLine("Pon");
            }
            else if (n=="2")
            {
                Console.WriteLine("Vt");
            }
            else if (n=="3")
            {
                Console.WriteLine("Sr");
            }
            else if(n=="4") 
            {
                Console.WriteLine("Ch");
            }
            else if (n=="5")
            {
                Console.WriteLine("Petak");
            }
            else
            {
                Console.WriteLine("Error");
            }


            Console.WriteLine();
            switch (n)
            {
                case "1": { Console.WriteLine("Ponedelnik");break; }
                case "2": { Console.WriteLine("Vtornik"); break; }
                case "3": { Console.WriteLine("Srqda"); break; }
                case "4": { Console.WriteLine("Chetvartak"); break; }
                case "5": { Console.WriteLine("Petak"); break; }
                case "6": { Console.WriteLine("Sabota"); break; }
                case "7": { Console.WriteLine("Nedelq"); break; }

                default:
                    {
                        Console.WriteLine("Error");
                    }
                    break;
            }
        }
    }
}
