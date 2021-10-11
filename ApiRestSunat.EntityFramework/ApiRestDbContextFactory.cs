﻿using Microsoft.EntityFrameworkCore.Design;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiRestSunat.EntityFramework
{
    public class ApiRestDbContextFactory : IDesignTimeDbContextFactory<ApiRestDbContext>
    {
        public ApiRestDbContext CreateDbContext(string[] args = null)
        {
            var options = new DbContextOptionsBuilder<ApiRestDbContext>();
            options.UseSqlServer("data source = (local); initial catalog = PatronSunat; user id = sa; password = Server123*");
            return new ApiRestDbContext(options.Options);

        }
    }
}