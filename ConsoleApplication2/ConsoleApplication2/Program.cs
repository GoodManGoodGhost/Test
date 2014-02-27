using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "SO2=$$PPM";

            try
            {
                if (str is string)
                {
                    throw new Exception("fdsfds");
                }
            }
            catch (System.Exception ex)
            {
            	
            }

            Console.WriteLine(str);

            Console.ReadKey();
        }
    }
}
