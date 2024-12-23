using System;
using PersonNamespace;

namespace MyConsoleApp
{
    class Program
    {
        #region enum of weekdays
        enum WeekDays { Sun, Mon, Tue, Wed, Thu, Fri, Sat };
        #endregion

        #region enum of seasons of the year
        enum Season { Spring, Summer, Autumn, Winter };
        #endregion

        #region enum of Colors
        enum Color { Red, Green, Blue };
        #endregion

        static void Main(string[] args)
        {
            #region Task 1 weekdays
            // foreach (WeekDays day in Enum.GetValues(typeof(WeekDays)))
            // {
            //     Console.WriteLine(day);
            // }
            #endregion

            #region Task 2 person structc
            // Person[] people = new Person[3];
            // people[0] = new Person("Ali", 25);
            // people[1] = new Person("Noor", 30);
            // people[2] = new Person("Rana", 35);

            // foreach (var person in people)
            //     person.ShowPersons();
            #endregion

            #region task3
            // Console.WriteLine("Enter Your Favorite Season Of The Year Please");
            // string userInput = Console.ReadLine();
            // if (Enum.TryParse(userInput, true, out Season userSeason))
            // {
            //     // Display corresponding season message
            //     switch (userSeason)
            //     {
            //         case Season.Autumn:
            //             Console.WriteLine("Autumn is from September to November.");
            //             break;
            //         case Season.Summer:
            //             Console.WriteLine("Summer is from June to August.");
            //             break;
            //         case Season.Spring:
            //             Console.WriteLine("Spring is from March to May.");
            //             break;
            //         case Season.Winter:
            //             Console.WriteLine("Winter is from December to February.");
            //             break;
            //         default:
            //             Console.WriteLine("Invalid season.");
            //             break;
            //     }
            // }
            // else
            // {
            //     Console.WriteLine("Invalid input. Please enter a valid season name.");
            // }
            #endregion

            #region primary colour
            // Console.Write("Enter a Colour :  ");
            // string userInput = Console.ReadLine();
            // if(Enum.TryParse( userInput, true , out Color userColor)){
            //     if(userColor == Color.Blue){
            //         Console.WriteLine("Blue is a primary colour.");
            //     }
            //     else if(userColor == Color.Green){
            //         Console.WriteLine("Green is a primary colour.");
            //     }
            //     else if(userColor == Color.Red){
            //         Console.WriteLine("Red is a primary colour.");
            //     }

            // }else{
            //         Console.WriteLine($"{userInput} colour entered is not a primary colour ");
            //     }
            #endregion

            #region ecledian distance
            // Console.WriteLine("Enter your first point:");
            // Console.WriteLine("Enter your first x1:");
            // double x1 = Convert.ToDouble(Console.ReadLine());
            // Console.WriteLine("Enter your first y1:");
            // double y1 = Convert.ToDouble(Console.ReadLine());

            // Console.WriteLine("Enter your second point:");
            // Console.WriteLine("Enter your second x2:");
            // double x2 = Convert.ToDouble(Console.ReadLine());
            // Console.WriteLine("Enter your second y2:");
            // double y2 = Convert.ToDouble(Console.ReadLine());

            // Point p1 = new Point(x1, y1);
            // Point p2 = new Point(x2, y2);

            // // Calculate the distance between p1 and p2
            // double distance = p1.GetDistanceBetweenXAndY(p2);

            // // Corrected output statement to print the actual calculated distance
            // Console.WriteLine($"The distance between the two points is {distance}");
            #endregion

            #region oldest person printed details
            Person[] people = new Person[3];
            people[0] = new Person("Ali", 25);
            people[1] = new Person("Noor", 30);
            people[2] = new Person("Rana", 35);

            // Sorting the people array based on age
            for (int i = 0; i < people.Length; i++)
            {
                for (int j = i + 1; j < people.Length; j++)
                {
                    if (people[i].Age > people[j].Age)
                    {
                        // Swap if person[i] is older than person[j]
                        Person temp = people[i];
                        people[i] = people[j];
                        people[j] = temp;
                    }
                }
            }

            // After sorting, the last person in the array will be the oldest
            Person oldestPerson = people[people.Length - 1];

            // Display  
            Console.WriteLine($"\nThe oldest person is {oldestPerson.Name} with age {oldestPerson.Age}.");
            #endregion   





            
        //              4- Assign the following Permissions (Read, write, Delete, Execute) in a form of Enum.
        // Create Variable from previous Enum to Add and Remove Permission from variable, check if specific Permission is existed inside variable
        
        //      did not git it    
        }



    }
}
