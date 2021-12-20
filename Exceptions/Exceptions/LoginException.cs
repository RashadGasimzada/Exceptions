using System;
using System.Collections.Generic;
using System.Text;

namespace Exceptions.Exceptions
{
    public class LoginException : Exception
    {
        public LoginException(string msj) : base(msj)
        {

        }
    }
}
