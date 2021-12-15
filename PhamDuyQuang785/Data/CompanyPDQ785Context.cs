using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using PhamDuyQuang785.Models;

    public class CompanyPDQ785Context : DbContext
    {
        public CompanyPDQ785Context (DbContextOptions<CompanyPDQ785Context> options)
            : base(options)
        {
        }

        public DbSet<PhamDuyQuang785.Models.CompanyPDQ785> CompanyPDQ785 { get; set; }

        public DbSet<PhamDuyQuang785.Models.PDQ0785> PDQ0785 { get; set; }
    }
