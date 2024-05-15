using HospitalManagement.COMMON.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalManagement.BUSINESS.USER
{
    public interface IUser
    {
        public UserRessource GetUserById(int id);
        public IEnumerable<UserRessource> GetAll();
        public void Add(UserRessource userRessource);
        public void Update(UserRessource userRessource);
        public void Delete(int id);
    }
}
