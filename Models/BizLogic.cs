using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcMovie.Models
{
    public class BizLogic
    {
        public static decimal? winPct = 0;
        //Team Win% =>600
        //After Four Ws in a row bet against them

        //Team Win% 500>599 
        //After Three Ws in a row bet against them

        //Team Win% 400>499 
        //After Two Ls in a row bet for them

        //Get Win Pct
        public decimal? GetWinPct(Teams team)
        {
            
            winPct = team.losses - team.wins;

            return winPct;
        }
    }
}
