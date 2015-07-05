namespace ATFRMWebApi.Migrations
{
    using Dal;
    using Entities;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<AtfrmContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(AtfrmContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //

            context.Authors.AddOrUpdate(
                b => b.Id,
                new Author { Id = 1, Name = "Rudy Clement" },
                new Author { Id = 2, Name = "Florent Ritz" },
                new Author { Id = 3, Name = "Yann Bertrand" }
            );

            context.Books.AddOrUpdate(
                b => b.Id,
                new Book { Id = 1, AuthorId = 1, Name = "Le horla", Description = "Description du livre 'Le horla'", Isbn = "DS484E" },
                new Book { Id = 2, AuthorId = 2, Name = "Candide", Description = "Description du livre 'Candide'", Isbn = "EF484S" },
                new Book { Id = 3, AuthorId = 3, Name = "Exemple", Description = "Description du livre 'Au hasard'", Isbn = "8748FS" }
            );
        }
    }
}
