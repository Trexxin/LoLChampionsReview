using LoLChampionsReview.Entities;

namespace LoLChampionsReview.Interfaces
{
    public interface IChampionRepository
    {
        ICollection<Champion> GetChampions();
    }
}
