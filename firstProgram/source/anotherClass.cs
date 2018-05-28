using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace firstProgram
{
    class anotherClass : goodName
    {
        static int[,] arrayInts = new int[10, 10];
        static int[] xLoc = new int[2] { 0 , 0 };
        public static void printBoard(int[] xLoc)
        {
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    arrayInts[i, j] = 0;
                    if (i == xLoc[0] && j == xLoc[1]) arrayInts[i, j] = 9;
                    Console.Write(arrayInts[i, j]);
                }
                Console.WriteLine();
            }
        }


        public anotherClass()
        {
        }

        public static void Main(string[] args)
        {
            anotherClass myObj = new anotherClass();
            while (!(xLoc[0] > 9 || xLoc[1] > 9 || xLoc[0] < 0 || xLoc[1] < 0))
            {
                printBoard(xLoc);
                ConsoleKeyInfo keyinfo = new ConsoleKeyInfo();
                keyinfo = Console.ReadKey(true);
                switch (keyinfo.Key)
                {
                    case ConsoleKey.RightArrow:
                        xLoc[1]++;
                        break;
                    case ConsoleKey.LeftArrow:
                        xLoc[1]--;
                        break;
                    case ConsoleKey.UpArrow:
                        xLoc[0]--;
                        break;
                    case ConsoleKey.DownArrow:
                        xLoc[0]++;
                        break;
                }
                Console.Clear();
            }
            printBoard(xLoc);
            Console.WriteLine("You went out of bounds, therefore you lose HAHAHAHHA");
            Program.readStuff();
        }
    }
}