using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace NastaniMK_2023.Models
{
    public class Event
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [Display(Name = "Настан")]
        public string Name { get; set; }
        [Required]
        [Display(Name = "Датум")]
        public string Date { get; set; }
        [Required]
        [Display(Name = "Време")]
        public string Time { get; set; }
        [Required]
        [Display(Name = "Локација")]
        public string Location { get; set; }
        [Display(Name = "Град")]
        [Required]
        public string City { get; set; }
        [Display(Name = "Карти")]
        [Required]
        public string Tickets { get; set; }
        [Required]
        [Display(Name = "Слика")]
        public string ImageURL { get; set; }
        [Required]
        [Display(Name = "Организатор")]
        public int OrganizerId { get; set; }
        public virtual Organizer Organizer { get; set; }
    }
}