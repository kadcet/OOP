using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Domain
{
    public class Sozlesmeli :Personel
    {
        public byte SozlesmeSuresi { get; set; }

        public override double IkramiyeHesapla()
        {
            return base.IkramiyeHesapla();

        }

        //public override double IkramiyeHesapla()
        //{
        //    // base nin anlamı benim kalıtım yaptığım sınıf demek. Personel deki metod bu
        //    // Personel.IkramiyeHesapla   gibi

        //    // Örneğin şu şekildede hesaplama yapılabilir. burda personeldeki gibi maaş*2.5 katı hesapla VE 500 tl ilave et gibi  
        //    
        //    //return Maas*SozlesmeSuresi

        //}
    }
}
