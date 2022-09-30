using API.Context;
using API.Models;
using API.Repositories.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Repositories.Data
{
    public class JabatanRepository : IJabatanRepository
    {
        MyContext myContext;

        public JabatanRepository(MyContext myContext)
        {
            this.myContext = myContext;
        }

        public int Delete(int id)
        {
            var dataPut = Get(id);
            myContext.Remove(dataPut);
            var resultPut = myContext.SaveChanges();
            return resultPut;
        }

        public List<Jabatan> Get()
        {
            var dataGet = myContext.Jabatan.ToList();
            return dataGet;
        }

        public Jabatan Get(int id)
        {
            var dataGet = myContext.Jabatan.Find(id);
            return dataGet;
        }

        public int Post(Jabatan jabatan)
        {
            myContext.Add(jabatan);
            var resultPut = myContext.SaveChanges();
            return resultPut;
        }

        public int Put(Jabatan jabatan)
        {
            var dataPut = Get(jabatan.Id);
            dataPut.Posisi = jabatan.Posisi;
            dataPut.SalaryId = jabatan.SalaryId;
            myContext.Update(dataPut);
            var resultPut = myContext.SaveChanges();
            return resultPut;
        }
    }
}
