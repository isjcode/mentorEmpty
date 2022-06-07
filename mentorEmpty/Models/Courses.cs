namespace mentorEmpty.Models
{
    public class Courses
    {
        public int Id { get; set; }
        public string CourseName { get; set; }
        public int Price { get; set; }  
        public int PositionId { get; set; }
        public string Description { get; set; }
        public int Hearts { get; set; }
        public int Humans { get; set; }
        public string TrainerName { get; set; }

        public string TrainerImage { get; set; }
        public string CourseImage { get; set; }
        public Positions Position { get; set; }
    }
}
