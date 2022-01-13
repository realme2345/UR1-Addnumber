using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeProb
{
    internal class Add
    {
        public  void AddTwoNumbers()
        {
            // Adding of two numbers by taking the input from user
            Console.WriteLine("Enter a First Number :");
            int firstNumber=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter a Second Number :");
            int secondNumber=Convert.ToInt32(Console.ReadLine());
            int result=firstNumber + secondNumber;
            Console.WriteLine("adding of two numbers = " + result);
        }
    }
}
