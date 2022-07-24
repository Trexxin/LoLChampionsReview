namespace LoLChampionsReview.Entities
{
    public class Region
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public ICollection<Champion> Champions { get; set; }
    }
}
