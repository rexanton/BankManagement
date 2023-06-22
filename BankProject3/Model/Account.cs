using BankProject3.repositary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankProject3.Model
{
    public class Account
    {

        public int acno;
        public String acname;
        public int acbalance = 0;
        public int password;
        public String type;

        repositary.Records r=new repositary.Records();

        public Account(String name, int no, int password)
        {
            this.acno = no;
            this.acname = name;
            this.password = password;
        }
        public Account(int no,String name,String type,int bal)
        {
            this.acno = no;
            this.acname=name;
            this.type = type;
            this.acbalance = bal;
        }
    }
}
