namespace P06___Alphabet_ASSCI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (char i = 'z'; i >= 'a'; i--)
            {
                Console.WriteLine($"{i} => {(int)(i)}");
            }
        }
    }
}
