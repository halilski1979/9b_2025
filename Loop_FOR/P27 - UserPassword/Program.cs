namespace P27___UserPassword
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string user = "Ivan";
            string password = "123";
            int counter = 0;
            
            while (true)
            {
                Console.Write("USER: ");
                string userName = Console.ReadLine();
                Console.Write("Password: ");
                string myPassword = Console.ReadLine();

                if (userName == user && myPassword == password)
                {
                    Console.WriteLine($"Welcome, {userName}"!);
                    break;
                }
                else
                {
                    Console.WriteLine("ERROR!");
                    counter++;
                }

                if (userName!=user)
                {
                    Console.WriteLine("Greshen user");
                }
                if (myPassword!=password)
                {
                    Console.WriteLine("Greshna parola");
                }
               

                if (counter == 2) 
                {
                    Console.WriteLine($"Posleden opit za parola:");
                }


                if (counter==3)
                {
                    Console.WriteLine($"Account is locked.");
                    break;
                }
               
                
            }
        }
    }
}
