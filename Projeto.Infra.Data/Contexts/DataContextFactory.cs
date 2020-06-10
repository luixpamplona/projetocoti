using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using System;
using System.Collections.Generic;
using System.Text;

namespace Projeto.Infra.Data.Contexts
{
    public class DataContextFactory : IDesignTimeDbContextFactory<DataContext>
    {
        public DataContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<DataContext>();
            builder.UseSqlServer(@"Data Source=SQL5059.site4now.net;Initial Catalog=DB_A5AD6C_lpbastos;User Id=DB_A5AD6C_lpbastos_admin;Password=1007ls95");

            return new DataContext(builder.Options);
        }
    }
}
