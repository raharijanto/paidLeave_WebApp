using API.Context;
using API.ViewModel;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Repositories.Data
{
    public class CutiPanelRepository
    {
        MyContext myContext;

        // Response Cuti Panel -> Fullname, HariCuti, Jabatan
        public ResponseCutiPanel CutiPanel(CutiPanel cutiPanel)
        {
            var dataLogin = myContext.Karyawan
                .Include(x => x.Jabatan)
                .Include(x => x.Cuti)
                .FirstOrDefault(x =>
                    x.Jabatan.Posisi.Equals(cutiPanel.Posisi) &&
                    x.Cuti.JumlahCuti.Equals(cutiPanel.JumlahCuti));

            if (dataLogin != null)
            {
                ResponseCutiPanel responseCutiPanel = new ResponseCutiPanel()
                {
                    FullName = dataLogin.Nama,
                    HariCuti = dataLogin.Cuti.JumlahCuti,
                    Jabatan = dataLogin.Jabatan.Posisi
                };
                return responseCutiPanel;
            }

            return null;
        }
    }
}
