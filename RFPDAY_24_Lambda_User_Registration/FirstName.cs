using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace RFPDAY_24_Lambda_User_Registration
{
    public class FirstName
    {
        public void MFirstName (string Name)
        {
           string RegexValid = "^[A-Z][A-z a-z 0-9 $#@!^&*?]{2,}$";
           if (Regex.IsMatch(RegexValid, Name))
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
