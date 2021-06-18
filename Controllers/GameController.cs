using Microsoft.AspNetCore.Mvc;

namespace questionexchange
{
	public class GameController : Controller
	{
        [Route("game/index")] // Test Route 
        public IActionResult Index()
        {
            //  return Ok("RUFE INDEX SEITE AUF ");
            return View();
        }
    }
}