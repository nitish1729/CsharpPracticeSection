using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace CSharpProgram
{
    public class RegexPract
    {
        //verify the user-entered mobile number then you can use regex. 
        public void Match()
        {
            string[] str = { "8252669501", "9852267614", "9925612824" };
            foreach (string s in str)
            {
                Console.WriteLine("{0} {1} a valid mobile number.", s,
                            isValidMobileNumber(s) ? "is" : "is not");
            }

            Console.ReadKey();
        }
        public static bool isValidMobileNumber(string inputMobileNumber)
        {
            string strRegex = @"(^[0-9]{10}$)|(^\+[0-9]{2}\s+[0-9]
                {2}[0-9]{8}$)|(^[0-9]{3}-[0-9]{4}-[0-9]{4}$)";

            // Class Regex Represents an
            // immutable regular expression.
            //   Format                Pattern
            // xxxxxxxxxx           ^[0 - 9]{ 10}$
            // +xx xx xxxxxxxx     ^\+[0 - 9]{ 2}\s +[0 - 9]{ 2}\s +[0 - 9]{ 8}$
            // xxx - xxxx - xxxx   ^[0 - 9]{ 3} -[0 - 9]{ 4}-[0 - 9]{ 4}$
            Regex re = new Regex(strRegex);

            // The IsMatch method is used to validate
            // a string or to ensure that a string
            // conforms to a particular pattern.
            if (re.IsMatch(inputMobileNumber))
                return (true);
            else
                return (false);
        }
        public void Match1()
        {
            // Input strings for Match
            // valid E-mail address.
            string[] str = {"parth@gmail.com",
                  "parthmaniyargmail.com",
                            "@gmail.com"};
            foreach (string s in str)
            {
                Console.WriteLine("{0} {1} a valid E-mail address.", s,
                                    isValidEmail(s) ? "is" : "is not");
            }
            Console.ReadLine();
            // Method to check the Email ID
            static bool isValidEmail(string inputEmail)
            {

                // This Pattern is use to verify the email
                string strRegex = @"\A(?:[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?)\Z";

                Regex re = new Regex(strRegex, RegexOptions.IgnoreCase);

                if (re.IsMatch(inputEmail))
                    return (true);
                else
                    return (false);
            }
        }
    }
}
