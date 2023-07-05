using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace NastaniMK_2023.Models
{
    public class BuyTicketModel
    {
        [Required]
        public string UserName { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        [Range(1,4, ErrorMessage = "Бројот на тикети не може да биде под 1 и не може да надминува 4.")]
        public int NumberOfTickets { get; set; }
        public int Price { get; set; }
        [Required]
        public string Contact { get; set; }
    }
}