using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yeni_Ödev
{
    internal class muhendis : Personel
    {
        string birim;

        public string Birim
        {
            get { return birim; }
            set => birim = value;
        }

        public muhendis() { }
        public override int ucretHesapla()
        {
            if (this.birim == "Üretim")
            { return this.Mesai * 1000; }
            return this.Mesai * 100 + 5000;

        }
        public muhendis(string gAd, string gAdres, int gYas, string gUnvan, int gMesai, string gBirim)
        {
            this.Ad = gAd;
            this.Adres = gAdres;
            this.Yas = Convert.ToInt32(gYas);
            this.Unvan = gUnvan;
            this.Mesai = Convert.ToInt32(gMesai);
            this.Birim = gBirim;
        }


    }
}
