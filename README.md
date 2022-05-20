# Csharp-Switch-Case

www.patika.dev

Karar Yapıları 2 Switch Case


<img width="1189" alt="Ekran Resmi 2022-05-19 19 24 06" src="https://user-images.githubusercontent.com/105243448/169350410-1012d167-2478-44e5-9560-1199c317a225.png">





```
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
    
```
