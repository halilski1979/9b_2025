namespace P02___Methods_S_Parametri
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // II. Методи с параметри
            Console.Write("a=");
            int a = int.Parse(Console.ReadLine());
            Console.Write("b=");
            int b = int.Parse(Console.ReadLine());

            Sum(a,b);
            Razlika(a,b);
            Umnojenie(a,b);           
        }

        public static void Sum(int x,int y)
        {
            Console.WriteLine($"{x} + {y} = {x+y}");
        }

        public static void Razlika(int x,int y)
        {
            Console.WriteLine($"{x} - {y}={x-y}");
        }

        public static void Umnojenie(int x1, int x2)
        {
            Console.WriteLine($"{x1} * {x2} = {x1*x2}");
        }
    }
}
