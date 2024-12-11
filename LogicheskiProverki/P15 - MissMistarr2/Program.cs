namespace P15___MissMistarr2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double age=double.Parse(Console.ReadLine());
            char pol=char.Parse(Console.ReadLine());

            if (pol == 'm')
            {
                if (age>=16)
                {
                    Console.WriteLine("Mr.");
                }
                else
                {
                    Console.WriteLine("Master");
                }
            }
            else if (pol == 'f')
            {
                if (age >= 16)
                {
                    Console.WriteLine("Ms.");
                }
                else
                {
                    Console.WriteLine("Miss");
                }
            }
        }
    }
}
