namespace DotnetAPI.Request;

public class CityRequest
{
    public int CityId { get; set; }
    public string Name { get; set; }
    public double? Latitude { get; set; }
    public double? Longitude { get; set; }
    public int? CountryId { get; set; }
}