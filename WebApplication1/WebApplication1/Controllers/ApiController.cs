using WebApplication1.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Controllers
{

    [ApiController]
    public class ApiController : ControllerBase
    {

        private List<bookapi> Listabooks;

        public ApiController()
        {
            Listabooks = new List<bookapi>()
            {
                new bookapi() {id = 1, Title = "AAAA", Author = "BBBB", Price = "100"},
                new bookapi() {id = 2, Title = "CCCC", Author = "DDDD", Price = "50"},
                new bookapi() {id = 3, Title = "EEEE", Author = "FFFF", Price = "10"}
            };
        }

        [HttpGet]
        [Route("api/books")]
        public ActionResult<IEnumerable<bookapi>> GetCard()
        {
            return Listabooks.ToList();
        }
        [HttpDelete("{id}")]
        [Route("api/book/{id}")]
        public IActionResult Delete(int id)
        {
            var res = Listabooks.Find(x => x.id == id);
            Listabooks.Remove(res);

            return NoContent();
        }
    }
}
