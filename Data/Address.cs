namespace CaseManagement.Data
{
    public class Address
    {       
        public string street { get; set; }
        public string? Apartment { get; set; }
        public string? City { get; set; }
        public Region state { get; set; }
        public string? Zip {  get; set; }

    }
}
