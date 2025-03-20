﻿using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace efmigration_to_sqldacpac_2;

public class Entity1
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }

    [StringLength(50)]
    public string? Name { get; set; }
}

public class SampleDbContext : DbContext
{
    public DbSet<Entity1>? Entity1
    {
        get; set;
    }

    public SampleDbContext(DbContextOptions<SampleDbContext> dbContextOptions) : base(dbContextOptions)
    {
    }
}