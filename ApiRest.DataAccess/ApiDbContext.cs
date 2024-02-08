using ApiRest.Abstractions;
using ApiRest.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiRest.DataAccess
{
    public class ApiDbContext : DbContext
    {
        public DbSet<SoccerTeam> SoccerTeams { get; set; }
        public ApiDbContext(DbContextOptions<ApiDbContext> options) : base(options)
        {
                
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Ignore<IEntity>();
            base.OnModelCreating(modelBuilder);
        }
    }
}
