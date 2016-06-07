using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            char x, o;
            x = 'X'; o = 'O';
            bool wasX = true;

            for (int i = 0; i < 8; i++) {
                for (int j = 0; j < 8; j++)
                {
                    if (j == 7)
                    {
                        if (wasX)
                        {
                            Console.WriteLine(x);
                            wasX = false;
                        }
                        else
                        {
                            Console.WriteLine(o);
                            wasX = true;
                        }
                    }
                    else
                    {
                        if (wasX)
                        {
                            Console.Write(x);
                            wasX = false;
                        }
                        else
                        {
                            Console.Write(o);
                            wasX = true;
                        }
                    }
                }
                wasX = !wasX;
            }
            Console.ReadLine();

        }
    }
}
