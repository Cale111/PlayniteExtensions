using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SteamLibrary.Models
{
    public class FamilyGroupInformation
    {
        public class Response
        {
            public string family_groupid;
            public bool is_not_member_of_any_group;
        }
        
        public Response response;
    }
}
