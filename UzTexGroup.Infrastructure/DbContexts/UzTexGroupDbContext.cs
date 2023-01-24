﻿using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace UzTexGroup.Infrastructure.DbContexts;

public class UzTexGroupDbContext : DbContext
{
	public UzTexGroupDbContext(DbContextOptions<UzTexGroupDbContext> dbContextOptions)
		: base(dbContextOptions)
	{
	}

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
    }
}
