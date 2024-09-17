namespace DotnetAPI.Entities;

public sealed class City 
{
        public int Id { get; set; }
        public string? Name { get; set; }
        public double? Latitude { get; set; }
        public double? Longitude { get; set; }
        public int CountryId { get; set; }
}