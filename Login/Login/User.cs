using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Login
{
    public class User
    {
        private string firstName;
        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }
        private string lastName;
        public string LastName
        {
            set { lastName = value; }   
            get { return lastName; }
        }
        private string mail;
        public string Mail
        {
            get { return mail; }
            set { mail = value; }
        }
        public User(string firstname,string lastname,string mail)
        {
            this.firstName = firstname;
            this.lastName = lastname;
            this.mail = mail;   

        }
    }
}
