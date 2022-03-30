namespace SimpleApp
{
    public class ProtocolQuery
    {
        /// <summary>
        /// The amount of entries taken per query. (Linq: Take)
        /// </summary>
        public int Limit { get; set; } = 10;
        /// <summary>
        /// The amount of entries skipped per query. (Linq: Skip)
        /// </summary>
        public int Offset { get; set; } = 0;
    }
}
