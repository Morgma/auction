using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Auction.Models
{
    public class Bid
    {
        public Guid UserID { get; set; }

        public string Amount { get; set; }
        public Guid AuctionItemID { get; set; }

        public int AuctionID { get; set; }

        public virtual User User { get; set; }
        public virtual Auction Auction { get; set; }
        public AuctionItem AuctionItem { get; set; }
    }
}