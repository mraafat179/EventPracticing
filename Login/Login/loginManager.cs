using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Login
{
    public class loginManager
    {
        public delegate void Handler(User user);
        public event Handler UserLoginSuccesful;
        public void loginUser(User user)
        {
            if(!user.Mail.EndsWith("@example.com"))
                return;
            OnUserLoginSuccessful(user);
        }
        public void OnUserLoginSuccessful(User user)
        {
            if (UserLoginSuccesful != null)
                UserLoginSuccesful.Invoke(user);
        }
    }
}
