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
            List<Account> allAccounts = new List<Account>();
            allAccounts.Add(new Account("Oluwafemi Akinwale Ojetokun"));
            allAccounts.Add(new Account("Keenam Tambari Iseoluwa"));
            allAccounts.Add(new Account("Sennaike Gbotemi"));
            allAccounts.Add(new Account("Abdussalam Hameedat"));
            allAccounts.Add(new Account("Leoso Oluwadara"));
            allAccounts.Add(new Account("Emeka-Ofoma Ugonna Francis"));
            allAccounts.Add(new Account("Ikoyo Emmanuel Onoemena"));
            allAccounts.Add(new Account("Olumese Kelvin Ozeigbe"));
            allAccounts.Add(new Account("Odegbami Oluuwagbemiro"));
            allAccounts.Add(new Account("Boateng Joseph"));
            allAccounts.Add(new Account("Nwaekwu Davidmark"));

            foreach(var account in allAccounts)
            {
                account.DisplayAccountInfo();
                Console.WriteLine("\n\n");
            }
        }
    }
}
