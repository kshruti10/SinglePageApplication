namespace SinglePageApplication.Migrations
{
    using SinglePageApplication.Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<SinglePageApplication.Data.SinglePageApplicationContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(SinglePageApplication.Data.SinglePageApplicationContext context)
        {
            context.ShoppingLists.AddOrUpdate(
                new ShoppingList
                {
                    Name = "Groceries",
                    Items =
                    {
                        new Item { Name = "Milk" },
                        new Item { Name = "Strawberries" },
                        new Item { Name = "Cornflakes" },
                    }
                    },
                    new ShoppingList
                    {
                        Name = "Hardware"
                    }
                
                );
        }
    }
}
