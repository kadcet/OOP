using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Domain
{
    /*Abstract : Türetilemez fakat kalıtım alınabilir */
    public abstract class Personel
    {
        public Personel(string _ad)
        {
            Ad = _ad;


            //Ad = "ahmet";
            // bunu yaparsam Personelden kalıtım olanların hepsinin ad değerleri Ahmet olacak
        }


        public string Ad { get; set; }

        public string Soyad { get; set; }

        public string TCNO { get; set; }

        public double Maas { get; set; }

        public DateTime IseBaslamaTarihi { get; set; }

        /*** virtual metod için abstract class ın içinde olmak zorunda DEĞİLİZ. */


        //public virtual double IkramiyeHesapla()
        //{
        //    return Maas * 2.5;
        //}

        public abstract double IkramiyeHesapla();


        // Personeli kalıtım alan herkes yöntemi kendisi yazacak
        // burda neye karar veriyorum. 
        // IkramiyeHesapla isminde bir metod olacak şu parametreleri kullanacak veya parametresiz olacak
        // bu metod geriye double tipinde dönecek
        // bu metod için bir gövde yazmıyorum.
        // Abstract bir metod yazabilmek için Abstract bir sınıfın içinde olmak ZORUNDAYIZ

    }
}
