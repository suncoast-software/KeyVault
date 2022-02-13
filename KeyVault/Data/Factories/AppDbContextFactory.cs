namespace KeyVault.Data.Factories
{
    internal class AppDbContextFactory : IDesignTimeDbContextFactory<AppDbContext>
    {
        private readonly IDataService _dataService;

        public AppDbContextFactory(IDataService dataService)
        {
            _dataService = dataService;
        }

        public AppDbContext CreateDbContext(string[] args)
        {
            var conString = _dataService.GetConnectionString();
            var connStr = conString.ConnectionString;
            var options = new DbContextOptionsBuilder<AppDbContext>();

            options.UseNpgsql(connStr);

            return new AppDbContext(options.Options);
        }
    }
}
