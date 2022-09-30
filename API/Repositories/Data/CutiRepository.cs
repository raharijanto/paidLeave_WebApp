using API.Context;
using API.Models;
using API.Repositories.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Repositories.Data
{
    public class CutiRepository : ICutiRepository
    {
        MyContext myContext;

        public CutiRepository(MyContext myContext)
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

        public List<Cuti> Get()
        {
            var dataGet = myContext.Cuti.ToList();
            return dataGet;
        }

        public Cuti Get(int id)
        {
            var dataGet = myContext.Cuti.Find(id);
            return dataGet;
        }

        public int Post(Cuti cuti)
        {
            myContext.Add(cuti);
            var resultPut = myContext.SaveChanges();
            return resultPut;
        }

        public int Put(Cuti cuti)
        {
            var dataPut = Get(cuti.Id);
            dataPut.JumlahCuti = cuti.JumlahCuti;
            myContext.Update(dataPut);
            var resultPut = myContext.SaveChanges();
            return resultPut;
        }
    }
}
