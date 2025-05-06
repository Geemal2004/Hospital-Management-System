using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalManagementSystem.Entities
{
    public class UserContext
    {
        public string UserName { get; set; }
        public string Role { get; set; }

        public UserContext(User user)
        {
            UserName = user.UserName;
            Role = user.Role;
        }
    }
}
