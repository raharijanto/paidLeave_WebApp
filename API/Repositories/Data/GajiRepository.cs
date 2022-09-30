using API.Context;
using API.Models;
using API.Repositories.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Repositories.Data
{
    public class GajiRepository : IGajiRepository
    {
        MyContext myContext;

        public GajiRepository(MyContext myContext)
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

        public List<Gaji> Get()
        {
            var dataGet = myContext.Gaji.ToList();
            return dataGet;
        }

        public Gaji Get(int id)
        {
            var dataGet = myContext.Gaji.Find(id);
            return dataGet;
        }

        public int Post(Gaji gaji)
        {
            myContext.Add(gaji);
            var resultPut = myContext.SaveChanges();
            return resultPut;
        }

        public int Put(Gaji gaji)
        {
            var dataPut = Get(gaji.Id);
            dataPut.GajiAwal = gaji.GajiAwal;
            myContext.Update(dataPut);
            var resultPut = myContext.SaveChanges();
            return resultPut;
        }
    }
}
