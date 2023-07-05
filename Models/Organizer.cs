using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace NastaniMK_2023.Models
{
    public class Organizer
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [Display(Name = "Организатор")]
        public string Name { get; set; }
        [Required]
        [Display(Name = "Тип на организатор")]
        public OrganizerType OrganizerType { get; set; }
        [Required]
        [Display(Name="Веб страна")]
        public string OrganizerURL { get; set; }
        [Required]
        [Display(Name = "Опис")]
        public string Description { get; set; }
        [Required]
        public string Banner { get; set; }
        [Required]
        public string Email { get; set; }
        public virtual List<Event> Events { get; set; }

    }
}