using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo
{
    public class Gehege
    {
        private int gehegeID;
        private string gehegeName;
        private int gehegeKontinent;
        public Gehege(int gid, string name, int gKont)

        {
            gehegeID = gid;
            gehegeName = name;
            gehegeKontinent = gKont;
        }

        public int GehegeID { get => gehegeID; set => gehegeID = value; }
        public string GehegeName { get => gehegeName; set => gehegeName = value; }
        public int GehegeKontinent { get => gehegeKontinent; set => gehegeKontinent = value; }
    }
}
