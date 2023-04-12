using Microsoft.EntityFrameworkCore;
using MVC.Data;

namespace MVC.Models
{
    public static class SeedDataGames
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new MVCContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<MVCContext>>()))
            {
                // Look for any Games.
                if (context.Game.Any())
                {
                    return;   // DB has been seeded
                }
                context.Game.AddRange(
                    new Game
                    {
                        Title = "When Harry Met Sally",
                        ReleaseDate = DateTime.Parse("1989-2-12"),
                        Genre = "Romantic Comedy",
                        Price = 7.99M
                    },
                    new Game
                    {
                        Title = "Ghostbusters ",
                        ReleaseDate = DateTime.Parse("1984-3-13"),
                        Genre = "Comedy",
                        Price = 8.99M
                    },
                    new Game
                    {
                        Title = "Ghostbusters 2",
                        ReleaseDate = DateTime.Parse("1986-2-23"),
                        Genre = "Comedy",
                        Price = 9.99M
                    },
                    new Game
                    {
                        Title = "Rio Bravo",
                        ReleaseDate = DateTime.Parse("1959-4-15"),
                        Genre = "Western",
                        Price = 3.99M
                    }
                );
                context.SaveChanges();
            }
        }
    }
}
