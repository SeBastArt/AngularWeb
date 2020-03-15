using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AngularWeb.Models.Users
{
    public class UnauthorizedUserModel
    {
        public int ErrorCode { get; set; }
        public string ErrorMessage { get; set; }
    }
}
