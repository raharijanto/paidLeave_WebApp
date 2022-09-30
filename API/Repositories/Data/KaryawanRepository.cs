using API.Context;
using API.Models;
using API.Repositories.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Repositories.Data
{
    public class KaryawanRepository : IKaryawanRepository
    {
        MyContext myContext;

        public KaryawanRepository(MyContext myContext)
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

        public List<Karyawan> Get()
        {
            var dataGet = myContext.Karyawan.ToList();
            return dataGet;
        }

        public Karyawan Get(int id)
        {
            var dataGet = myContext.Karyawan.Find(id);
            return dataGet;
        }

        public int Post(Karyawan karyawan)
        {
            myContext.Add(karyawan);
            var resultPut = myContext.SaveChanges();
            return resultPut;
        }

        public int Put(Karyawan karyawan)
        {
            var dataPut = Get(karyawan.Id);
            dataPut.Nama = karyawan.Nama;
            dataPut.Email = karyawan.Email;
            dataPut.PosisiId = karyawan.PosisiId;
            dataPut.AmbilCuti = karyawan.AmbilCuti;
            myContext.Update(dataPut);
            var resultPut = myContext.SaveChanges();
            return resultPut;
        }
    }
}
