using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesafioProtesto.Models
{
    public interface IProtestoRepositorio
    {
        void Add(Protesto item);
        IEnumerable<Protesto> GetAll();
        Protesto Find(long key);
        void Remove(long key);
        void Update(Protesto item);
    }
}
