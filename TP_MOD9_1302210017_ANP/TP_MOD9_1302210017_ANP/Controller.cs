using System.Runtime.InteropServices;
using Microsoft.AspNetCore.Mvc;

namespace TP_MOD9_1302210017_ANP.Controllers
{
    [Route("api/[Controller")]
    [ApiController]

    public class MahasiswaController : ControllerBase
    {
        private static List<Mahasiswa> dataMhw = new List<Mahasiswa>
        {
            new Mahasiswa("Walid Hanif Ataullah", "1302213120"),
            new Mahasiswa("Muhammad Raffa Zuhayr", "1302210068"),
            new Mahasiswa("Muhammad Yassin Rafi", "1302210055"),
            new Mahasiswa("Sylvana Rheina K", "1302210017")
        };

        [HttpGet]
        public IEnumerable<Mahasiswa> Get()
        {
            return dataMhw;
        }

        [HttpGet("{id}")]
        public Mahasiswa Get(int id)
        {
            return dataMhw[id];
        }

        [HttpPost]
        public void Post([FromBody] Mahasiswa newMhw)
        {
            dataMhw.Add(newMhw);
        }

        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Mahasiswa updatedMhw)
        {
            dataMhw[id] = updatedMhw;
        }

        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            dataMhw.RemoveAt(id);
        }