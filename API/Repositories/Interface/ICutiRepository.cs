using API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Repositories.Interface
{
    interface ICutiRepository
    {
        List<Cuti> Get();

        Cuti Get(int id);

        int Post(Cuti cuti);

        int Put(Cuti cuti);

        int Delete(int id);
    }
}
