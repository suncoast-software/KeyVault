namespace KeyVault.Data
{
    internal class AppDbContext : DbContext
    {
        public DbSet<AppUser> MyProperty { get; set; }
        public AppDbContext(DbContextOptions options) : base(options)
        {
        }
    }
}
