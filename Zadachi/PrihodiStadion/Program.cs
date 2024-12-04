namespace PrihodiStadion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int brSectors=int.Parse(Console.ReadLine());
            int capacity=int.Parse(Console.ReadLine());
            double priceTicket=double.Parse(Console.ReadLine());

            Console.WriteLine($"Total income - {capacity*priceTicket:f2} BGN");
            double oneSectorPrihodi= (capacity * priceTicket) / brSectors;
            double monyBl = (oneSectorPrihodi * brSectors - (oneSectorPrihodi * 0.75)) / 8;


            Console.WriteLine($"Money for charity - {monyBl:f2} BGN");

        }
    }
}
