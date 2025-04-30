namespace P12___Triangle_Parametars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("a=");
            double a = double.Parse(Console.ReadLine());
            Console.Write("b=");
            double b = double.Parse(Console.ReadLine());
            Console.Write("c=");
            double c = double.Parse(Console.ReadLine());
            Console.Write("ha=");
            double ha = double.Parse(Console.ReadLine());
            Perimetur(a, b, c);
            Area(a, ha);
        }
        public static void Perimetur(double x,double y,double z)
        {
            Console.WriteLine($"{x} + {y} + {z}= {x+y+z}");
        }
        public static void Area(double x, double y)
        {
            Console.WriteLine($"{x}+{y} /2={(x*y)/2}");
        }
    }
}
