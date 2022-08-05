using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace JWT.Controllers
{
    [Route("Math")]
    [ApiController]
    public class MathController : Controller
    {
        [HttpGet, Authorize(Roles = "Admin")]
        public int Index()
        {
            Random rand = new Random();
            return rand.Next();
        }

    }
}
