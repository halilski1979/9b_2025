namespace p14___AreaFigur
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string typeFigure=Console.ReadLine();

            if (typeFigure == "square")
            {
                int a=int.Parse(Console.ReadLine());
                Console.WriteLine(a*a);
            }
            else if (typeFigure == "rectangle")
            {
                int a=int.Parse(Console.ReadLine());
                int b=int.Parse(Console.ReadLine());
                Console.WriteLine(a*b);
            }
            else if (typeFigure == "circle")
            {
                double r=double.Parse(Console.ReadLine());
                Console.WriteLine(Math.PI*r*r);
            }
            else if (typeFigure == "triangle")
            {
                double a=double.Parse(Console.ReadLine());
                double ha = double.Parse(Console.ReadLine());
                Console.WriteLine((a*ha)/2);
            }
        }
    }
}
