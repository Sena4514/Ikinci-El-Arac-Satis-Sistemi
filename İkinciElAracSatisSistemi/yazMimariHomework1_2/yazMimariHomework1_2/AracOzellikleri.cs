using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace yazMimariHomework1_2
{
    public class AracOzellikleri
    {
        public string aracTuru { get; set; }
        public DateTime aracUretimYili { get; set; }
        public string aracMarka { get; set; }
        public int aracModel { get; set; }
        public string aracYakitTuru { get; set; }
        public int aracMotor { get; set; }
        public string aracSanziman { get; set; }
        public int aracKilometre { get; set; }
        public int aracSatisFiyati { get; set; }
        public string aracResimleri { get; set; }
        public bool sisFari { get; set; }
        public bool katlanabilirAyna { get; set; }
        public bool parkSensoru { get; set; }
        public bool merkeziKilit { get; set; }
        public bool camTavan { get; set; }
    }
}
