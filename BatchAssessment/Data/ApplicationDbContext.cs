using BatchAssessment.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BatchAssessment.Data
{
    public class ApplicationDbContext :DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        public DbSet<BatchModel> Batches { get; set; }

        public DbSet<Models.Atribute> Attributes { get; set; }

        public DbSet<Models.ACL> ACLs { get; set; }
    }
}
