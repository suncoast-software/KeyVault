namespace KeyVault.Model
{
    internal class SystemMessage
    {
        public int Id { get; set; }
        public Guid MessageId { get; set; }
        public string? Message { get; set; }
        public MessageType Type { get; set; }
    }
}
