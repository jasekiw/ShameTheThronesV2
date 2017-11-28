using System;
using System.Collections.Generic;
using System.IO;
using System.Net.Http;
using System.Text;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.TestHost;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using ShameTheThronesV2.DB;

namespace ShameTheThronesV2.Tests.Integration
{
    public class TestCase
    {
        protected ShameTheThronesContext _context;
        private readonly TestServer _server;
        protected readonly HttpClient _client;
        public static IConfiguration Configuration { get; set; }
        public TestCase()
        {
            _server = new TestServer(new WebHostBuilder()
                .UseEnvironment("Testing")
                .UseStartup<Startup>());

            _client = _server.CreateClient();


            var serviceProvider = new ServiceCollection()
                .AddEntityFrameworkSqlServer()
                .BuildServiceProvider();



            var confBuilder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json");

            Configuration = confBuilder.Build();


            var dbBuilder = new DbContextOptionsBuilder<ShameTheThronesContext>();

            dbBuilder.UseSqlServer(Configuration.GetConnectionString("ShameTheThronesDatabase"))
                .UseInternalServiceProvider(serviceProvider);

            _context = new ShameTheThronesContext(dbBuilder.Options);
            _context.Database.Migrate();
        }
    }
}
