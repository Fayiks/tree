using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;
namespace Tree
{
    class Program
    {
        static void Main(string[] args)
        {

            string text = "the_sculpture faith";

            CamelText(text);
            Console.WriteLine();
            NarcissitCheck();
            Console.ReadLine();

        }

        private static void NarcissitCheck()
        {
            var message = ("\t this works for 3 digits at the moment").ToUpper();
            Console.WriteLine(message);
            
            Console.WriteLine("enter first digits: ");
            var Firstdigit = Console.ReadLine();

            Console.WriteLine("enter second digits: ");
            var Seconddigit = Console.ReadLine();

            Console.WriteLine("enter next digits: ");
            var nextdigit = Console.ReadLine();

            var digits = new[] { Firstdigit, Seconddigit, nextdigit };
            

            var Power = digits.Count();

            var result = Math.Pow(int.Parse(Firstdigit), Power) + Math.Pow(int.Parse(Seconddigit), Power) + Math.Pow(int.Parse(nextdigit), Power);
            string show = result.ToString();
            Console.WriteLine(result);
            string singleString = String.Join(",", digits);
            Console.WriteLine(singleString);
            
            if (show == (Firstdigit+Seconddigit+nextdigit))
            {
                Console.WriteLine("Narcissit");
                
            }
            else
            {
                Console.WriteLine("Not Narcissit");
                
            }
            /*foreach (string digist in digits)
            {
                Console.WriteLine(digist);
            }*/
            Console.WriteLine("press enter to cancel");
            Console.ReadLine();
            Console.ReadKey();
        }
        

        private static string CamelText(string text)
        {
            TextInfo cultInfo = new CultureInfo("en-US", false).TextInfo;

            text = cultInfo.ToTitleCase(text);

            text = text.Replace("_", "").Replace(" ", "");

            Console.WriteLine(text);
            return text;
        }
    }

}
