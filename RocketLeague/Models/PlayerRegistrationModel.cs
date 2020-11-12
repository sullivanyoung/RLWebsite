using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace RocketLeague.Models
{
    public class PlayerRegistrationModel
    {
        [Display(Name = "Full Name")]
        [Required(ErrorMessage = "You must enter your full name")]
        public string playerName { get; set; }

        [Display(Name = "Username")]
        [Required(ErrorMessage = "You must enter a username")]
        public string userName { get; set; }

        [Display(Name = "Birthdate")]
        [DataType(DataType.Date)]
        [Required(ErrorMessage = "You must enter a birthdate")]
        public string playerBirthdate { get; set; }

        [Display(Name = "Team")]
        [Required(ErrorMessage = "You must enter a Team name")]
        public string playerTeam { get; set; }

        [Display(Name = "Approx. Earnings")]
        [DataType(DataType.Currency)]
        [Required(ErrorMessage = "You must enter your total earnings")]
        public decimal playerEarnings { get; set; }

        [Display(Name = "System")]
        [Required(ErrorMessage = "You must enter a your system")]
        public string system { get; set; }

        [Display(Name = "Time Zone")]
        [Required(ErrorMessage = "You must enter your time zone")]
        public string timeZone { get; set; }

        [Display(Name = "Peak MMR")]
        [Range(1, 2500, ErrorMessage = "You need to enter valid mmr")]
        public int mmr { get; set; }


    }
}