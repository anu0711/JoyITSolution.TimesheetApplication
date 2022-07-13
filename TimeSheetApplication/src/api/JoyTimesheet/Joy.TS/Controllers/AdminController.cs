using Employee.Model;
using Joy.TS.BAL.Implementation;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Joy.TS.Api.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class AdminController : ControllerBase
    {
        public AdminController(IAdmin _admin)
        {
            Ak = _admin;
        }
        public IAdmin Ak { get; set; }

        [HttpGet]
        public IActionResult GetClients(int id)
        {
            var item = Ak.GetClient(id);
            return new ObjectResult(item);
        }
    }
}
