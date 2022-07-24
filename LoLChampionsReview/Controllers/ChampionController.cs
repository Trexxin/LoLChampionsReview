using LoLChampionsReview.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace LoLChampionsReview.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ChampionController : ControllerBase
    {
        private readonly IChampionRepository _championRepository;

        public ChampionController(IChampionRepository championRepository)
        {
            _championRepository = championRepository;
        }

        [HttpGet]
        public IActionResult GetChampions()
        {
            var champions = _championRepository.GetChampions();

            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            return Ok(champions);
        }
    }
}
