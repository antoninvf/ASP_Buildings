namespace ASP_Buildings.ViewModels;

public class RoomViewModel
{
    public string Id { get; set; }
    public string BuildingId { get; set; }
    public string Name { get; set; }
    public List<TimeViewModel> ReservedTimes { get; set; }
}