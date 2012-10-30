using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace SE3_Metric_1
{
    // Rooter:  Simple C# program to input an integer and output its square root
    // Greg McCarra, 10/10/12
    //
    class Rooter
    {
        static void Main()
        {
            string s_input, s_output;
            int val;
            double res;
            System.Console.WriteLine("Please enter a positive integer:  ");
            s_input = System.Console.ReadLine();
            val = int.Parse(s_input);
            res = Math.Sqrt(val);
            s_output = "The square root of " + val + " is " + res;
            System.Console.WriteLine(s_output);
            System.Console.Read();
        }
    }
}
