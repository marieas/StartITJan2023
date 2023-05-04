using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Diagnostics.Metrics;

namespace Undervisning2
{
        class Program
        {
            static Random Random = new Random();
            
            static void Main(string[] args)
            {              
                Bil bil = new Bil();
                bil.PutInEngine("V8");
                Console.WriteLine(bil.Motor);
                //if(args.Length != 2)
                //{
                //    ShowMenu();
                //}
                //else 
                //{
                //    if (IsArgumentsValid(args))
                //    {
                //        string pattern = args[1];

            //        int totalCharacters = int.Parse(args[0]);
            //       if(totalCharacters < 14)
            //        {
            //            pattern = pattern.PadRight(totalCharacters, 'l');
            //        }

            //    }
            //    else
            //    {
            //        ShowMenu();
            //    }
            //}
            //var randomLetters = new char[10];
            //var randomNumbers = new int[10];

            //for (var i = 0; i < 10; i++)
            //{
            //    var randomLetter = GetRandomUpperCaseLetter();
            //    var randomNumber = Random.Next(0, 10);

            //    randomLetters[i] = randomLetter;
            //    randomNumbers[i] = randomNumber;
            //}
        }

        static bool IsArgumentsValid(string[] args)
        {
            var passwordLength = args[0];
            foreach (var character in passwordLength)
            {
                var isdigit = char.IsDigit(character);
                if(isdigit == false)
                {
                    return false;
                }
            }

            var options = args[1];
            foreach (var character in options)
            {
                if(!(character == 'l' || character == 'L' || character == 'd' || character == 's'))
                {
                    return false;
                }
            }

            return true;
        }

        static void ShowMenu()
        {
            var menustring = @"PasswordGenerator
                  Options:
                  -l = lower case letter
                  - L = upper case letter
                  - d = digit
                  - s = special character(!""#¤%&/(){}[]
                Example: PasswordGenerator 14 lLssdd
                         Min. 1 lower case
                         Min. 1 upper case
                         Min. 2 special characters
                         Min. 2 digits";
            Console.WriteLine(menustring);
        }
                    

            private static char GetRandomUpperCaseLetter()
            {
                return GetRandomLetter('A', 'Z');
            }

            private static char GetRandomLetter(char min, char max)
            {
                return (char)Random.Next(min, max);
            }
        }

}