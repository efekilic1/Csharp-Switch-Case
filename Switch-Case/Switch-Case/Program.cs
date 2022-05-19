using System;

namespace SwitchCase
{
    class MainClass
    {
        public static void Main(string[] args)
        {

            Console.WriteLine("Enter a Month");
            string month =  Console.ReadLine().ToLower();

            switch (month)
            {
                case "january": Console.WriteLine("Winter"); break;
                case "february": Console.WriteLine("Winter"); break;
                case "march": Console.WriteLine("Spring"); break;
                case "april": Console.WriteLine("Spring"); break;
                case "may": Console.WriteLine("Spring"); break;
                case "june": Console.WriteLine("Summer"); break;
                case "july": Console.WriteLine("Summer"); break;
                case "august": Console.WriteLine("Summer"); break;
                case "september": Console.WriteLine("fall"); break;
                case "october": Console.WriteLine("Fall"); break;
                case "november": Console.WriteLine("Fall"); break;
                case "december": Console.WriteLine("Winter"); break;
                default:
                    Console.WriteLine("Incorrect Entry");
                    break;
            }

            Console.ReadLine();


        }


        }
    }
