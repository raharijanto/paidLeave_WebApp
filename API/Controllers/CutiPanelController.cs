using API.Repositories.Data;
using API.ViewModel;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CutiPanelController : ControllerBase
    {
        CutiPanelRepository cutiPanelRepository;

        public CutiPanelController(CutiPanelRepository cutiPanelRepository)
        {
            this.cutiPanelRepository = cutiPanelRepository;
        }

        [HttpPost]
        public IActionResult CutiPanel(CutiPanel cutiPanel)
        {
            var dataLogin = cutiPanelRepository.CutiPanel(cutiPanel);
            if (dataLogin != null)
            {
                return Ok(new { message = "Cuti Disetujui", statusCode = 200, data = dataLogin });
            }
            return BadRequest(new { message = "Gagal Cuti", statusCode = 400 });
        }
    }
}
