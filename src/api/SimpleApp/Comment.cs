namespace SimpleApp
{
    public class Comment
    {
        public int CommentId { get; set; }
        public DateTime CreatedDate { set; get; }
        public int? ProtocolId { get; set; }
        public Protocol? Protocol { get; set; }
        public string? Text { set; get; }
        public string? CreatedBy { set; get; }
        public bool IsDeleted { set; get; }
    }
}
