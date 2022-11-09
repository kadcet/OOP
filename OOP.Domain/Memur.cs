using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Domain
{
    public class Memur :Personel
    {
        // eğer base classın yani Personel in yapıcı metodunda parametre ile değer istersek buurayada yapıcı metod yapıcaz
        // name değişkenine aldığım değeri üst sınıfa gönder.Yani Personelin yapıcı metoduna gönder
        public Memur(string _name):base(_name)  
        {

        }

        public byte Kidem { get; set; }

        public override double IkramiyeHesapla()
        {
            return Maas * Kidem;     // Burda müdahale ediyoruz. burda böyle hesapla
        }
    }
}
