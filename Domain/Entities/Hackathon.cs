namespace Domain.Entities;

public class Hackathon
{
    public int Id { get; set; }
    public string Name { get; set; }
    public int HackathonId { get; set; }
    public DateTime CreatedDate { get; set; }
}
