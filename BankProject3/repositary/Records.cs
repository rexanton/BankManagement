using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BankProject3.Controller.DetailsController;
using BankProject3.Model;
using BankProject3.Controller.TransactionController;

namespace BankProject3.repositary
{
    public class Records
    {


        public static ArrayList Accounts ;
          public Records()
         {
            if (Accounts == null)
            {
                Accounts = new ArrayList();
            }
          }

        public static void addac(Account account)
        {
            Accounts.Add(account);
        }
        public static void removeac(Account account)
        {
            Accounts.Remove(account);
        }
    }
}
