using System.ComponentModel;

namespace CaseManagement.Data
{
    public class Person
    {
        public string ID { get; set; }
        public string FirstName { get; set; }
        public string LastName {get; set;}
        public string? MiddleName { get; set;}
        public DateTime DoB { get; set; }
        public int? Height { get; set; }
        public int? Weight { get; set; }
        public Gender? Gender { get; set; }
        public string EyeColor { get; set; }
        public Address? PhysicalAddress { get; set;}
        public Address? MailingAddress { get; set;}
        public License? License { get; set; }
        public List<Charge> charges { get; set; }
        public List<Appearance> appearances { get; set; }
        public List<Vehicle> vehicles { get; set; }

    }
}
