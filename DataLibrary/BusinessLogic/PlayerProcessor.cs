using DataLibrary.DataAccess;
using DataLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLibrary.BusinessLogic
{
    public static class PlayerProcessor
    {
        public static int CreatePlayer(string PlayerName, string UserName, string PlayerBirthDate, 
            string PlayerTeam, decimal PlayerEarnings, string System, string TimeZone, int Mmr)
        {
            PlayerRegistrationModel data = new PlayerRegistrationModel
            {
                playerName = PlayerName,
                userName = UserName,
                playerBirthDate = PlayerBirthDate,
                playerTeam = PlayerTeam,
                playerEarnings = PlayerEarnings,
                system = System,
                timeZone = TimeZone,
                mmr = Mmr
            };

            string sql = @"insert into dbo.Player (playerName, userName, playerBirthdate, playerTeam, playerEarnings, system, timeZone, mmr)
                            values (@playerName, @userName, @playerBirthdate, @playerTeam, @playerEarnings, @system, @timeZone, @mmr)";

            return SQLDataAccess.SaveData(sql, data);
        }

        public static List<PlayerRegistrationModel> LoadPlayers()
        {
            string sql = @"select playerName, userName, playerBirthdate, playerTeam, playerEarnings, system, timeZone, mmr
                           from dbo.Player;";

            return SQLDataAccess.LoadData<PlayerRegistrationModel>(sql);
        }
    }
}
