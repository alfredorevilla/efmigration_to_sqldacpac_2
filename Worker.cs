using Microsoft.EntityFrameworkCore;

namespace efmigration_to_sqldacpac_2;

public class Worker(ILogger<Worker> logger, SampleDbContext dbContext) : IHostedService
{
    public async Task StartAsync(CancellationToken cancellationToken)
    {
        var count = await dbContext.Entity1!.CountAsync(cancellationToken);
        logger.LogInformation("Entity1 count: {Count}", count);
    }

    public async Task StopAsync(CancellationToken cancellationToken)
    {
        await Task.CompletedTask;
    }
}