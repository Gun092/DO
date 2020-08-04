using System;

namespace Finding_Value
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello DOSCG");
            Console.WriteLine("X, Y, 5, 9, 15, 23, Z" + " finding X, Y, Z Value");

            int a = 5, b = 9, c = 15, d = 23, e = 10, z, x, y, A = 21, B, C;
            
            /*X, Y, 5, 9, 15, 23, Z -Please create a new function for finding X, Y, Z value*/
            if (e < 12)
            {
                z = e + d;
                e = e - 2;
                if (e < 9)
                {
                    e = e - 2;
                    if (e < 7)
                    {
                        e = e - 2;
                        if (e < 5)
                        {
                            e = e - 2;
                            if (e < 3)
                            {
                                y = a - e;
                                e = e - 2;
                                if (e == 0)
                                {
                                    x = -y;
                                    Console.WriteLine(" " + x + "," + y + "," + a + "," + b + "," + c + "," + d + "," + z + ",");
                                }
                            }
                        }
                    }
                }

            }
            
            /*IF A =21, A+B = 23, A+C = -21 : Please create a new function for finding B and C value */
            Console.WriteLine("If A = 21, A + B = 23, A + C = -21 finding B and C Value");
            B = 23 - A;
            C = -21 - A;
            Console.WriteLine(" B = " + B + " and C =" + C);
        }
    }
}
