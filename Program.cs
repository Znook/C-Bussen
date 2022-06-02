using BusApp2.Models;
using System;

namespace BusApp2
{
    class Program
    {
        public static void Main(string[] args)
        {
            //var myBus = new MyBus(30);
            var newBus = new MyBus(40);

            myBus.Run();
            
            
            int mySwitch;
            while (true)
            {
                myBus.PrintMenu();
                try
                {
                    mySwitch = int.Parse(Console.ReadLine());
                }
                catch (Exception e)
                {
                    Console.WriteLine($"{e.Message}\n");
                    continue;
                }
                switch (mySwitch)
                {
                    case 1:
                        Console.Clear();

                        Console.Write("Enter name: ");
                        var name = Console.ReadLine();

                        Console.Write("Enter Gender: ");
                        var gender = Console.ReadLine();

                        Console.Write("Enter Age: ");
                        var age = int.Parse(Console.ReadLine());

                        Passenger newPassanger = new Passenger(name, gender, age);
                        myBus.Add_passenger(newPassanger);
                        break;
                    case 2:
                        Console.Clear();
                        myBus.Print_buss();
                        break;
                    case 3:
                        Console.Clear();
                        int cta = myBus.Calc_total_age();
                        Console.WriteLine($"Total age of the buss is: {cta}");
                        break;
                    case 4:
                        Console.Clear();
                        int caa = myBus.Calc_average_age();
                        Console.WriteLine($"Average age of the buss is: {caa}");
                        break;
                    case 5:
                        Console.Clear();
                        Console.WriteLine(myBus.Max_age());
                        break;
                    case 6:
                        Console.Clear();

                        Console.WriteLine("Enter from age");
                        int fromAge = int.Parse(Console.ReadLine());

                        Console.WriteLine("Enter to age");
                        int toAge = int.Parse(Console.ReadLine());

                        myBus.Find_age(fromAge, toAge);
                        break;
                    case 7:
                        Console.Clear();
                        myBus.Sort_buss();
                        Console.WriteLine("Buss is now sorted!");
                        break;
                    case 8:
                        Console.Clear();
                        myBus.Print_sex();
                        break;
                    case 9:
                        Console.Clear();
                        myBus.Poke();
                        break;
                    case 10:
                        Console.Clear();
                        Console.WriteLine("Who's getting off?");
                        string passangerName = Console.ReadLine();
                        Console.WriteLine($"How old is {passangerName}?");
                        int passangerAge = int.Parse(Console.ReadLine());
                        myBus.Getting_off(passangerName, passangerAge); 
                        break;
                    case 0:
                        return;
                    default:
                        Console.Clear();
                        Console.WriteLine($"Options {mySwitch} does not exist.  Please try again!");
                        break;
                }
            }
        }
    }
}
