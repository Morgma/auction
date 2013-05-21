using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Auction.Models
{
    public class AuctionItem
    {
        public Guid AuctionItemID { get; set; }
        public string StartingBid { get; set; }
        public string Photo { get; set; }
        public string Description { get; set; }
    }
}