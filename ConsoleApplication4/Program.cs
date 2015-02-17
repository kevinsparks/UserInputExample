using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4
{
    /// <summary>
    /// Used as an example of user input and manipulation
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter your name");
            string name = Console.ReadLine(); // Only returns strings 

            Console.WriteLine("Enter age");
            string age = Console.ReadLine();
            
            int ageNum = int.Parse(age);
            ageNum++;
            Console.WriteLine(ageNum);

            Console.WriteLine(name);

            Console.WriteLine("Press any key");
            Console.ReadKey();
        }
    }
}
