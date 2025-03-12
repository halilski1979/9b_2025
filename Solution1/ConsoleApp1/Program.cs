namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var courses=new Dictionary<string, List<string>>();

            while (true)
            {
                var cmd = Console.ReadLine().Split(" ").ToList();
                if (cmd[0]=="end")
                {
                    break;
                }

                var coursName = cmd[0];
                var stName = cmd[1];
                if (!courses.ContainsKey(coursName))
                {
                    courses[coursName] = new List<string>();
                }
                else
                {
                    courses[coursName].Add(stName);
                }
            }

            foreach (var item in courses)
            {
                Console.WriteLine($"Course: {item.Key} : {courses.Values.Count}");
                foreach (var student in item.Value)
                {
                    Console.WriteLine($"-- {student}");
                }
            }
        }
    }
}
