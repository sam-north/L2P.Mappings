namespace L2P.Mappings.Models.Dtos
{
    public class PersonEmergencyContactDto
    {
        public long PersonId { get; set; }
        public string PersonFullname { get; set; }
        public string EmergencyContactName { get; set; }
        public string EmergencyContactPhoneNumber { get; set; }
        public string EmergencyContactAddressLine1 { get; set; }
        public string EmergencyContactAddressLine2 { get; set; }
        public string EmergencyContactCity { get; set; }
        public string EmergencyContactState { get; set; }
        public string EmergencyContactZip { get; set; }
    }
}
