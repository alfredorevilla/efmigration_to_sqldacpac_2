using efmigration_to_sqldacpac_2;
using Microsoft.EntityFrameworkCore;

var builder = Host.CreateApplicationBuilder(args);
builder.Services.AddHostedService<Worker>();
builder.Services.AddDbContext<SampleDbContext>(o => o.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")), ServiceLifetime.Singleton, ServiceLifetime.Singleton);

var host = builder.Build();
host.Run();