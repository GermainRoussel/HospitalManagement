using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalManagement.COMMON.DTO
{
    public class UserRessource : EntityRessource
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDate { get; set; }
        public string Token { get; set; }
        public UserRessource()
        {
            
        }

    }
}
