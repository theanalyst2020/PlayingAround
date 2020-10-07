using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using PlayingAround.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PlayingAround.Models
{
    public class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new dbcontext(serviceProvider.GetRequiredService<DbContextOptions<dbcontext>>())) 
            {
                if (context.Pages.Any())
                {
                    return;
                }
                context.Pages.AddRange(
                    new Page
                    {
                        Title = "Home",
                        Slug = "home",
                        Content="home page",
                        Sorting=0
                    },
                    new Page
                    {
                        Title = "About us",
                        Slug = "about-us",
                        Content = "About us page",
                        Sorting = 100
                    },
                    new Page
                    {
                        Title = "Services",
                        Slug = "services",
                        Content = "Services page",
                        Sorting = 100
                    },
                    new Page
                    {
                        Title = "Contact",
                        Slug = "contact",
                        Content = "Contact page",
                        Sorting = 100
                    }

                );
                context.SaveChanges();

            }
        }
    }
}
