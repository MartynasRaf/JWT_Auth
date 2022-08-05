using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace JWT.Controllers
{
    [Route("Math")]
    [ApiController]
    public class MathController : Controller
    {
        [HttpGet, Authorize]
        public int Index()
        {
            Random rand = new Random();
            return rand.Next();
        }

    }
}
