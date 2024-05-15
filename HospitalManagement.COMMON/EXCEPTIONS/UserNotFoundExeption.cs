using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalManagement.COMMON.EXCEPTIONS
{
    public class UserNotFoundExeption : Exception
    {
        public string Message()
        {
            return "User not found";
        }
    }
}
