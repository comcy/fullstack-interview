namespace SimpleApp
{
    public class Protocol
    {         
        public int ProtocolId { get; set; }
        public string Name { get; set; }
        public string FileName { get; set; }
        public string? DrawingNumber { get; set; }
        public string? PartNumber { get; set; }
        public string? OrderNumber { get; set; }
        public string? WorkpieceName { get; set; }
        public string? SoftwareVersion { get; set; }
        public string? OperatorName { get; set; }
        public string? CmmNumber { get; set; }
        public DateTime MeasuredOn { get; set; }
        public List<Comment>? Comments { get; set; }
    }
}