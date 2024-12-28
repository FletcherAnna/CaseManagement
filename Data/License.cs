namespace CaseManagement.Data
{
    public class License
    {
        public int ID { get; set; }
        public string LicenseNo { get; set; }
        public State state { get; set; }
        public bool Commercial { get; set; }

        public LicenseTypes licenseType { get; set; }

        public bool Hazmat { get; set; }

        public string? DOTNo { get; set; }

    }
}
