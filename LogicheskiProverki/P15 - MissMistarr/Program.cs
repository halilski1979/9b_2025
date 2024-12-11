namespace P15___MissMistarr
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double age=double.Parse(Console.ReadLine());
            char pol=char.Parse(Console.ReadLine());

            if (age>=16 && pol=='m')
            {
                Console.WriteLine("Mr.");
            }
            else if (age < 16 && pol == 'm')
            {
                Console.WriteLine("Master");
            }
            else if (age < 16 && pol == 'f')
            {
                Console.WriteLine("Miss");
            }
            else if (age >= 16 && pol == 'f')
            {
                Console.WriteLine("Ms.");
            }
        }
    }
}
