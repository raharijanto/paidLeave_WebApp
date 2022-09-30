using API.Context;
using API.ViewModel;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Repositories.Data
{
    public class AccountRepository
    {
        MyContext myContext;

        // Response Login -> Id karyawan, Fullname, Email, Jabatan
        public ResponseLogin Login(Login login)
        {
            var dataLogin = myContext.Pengguna
                .Include(x => x.Karyawan)
                .Include(x => x.Karyawan.Jabatan)
                .Include(x => x.Karyawan.Cuti)
                .FirstOrDefault(x =>
                    x.Karyawan.Email.Equals(login.Email) &&
                    x.Password.Equals(login.Password));

            if (dataLogin != null)
            {
                ResponseLogin responseLogin = new ResponseLogin()
                {
                    Id = dataLogin.Id,
                    FullName = dataLogin.Karyawan.Nama,
                    Email = dataLogin.Karyawan.Email,
                    Jabatan = dataLogin.Karyawan.Jabatan.Posisi
                };
                return responseLogin;
            }

            return null;
        }
    }
}
