using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BankProject3.Controller.TransactionController;
using BankProject3.Model;

namespace BankProject3.repositary
{
    public class History
    {
        public static ArrayList history=new ArrayList();
        public static void addhis(Account h)
        {
            history.Add(h);
        }
    }
}
