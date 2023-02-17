using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using ButtonMvcApp.Data;
using System;
using System.Linq;

namespace ButtonMvcApp.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new ApplicationDbContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<ApplicationDbContext>>()))
            {
                // Look for any movies.
                if (context.Button.Any())
                {
                    return;   // DB has been seeded
                }

                context.Button.AddRange(
                    new Button
                    {
                       Type = "push-button",
                       Material = "plastic",
                       Size = "Medium",
                        ManufactringDate = "1 Jan,2023",
                        Color = "Blue",
                        Price = 6.00M

                    },

                     new Button
                     {
                         Type = "toggle button",
                         Material = "Metal",
                         Size = "Small",
                         ManufactringDate = "1 Feb,2023",
                         Color = "Red",
                         Price = 5.50M

                     },

                      new Button
                      {
                          Type = "Slide button",
                          Material = "Glass",
                          Size = "large",
                          ManufactringDate = "1 Feb,2023",
                          Color = "Grey ",
                          Price = 10.00M

                      },

                       new Button
                       {
                           Type = "Rocker button",
                           Material = "rubber",
                           Size = "X-large",
                           ManufactringDate = "10 March,2022",
                           Color = "Green",
                           Price = 4.00M

                       },

                         new Button
                         {
                             Type = "Membrane button",
                             Material = "Plastic",
                             Size = "Large",
                             ManufactringDate = "15 March,2022",
                             Color = "Purple",
                             Price = 5.60M

                         },

                          new Button
                          {
                              Type = "Push button",
                              Material = "Metal",
                              Size = "Large",
                              ManufactringDate = "15 Jan,2022",
                              Color = "white",
                              Price = 7.60M

                          },

                           new Button
                           {
                               Type = "Slide button",
                               Material = "glass",
                               Size = "Large",
                               ManufactringDate = "31 March,2022",
                               Color = "Silver",
                               Price = 7.60M

                           },
                           new Button
                           {
                               Type = "Toggle button",
                               Material = "Plastic",
                               Size = "Large",
                               ManufactringDate = "15 March,2022",
                               Color = "Brown",
                               Price = 5.60M

                           },

                            new Button
                            {
                                Type = "Membrane button",
                                Material = "Glass",
                                Size = "Small",
                                ManufactringDate = "15 March,2022",
                                Color = "Golden",
                                Price = 12.00M

                            },

                            new Button
                            {
                                Type = "Rocker button",
                                Material = "Metal",
                                Size = "X-Large",
                                ManufactringDate = "15 March,2022",
                                Color = "Purple",
                                Price = 3.00M

                            }


                );
                context.SaveChanges();
            }
        }
    }
}