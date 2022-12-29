﻿using Furion.DatabaseAccessor;
using Microsoft.EntityFrameworkCore;

namespace Elephent.EntityFramework.Core;

[AppDbContext("Elephent", DbProvider.Sqlite)]
public class DefaultDbContext : AppDbContext<DefaultDbContext>
{
    public DefaultDbContext(DbContextOptions<DefaultDbContext> options) : base(options)
    {
    }
}
