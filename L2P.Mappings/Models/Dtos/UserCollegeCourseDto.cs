namespace L2P.Mappings.Models.Dtos
{
    public class UserCollegeCourseDto
    {
        public int UserId { get; set; }
        public string UserEmail { get; set; }
        public long CollegeCourseId { get; set; }
        public string CollegeCourseName { get; set; }
        public long PersonId { get; set; }
        public string PersonFullname { get; set; }
    }
}
