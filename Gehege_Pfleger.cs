using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo
{
    public class Gehege_Pfleger
    {
        private int gehPflID;
        private int gehegeid;
        private int pflegerid;
        private int hauptpfleger;

        public Gehege_Pfleger(int gp, int gid, int pflid, int hauptpfl)
        {
            gehPflID = gp;
            gehegeid = gid;
            pflegerid = pflid;
            hauptpfleger = hauptpfl;
        }

        public int Gehegeid { get => gehegeid; set => gehegeid = value; }
        public int Pflegerid { get => pflegerid; set => pflegerid = value; }
        public int Hauptpfleger { get => hauptpfleger; set => hauptpfleger = value; }
        public int GehPflID { get => gehPflID; set => gehPflID = value; }
    }
}
