using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM_Console
{
    internal class User
    {
        public int ID {  get; set; }
        public string FullName { get; set; }
        public double Balance { get; set; }
        public int PIN { get; set; }

        public User()
        {
        }
        public User(int _id, string _fullName, double _balance , int _pin)
        {
            this.ID = _id;
            this.FullName = _fullName;
            this.Balance = _balance;
            this.PIN = _pin;
        }
    }
}
