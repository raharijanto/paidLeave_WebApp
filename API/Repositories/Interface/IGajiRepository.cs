using API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Repositories.Interface
{
    interface IGajiRepository
    {
        List<Gaji> Get();

        Gaji Get(int id);

        int Post(Gaji gaji);

        int Put(Gaji gaji);

        int Delete(int id);
    }
}
