using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Auction.Models
{
    public class AuctionManifest
    {
        public int AuctionID { get; set; }
        public Guid AuctionItemID { get; set; }

        public Auction Auction { get; set; }
        public AuctionItem AuctionItem { get; set; }
    }
}