namespace P10___Excellent
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double grade=double.Parse(Console.ReadLine());

            if (grade >= 5.5 && grade<=6 )
            {
                Console.WriteLine("Otlichen");
            }
            else
            {
                Console.WriteLine("Ne e otlichna ocenka!");
            }
        }
    }
}
