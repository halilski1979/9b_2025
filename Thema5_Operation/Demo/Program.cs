namespace Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Name: ");
            string name=Console.ReadLine();
            Console.Write("Klas: ");

            int klas=int.Parse(Console.ReadLine());
            Console.Write("Paralelka: ");

            char paralelka=char.Parse(Console.ReadLine());
            Console.Write("Uspeh: ");

            double uspeh=double.Parse(Console.ReadLine());
            bool stipendia = (uspeh>=5.50);


            Console.WriteLine("--------------");
            Console.WriteLine($"I am {name}, {klas} {paralelka} class. My grade is {uspeh}. Stipeendia: {stipendia}");

        }
    }
}
