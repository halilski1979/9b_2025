using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Person
    {
        private string firstName;
        private string lastName;
        private int age;

        public Person(string firstName, string lastName, int age)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.age = age;
        }
        public string FirstName => firstName;//Своиство за четене на firstName

        public override string ToString()
        {
            return $" {firstName} {lastName} is a {age} years old";
        }
    }
}
