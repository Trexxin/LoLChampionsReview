using LoLChampionsReview.Data;
using LoLChampionsReview.Entities;

namespace LoLChampionsReview
{
    public class Seed
    {
        private readonly DataContext _dataContext;

        public Seed(DataContext context)
        {
            _dataContext = context;
        }

        public void SeedDataContext()
        {
            if (!_dataContext.Champions.Any())
            {
                var champions = new List<Champion>()
                {
                    new Champion()
                    {
                        Name = "Riven",
                        Region = new Region()
                        {
                            Name = "Noxus"
                        },
                        Difficulty = 3,
                        Role = "Fighter",
                        Backstory = "Once a swordmaster in the warhosts of Noxus, Riven is an expatriate in a land she previously tried to conquer." +
                        "She rose through the ranks on the strength of her conviction and brutal efficiency, and was rewarded with a legendary runic blade and a warband of her own. " +
                        "However, on the Ionian front, Riven's faith in her homeland was tested and ultimately broken. " +
                        "Having severed all ties to the empire, she now seeks to find her place in a shattered world, even as rumors abound that Noxus itself has been reforged...",
                        CreatedDate = new DateTime(2011,9,14)
                    },
                    new Champion()
                    {
                        Name = "Heimerdinger",
                        Region = new Region()
                        {
                            Name = "Piltover"
                        },
                        Difficulty = 3,
                        Role = "Mage",
                        Backstory = "A brilliant yet eccentric yordle scientist, Professor Cecil B. Heimerdinger is one of the most innovative and esteemed inventors Piltover has ever known. " +
                        "Relentless in his work to the point of neurotic obsession, he thrives on answering the universe's most impenetrable questions. " +
                        "Though his theories often appear opaque and esoteric, Heimerdinger has crafted some of Piltover's most miraculous—not to mention lethal—machinery, " +
                        "and constantly tinkers with his inventions to make them even more efficient.",
                        CreatedDate = new DateTime(2009,10,10)
                    },
                    new Champion()
                    {
                        Name = "Kayle",
                        Region = new Region()
                        {
                            Name = "Targon"
                        },
                        Difficulty = 2,
                        Role = "Fighter",
                        Backstory = "Born to a Targonian Aspect at the height of the Rune Wars, Kayle honored her mother's legacy by fighting for justice on wings of divine flame. " +
                        "She and her twin sister Morgana were the protectors of Demacia for many years—until Kayle became disillusioned with the repeated failings of mortals, " +
                        "and abandoned this realm altogether. Still, legends are told of her punishing the unjust with her fiery swords, and many hope that she will one day return…",
                        CreatedDate = new DateTime(2009,2,21)
                    }
                };
                _dataContext.Champions.AddRange(champions);
                _dataContext.SaveChanges();
            }
        }
    }
}
