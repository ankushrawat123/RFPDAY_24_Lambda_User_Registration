using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace RFPDAY_24_Lambda_User_Registration
{
    public class PasswordMin8Char
    {
        public string RegexPassword = "^[A-Z a-z 0-9]{8,}$";
        public void Password8Char(string pwd)
        {
            if (Regex.IsMatch(RegexPassword, pwd))
                Console.WriteLine("Minimum 8 Char Password is Valid");
            else
                Console.WriteLine("Minimum 8 char Password is InValid");
        }
    }
}
