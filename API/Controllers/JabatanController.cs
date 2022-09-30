using API.Context;
using API.Models;
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
    public class JabatanController : ControllerBase
    {
        JabatanRepository jabatanRepository;

        public JabatanController(JabatanRepository jabatanRepository)
        {
            this.jabatanRepository = jabatanRepository;
        }

        [HttpGet]
        public IActionResult Get()
        {
            var dataGet = jabatanRepository.Get();
            if (dataGet.Count == 0)
            {
                return Ok(new { message = "Sukses mengambil data", statusCode = 200, data = "null" });
            }
            return Ok(new { message = "Sukses mengambil data", statusCode = 200, data = dataGet });
        }

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var dataGet = jabatanRepository.Get(id);
            if (dataGet == null)
            {
                return Ok(new { message = "Sukses mengambil data", statusCode = 200, data = "null" });
            }
            return Ok(new { message = "Sukses mengambil data", statusCode = 200, data = dataGet });
        }

        [HttpPut]
        public IActionResult Put(Jabatan jabatan)
        {
            var resultPut = jabatanRepository.Put(jabatan);
            if (resultPut > 0)
            {
                return Ok(new { message = "Sukses memperbaharui data", statusCode = 200 });
            }
            return BadRequest(new { message = "Gagal memperbaharui data", statusCode = 400 });
        }

        [HttpPost]
        public IActionResult Post(Jabatan jabatan)
        {
            var resultPost = jabatanRepository.Post(jabatan);
            if (resultPost > 0)
            {
                return Ok(new { message = "Sukses memperbaharui data", statusCode = 200 });
            }
            return BadRequest(new { message = "Gagal memperbaharui data", statusCode = 400 });
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var resultDelete = jabatanRepository.Delete(id);
            if (resultDelete > 0)
            {
                return Ok(new { message = "Sukses mengambil data", statusCode = 200 });
            }
            return Ok(new { message = "Sukses mengambil data", statusCode = 400 });
        }
    }
}
