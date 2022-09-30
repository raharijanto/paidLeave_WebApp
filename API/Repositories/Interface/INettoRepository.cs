using API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Repositories.Interface
{
    interface INettoRepository
    {
        List<Netto> Get();

        Netto Get(int id);

        int Post(Netto netto);

        int Put(Netto netto);

        int Delete(int id);
    }
}
