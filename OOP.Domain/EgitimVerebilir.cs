using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Domain
{
    public interface IEgitimVerebilir
    {
        List<string> IEgitimYetkiAlanlari { set; }

        string GetEgitimYetkileri();
    }
}
