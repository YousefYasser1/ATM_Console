using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace ATM_Console
{
    internal class Bank_Function
    {
        public static void Deposit(User user)
        {
            Console.WriteLine("Enter The Number Of Money $$ : ");
            double money = Convert.ToDouble(Console.ReadLine());
            user.Balance += money;
            Console.WriteLine($"The Current Balance = {user.Balance:C}\n");
        }
        public static void WithDraw(User user)
        {
            Console.WriteLine("Enter The Number For WithDraw $$ : ");
            double withdraw = Convert.ToDouble(Console.ReadLine());
            if (user.Balance < withdraw)
            {
                Console.WriteLine("Sorry WithDraw Process Faild....\n");
            }
            else
            {
                user.Balance = user.Balance - withdraw;
                Console.WriteLine($"The Current Balance = {user.Balance:C}\n");
            }            
        }
        public static void GetBalance(User user) => Console.WriteLine($"[{user.FullName}] == {user.Balance:C}\n");
    }
}
