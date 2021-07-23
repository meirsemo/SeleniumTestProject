using System;

namespace TestProject1.HelperObjects
{
    public class RegisterObject
    {
        public TitleCombo Title { get; set; } 
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Phone { get; set; }
        public DateTime DateOfBirth { get; set; }
        public bool FullLicence { get; set; }
        public AddressObject Address { get; set; }
        public int LicencePeriod { get; set; } 
        public OccupationCombo Occupation { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string ConfirmPasword { get; set; }

        public static RegisterObject TestModel => new RegisterObject
        {
            FirstName = "bla",
            LastName = "blabla",
            DateOfBirth = new DateTime(1940, 5, 20),
            Email = "blabla@gmail.com",
            FullLicence = false,
            Address = AddressObject.TestModel,
            LicencePeriod = 30,
            Occupation = OccupationCombo.Academic,
            Password = "123456",
            ConfirmPasword = "123456",
            Phone = "987-654321",
            Title = TitleCombo.Captain
        };

        public enum TitleCombo
        {
            Mr,
            Mrs,
            Miss,
            Ms,
            Doctor,
            Captain,
            Duchess,
            Duke,
            Father,
            General,
            Lady,
            Lord,
            Lieutenant,
            LieutenantColonel,
            Major,
            Master,
            Professor,
            Reverend,
            Sir,
            Squire,
            SquadronLeader
        }
        public enum OccupationCombo
        {
            Academic = 1,
            Actor = 2,
            Artist = 3,
            Doctor = 4,
            Librarian = 5,
            Student = 6,
            Accountant = 7,
            Architect = 8,
            Dentist = 9,
            Economists = 10,
            Writer = 11,
            Engineer = 12,
            Lawyer = 13,
            Nurse = 14,
            Pharmacist = 15,
            Physician = 16,
            Physiotherapist = 17,
            Psychologist = 18,
            Scientist = 19,
            SocialWorker = 20,
            Statistician = 21,
            Surgeon = 22,
            Teacher = 23,
            MathProfessor = 24,
            BankExaminer = 25,
            MuseumCurator = 26,
            CasinoDealer = 27
        }
    }
}
