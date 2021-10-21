using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using MvcMovie.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcMovie.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new MvcMovieContext(
                serviceProvider.GetRequiredService<DbContextOptions<MvcMovieContext>>()))
            {
                //Look for any movies
                if (context.Movie.Any())
                {
                    return; //Db is already seeded
                }

                context.Movie.AddRange(
                    new Movie
                    {
                        Title = "Pulp Fiction",
                        ReleaseDate = DateTime.Parse("1994-10-14"),
                        Genre = "Romantic Comedy",
                        Price = 7.99M,
                        Rating = "R"
                    },
                    new Movie
                    {
                        Title = "Ghostbusters",
                        ReleaseDate = DateTime.Parse("1984-3-13"),
                        Genre = "Comedy",
                        Price = 8.99M,
                        Rating = "PG"
                    },
                    new Movie
                    {
                        Title = "Step Brothers",
                        ReleaseDate = DateTime.Parse("2008-07-28"),
                        Genre = "Comedy",
                        Price = 15.99M,
                        Rating = "R"
                    },
                    new Movie
                    {
                        Title = "Law Abiding Citizen",
                        ReleaseDate = DateTime.Parse("2009-10-16"),
                        Genre = "Action Thriller",
                        Price = 20.99M,
                        Rating = "R"
                    },
                    new Movie
                    {
                        Title = "Up",
                        ReleaseDate = DateTime.Parse("2009-5-29"),
                        Genre = "Animation Adventure",
                        Price = 7.99M,
                        Rating = "PG"
                    }
                    );
                context.SaveChanges();
            }
        }
    }
}
