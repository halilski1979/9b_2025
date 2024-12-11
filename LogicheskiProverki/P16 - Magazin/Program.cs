namespace P16___Magazin
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string stoka=Console.ReadLine();
            string grad=Console.ReadLine();
            double kolichestvo=double.Parse(Console.ReadLine());

            if(grad == "Sofia")
            {
                if (stoka == "coffee")
                {
                    Console.WriteLine(kolichestvo* 0.50);
                }
                else if (stoka=="water")
                {
                    Console.WriteLine(kolichestvo * 0.80);
                }
                else if (stoka == "beer")
                {
                    Console.WriteLine(kolichestvo * 1.20);
                }
                else if (stoka == "sweets")
                {
                    Console.WriteLine(kolichestvo * 1.45);
                }
                else if (stoka == "peanuts")
                {
                    Console.WriteLine(kolichestvo * 1.60);
                }
            }


            else if (grad == "Plovdiv")
            {
                if (stoka == "coffee")
                {
                    Console.WriteLine(kolichestvo * 0.40);
                }
                else if (stoka == "water")
                {
                    Console.WriteLine(kolichestvo * 0.70);
                }
                else if (stoka == "beer")
                {
                    Console.WriteLine(kolichestvo * 1.15);
                }
                else if (stoka == "sweets")
                {
                    Console.WriteLine(kolichestvo * 1.30);
                }
                else if (stoka == "peanuts")
                {
                    Console.WriteLine(kolichestvo * 1.50);
                }
            }

            if (grad == "Varna")
            {
                if (stoka == "coffee")
                {
                    Console.WriteLine(kolichestvo * 0.45);
                }
                else if (stoka == "water")
                {
                    Console.WriteLine(kolichestvo * 0.70);
                }
                else if (stoka == "beer")
                {
                    Console.WriteLine(kolichestvo * 1.10);
                }
                else if (stoka == "sweets")
                {
                    Console.WriteLine(kolichestvo * 1.35);
                }
                else if (stoka == "peanuts")
                {
                    Console.WriteLine(kolichestvo * 1.55);
                }
            }
        }
    }
}
