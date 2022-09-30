using API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Repositories.Interface
{
    interface IJabatanRepository
    {
        List<Jabatan> Get();

        Jabatan Get(int id);

        int Post(Jabatan jabatan);

        int Put(Jabatan jabatan);

        int Delete(int id);
    }
}
