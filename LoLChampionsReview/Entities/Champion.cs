namespace LoLChampionsReview.Entities
{
    public class Champion
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public Region Region { get; set; }
        public int Difficulty { get; set; }
        public string Role { get; set; }
        public string Backstory { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}
