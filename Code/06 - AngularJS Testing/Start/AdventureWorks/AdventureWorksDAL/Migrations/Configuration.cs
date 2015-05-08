namespace AdventureWorksDAL.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<AdventureWorksDAL.AdventureWorksContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(AdventureWorksDAL.AdventureWorksContext context)
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

            Random r = new Random();

            context.Products.AddOrUpdate(x => x.ProductID,
                new Product() { ProductID = 1, Name = "Adjustable Race", Color = null, ListPrice = (decimal)r.NextDouble() * 100 },
                new Product() { ProductID = 2, Name = "Bearing Ball", Color = null, ListPrice = (decimal)r.NextDouble() * 100 },
                new Product() { ProductID = 3, Name = "BB Ball Bearing", Color = null, ListPrice = (decimal)r.NextDouble() * 100 },
                new Product() { ProductID = 4, Name = "Headset Ball Bearings", Color = null, ListPrice = (decimal)r.NextDouble() * 100 },
                new Product() { ProductID = 5, Name = "Blade", Color = null, ListPrice = (decimal)r.NextDouble() * 100 },
                new Product() { ProductID = 6, Name = "LL Crankarm", Color = "Black", ListPrice = (decimal)r.NextDouble() * 100 },
                new Product() { ProductID = 7, Name = "ML Crankarm", Color = "Black", ListPrice = (decimal)r.NextDouble() * 100 },
                new Product() { ProductID = 8, Name = "HL Crankarm", Color = "Black", ListPrice = (decimal)r.NextDouble() * 100 },
                new Product() { ProductID = 9, Name = "Chainring Bolts", Color = "Silver", ListPrice = (decimal)r.NextDouble() * 100 },
                new Product() { ProductID = 10, Name = "Chainring Nut", Color = "Silver", ListPrice = (decimal)r.NextDouble() * 100 },
                new Product() { ProductID = 11, Name = "Chainring", Color = "Black", ListPrice = (decimal)r.NextDouble() * 100 },
                new Product() { ProductID = 12, Name = "Crown Race", Color = null, ListPrice = (decimal)r.NextDouble() * 100 },
                new Product() { ProductID = 13, Name = "Chain Stays", Color = null, ListPrice = (decimal)r.NextDouble() * 100 },
                new Product() { ProductID = 14, Name = "Decal 1", Color = null, ListPrice = (decimal)r.NextDouble() * 100 },
                new Product() { ProductID = 15, Name = "Decal 2", Color = null, ListPrice = (decimal)r.NextDouble() * 100 },
                new Product() { ProductID = 16, Name = "Down Tube", Color = null, ListPrice = (decimal)r.NextDouble() * 100 },
                new Product() { ProductID = 17, Name = "Mountain End Caps", Color = null, ListPrice = (decimal)r.NextDouble() * 100 },
                new Product() { ProductID = 18, Name = "Road End Caps", Color = null, ListPrice = (decimal)r.NextDouble() * 100 },
                new Product() { ProductID = 19, Name = "Touring End Caps", Color = null, ListPrice = (decimal)r.NextDouble() * 100 },
                new Product() { ProductID = 20, Name = "Fork End", Color = null, ListPrice = (decimal)r.NextDouble() * 100 }
            );
        }
    }
}
