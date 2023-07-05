using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace NastaniMK_2023.Models
{
    public class ContactModel
    {
        [Required]
        public string UserName { get; set; }
        [Required]
        public string OrganizationName { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public string Message { get; set; }
    }
}