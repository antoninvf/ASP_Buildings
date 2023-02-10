namespace ASP_Buildings.ViewModels;

public class BuildingViewModel
{
    public string Id { get; set; }
    public string Name { get; set; }
    public List<RoomViewModel> Rooms = new List<RoomViewModel>();
}