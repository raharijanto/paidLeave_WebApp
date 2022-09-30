using API.Context;
using API.Models;
using API.Repositories.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Repositories.Data
{
    public class NettoRepository : INettoRepository
    {
        MyContext myContext;

        public NettoRepository(MyContext myContext)
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

        public List<Netto> Get()
        {
            var dataGet = myContext.Netto.ToList();
            return dataGet;
        }

        public Netto Get(int id)
        {
            var dataGet = myContext.Netto.Find(id);
            return dataGet;
        }

        public int Post(Netto netto)
        {
            myContext.Add(netto);
            var resultPut = myContext.SaveChanges();
            return resultPut;
        }

        public int Put(Netto netto)
        {
            var dataPut = Get(netto.Id);
            dataPut.GajiBersih = netto.GajiBersih;
            dataPut.GajiId = netto.GajiId;
            dataPut.CutiId = netto.CutiId;
            myContext.Update(dataPut);
            var resultPut = myContext.SaveChanges();
            return resultPut;
        }
    }
}
