using PlayingAround.Models;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PlayingAround.Infrastructure
{
    public class dbcontext : DbContext
    {
        public dbcontext(DbContextOptions<dbcontext> options):base(options)
        {

        }
        public DbSet<Models.Page> Pages { get; set; }
    }
}
