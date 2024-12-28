namespace CaseManagement.Data
{
    public class Citation
    {
        public int CitationNo { get; set; }
        public DateTime IssueDate { get; set; }
        public int CountyCode { get; set; }
        public int AgencyCode { get; set; }
        public string? Identification { get; set; }
        public int? District { get; set; }
        public int? MilePost { get; set; }
        public string? Location { get; set; }

        public Officer CitingOfficer { get; set; }

        public string EssentialFacts {get; set;}

    }
}
