using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gotoexample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string userName;
            Again:
            Console.WriteLine("Enter user Name");
            userName = Console.ReadLine();
            if(userName.Length>=6)
            {
                Console.WriteLine("Welcome : \t" + userName);
            }
            else
            {
                Console.WriteLine("Invalid user Name");
                goto Again;
            }
            Console.ReadKey();
        }
    }
}
