using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace yazMimariHomework1_2
{
    public class SistemYonetici : IKullanici, IOnay, IIlanIslemleri
    {
        public string yonetici_eposta { get; set; }
        public string yoneticiSifre { get; set; }

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

        public void OnayVerme()
        {
            //Todo
        }

        public void SistemeGirisYap()
        {
            //Todo
        }
    }
}
