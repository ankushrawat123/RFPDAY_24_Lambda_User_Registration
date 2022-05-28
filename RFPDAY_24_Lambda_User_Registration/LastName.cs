using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace RFPDAY_24_Lambda_User_Registration
{
    public class LastName
    {
        public void MLastName(string name)
        {
            string regex_LastName = "^[A-Z][A-Z a-z 0-9 !@#$%&*?]{2,}$";
            if(Regex.IsMatch(regex_LastName,name))
            {
                Console.WriteLine("Valid");
            }
            else
            {
                Console.WriteLine("Invalid");
            }
        }
    }
}
