﻿using API.Repositories.Data;
using API.ViewModels;
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
    //[EnableCors("AllowOrigin")]
    public class PerbaikanController : ControllerBase
    {
        PerbaikanRepository perbaikanRepository;

        //READ
        [HttpGet]
        public IActionResult Get()
        {

            var data = perbaikanRepository.Get();

            if (data != null)
            {
                return Ok(new { message = "Sukses", statusCode = 200, data = data });
            }
            else
            {
                return Ok(new { message = "Sukses", statusCode = 200, data = "null" });
            }
        }

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var data = perbaikanRepository.Get(id);

            if (data != null)
            {
                return Ok(new { message = "Sukses", statusCode = 200, data = data });
            }
            else
            {
                return Ok(new { message = "Sukses", statusCode = 200, data = "null" });
            }

        }

        [HttpPost]
        public IActionResult Post(Perbaikan perbaikan)
        {
            var result = perbaikanRepository.Post(perbaikan);
            if (result > 0)
            {
                return Ok(new { message = "Sukses pinjam barang, Tabel Barang & Rowayat Peminjaman telah diperbarui", statusCode = 200 });
            }
            else
            {
                return BadRequest(new { message = "Gagal tambah pinjam barang", statusCode = 400 });
            }

        }


        //UPDATE
        [HttpPut("{id}")]
        public IActionResult Put(int Id, Perbaikan perbaikan)
        {
            var result = perbaikanRepository.Put(Id, perbaikan);
            if (result > 0)
            {
                return Ok(new { message = "Sukses ubah data", statusCode = 200 });
            }
            else
            {
                return BadRequest(new { message = "Gagal ubah data", statusCode = 400 });
            }

        }


        //DELETE
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var result = perbaikanRepository.Delete(id);
            if (result > 0)
            {
                return Ok(new { message = "Sukses hapus data", statusCode = 200 });
            }
            else
            {
                return BadRequest(new { message = "Gagal hapus data", statusCode = 400 });
            }

        }

    }
}
