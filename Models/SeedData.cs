using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System.Linq;

namespace HeraldsHelmets.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new MvcHelmetContext(
                serviceProvider.GetRequiredService<DbContextOptions<MvcHelmetContext>>()))
            {
                // Look for any movies.
                if (context.Helmet.Any())
                {
                    return;   // DB has been seeded
                }

                context.Helmet.AddRange(
                    new Helmet
                    {
                        Type = "Football",
                        Size = "Medium",
                        Brand = "Schutt",
                        Model = "Vengeance Pro",
                        Colour = "Yellow",
                        Price = 299.95M,
                        Rating = 3
                    },
                    new Helmet
                    {
                        Type = "Football",
                        Size = "Small",
                        Brand = "VICIS",
                        Model = "Zero2",
                        Colour = "Black",
                        Price = 899.95M,
                        Rating = 5
                    },
                    new Helmet
                    {
                        Type = "Football",
                        Size = "Large",
                        Brand = "Schutt",
                        Model = "Vengeance A11",
                        Colour = "White",
                        Price = 499.95M,
                        Rating = 5
                    },
                    new Helmet
                    {
                        Type = "Motorcycle",
                        Size = "Small",
                        Brand = "ICON",
                        Model = "Airflite Peacekeeper",
                        Colour = "White",
                        Price = 429.95M,
                        Rating = 4
                    },
                    new Helmet
                    {
                        Type = "Motorcycle",
                        Size = "Medium",
                        Brand = "CKX",
                        Model = "Quest RSV",
                        Colour = "Red",
                        Price = 199.99M,
                        Rating = 2
                    },
                    new Helmet
                    {
                        Type = "Motorcycle",
                        Size = "XXX-Large",
                        Brand = "Bell",
                        Model = "Qualifier",
                        Colour = "Black",
                        Price = 599.95M,
                        Rating = 5
                    },
                    new Helmet
                    {
                        Type = "Baseball",
                        Size = "X-Large",
                        Brand = "Easton",
                        Model = "Z5 2.0",
                        Colour = "Blue",
                        Price = 44.99M,
                        Rating = 4
                    },
                    new Helmet
                    {
                        Type = "Baseball",
                        Size = "Medium",
                        Brand = "Rawlings",
                        Model = "Velo R16",
                        Colour = "Green",
                        Price = 39.95M,
                        Rating = 3
                    },
                    new Helmet
                    {
                        Type = "Baseball",
                        Size = "X-Large",
                        Brand = "Easton",
                        Model = "Z7 Dual Finish",
                        Colour = "Purple",
                        Price = 29.99M,
                        Rating = 2
                    },
                    new Helmet
                    {
                        Type = "Bike",
                        Size = "Small",
                        Brand = "Specialized",
                        Model = "Propero 3",
                        Colour = "Pink",
                        Price = 169.99M,
                        Rating = 5
                    },
                    new Helmet
                    {
                        Type = "Bike",
                        Size = "XX-Large",
                        Brand = "Engage Optics",
                        Model = "Convoy MIPS",
                        Colour = "Orange",
                        Price = 99.99M,
                        Rating = 3
                    },
                    new Helmet
                    {
                        Type = "Bike",
                        Size = "Medium",
                        Brand = "Giro",
                        Model = "Quarter",
                        Colour = "Grey",
                        Price = 49.99M,
                        Rating = 2
                    }
                );
                context.SaveChanges();
            }
        }
    }
}
