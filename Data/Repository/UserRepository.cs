using Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{


    public class UserRepository : RepositoryBase<User>
    {

        public UserRepository() { }

        public string getUserCodeByUserName(string name)
        {
            var user = GetAll().FirstOrDefault(x => x.FullName == name);
            if (user != null)
            {
                return user.MemberCode;
            }
            return "user not exist";
        }

        public bool checkUserCode(string code)
        {
            var user = GetAll().SingleOrDefault(x => x.MemberCode == code);
            if (user != null)
            {
                return true;
            }

            return false;
        }
    }
}
