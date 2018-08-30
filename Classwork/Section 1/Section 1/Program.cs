using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section_1
{
    class Program
    {
        static void Main( string[] args )
        {
            bool notQuit;
            do
            {
                 notQuit = DisplayMenu();
            } while (!notQuit);

                 //PlayWithString();
    }

        private static void PlayWithString()
        {
            string hoursString = "10A";
            //int hours = Int32.Parse(hoursString);
            //int hours;
            //bool result = Int32.TryParse(hoursString, out hours);
            //bool result = Int32.TryParse(hoursString, out int hours);
            //
            //hoursString = hours.ToString();
            //4.75.ToString();
            //457.ToString();
            //Console.ReadLine().ToString();
            string message = "Hello\tworld";
            string filePath = "C:\\Temp\\Test";

            //Verbatim strings
            filePath = @"C:\Temp\Test";

            //Concat
            string firstName = "Bob";
            string lastName = "Smith";
            string name = firstName + "" + lastName;

            //Strings are immutable -this produces a new string
            //name = "Hello " + name;
            Console.WriteLine("Hello" + name);//Approach 1
            Console.WriteLine("Hello {0}", firstName, lastName);//Approach2
            string str =String.Format("Hello {0} {1}", firstName, lastName);//Approach 3
            Console.WriteLine(str);

            //Approach 4
            Console.WriteLine($"Hello {firstName} {lastName}");

            string missing = null;
            string empty = "";
            string empty2 = String.Empty;


            //Checking for empty strings
            //if (firstName.Length == 0)
            //if (firstName!= null && firstName !="")
            if (!String.IsNullOrEmpty(firstName))
                Console.WriteLine(firstName);

            //Other stuff
            string uppperName = firstName.ToUpper();
            string lowerName = firstName.ToLower();

            // Comparsion
            bool areEqual = firstName == lastName;
            areEqual = firstName.ToLower() == lastName.ToLower();
            areEqual = String.Compare(firstName, lastName, true) == 0;

            bool starsWithA = firstName.StartsWith("A");
            bool endWithA = firstName.EndsWith("A");
            bool hasA = firstName.IndexOf("A") >= 0;
            string subset = firstName.Substring(4);

            //Clean up
            string cleanMe = firstName.Trim();//TrimStart, TrimEnd
            string makeLonger = firstName.PadLeft(20);//PadRight

        }

        private static bool DisplayMenu()
        {
            while (true)
            {
                Console.WriteLine("A)dd Movie");
                Console.WriteLine("E)dit Movie");
                Console.WriteLine("D)elete Movies");
                Console.WriteLine("V)iew Movies");
                Console.WriteLine("Q)uit");

                string input = Console.ReadLine();
                switch (input[0])
                {
                    case 'a':
                    case 'A': AddMovie(); return true;


                    case 'e':
                    case 'E': EditMovie(); return true;


                    case 'd':
                    case 'D': DeleteMovie(); return true;


                    case 'v':
                    case 'V': ViewMovie(); return true;


                    case 'q':
                    case 'Q': return false;
                    

                    default:
                    Console.WriteLine("Please enter a valid value.");
                    break;

                };
            };
        }

        private static void ViewMovie()
        {
            Console.WriteLine("ViewMovie");
        }

        private static void DeleteMovie()
        {
            Console.WriteLine("DeleteMovie");
        }

        private static void EditMovie()
        {
            Console.WriteLine("EditMovie");
        }

        private static void AddMovie()
        {
            Console.WriteLine("AddMovie");
        }
    }
}
