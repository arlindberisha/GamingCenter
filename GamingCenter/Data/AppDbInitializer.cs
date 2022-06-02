using GamingCenter.Data.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Linq;

namespace GamingCenter.Data
{
    public class AppDbInitializer
    {
        public static void Seed(IApplicationBuilder applicationBulider)
        {
            using (var serviceScope = applicationBulider.ApplicationServices.CreateScope())
            {
                var context = serviceScope.ServiceProvider.GetService<AppDbContext>();
                if (!context.Workers.Any())
                {
                    context.Workers.AddRange(new Workers()
                    {
                        Name = "Arlind",
                        Gender = true,
                        SectorsId = 1,
                        DateStarted = DateTime.Now

                    });
                    context.SaveChanges();
                }
            }
        }
    }
}
