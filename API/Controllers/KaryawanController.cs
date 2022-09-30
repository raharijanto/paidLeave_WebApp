using API.Context;
using API.Models;
using API.Repositories.Data;
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
    public class KaryawanController : ControllerBase
    {
        KaryawanRepository karyawanRepository;

        public KaryawanController(KaryawanRepository karyawanRepository)
        {
            this.karyawanRepository = karyawanRepository;
        }

        [HttpGet]
        public IActionResult Get()
        {
            var dataGet = karyawanRepository.Get();
            if (dataGet.Count == 0)
            {
                return Ok(new { message = "Sukses mengambil data", statusCode = 200, data = "null" });
            }
            return Ok(new { message = "Sukses mengambil data", statusCode = 200, data = dataGet });
        }

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var dataGet = karyawanRepository.Get(id);
            if (dataGet == null)
            {
                return Ok(new { message = "Sukses mengambil data", statusCode = 200, data = "null" });
            }
            return Ok(new { message = "Sukses mengambil data", statusCode = 200, data = dataGet });
        }

        [HttpPut]
        public IActionResult Put(Karyawan karyawan)
        {
            var resultPut = karyawanRepository.Put(karyawan);
            if (resultPut > 0)
            {
                return Ok(new { message = "Sukses memperbaharui data", statusCode = 200 });
            }
            return BadRequest(new { message = "Gagal memperbaharui data", statusCode = 400 });
        }

        [HttpPost]
        public IActionResult Post(Karyawan karyawan)
        {
            var resultPost = karyawanRepository.Post(karyawan);
            if (resultPost > 0)
            {
                return Ok(new { message = "Sukses memperbaharui data", statusCode = 200 });
            }
            return BadRequest(new { message = "Gagal memperbaharui data", statusCode = 400 });
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var resultDelete = karyawanRepository.Delete(id);
            if (resultDelete > 0)
            {
                return Ok(new { message = "Sukses mengambil data", statusCode = 200 });
            }
            return Ok(new { message = "Sukses mengambil data", statusCode = 400 });
        }
    }
}
