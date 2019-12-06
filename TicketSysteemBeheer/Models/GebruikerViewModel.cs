using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TicketSysteemBeheer.Models
{
    public class GebruikerViewModel
    {
        public string Id { get; set; }

        [EmailAddress]
        [Display(Name = "E-mail")]
        public string Email { get; set; }

        [StringLength(64)]
        [Required]
        public string Voornaam { get; set; }

        [StringLength(32)]
        public string Tussenvoegsel { get; set; }

        [StringLength(64)]
        [Required]
        public string Achternaam { get; set; }

        [StringLength(11)]
        public string Telefoonnummer { get; set; }
    }
}