using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace yazMimariHomework1_2
{
    public class SqlIkinciElAracSistemi : DBIkinciElAracSistemi
    {
        public override void Baglan()
        {
            Console.Write("Sql'e Baglan");
        }

        public override void Sorgula()
        {
            Console.Write("T-SQL");
        }
    }
}
