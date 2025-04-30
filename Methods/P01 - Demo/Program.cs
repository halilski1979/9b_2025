namespace P01___Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // I. Методи без параметър
            
            Umnojenie();
        }

        public static void Umnojenie()
        {
            Console.Write("a=");
            int a = int.Parse(Console.ReadLine());
            Console.Write("b=");
            int b = int.Parse(Console.ReadLine());

            int s = a * b;
            Console.WriteLine($"{a}*{b} = {s}");
        }

        public static void Razlika()
        {
            Console.Write("a=");
            int a = int.Parse(Console.ReadLine());
            Console.Write("b=");
            int b = int.Parse(Console.ReadLine());

            int s = a - b;
            Console.WriteLine($"{a}-{b} = {s}");
        }

        public static void Sum()
        {
            // Сбор на 2 числа
            Console.Write("a=");
            int a = int.Parse(Console.ReadLine());
            Console.Write("b=");
            int b = int.Parse(Console.ReadLine());

            int s = a + b;
            Console.WriteLine($"{a}+{b} = {s}");
        }



    }
}
