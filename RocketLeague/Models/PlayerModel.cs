﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace RocketLeague.Models
{
    public class PlayerModel
    {
        [Display(Name = "Player ID")]
        public int playerId { get; set; }
        
        [Display(Name = "Name")]
        public string playerName { get; set; }

        [Display(Name = "Birthday")]
        public string  playerBirthDate { get; set; }

        [Display(Name = "Team")]
        public string  playerTeam { get; set; }

        [Display(Name = "Approx. Earnings")]
        public double playerEarnings { get; set; }

    }
}