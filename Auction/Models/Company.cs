﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Auction.Models
{
    public class Company
    {
        public Guid CompanyID { get; set; }
        public string Name { get; set; }
        public string PhoneNumber { get; set; }

        public string Address { get; set; }

        public virtual ICollection<User> Users { get; set; } 
    }
}