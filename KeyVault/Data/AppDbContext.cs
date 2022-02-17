namespace KeyVault.Data
{
    internal class AppDbContext : DbContext
    {
        public DbSet<AppUser> AppUsers { get; set; }
        public DbSet<Account> Accounts { get; set; }

        public AppDbContext(DbContextOptions options) : base(options)
        {
        }
    }
}
