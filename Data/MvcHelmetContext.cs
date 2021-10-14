using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using HeraldsHelmets.Models;

    public class MvcHelmetContext : DbContext
    {
        public MvcHelmetContext (DbContextOptions<MvcHelmetContext> options)
            : base(options)
        {
        }

        public DbSet<HeraldsHelmets.Models.Helmet> Helmet { get; set; }
    }
