using L2P.Mappings.Models;
using L2P.Mappings.Models.Dtos;
using System;

namespace L2P.Mappings
{
    class Program
    {
        static Person _person;
        static CollegeCourse _collegeCourse;
        static PersonCollegeCourse _personCollegeCourse;
        static User _user;

        static void Main(string[] args)
        {
            CreateObjects();
            Console.WriteLine($"Person PhoneNumber: {_person.PhoneNumber}");
            Console.WriteLine($"Person EmergencyContactName: {_person.EmergencyContactName}");
            Console.WriteLine($"Person EmergencyContactPhoneNumber: {_person.EmergencyContactPhoneNumber}");

            var personProfileDto = MapPersonToPersonProfileDto(_person);
            personProfileDto.PhoneNumber = "new phone who dis";

            var updatedPerson = MapPersonProfileDtoToPerson(personProfileDto);
            Console.WriteLine($"Person PhoneNumber: {updatedPerson.PhoneNumber}");

            var personEmergencyContactDto = MapPersonToPersonEmergencyContactDto(_person);
            personEmergencyContactDto.EmergencyContactName = "Jimmy johns";
            personEmergencyContactDto.EmergencyContactPhoneNumber = "Your moms";

            updatedPerson = MapPersonEmergencyContactDtoToPerson(personEmergencyContactDto);
            Console.WriteLine($"Person EmergencyContactName: {updatedPerson.EmergencyContactName}");
            Console.WriteLine($"Person EmergencyContactPhoneNumber: {updatedPerson.EmergencyContactPhoneNumber}");

            var userCollegeCourseDto = Map(_person, _collegeCourse, _user);
            Console.WriteLine($"userCollegeCourseDto relevant info: {userCollegeCourseDto.PersonFullname} ({userCollegeCourseDto.UserEmail}) is enrolled in {userCollegeCourseDto.CollegeCourseName}");
            var anotherUserCollegeCourseDto = Map(userCollegeCourseDto);
            Console.WriteLine($"another mapped copy userCollegeCourseDto relevant info: {anotherUserCollegeCourseDto.PersonFullname} ({anotherUserCollegeCourseDto.UserEmail}) is enrolled in {anotherUserCollegeCourseDto.CollegeCourseName}");
        }

        private static UserCollegeCourseDto Map(UserCollegeCourseDto source)
        {
            return new UserCollegeCourseDto
            {
                CollegeCourseId = source.CollegeCourseId,
                CollegeCourseName = source.CollegeCourseName,
                PersonFullname = source.PersonFullname,
                PersonId = source.PersonId,
                UserEmail = source.UserEmail,
                UserId = source.UserId
            };
        }

        private static UserCollegeCourseDto Map(Person person, CollegeCourse collegeCourse, User user)
        {
            return new UserCollegeCourseDto
            {
                CollegeCourseId = collegeCourse.Id,
                CollegeCourseName = collegeCourse.Name,
                PersonFullname = $"{person.Firstname} {person.Middlename} {person.Lastname}",
                PersonId = person.Id,
                UserEmail = user.Email,
                UserId = user.Id
            };
        }

        private static Person MapPersonEmergencyContactDtoToPerson(PersonEmergencyContactDto dto)
        {
            _person.EmergencyContactAddressLine1 = dto.EmergencyContactAddressLine1;
            _person.EmergencyContactAddressLine2 = dto.EmergencyContactAddressLine2;
            _person.EmergencyContactPhoneNumber = dto.EmergencyContactPhoneNumber;
            _person.EmergencyContactName = dto.EmergencyContactName;
            _person.EmergencyContactCity = dto.EmergencyContactCity;
            _person.EmergencyContactState = dto.EmergencyContactState;
            _person.EmergencyContactZip = dto.EmergencyContactZip;
            return _person;
        }

