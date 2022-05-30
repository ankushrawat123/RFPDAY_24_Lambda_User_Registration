using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace RFPDAY_24_Lambda_User_Registration
{
    public class Email
    {//enter a valid email - E.g. abc.xyz@bl.co.in - Email has 3 mandatory parts (abc, bl & co) and 2 optional(xyz & in) with precise @ and.positions
        public string RegexEmail = "^[A-Z a-z 0-9]+([.][a-z A-Z 0-9]+)?[@][a-z A-Z 0-9]+[.][a-z]{2,3}([a-z]{2})?";
        public void MEmail(string Email)
        {
            if (Regex.IsMatch(Email, RegexEmail))
            {
                Console.WriteLine("Email is Valid");
            }
            else
            {
                Console.WriteLine("Email is invalid");
            }
        }
    }
}
