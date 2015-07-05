namespace Dal
{
    using Entities;
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class AtfrmContext : DbContext
    {
        // Your context has been configured to use a 'AtfrmContext' connection string from your application's 
        // configuration file (App.config or Web.config). By default, this connection string targets the 
        // 'Dal.AtfrmContext' database on your LocalDb instance. 
        // 
        // If you wish to target a different database and/or database provider, modify the 'AtfrmContext' 
        // connection string in the application configuration file.
        public AtfrmContext()
            : base("name=AtfrmContext")
        {
        }

        // Add a DbSet for each entity type that you want to include in your model. For more information 
        // on configuring and using a Code First model, see http://go.microsoft.com/fwlink/?LinkId=390109.

        public virtual DbSet<Book> Books { get; set; }
        public virtual DbSet<Author> Authors { get; set; }
    }

    //public class MyEntity
    //{
    //    public int Id { get; set; }
    //    public string Name { get; set; }
    //}
}