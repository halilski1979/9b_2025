namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Person> people = new List<Person>();
            //Въвеждане на броя на хората
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                //Четем входните данни
                string[] input = Console.ReadLine().Split(' ');

                string firstName = input[0];
                string lastName = input[1];
                int age = int.Parse(input[2]);

                //Създаваме обект и го добавяме в списъка
                people.Add(new Person(firstName, lastName, age));
            }
            //Сортиране по азбучен ред на firstName
            var sortedPeople = people.OrderBy(p => p.FirstName).ToList();

            //Извеждане на резултата
            foreach (var person in sortedPeople)
            {
                Console.WriteLine(person);
            }
        }
    }
}
