using Microsoft.AspNetCore.Mvc;

namespace questionexchange
{
	public class GameController : Controller
	{
        // Test Route 
        [Route("game/index")]
        public IActionResult Index()
        {
            //  return Ok("RUFE INDEX SEITE AUF ");
            return View();
        }
        [Route("game/rea")]
        public IActionResult Rasp()
        {
            return Ok("RUFE INDEX @@@@DEAD HEAD @@@@@SEITE AUF ");
        }
        
    }
}