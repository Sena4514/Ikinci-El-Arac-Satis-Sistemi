using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace yazMimariHomework1_2
{
    public class OracleIkinciElAracSistemi : DBIkinciElAracSistemi
    {
        public override void Baglan()
        {
            Console.Write("Oracle'a Baglan");
        }

        public override void Sorgula()
        {
            Console.Write("PL-SQL");
        }
    }
}
