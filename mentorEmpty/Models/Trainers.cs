namespace mentorEmpty.Models
{
    public class Trainers { 
        public int Id { get; set; }
        public string Image { get; set; } 
        public string Name { get; set; }
        public int? PositionsId { get; set; }
        public string Description { get; set; }
        public Positions Positions { get; set; }
       


    }
}
