using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo
{
    public class Datei
    {
        private string dateiName;

        public Datei(string dn)
        {
            dateiName = dn;
        }

        public void schreibeDatei(string was)
        {
            FileStream fs = new FileStream(
                dateiName,
                FileMode.Append,
                FileAccess.Write
                );
            StreamWriter sw = new StreamWriter(fs);

            sw.WriteLine(was);

            sw.Close();
            fs.Close();
        }
    }
}
