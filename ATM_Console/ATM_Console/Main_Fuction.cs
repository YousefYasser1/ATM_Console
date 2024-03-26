using Microsoft.VisualBasic.FileIO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM_Console
{
    internal class Main_Fuction
    {
        public static void MainFunction(List<User> users)
        {

            User user = new User();

            Console.WriteLine("Enter Your Name : ");
            string name = Console.ReadLine();
            Console.WriteLine("Enter Your PIN : ");
            int.TryParse(Console.ReadLine(), out int pin);

            Console.WriteLine();
            user.FullName = name;
            user.PIN = pin;
            foreach (var item in users)
            {
                if((item.PIN == user.PIN)&&(item.FullName == user.FullName))
                {
                    user = item;
                    Console.WriteLine($"Welcome {user.FullName}....");
                    int option;
                    do
                    {
                        Options_Fuction.DisplayOprions();
                        int.TryParse(Console.ReadLine(), out option);
                        switch (option)
                        {
                            case 1:
                                Bank_Function.Deposit(user);
                                break;
                            case 2:
                                Bank_Function.WithDraw(user);
                                break;
                            case 3:
                                Bank_Function.GetBalance(user);
                                break;
                            case 4:
                                break;
                            default:
                                Console.WriteLine("Enter The Right Number");
                                break;
                        }

                    } while (option != 4);
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid User , Try Later.....");
                    break;
                }
            }
        }
    }
}
