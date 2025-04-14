using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo
{
    public class Pfleger
    {
        private int pflegerID;
        private string pflegerVorname;
        private string pflegerNachname;

        public Pfleger(int pflid, string vorn, string nachn)
        {
            pflegerID = pflid;
            pflegerVorname = vorn;
            pflegerNachname = nachn;
        }

        public int PflegerID { get => pflegerID; set => pflegerID = value; }
        public string PflegerVorname { get => pflegerVorname; set => pflegerVorname = value; }
        public string PflegerNachname { get => pflegerNachname; set => pflegerNachname = value; }
    }
}
