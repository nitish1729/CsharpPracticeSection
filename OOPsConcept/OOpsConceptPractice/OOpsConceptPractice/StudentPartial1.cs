using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPsConcept
{
    public partial class StudentPartial
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
    }
}
