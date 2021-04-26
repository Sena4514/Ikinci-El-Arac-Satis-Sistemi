using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace yazMimariHomework1_2
{
    public class AracSahibi : IKullanici, IIlanIslemleri
    {
        public string aracSahibiAdi { get; set; }
        public string aracSahibiSoyadi { get; set; }
        public string aracSahibi_email { get; set; }
        public string aracSahibiSifre { get; set; }

        public void IlanDuzenleme()
        {
            //Todo
        }

        public void IlanEkleme()
        {
            //Todo
        }

        public void IlanKaldirma()
        {
            //Todo
        }

        public void IlanSilme()
        {
            //Todo
        }

        public void SistemeGirisYap()
        {
            //Todo
        }
    }
}
