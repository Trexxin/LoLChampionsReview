using LoLChampionsReview.Entities;

namespace LoLChampionsReview.Interfaces
{
    public interface IChampionRepository
    {
        ICollection<Champion> GetChampions();
        Champion GetChampion(Guid id);
        Champion GetChampion(string name);
        int GetChampionDifficulty(Guid championId);
        bool ChampionExists(Guid championId);
    }
}
