using Microsoft.AspNetCore.Mvc;

namespace MagicBall.API.Controllers
{
	[ApiController]
	[Route("magic-ball")]
	public class MagicBallController : ControllerBase
	{
		private static readonly string[] defaultResponses = new[]
		{
			"Yes", "No", "Maybe", "Most likely", "Do not count on it", "Ask again"
		};
				
		[HttpGet("response")]
		public ActionResult<string> GetResponse()
		{
			var random = new Random();
			var randomIndex = random.Next(0, defaultResponses.Length);

			return Ok(defaultResponses[randomIndex]);
		}
	}
}