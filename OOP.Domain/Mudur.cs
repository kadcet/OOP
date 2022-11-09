using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Domain
{
    /* Mudur bir Memurdur. Memur bir Pesoneldir. Mudur hem Memur hem Personeldir*/

    public class Mudur :Memur,IEgitimVerebilir
    {
        // burdaki base Memur. Memur a gönderiyor.
        public Mudur(string ad):base(ad)  
        {

        }

        public List<string> EgitimYetkiAlanlari { set => throw new NotImplementedException(); }

        public string GetEgitimYetkileri()
        {
            throw new NotImplementedException();
        }
    }
}
