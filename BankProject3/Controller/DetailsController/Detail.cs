using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BankProject3.Model;
using BankProject3.MyException;
using BankProject3.repositary;

namespace BankProject3.Controller.DetailsController
{
    public class Detail
    {
        public void addaccount()
        {
            int no, pass;
            String name;
            try
            {
                Console.Write("Enter Account No : ");
                no = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter Name       : ");
                name = Console.ReadLine();
                Console.Write("Enter PAssword   : ");
                pass = Convert.ToInt32(Console.ReadLine());

                Account a = new Account(name, no, pass);
                Records.addac(a);
                Console.WriteLine("\nAccount Stored....");
                Console.ReadKey();
                Console.Clear();
            }
            catch (Error e)
            {
                Console.WriteLine(e.ToString());
            }
        }
        public void removeaccount()
        {
            Console.Write("Enter the Account No   : ");
            int a = Convert.ToInt32(Console.ReadLine());
            if(Searchacount(a) == -1)    
                Console.WriteLine("\nAccount Not Removed....");
            else
                Records.removeac((Account)Records.Accounts[Searchacount(a)]);
            Console.ReadKey();
            Console.Clear();
        }

        public void checkbalance()
        {
            int no;
            Console.WriteLine("Enter the Account No   : ");
            no = Convert.ToInt32(Console.ReadLine());
        
            if (Searchacount(no) == -1)
                Console.WriteLine("\nAccount not found");
            else
                Console.WriteLine("Balance  : {0} ", ((Account)(Records.Accounts[Searchacount(no)])).acbalance);
            Console.ReadKey();
            Console.Clear();

        }

        public void showaccounts()
        {
            Console.WriteLine("---------------------------------------------------------------------");
            Console.WriteLine("                     Acount Details");
            Console.WriteLine("---------------------------------------------------------------------");
            for (int i = 0; i<Records.Accounts.Count; i++)
            {
                Console.WriteLine("Name : {0}     No : {1}     Balance : {2}", ((Account)(Records.Accounts[i])).acname, ((Account)(Records.Accounts[i])).acno, ((Account)(Records.Accounts[i])).acbalance);
            }
            Console.WriteLine("\n\n");
            Console.ReadKey();
            Console.Clear();
        }

       public void history()
        {
            Console.WriteLine("---------------------------------------------------------------------");
            Console.WriteLine("                     History Details");
            Console.WriteLine("---------------------------------------------------------------------");
            for (int i = 0; i < History.history.Count; i++)
            {
                Console.WriteLine("No : {0}     Name : {1}    Type : {2}    Amt : {3}", ((Account)(History.history[i])).acno, ((Account)(History.history[i])).acname, ((Account)(History.history[i])).type,((Account)(History.history[i])).acbalance);
            }
        
            Console.WriteLine("\n\n");
            Console.ReadKey();
            Console.Clear();
        }

        public int Searchacount(int ano)
        {
            Console.WriteLine(Records.Accounts.Count);
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
