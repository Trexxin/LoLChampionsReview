using LoLChampionsReview.Data;
using LoLChampionsReview.Entities;
using LoLChampionsReview.Interfaces;

namespace LoLChampionsReview.Repository
{
    public class ChampionRepository : IChampionRepository
    {
        private readonly DataContext _context;

        public ChampionRepository(DataContext context)
        {
            _context = context;
        }
        public ICollection<Champion> GetChampions()
        {
            return _context.Champions.OrderBy(c => c.Id).ToList();
        }
    }
}
