using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPCalisma2
{
    class Program
    {
        static void Main(string[] args)
        {
            kullanici k1 = new kullanici();
            k1.AdSoyad = "Abdullah Balbazar";
            k1.E_posta = "Abalbazar@hotmail.com";
            k1.Telefon = "0535-588-85-85";

            sigorta s1 = new sigorta();
            s1.sigorta_numarası = "125786";
            s1.sigorta_bitis_tarihi = "20.12.2040";

            araba a1 = new araba();
            a1.marka = marka.AlfaRomeo.ToString();
            a1.iilanno = "0039124612";
            a1.ikullanici = "Abuzer Kadayıf";
            a1.model = "Giulietta";
            a1.iilantarihi = "19.08.2019";
            a1.sigorta = s1;
            a1.kullanici = k1;



            Console.WriteLine($"Kullanıcı adı: {k1.AdSoyad}\nKullanıcı Epostası: {k1.E_posta}\nKullanıcı Telefonu: {k1.Telefon}\n\nAraç Bilgileri;\nAraba Markası: {a1.marka}\nAraba Modeli: {a1.model}\nAraç İlan No: {a1.iilanno}\nAraç İlan Tarihi: {a1.iilantarihi}\nAracın Sahibi: {a1.ikullanici}\n\nSigorta Bilgileri\nAracın Sigorta Numarası: {s1.sigorta_numarası}\nAracın Sigorta Bitiş Tarihi: {s1.sigorta_bitis_tarihi} \n\nKullanıcı adı: {a1.kullanici.AdSoyad}");

            Console.Read();
        }
    }
    interface ivasita
    {
        string marka { get; set; }
        string model { get; set; }
    }
    interface iialn
    {
        string iilanno { get; set; }
        string iilantarihi { get; set; }
        string ikullanici { get; set; }
        kullanici kullanici { get; set; }
    }
    public class sigorta
    {
        public string sigorta_numarası;
        public string sigorta_bitis_tarihi;
    }
    public class kullanici
    {
        public string AdSoyad;
        public string E_posta;
        public string Telefon;
    }

    enum marka
    {
        Opel, Mercedes, BMW, Audi, Porche, AlfaRomeo, Wolswogen, Tofaş, Anadol, Devrim
    }
    enum vites
    {
        düz, otomatik
    }
    enum Yakittipi
    {
        dizel, benzin
    }
    enum kasatipi
    {
        Sedan, Hp
    }
    enum renk
    {
        mavi, kırmızı, sari, siyah, gri, beyaz, pembe, mor
    }
    class araba : ivasita, iialn
    {
        public string iilanno { get; set; }
        public string iilantarihi { get; set; }
        public string ikullanici { get; set; }
        public string marka { get; set; }
        public string model { get; set; }
        public kullanici kullanici { get; set; }
        string yakittipi;
        string Vites;
        int KiloMetre;
        string kasatipi;
        double motorhacmi;
        string renk;
        public sigorta sigorta;
        string yıl;
        string çekiş;
    }
}
