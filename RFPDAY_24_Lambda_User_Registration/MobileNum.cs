using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace RFPDAY_24_Lambda_User_Registration
{
    public class MobileNum
    {
        public string RegexMobile = "^91[ ][1-9][0-9]{9}$";
        public void MMoblie(string Mobile)
        {
            if(Regex.IsMatch(Mobile, RegexMobile))
                Console.WriteLine("Mobile Number is Valid");
            else
                Console.WriteLine("Mobile Number is Invalid");
        }
    }
}
