using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using BankProject3.Model;
using BankProject3.repositary;

namespace BankProject3.Controller.TransactionController
{
    public class Transaction
    {
        public void cashwidthdraw()
        {
            int c = 1;
            Console.Write("Enter the Account No : ");
            int no = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the Amount     : ");
            int amt = Convert.ToInt32(Console.ReadLine());
            Console.Write("ENter NAme           :");
            String name=Console.ReadLine();
            Console.Write("Enter the Password   : ");
            int pass = Convert.ToInt32(Console.ReadLine());
            Console.ReadKey();
            for (int i = 0; i < Records.Accounts.Count; i++)

                if (((Account)(Records.Accounts[i])).acno == no && ((Account)(Records.Accounts[i])).password == pass && ((Account)(Records.Accounts[i])).acbalance >= amt)
                {
                    ((Account)(Records.Accounts[i])).acbalance -= amt;
                    c = 0;
                    Account a = new Account(no, name, "Widthdraw", amt);
                    History.history.Add(a);
                }
            if (c == 1)
                Console.WriteLine("Invalid PAssword  (or)  InSufficient Amount  (or)  Invalid Account name ");
            Console.ReadKey();
            Console.Clear();
        }
        public void cashdeposit()
        {
            int c = 1;
            Console.Write("Enter the Account No     : ");
            int no = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the Deposit Amount : ");
            int amt = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter depositor namename : ");
            String name = Console.ReadLine();
            for (int i = 0; i < Records.Accounts.Count; i++)
            {
                if (((Account)(Records.Accounts[i])).acno == no)
                {
                    ((Account)(Records.Accounts[i])).acbalance += amt;
                    Console.WriteLine("\nAmount Deposited Succesfully..."); c = 0;
                    Account a = new Account(no, name, "Deposit", amt);
                    History.history.Add(a);
                    break;
                }
            }
            if (c == 1)
                Console.WriteLine("Invalid Account Name....Try Again !");
            Console.ReadKey();
            Console.Clear();
        }
        public int Searchacount(int ano)
        {
            for (int i = 0; i < Records.Accounts.Count; i++)
            {
                if (((Account)(Records.Accounts[i])).acno != ano)
                    continue;

                else if (((Account)(Records.Accounts[i])).acno == ano)
                    return i;
            }
            return -1;
        }

    }
}
