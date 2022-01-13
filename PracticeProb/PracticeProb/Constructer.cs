using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    internal class Constructer
    {
         public int num;
         public string Name;

         public Constructer(int Num,string name)// create a constructor with number of parameters
        {
            num = Num; // Assigning the user values 
            Name = name;
            Console.WriteLine(Num+"  "+Name);// It will give the Result

        }
    }
}
