using System;
using System.Collections.Generic;
using System.Text;

namespace BusApp2.Models
{
    public class Passenger: IComparable<Passenger>
    {
        public string Name { get; set; }
        public string Gender { get; set; }
        public int Age { get; set; }

        public Passenger(string name, string gender, int age)
        {
            Name = name;
            Gender = gender;
            Age = age;
        }
        public int CompareTo(Passenger passenger)
        {
            int a = this.Age;
            int b = passenger.Age;

            if (a < b)
            {
                return -1;
            }
            else if (a > b)
            {
                return 1;
            }
            else
            {
                return 0;
            }

        }
        public void Poke()
        {
            if (Age >= 55 && Gender == "MALE")
            {
                Console.WriteLine("Ehh, leave me alone...");
            }
            else if (Age >= 30 && Gender == "MALE")
            {
                Console.WriteLine("Hello  there cutie");
            }
            else if (Age >= 20 && Gender == "MALE")
            {
                Console.WriteLine("Dude wtf?");
            }
            else if (Age >= 55 && Gender == "FEMALE")
            {
                Console.WriteLine("NO you can't have my seat!");
            }
            else if (Age >= 30 && Gender == "FEMALE")
            {
                Console.WriteLine("Eww, gross. Get out of here");
            }
            else if (Age >= 20 && Gender == "FEMALE")
            {
                Console.WriteLine("Pervert!");
            }
        }
    }
}
