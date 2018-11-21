using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Linq;

namespace RazorPagesMovie.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new RazorPagesMovieContext(
                serviceProvider.GetRequiredService<DbContextOptions<RazorPagesMovieContext>>()))
            {
                // Look for any movies.
                if (context.Movie.Any())
                {
                    return;   // DB has been seeded
                }

                context.Movie.AddRange(
                    new Movie
                    {
                        Title = "Fantastic Beasts: The Crimes of Grindelwald",
                        ReleaseDate = DateTime.Parse("2018-11-16"),
                        Genre = "Fantasy",
                        Price = 29.99M,
                           Rating = "R"
                    },

                    new Movie
                    {
                        Title = "Great Expectations",
                        ReleaseDate = DateTime.Parse("1861-1-1"),
                        Genre = "Novel",
                        Price = 8.99M,
                         Rating = "G"
                    },

                    new Movie
                    {
                        Title = " A Song of Ice and Fire",
                        ReleaseDate = DateTime.Parse("1996-09-01"),
                        Genre = "Fantasy",
                        Price = 19.99M,
                        Rating = "G"
                    },

                    new Movie
                    {
                        Title = "The Hobbit, or There and Back Again",
                        ReleaseDate = DateTime.Parse("1937-09-21"),
                        Genre = "High fantasy",
                        Price = 3.99M,
                           Rating = "R"
                    }
                );
                context.SaveChanges();
            }
        }
    }
}
