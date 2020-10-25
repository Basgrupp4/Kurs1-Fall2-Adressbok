using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basgrupp5_Fall2
{
    public class Person
    {

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PhoneNumber1 { get; set; }
        public string PhoneNumber2 { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }


        public string EditFirst(string FirstName = "")
        {
            this.FirstName = FirstName;
            return FirstName;
        }

        public string EditFirst2(string LastName = "")
        {
            this.LastName = LastName;
            return LastName;
        }

        public string EditFirst3(string PhoneNumber1 = "")
        {
            this.PhoneNumber1 = PhoneNumber1;
            return PhoneNumber1;
        }

        public string EditFirst4(string PhoneNumber2 = "")
        {
            this.PhoneNumber2 = PhoneNumber2;
            return PhoneNumber2;
        }

        public string EditFirst5(string Address = "")
        {
            this.Address = Address;
            return Address;
        }

        public string EditFirst6(string Email = "")
        {
            this.Email = Email;
            return Email;
        }
    }
}
