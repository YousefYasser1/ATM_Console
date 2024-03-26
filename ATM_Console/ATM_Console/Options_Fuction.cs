using Microsoft.VisualBasic.FileIO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM_Console
{
    internal class Options_Fuction
    {
        public static void DisplayOprions()
        {
            Console.WriteLine("Choose From Thie Options : ");
            Console.WriteLine("1-Deposit");
            Console.WriteLine("2-WithDraw");
            Console.WriteLine("3-Get Balance");
            Console.WriteLine("4-Exit");
        }
    }
}
