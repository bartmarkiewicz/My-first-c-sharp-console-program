using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace litfamhelloworld
{
    class Program
    {
        public static void readShit()
        {
            Console.ReadLine();
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Lit fam");
            for (int i = 0; i < 5; i++)
            {
               Console.WriteLine(i);
            }
            Console.WriteLine("Enter a number from 1 to 3");
            string myString = Console.ReadLine();
            int myNumber = 0; 
            bool myBool = int.TryParse(myString, out myNumber);
            if (myBool)
            {
                switch (myNumber)
                {
                    case 1:
                        Console.WriteLine("its 1");
                        break;
                    case 2:
                        Console.WriteLine("its 2");
                        break;
                    case 3:
                        Console.WriteLine("its 3");
                        break;
                    default :
                        Console.WriteLine("its default yo");
                        break;
                } 
            }
            else
            {
                Console.WriteLine("Not a number yo");
            }

            


            readShit();
        }

    }
}
