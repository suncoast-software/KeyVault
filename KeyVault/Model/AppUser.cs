namespace KeyVault.Model
{
    internal class AppUser
    {
        [Key]
        public int Id { get; set; }
        public Guid UserId { get; set; }
        public string? Username { get; set; }
        public string? PasswordHash { get; set; }
    }
}
