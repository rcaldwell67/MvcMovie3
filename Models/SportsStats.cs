using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SportsData.Models
{
    public partial class SportsStats
    {
        public int Id { get; set; }
        public int sportId { get; set; }
        public int teamId { get; set; }
        public string name { get; set; }

        [Column(TypeName = "decimal(18,4)")]
        public decimal value { get; set; }

        public string statHash { get; set; }

        public SportsStats(int sportId, int teamId, string name, decimal value, string statHash)
        {
            this.sportId = sportId;
            this.teamId = teamId;
            this.name = name;
            this.value = value;
            this.statHash = statHash;
        }

        public SportsStats()
        {
            this.Id = Id;
            this.sportId = sportId;
            this.teamId = teamId;
            this.name = name;
            this.value = value;
            this.statHash = statHash;
        }
    }
}
