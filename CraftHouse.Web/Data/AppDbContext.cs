﻿using Microsoft.EntityFrameworkCore;

namespace CraftHouse.Web.Data;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions options) : base(options)
    {
    }
}