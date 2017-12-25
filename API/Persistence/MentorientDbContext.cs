using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Models;
using Microsoft.EntityFrameworkCore;

namespace API.Persistence
{
    public class MentorientDbContext : DbContext
    {
        public MentorientDbContext(DbContextOptions<MentorientDbContext> options)
            : base(options)
        {
        }
        
        public DbSet<Forum> Forums { get; set; }
    }
}
