using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoginLibros.negocio
{
    class LoginService
    {
        string usernameValido = "Karen";
        string passwordValido = "karen123";


        public bool check(string username, string password)
        {
            if (usernameValido == username &&
                passwordValido == password)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}

