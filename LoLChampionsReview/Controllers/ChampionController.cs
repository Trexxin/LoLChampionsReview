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

        // Request to get a list of the champions in the database
        [HttpGet]
        public IActionResult GetChampions()
        {
            var champions = _championRepository.GetChampions();

            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            return Ok(champions);
        }

        // Request to find a specific champion by their id
        [HttpGet("{id}")]
        public IActionResult GetChampion(Guid id)
        {
            var champion = _championRepository.GetChampion(id);

            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            return Ok(champion);
        }

        // Request to find a specific champion by their id
        [HttpGet("{name}")]
        public IActionResult GetChampion(string name)
        {
            var champion = _championRepository.GetChampion(name);

            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            return Ok(champion);
        }
    }
}
