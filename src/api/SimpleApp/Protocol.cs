namespace SimpleApp
{
    public class Protocol
    {         
        public int ProtocolId { get; set; }
        public string? Name { get; set; }
        public string? DrawingNumber { get; set; }
        public string? PartNumber { get; set; }
        public string? OrderNumber { get; set; }
        public string? WorkpieceName { get; set; }
        public string? CustomerName { get; set; }
        public string? CncName { get; set; }
        public string? SoftwareVersion { get; set; }
        public string? OperatorName { get; set; }
        public string? CmmNumber { get; set; }
        public DateTime MeasuredOn { get; set; }
        public string? DrawingIndex { get; set; }
        public string? UserDefined1 { get; set; }
        public string? UserDefined2 { get; set; }
        public string? UserDefined3 { get; set; }
        public string? UserDefined4 { get; set; }
        public string? UserDefined5 { get; set; }
        public string? UserDefined6 { get; set; }
        public string? UserDefined7 { get; set; }
        public List<Comment>? Comments { get; set; }
    }
}