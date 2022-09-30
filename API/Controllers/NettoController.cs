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
    public class NettoController : ControllerBase
    {
        NettoRepository nettoRepository;

        public NettoController(NettoRepository nettoRepository)
        {
            this.nettoRepository = nettoRepository;
        }

        [HttpGet]
        public IActionResult Get()
        {
            var dataGet = nettoRepository.Get();
            if (dataGet.Count == 0)
            {
                return Ok(new { message = "Sukses mengambil data", statusCode = 200, data = "null" });
            }
            return Ok(new { message = "Sukses mengambil data", statusCode = 200, data = dataGet });
        }

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var dataGet = nettoRepository.Get(id);
            if (dataGet == null)
            {
                return Ok(new { message = "Sukses mengambil data", statusCode = 200, data = "null" });
            }
            return Ok(new { message = "Sukses mengambil data", statusCode = 200, data = dataGet });
        }

        [HttpPut]
        public IActionResult Put(Netto netto)
        {
            var resultPut = nettoRepository.Put(netto);
            if (resultPut > 0)
            {
                return Ok(new { message = "Sukses memperbaharui data", statusCode = 200 });
            }
            return BadRequest(new { message = "Gagal memperbaharui data", statusCode = 400 });
        }

        [HttpPost]
        public IActionResult Post(Netto netto)
        {
            var resultPost = nettoRepository.Post(netto);
            if (resultPost > 0)
            {
                return Ok(new { message = "Sukses memperbaharui data", statusCode = 200 });
            }
            return BadRequest(new { message = "Gagal memperbaharui data", statusCode = 400 });
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var resultDelete = nettoRepository.Delete(id);
            if (resultDelete > 0)
            {
                return Ok(new { message = "Sukses mengambil data", statusCode = 200 });
            }
            return Ok(new { message = "Sukses mengambil data", statusCode = 400 });
        }
    }
}
