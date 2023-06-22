using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankProject3.MyException
{
    internal class Error : Exception
    {
        public Error(String msg) : base(msg) { }
    }
}
