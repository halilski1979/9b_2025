namespace P11___Triangle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Perimeter();
            Area();
        }

        public static void Area()
        {
            Console.WriteLine("Lice na triagalnik");
            Console.Write("a=");
            double a = double.Parse(Console.ReadLine());
            Console.Write("ha=");
            double ha = double.Parse(Console.ReadLine());

            Console.WriteLine($"S: {a}*{ha}/{2}={(a * ha) / 2}");
        }
        public static void Perimeter()
        {
            Console.WriteLine("Peimeter na triagalnik");
            Console.Write("a=");
            double a = double.Parse(Console.ReadLine());
            Console.Write("b=");
            double b = double.Parse(Console.ReadLine());
            Console.Write("c=");
            double c = double.Parse(Console.ReadLine());
            Console.WriteLine($"P: {a}+{b}+{c} = {a + b + c}");
        }

    }
}
