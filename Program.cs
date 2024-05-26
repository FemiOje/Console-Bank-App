using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_Bank_App
{
    class Program
    {
        static void Main(string[] args)
        {
            Account account1 = new Account("Oluwafemi Akinwale Ojetokun");
            account1.DisplayAccountInfo();
        }
    }
}
