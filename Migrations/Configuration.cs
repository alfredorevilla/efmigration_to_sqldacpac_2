namespace efmigration_to_sqldacpac_2.Migrations;

using System;
using System.Data.Entity.Migrations;

internal sealed class Configuration : DbMigrationsConfiguration<SampleDbContext>
{
    public Configuration()
    {
        AutomaticMigrationsEnabled = false;
    }

    protected override void Seed(SampleDbContext context)
    {
        if (context is null)
        {
            throw new ArgumentNullException(nameof(context));
        }
        //  This method will be called after migrating to the latest version.

        //  You can use the DbSet<T>.AddOrUpdate() helper extension method
        //  to avoid creating duplicate seed data.
    }
}