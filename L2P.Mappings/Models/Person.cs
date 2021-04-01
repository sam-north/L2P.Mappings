using System;

namespace L2P.Mappings.Models
{
    public class Person
    {
        public long Id { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Firstname { get; set; }
        public string Middlename { get; set; }
        public string Lastname { get; set; }
        public string MotherFirstname { get; set; }
        public string MotherMiddlename { get; set; }
        public string MotherLastname { get; set; }
        public string FatherFirstname { get; set; }
        public string FatherMiddlename { get; set; }
        public string FatherLastname { get; set; }
        public string DriversLicenseNumber { get; set; }
        public string PassportId { get; set; }
        public string SSN { get; set; }
        public decimal BirthWeightPounds { get; set; }
        public decimal CurrentWeightPounds { get; set; }
        public decimal BirthHeightInches { get; set; }
        public decimal CurrentHeightInches { get; set; }
        public string AddressLine1 { get; set; }
        public string AddressLine2 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zip { get; set; }
        public string PhoneNumber { get; set; }
        public string EmergencyContactName { get; set; }
        public string EmergencyContactPhoneNumber { get; set; }
        public string EmergencyContactAddressLine1 { get; set; }
        public string EmergencyContactAddressLine2 { get; set; }
        public string EmergencyContactCity { get; set; }
        public string EmergencyContactState { get; set; }
        public string EmergencyContactZip { get; set; }
    }
}
