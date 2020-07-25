using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Runtime.Remoting.Services;
using System.Text;
using System.Threading.Tasks;

namespace Start
{
    class Program
    {
        static void Main(string[] args)

            
        {
          // A better calcultor with more options
          
            Console.Write("Enter a number");
            double integer1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter Operator");
            string op = Console.ReadLine();


            Console.Write("Enter a number");
            double integer2= Convert.ToDouble(Console.ReadLine());

            if (op == "+")
            {
                Console.WriteLine(integer1 + integer2);
            }
            else if (op == "-") ;
            {
                Console.WriteLine(integer1 - integer2);
            }
            else if (op == "*") ;
            {
                Console.WriteLine(integer1 * integer2);
            }
            else if (op == "/") ;
            {
                Console.WriteLine(integer1 / integer2);
            }
            else
            {
                Console.WriteLine("Invalid Operator");
            }
