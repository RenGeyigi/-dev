using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yeni_Ödev
{
    internal class Personel
    {
        public Personel(string gAd, string gAdres, string gUnvan, int gYas, int gMesai)
        {
            this.Ad = gAd;
            this.Adres = gAdres;
            this.Yas = gYas;
            this.Mesai = gMesai;
            this.Unvan = gUnvan;
        }

        public Personel() { }

        public virtual int ucretHesapla()
        {
            return this.mesai * 1000;
        }





        string ad;

        public string Ad { get => ad; set => ad = value; }


        string adres;
        public string Adres { get => adres; set => adres = value; }


        string unvan;
        public string Unvan { get => unvan; set => unvan = value; }


        int yas;
        public int Yas { get => yas; set => yas = value; }


        int mesai;
        public int Mesai
        {
            get { return mesai; }
            set { mesai = value; }
        }

        public void ucretHesapla(int ekUcret)
        {

            MessageBox.Show((this.Mesai * 1000 + ekUcret).ToString());
        }

    }
}
