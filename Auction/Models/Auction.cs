using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Auction.Models
{
    public class Auction
    {
        public int AuctionID { get; set; }
        public Guid CompanyID { get; set; }
        public DateTime Start { get; set; }
        public DateTime Stop { get; set; }

        public ICollection<AuctionManifest> Manifests { get; set; }
        public Company Company { get; set; }
    }
}