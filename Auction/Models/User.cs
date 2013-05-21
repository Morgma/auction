using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Auction.Models
{
    public class User
    {
        public Guid UserID { get; set; }
        public Guid CompanyID { get; set; }

        public string Email { get; set; }
        public string UserName { get; set; }

        //not sure on this....
        [MinLength(8)]
        public string Password { get; set; }

        public virtual Company Company { get; set; }
    }
}