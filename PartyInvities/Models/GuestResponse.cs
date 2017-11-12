using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PartyInvities.Models
{
    public class GuestResponse
    {
        [Required(ErrorMessage="Proszę podać i imię i nazwisko.")]
        public string Name { get; set; }
       
        public string Email { get; set; }
        public string Phone { get; set; }
        [Required(ErrorMessage = "Proszę określić, czy weźmiesz udział.")]
        public bool? WillAttend { get; set; }

    }
}