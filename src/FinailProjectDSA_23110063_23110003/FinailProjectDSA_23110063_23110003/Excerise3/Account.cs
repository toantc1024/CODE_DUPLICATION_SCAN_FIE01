using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BSTFinalProject
{
    public class Account
    {
        public int AccountID { get; set; }
        public string Name { get; set; }
        public decimal Balance { get; set; }

        public Account(int accountId, string name, decimal balance)
        {
            AccountID = accountId;
            Name = name;
            Balance = balance;
        }

        public override string ToString()
        {
            return $"ID: {AccountID}, Name: {Name}, Balance: {Balance:C}";
        }
    }

}
