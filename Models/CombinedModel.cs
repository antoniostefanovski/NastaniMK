using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Reflection;
using System.Web;

namespace NastaniMK_2023.Models
{
    public class CombinedModel
    {
        public string EventName { get; set; }
        public int EventId { get; set; }
        public BuyTicketModel BuyTicketModel { get; set; }

        public decimal TotalPrice => BuyTicketModel.Price * BuyTicketModel.NumberOfTickets;
    }
}