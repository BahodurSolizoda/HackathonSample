namespace Domain.Entities;

public class Team
{
    public int Id { get; set; }
    public string Name { get; set; }
    public DateTime CreatedDate { get; set; }
    
    //foreign key
    public Hackathon Hackathon { get; set; }
    public int HackathonId { get; set; }
    
    //navigation property
    public List<Participant> Participants { get; set; }
}
