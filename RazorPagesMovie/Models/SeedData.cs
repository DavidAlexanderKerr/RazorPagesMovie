using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace RazorPagesMovie.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new RazorPagesMovieContext(serviceProvider.GetRequiredService<DbContextOptions<RazorPagesMovieContext>>()))
            {
                // look for any movies
                if (!context.Movie.Any())
                {
                    context.Movie.AddRange(
                        new Movie
                        {
                            Title = "When Harry Met Sally",
                            ReleaseDate = DateTime.Parse("12/2/1989"),
                            Genre = "Romantic Comedy",
                            Price = 7.99M,
                            Rating = "R"
                        },
                        new Movie
                        {
                            Title = "Ghostbusters",
                            ReleaseDate = DateTime.Parse("13/3/1984"),
                            Genre = "Comedy",
                            Price = 8.99M,
                            Rating = "R"
                        },
                        new Movie
                        {
                            Title = "Ghostbusters 2",
                            ReleaseDate = DateTime.Parse("23/2/1986"),
                            Genre = "Comedy",
                            Price = 9.99M,
                            Rating = "R"
                        },
                        new Movie
                        {
                            Title="Rio Bravo",
                            ReleaseDate=DateTime.Parse("15/4/1954"),
                            Genre="Western",
                            Price=3.99M,
                            Rating="R"
                        }
                        );

                    context.SaveChanges();
                }
            }
        }
    }
}
