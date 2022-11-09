using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Domain
{
    /* eğitmen bir Sözleşmelidir. Sözleşmeli bir Personel dir. Eğitmen hem Sözleşmeli hemde Personeldir */
    public class Egitmen :Sozlesmeli,IEgitimVerebilir
    {
        public string Brans { get; set; }
        public List<string> EgitimYetkiAlanlari { set => throw new NotImplementedException(); }

        public string GetEgitimYetkileri()
        {
            throw new NotImplementedException();
        }
    }
}
