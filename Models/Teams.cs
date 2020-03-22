using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MvcMovie.Models
{
    public partial class Teams
    {
        public int Id { get; set; }
        public int teamId { get; set; }
        public int sportId { get; set; }
        public string location { get; set; }
        public string name { get; set; }
        public string abbreviation { get; set; }
        
        [Display(Name = "Team")]
        public string displayName { get; set; }
        
        public bool isActive { get; set; }
        
        [Column(TypeName = "decimal(18,4)")]
        public decimal? avgPointsAgainst { get; set; }

        [Column(TypeName = "decimal(18,4)")]
        public decimal? avgPointsFor { get; set; }

        [Column(TypeName = "decimal(18,4)")]
        public decimal? gamesBehind { get; set; }

        [Column(TypeName = "decimal(18,4)")]
        public decimal? gamesPlayed { get; set; }

        [Column(TypeName = "decimal(18,4)")]
        public decimal? homeLosses { get; set; }

        [Column(TypeName = "decimal(18,4)")]
        public decimal? homeTies { get; set; }

        [Column(TypeName = "decimal(18,4)")]
        public decimal? homeWins { get; set; }

        [Column(TypeName = "decimal(18,4)")]
        public decimal? leagueWinPercent { get; set; }

        [Display(Name = "Losses")]
        [Column(TypeName = "decimal(18,4)")]
        public decimal? losses { get; set; }

        [Column(TypeName = "decimal(18,4)")]
        public decimal? OTWins { get; set; }

        [Column(TypeName = "decimal(18,4)")]
        public decimal? OTLosses { get; set; }

        [Column(TypeName = "decimal(18,4)")]
        public decimal? playoffSeed { get; set; }

        [Column(TypeName = "decimal(18,4)")]
        public decimal? pointDifferential { get; set; }

        [Column(TypeName = "decimal(18,4)")]
        public decimal? pointsAgainst { get; set; }

        [Column(TypeName = "decimal(18,4)")]
        public decimal? pointsDiff { get; set; }

        [Column(TypeName = "decimal(18,4)")]
        public decimal? pointsFor { get; set; }

        [Column(TypeName = "decimal(18,4)")]
        public decimal? roadLosses { get; set; }

        [Column(TypeName = "decimal(18,4)")]
        public decimal? roadTies { get; set; }

        [Column(TypeName = "decimal(18,4)")]
        public decimal? roadWins { get; set; }

        [Column(TypeName = "decimal(18,4)")]
        public decimal? rotWins { get; set; }

        [Display(Name = "Streak")]
        [DisplayFormat(DataFormatString = "{0:N0}", ApplyFormatInEditMode = true)]
        [Column(TypeName = "decimal(18,4)")]
        public decimal? streak { get; set; }

        [Column(TypeName = "decimal(18,4)")]
        public decimal? ties { get; set; }

        [Display(Name = "Win %")]
        [DisplayFormat(DataFormatString = "{0:P2}")]
        [Column(TypeName = "decimal(18,4)")]
        public decimal? winPercent { get; set; }

        [Display(Name = "Wins")]
        [Column(TypeName = "decimal(18,4)")]
        public decimal? wins { get; set; }
        
        public string? statHash { get; set; }

        [Display(Name = "Win%")]
        [DisplayFormat(DataFormatString = "{0:P2}")]
        [Column(TypeName = "decimal(18,4)")]
        public decimal? winPct { get; set; }

        public Teams(int teamId, int sportId, string location, string name, string abbreviation, string displayName, bool isActive)
        {
            this.teamId = teamId;
            this.sportId = sportId;
            this.location = location;
            this.name = name;
            this.abbreviation = abbreviation;
            this.displayName = displayName;
            this.isActive = isActive;

        }

        public Teams()
        {
            Id = Id;
            teamId = teamId;
            sportId = sportId;
            location = location;
            name = name;
            abbreviation = abbreviation;
            displayName = displayName;
            isActive = isActive;
            avgPointsAgainst = avgPointsAgainst;
            avgPointsFor = avgPointsFor;
            gamesBehind = gamesBehind;
            gamesPlayed = gamesPlayed;
            homeLosses = homeLosses;
            homeTies = homeTies;
            homeWins = homeWins;
            leagueWinPercent = leagueWinPercent;
            losses = losses;
            OTLosses = OTLosses;
            OTWins = OTWins;
            playoffSeed = playoffSeed;
            pointDifferential = pointDifferential;
            pointsAgainst = pointsAgainst;
            pointsDiff = pointsDiff;
            pointsFor = pointsFor;
            roadLosses = roadLosses;
            roadTies = roadTies;
            roadWins = roadWins;
            rotWins = rotWins;
            streak = streak;
            ties = ties;
            winPercent = winPercent;
            wins = wins;
            statHash = statHash;
        }
    }
}
