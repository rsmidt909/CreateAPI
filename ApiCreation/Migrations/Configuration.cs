namespace ApiCreation.Migrations
{
    using ApiCreation.Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<ApiCreation.Models.ApplicationDbContext>
    {
        public ApplicationDbContext db;
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            db = new ApplicationDbContext();
        }

        protected override void Seed(ApiCreation.Models.ApplicationDbContext db)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.
    //        db.Movies.AddOrUpdate(
    //new Models.Movie { Title = "The Departed", Genre = "Drama", DirectorName = "Martin Scorsese" },
    //new Models.Movie { Title = "The Dark Knight", Genre = "Drama", DirectorName = "Christopher Nolan" },
    //new Models.Movie { Title = "Inception", Genre = "Drama", DirectorName = "Christopher Nolan" },
    //new Models.Movie { Title = "Pineapple Express", Genre = "Comedy", DirectorName = "David Gordon Green" },
    //new Models.Movie { Title = "Die Hard", Genre = "Action", DirectorName = "John McTiernan" }
//);
        }
    }
}
