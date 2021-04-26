using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace yazMimariHomework1_2
{
    public class Musteri : IKullanici, IIlanKarsilastir, IVitrinIlanlari
    {
        public string musteri_eposta { get; set; }
        public string musteriSifre { get; set; }

        public void IIlanKarsilastir()
        {
            //Todo
        }

        public void IlanArama()
        {
            //Todo
        }

        public void IlanGoruntule()
        {
            //Todo
        }

        public void SistemeGirisYap()
        {
            //Todo
        }
    }
}
