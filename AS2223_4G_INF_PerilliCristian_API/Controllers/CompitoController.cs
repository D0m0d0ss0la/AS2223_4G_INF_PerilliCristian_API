using Microsoft.AspNetCore.Mvc;

namespace AS2223_4G_INF_PerilliCristian_API.Controllers
{
    [ApiController]
    [Produces("application/json")]
    [Route("api/v1/")]
    public class SusController : Controller
    {
        [HttpGet("division")]
        public JsonResult GetDivision(double numerator, double denominator)
        {
            if (denominator == 0)
            {
                return Json(new { status = "error" });
            }

            return Json(new
            {
                result = numerator / denominator,
                status = 200
            });
        }
    }
}
