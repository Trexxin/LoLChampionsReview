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

        public bool ChampionExists(Guid id)
        {
            throw new NotImplementedException();
        }

        public Champion GetChampion(Guid id)
        {
            return _context.Champions.Where(c => c.Id == id).FirstOrDefault();
        }

        public Champion GetChampion(string name)
        {
            return _context.Champions.Where(c => c.Name == name).FirstOrDefault();
        }

        public int GetChampionDifficulty(Guid championId)
        {
            throw new NotImplementedException();
        }

        public ICollection<Champion> GetChampions()
        {
            return _context.Champions.OrderBy(c => c.Id).ToList();
        }
    }
}
