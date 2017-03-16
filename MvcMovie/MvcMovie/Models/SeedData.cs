using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Linq;

namespace MvcMovie.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new MvcMovieContext(
                serviceProvider.GetRequiredService<DbContextOptions<MvcMovieContext>>()))
            {
                // Look for any movies.
                if (context.Movie.Any())
                {
                    return;   // DB has been seeded
                }

                context.Movie.AddRange(
                     new Movie
                     {
                         Title = "Meet the Mormons",
                         ReleaseDate = DateTime.Parse("2015-2-26"),
                         Genre = "Documentary",
                         Rating = "PG",
                         Price = 9.99M
                     },

                     new Movie
                     {
                         Title = "The Saratov Approach",
                         ReleaseDate = DateTime.Parse("2013-10-9"),
                         Genre = "Action",
                         Rating = "PG-13",
                         Price = 19.99M
                     },

                     new Movie
                     {
                         Title = "17 Miracles",
                         ReleaseDate = DateTime.Parse("2011-6-7"),
                         Genre = "Adventure",
                         Rating = "PG",
                         Price = 19.99M
                     },

                   new Movie
                   {
                       Title = "Saturday's Warrior",
                       ReleaseDate = DateTime.Parse("2016-4-1"),
                       Genre = "Musical",
                       Rating = "PG",
                       Price = 19.99M
                   }
                );
                context.SaveChanges();
            }
        }
    }
}