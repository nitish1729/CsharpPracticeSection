using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPsConcept
{
    /*
        Partial class
        partial class is a special feature of C#, it provides a special abillity to implement the functionality of a single 
        into multiple files and all these files are combined into a single class file when the application is compiled
     
        A partial class is created by using partial keyword
        A partial keyword can also be used to split a struct or an interface over two or more files.
     
        We use partial class when code of a class contain so many lines to manage. 
    */
    public class PartialClass
    {
        private string firstname;
        private string lastname;
        public string FirstName
        {
            get
            {
                return firstname;
            }
            set
            {
                firstname = value;
            }
        }
        public string LastName
        {
            set 
            {
                lastname = value;
            }
            get
            {
                return lastname;
            }
        }
        public string getfullname()
        {
            return firstname + " " + lastname;
        }
    }
}
