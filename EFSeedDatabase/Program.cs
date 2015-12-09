using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFSeedDatabase
{
    class Program
    {
        static void Main(string[] args)
        {

            User usr = new User() { Name = "User Name", Email = "user@gmail.com" };

            try
            {
                using (var ctx = new EFContext())
                {
                    ctx.Users.Add(usr);
                    ctx.SaveChanges();
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.WriteLine("Press any key to close");
            Console.ReadKey();

        }
    }
}
