using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SportsData.Models
{
    public partial class Sports_History
    {

        public int id { get; set; }
        public int sportId { get; set; }
        public int leagueId { get; set; }
        public string sportName { get; set; }
        public string abbreviation { get; set; }
        public DateTime UpdateTimeStamp { get; set; }

        public Sports_History(int sportId, int leagueId, string sportName, string abbreviation, DateTime UpdateTimeStamp) 
        {
            this.sportId = sportId;
            this.leagueId = leagueId;
            this.sportName = sportName;
            this.abbreviation = abbreviation;
            this.UpdateTimeStamp = UpdateTimeStamp;
        }

        public Sports_History()
        {
            id = id;
            sportId = sportId;
            leagueId = leagueId;
            sportName = sportName;
            abbreviation = abbreviation;
            UpdateTimeStamp = UpdateTimeStamp;
        }

    }
}
