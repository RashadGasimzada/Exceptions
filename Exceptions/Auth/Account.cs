using Exceptions.Constants;
using Exceptions.Exceptions;
using System;
using System.Collections.Generic;
using System.Text;

namespace Exceptions.Auth
{
    public class Account
    {
        public void Login(string username, string password)
        {
            try
            {
                if (password.Length < 6)
                {
                    throw new LoginException(Messages.PasswordMessage);
                }
                Console.WriteLine("Login was success");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);                
            }
            
        }
    }
}
