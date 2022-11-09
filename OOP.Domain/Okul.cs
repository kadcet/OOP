using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Domain
{
    public class Okul
    {
        public Okul()
        {
            Okul o = new Okul();
            Mudur m = new Mudur("Ahmet"); // en üst sınıfa kadar gidecek
            
            Egitmen e = new Egitmen();
            
            
            

            o.PersonelRaporu(m);
            o.PersonelRaporu(e);

            Personel p = new Egitmen();


            Sekreter s = new Sekreter("Ayşe");
            List<IEgitimVerebilir> list = new List<IEgitimVerebilir>();
            list.Add(m);
            list.Add(e);
            o.EgitimcilerRaporu(list);
            //list.Add(s);
            //o.EgitimcilerRaporu(s);  // sekreter veremem çünkü IEgitimVerebilir i implemente etmiyor


        }

        public string PersonelRaporu(Personel p)
        {
            return $"{p.Ad} {p.Soyad} {p.Maas} {p.IkramiyeHesapla()}";
            // Tüm personellerin ad,soyad,maaş ve ikramiye bilgisi string olarak dönülür
        }

        public void EgitimcilerRaporu(List<IEgitimVerebilir> liste)
        {
            foreach (var item in liste)
            {
                var x = item.GetEgitimYetkileri();
            }
        }






        // eğitim verebilen herkes buraya liste olarak gelsin. Herkesin eğitim yetkilerini toplayım değişkenin içine
        //public void EgitimcilerRaporu(List<IEgitimVerebilir> liste)
        //{

        //}
    }
}
