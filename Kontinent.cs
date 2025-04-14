using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo
{
    public class Kontinent
    {
        private int KontinentID;
        private string Name;

        public int KontinentID1 { get => KontinentID; set => KontinentID = value; }
        public string Name1 { get => Name; set => Name = value; }

        public Kontinent(int id, string name)
        {
            KontinentID = id;
            Name = name;
        }
    }
}