        private static PersonEmergencyContactDto MapPersonToPersonEmergencyContactDto(Person person)
        {
            return new PersonEmergencyContactDto
            {
                EmergencyContactAddressLine1 = person.EmergencyContactAddressLine1,
                EmergencyContactAddressLine2 = person.EmergencyContactAddressLine2,
                EmergencyContactPhoneNumber = person.EmergencyContactPhoneNumber,
                EmergencyContactName = person.EmergencyContactName,
                EmergencyContactCity = person.EmergencyContactCity,
                EmergencyContactState = person.EmergencyContactState,
                EmergencyContactZip = person.EmergencyContactZip,
                PersonFullname = $"{person.Firstname} {person.Middlename} {person.Lastname}",
                PersonId = person.Id
            };
        }

        private static void CreateObjects()
        {
            _person = new Person();
            _person.Id = 36346346346346;
            _person.DateOfBirth = Convert.ToDateTime("12-12-2012");

            _person.Firstname = "weofimwef";
            _person.Middlename = "jtytj";
            _person.Lastname = "uliuli";
            _person.MotherFirstname = "xvcbxbcv";
            _person.MotherMiddlename = "ytjj";
            _person.MotherLastname = "liuil";
            _person.FatherFirstname = "wsdfsdf";
            _person.FatherMiddlename = "nvnbvbn";
            _person.FatherLastname = "uylliiyl";
            _person.DriversLicenseNumber = "34regdfdg";
            _person.PassportId = "453dfdfgwr4";
            _person.SSN = "876969897";
            _person.BirthWeightPounds = 2398.3m;
            _person.CurrentWeightPounds = 325.43m;
            _person.BirthHeightInches = 45;
            _person.CurrentHeightInches = 11.111m;
            _person.AddressLine1 = "2938324 woeifmwoief";
            _person.AddressLine2 = "29rth rjrj";
            _person.City = "Foimwef";
            _person.State = "we";
            _person.Zip = "23423";
            _person.PhoneNumber = "23423411";
            _person.EmergencyContactName = "ingle ingles";
            _person.EmergencyContactPhoneNumber = "2346546324";
            _person.EmergencyContactAddressLine1 = "2938324 woeifmwoief";
            _person.EmergencyContactAddressLine2 = "29rth rjrj";
            _person.EmergencyContactCity = "hrttheerg";
            _person.EmergencyContactState = "AF";
            _person.EmergencyContactZip = "80439";
            _person.EmergencyContactPhoneNumber = "2938393398";

            _collegeCourse = new CollegeCourse
            {
                Id = 12,
                Name = "CMPS 101",
                Description = "L2p"
            };

            _personCollegeCourse = new PersonCollegeCourse();
            _personCollegeCourse.Id = 239282;
            _personCollegeCourse.CollegeCourseId = 12;
            _personCollegeCourse.PersonId = 36346346346346;

            _user = new User
            {
                Id = 9460923,
                Email = "Test@test.com",
                Password = "password1",
                PersonId = 36346346346346,
                IsDeleted = false
            };
        }

        private static PersonProfileDto MapPersonToPersonProfileDto(Person person)
        {
            var dto = new PersonProfileDto();
            dto.Firstname = person.Firstname;
            dto.Middlename = person.Middlename;
            dto.Lastname = person.Lastname;
            dto.AddressLine1 = person.AddressLine1;
            dto.AddressLine2 = person.AddressLine2;
            dto.City = person.City;
            dto.State = person.State;
            dto.Zip = person.Zip;
            dto.PhoneNumber = person.PhoneNumber;
            return dto;
        }

        private static Person MapPersonProfileDtoToPerson(PersonProfileDto dto)
        {
            _person.Firstname = dto.Firstname;
            _person.Middlename = dto.Middlename;
            _person.Lastname = dto.Lastname;
            _person.AddressLine1 = dto.AddressLine1;
            _person.AddressLine2 = dto.AddressLine2;
            _person.City = dto.City;
            _person.State = dto.State;
            _person.Zip = dto.Zip;
            _person.PhoneNumber = dto.PhoneNumber;
            return _person;
        }
    }
}
