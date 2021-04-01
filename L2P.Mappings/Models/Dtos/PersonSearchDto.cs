using System;

namespace L2P.Mappings.Models.Dtos
{
    public class PersonSearchDto
    {
        public string Name { get; set; }
        public string SSN { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string DriversLicenseNumber { get; set; }
        public string PassportId { get; set; }
    }
}
