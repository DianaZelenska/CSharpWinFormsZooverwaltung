using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo
{
    public class Tier
    {
        private int tierid;
        private string tierName;
        private string tierGeburtsjahr;
        private int tierGehege;
        private int tierTierart;

        public Tier(int tid, string tiername, string jahr, int tierge, int tierti)
        {
            tierid = tid;
            tierName = tiername;
            tierGeburtsjahr = jahr;
            tierGehege = tierge;
            tierTierart = tierti;
        }

        public int Tierid { get => tierid; set => tierid = value; }
        public string TierName { get => tierName; set => tierName = value; }
        public string TierGeburtsjahr { get => tierGeburtsjahr; set => tierGeburtsjahr = value; }
        public int TierGehege { get => tierGehege; set => tierGehege = value; }
        public int TierTierart { get => tierTierart; set => tierTierart = value; }
    }
}
