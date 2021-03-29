using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ScoreTracker.Models
{
    public class Inning
    {
        public Inning() { Runs = 0; Wickets = 0; Overs = 0.0; }

        public double Overs { get; set; }

        public int TotalOvers { get; set; }

        public int Players { get; set; }

        public int Runs { get; set; }

        public int Wickets { get; set; }
    }
}
