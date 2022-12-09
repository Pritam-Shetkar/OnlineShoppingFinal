using Shopping.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shopping.Interface
{
   public interface IJWTMangerRepository
    {

      Tokens Authenticate(LoginViewModel users, bool IsRegister);
       // Tokens Authenticate(RegisterViewModel users, bool IsRegister);
    }
}
