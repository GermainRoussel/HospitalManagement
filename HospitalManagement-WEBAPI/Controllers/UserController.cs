using HospitalManagement.COMMON.DTO;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HospitalManagement_WEBAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UserController : Controller
    {
        [HttpPost]

        public ActionResult Create(UserRessource userRessource)
        {
            return Ok();
        }

        [HttpPut]

        public ActionResult Edit(UserRessource userRessource)
        {
            return Ok();
        }

        [HttpDelete("id")]
        public ActionResult Delete(int id)
        {
            return Ok();
        }

        [HttpGet("id")]
        public ActionResult GetById(int id)
        {
            return Ok();
        }
        [HttpGet]
        public ActionResult GetAll()
        {
            return Ok();
        }
    }
}
