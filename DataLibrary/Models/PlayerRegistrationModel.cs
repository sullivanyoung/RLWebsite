using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLibrary.Models
{
    public class PlayerRegistrationModel
    {
        public int Id { get; set; }
        public int playerId { get; set; }
        public string playerName { get; set; }
        public string userName { get; set; }
        public string playerBirthDate { get; set; }
        public string playerTeam { get; set; }
        public decimal playerEarnings { get; set; }
        public string system { get; set; }
        public string timeZone { get; set; }
        public int mmr { get; set; }

    }
}
