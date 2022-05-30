// See https://aka.ms/new-console-template for more information
using RFPDAY_24_Lambda_User_Registration;
Console.WriteLine("Welcome to Lambda Registration Program");
Console.WriteLine("Enter \n1 FOR FIRSTNAME REGEX \n2 FOR LASTNAME REGEX \n3 FOR EMAIL REGEX \n4 FOR MOBILE NUMBER REGEX");
int num = Convert.ToInt32(Console.ReadLine());
switch (num)
{
    case 1:
        FirstName obj1 = new FirstName();
        obj1.MFirstName("Ankush");
        break;

    case 2:
        LastName obj2 = new LastName();
        obj2.MLastName("Rawat");
        break;

    case 3:
        Email obj3 = new Email();
        obj3.MEmail("abc.xyz@bl.co.in");
        break;

    case 4:
        MobileNum obj4 = new MobileNum();
        obj4.MMoblie("91 9812345605");
        break;
}
