namespace Basketball
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int taksa=int.Parse(Console.ReadLine());

            double sneckers = taksa * 0.6;
            double ekip = sneckers -sneckers*0.2;
            double ball = ekip / 4;
            double accesoarse = ball / 5;

            Console.WriteLine($"{taksa+sneckers+ekip+ball+accesoarse}");


        }
    }
}
