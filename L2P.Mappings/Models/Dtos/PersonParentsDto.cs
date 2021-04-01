namespace L2P.Mappings.Models.Dtos
{
    public class PersonParentsDto
    {
        public long PersonId { get; set; }
        public string PersonFullname { get; set; }
        public string MotherFirstname { get; set; }
        public string MotherMiddlename { get; set; }
        public string MotherLastname { get; set; }
        public string FatherFirstname { get; set; }
        public string FatherMiddlename { get; set; }
        public string FatherLastname { get; set; }
    }
}
