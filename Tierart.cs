using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo
{
    public class Tierart
    {
        private int TierartID;
        private string TierartName;

        public int TierartID1 { get => TierartID; set => TierartID = value; }
        public string TierartName1 { get => TierartName; set => TierartName = value; }

        public Tierart(int tierartid, string tierart)
        {
            TierartID = tierartid;
            TierartName = tierart;
        }

    }
}
