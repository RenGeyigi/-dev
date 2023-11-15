using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yeni_Ödev
{
    internal class isci : Personel
    {

        string tur;
        public string Tur
        {
            get { return tur; }
            set => tur = value;
        }


        public isci(string gAd, string gAdres, int gYas, string gUnvan, int gMesai, string gTur)
        {
            this.Ad = gAd;
            this.Adres = gAdres;
            this.Yas = gYas;
            this.Unvan = gUnvan;
            this.Mesai = gMesai;
            this.Tur = gTur;
        }



        public override int ucretHesapla()
        {
            if (this.Tur == "Gündelik")
            { return this.Mesai * 1000; }
            return this.Mesai * 100 + 5000;

        }


    }
}
