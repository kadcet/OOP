using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Domain
{

    // eğitmenler eğitim verebilme yetkisine sahip olsunlar
    // eğitim yetki alanı diye birşey olsun eğitmenlerin ve eğitim verebilecek hangi personeller varsa
    // mesela müdürler,stajerler,eğitmenler. Üçüde eğitim verebilir olsun. Ama Sekreter EĞİTİM VEREMESİN
    public class StajerEgitmen : IEgitimVerebilir
    {
        public byte StajSuresi { get; set; }
        
        public List<string> IEgitimYetkiAlanlari { set => throw new NotImplementedException(); }

        public string GetEgitimYetkileri()
        {
            throw new NotImplementedException();
        }
    }
}
