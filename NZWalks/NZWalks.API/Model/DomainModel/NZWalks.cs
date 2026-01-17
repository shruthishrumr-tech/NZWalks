namespace NZWalks.API.Model.DomainModel
{
   

    public class Region
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
        public string RegionImageUrl { get; set; }
    }   
    public class WalkDifficulty
    {
        public Guid Id { get; set; }
        public string Code { get; set; }
    }   
    public class Walk
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public double LengthInKm { get; set; }
        public Guid RegionId { get; set; }
        public Guid WalkDifficultyId { get; set; }
        // Navigation Properties
        public Region Region { get; set; }
        public WalkDifficulty WalkDifficulty { get; set; }
    }   
}
