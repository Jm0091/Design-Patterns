using System;
using System.Collections.Generic;
using System.Text;

namespace Problem4
{
    /// <summary>
    /// This Class simulates the Auction.
    /// This is class is the Subject class of of observer pattern.
    /// It starts an Auction for item for maximum of upto 5 bid and announce the highest bidder.
    /// </summary>
    public class Auctioneer
    {
        private List<IBidder> bidders;
        private Item currentItem;
        private double highestBid;
        private IBidder highestBidder;
        private int bidCount;
        private readonly int MAXIMUM_BID_COUNT = 5;

        public Auctioneer()
        {
            bidders = new List<IBidder>();
        }

        /// <summary>
        /// This method can be used to start auction for a particular item.
        /// IT will notify all the registerd user about the new item and intial price.
        /// </summary>
        /// <param name="item"></param>
        public void StartAuction(Item item)
        {
            currentItem = item;
            highestBid = item.InitialPrice;
            highestBidder = null;
            bidCount = 0;
            NotifyAll($"Auction Started for item {item.Name}, initial bid is {highestBid}");
        }

        /// <summary>
        /// This method can be used by bidders to bid an item.
        /// if the ammount is greater than the highest bid, new price will be set and all registerd bidder ill be notified of new price.
        /// if the limit of 5 maximum bid is reached the item will be sold to the highest bidder.
        /// </summary>
        /// <param name="amount">New price to bid for an time</param>
        /// <param name="bidder">bidder that is bidding for the item.</param>
        public void Bid(double amount, IBidder bidder)
        {
            if (currentItem != null)
            {
                if (bidder.getMaximumLimit() < amount)
                {
                    Console.WriteLine($"Not allowed to bid more than {bidder.getMaximumLimit()}");
                    return;
                }
                if (amount > highestBid)
                {
                    highestBid = amount;
                    highestBidder = bidder;
                    bidCount += 1;
                    if (bidCount == MAXIMUM_BID_COUNT)
                    {
                        currentItem.SoldPrice = highestBid;
                        NotifyAll($"Bidding for item {currentItem.Name} is Closed. It is sold to {highestBidder.getName()} at price {highestBid}");
                        UnRegisterBidder(highestBidder);
                        highestBid = 0;
                        highestBidder = null;
                        currentItem = null;
                    }
                    else
                    {
                        NotifyAll($"New Price for the {currentItem.Name} is {highestBid}");
                    }
                }
                else
                {
                    Console.WriteLine($"Please Bid higher than current bid: {highestBid}");
                }
            }
        }

        /// <summary>
        /// This mehod is used to register the bidder into an Auction.
        /// </summary>
        /// <param name="bidder">bidder interested to be registered in the Auction.</param>
        public void RegisterBidder(IBidder bidder)
        {
            bidders.Add(bidder);
        }

        /// <summary>
        /// This method can be used to UnRegister from the auction.
        /// </summary>
        /// <param name="bidder">bidder who wants to get unregister from the Auction</param>
        public void UnRegisterBidder(IBidder bidder)
        {
            bidders.RemoveAll(b => b.getName().Equals(bidder.getName()));
        }

        /// <summary>
        /// This method is used to notify each bidders with updates.
        /// </summary>
        /// <param name="announcment">message to be passed to all refistered bidder.</param>
        public void NotifyAll(string announcment)
        {
            bidders.ForEach(b => b.Notify(announcment));
        }

        public double getHighestBid() {
            return highestBid;
        }
    }
}
