using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;


namespace EFSeedDatabase
{
    public class EFContext : DbContext
    {
        public EFContext()
            : base("EFDatabase")
        {

            Database.SetInitializer(new EFInitializer());

        }

        public DbSet<User> Users { get; set; }

    }

    //public class EFInitializer : DropCreateDatabaseAlways<EFContext>
    //{

    //    protected override void Seed(EFContext context)
    //    {
    //        context.Users.Add(new User() { Name = "User 1", Email = "user1@gmail.com" });
    //        context.Users.Add(new User() { Name = "User 2", Email = "user2@gmail.com" });
    //        context.SaveChanges();

    //        base.Seed(context);
    //    }

    //}


    public class EFInitializer : IDatabaseInitializer<EFContext>
    {
        public void InitializeDatabase(EFContext context)
        {

                context.Database.Delete();
                context.Database.Create();
                Seed(context);
         


        }


        protected virtual void Seed(EFContext context)
        {
            /// Our seed code


            context.Users.Add(new User() { Name = "User 1", Email = "user1@gmail.com" });
            context.Users.Add(new User() { Name = "User 2", Email = "user2@gmail.com" });
            context.SaveChanges();
        }

    }


    
}
