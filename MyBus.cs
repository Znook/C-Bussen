using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BusApp2.Models
{
    public class MyBus
    {
        public List<Passenger> Passengers;
        private int MaxCapacity;
        
        public MyBus()
        {
            Passengers = new List<Passenger>();
            MaxCapacity = 30;
        }

        public MyBus(int Max)
        {
            Passengers = new List<Passenger>();
            MaxCapacity = Max;
        }

        public void Run()
        {
            Console.WriteLine("Welcome to the awesome Buss-simulator");
        }

        public void PrintMenu()
        {
            Console.WriteLine("\n1. Add Passanger");
            Console.WriteLine("2. Print buss");
            Console.WriteLine("3. Calculate total age");
            Console.WriteLine("4. Calculate average age");
            Console.WriteLine("5. Max age");
            Console.WriteLine("6. Find age");
            Console.WriteLine("7. Sort buss");
            Console.WriteLine("8. Print sex");
            Console.WriteLine("9. Poke");
            Console.WriteLine("10. Getting off");
            Console.WriteLine("0. Exit");
        }

        public void Add_passenger(Passenger passenger)
        {
            if (Passengers.Count >= MaxCapacity)
            {
                Console.WriteLine("Sorry buss is currently full!");
            }
            else
            {
                Passengers.Add(passenger);
                Console.Write($"Added passenger: {passenger.Name}");
            }
        }

        public void Print_buss()
        {
            foreach (var passenger in Passengers)
            {
                Console.WriteLine(passenger.Name);
            }
        }

        public int Calc_total_age()
        {
            var calcAge = 0;
            foreach (var passanger in Passengers)
            {
                calcAge += passanger.Age;
            }
            return calcAge;
        }

        public int Calc_average_age()
        {
            return Calc_total_age() / Passengers.Count;
        }

        public int Max_age()
        {
            int maxAge = Passengers[0].Age;

            for (int i = 1; i < Passengers.Count; i++)
            {
                if (Passengers[i].Age > maxAge )
                {
                    maxAge = Passengers[i].Age;
                }
            }
            return maxAge;
        }
        
        public void Find_age(int fromAge, int toAge)
        {
            foreach (var passenger in Passengers)
            {
                if (passenger.Age >= fromAge && passenger.Age <= toAge)
                {
                    var index = Passengers.IndexOf(passenger);
                    Console.WriteLine(index);
                }
            }
        }
        public void Sort_buss()
        {
            Passengers.Sort();

            //List<Passenger> SortedList = Passengers.OrderByDescending(passenger => passenger.Age).ToList();
            //Passengers = SortedList;
            //Source https://stackoverflow.com/questions/3309188/how-to-sort-a-listt-by-a-property-in-the-object
        }

        public void Print_sex()
        {
            for (int i = 0; i < Passengers.Count; i++)
            {
                if (Passengers[i].Gender.ToUpper() == "MALE")
                {
                    Console.Write($"Position: {i}, SEX: Male\n");
                }
                else if (Passengers[i].Gender.ToUpper() == "FEMALE")
                {
                    Console.Write($"Position: {i}, SEX: Female\n");
                }
            }
        }

        public void Poke()
        {
            foreach (var passanger in Passengers)
            {
                passanger.Poke();
            }
        }

        public void Getting_off(string name, int age)
        {
            foreach (var passenger in Passengers)
            {
                if (passenger.Name == name && passenger.Age == age)
                {
                    Passengers.Remove(passenger);
                }
            }

        }
    }
}
