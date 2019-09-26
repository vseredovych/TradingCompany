using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TradingCompany.DAL.Core;
using TradingCompany.DAL.Database;
using TradingCompany.DAL.Models.Entities.Implementations;
using TradingCompany.DAL.Models.Filters.Implementations;
using TradingCompany.DAL.Repositories.Implementations;

namespace TradingCompany.ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            DbManager dbManager = new DbManager();
            MigrationManager migrationManager = new MigrationManager();
            migrationManager.DropTables();
            migrationManager.CreateTables();
            migrationManager.ImportStartValues();


            //dbManager.CommandExecuteNonQuery(@"insert into tblRole (Name) Values ('Admin'), ('Customer');");
            //var reader = dbManager.GetDataReader(@"select Id, Name from tblRole;");

            //while (reader.Read())
            //{
            //    Console.WriteLine("{0}\t{1}", reader.GetInt32(0),
            //                            reader.GetString(1));
            //}


            UsersRepository usersRepo = new UsersRepository();

            User entity = new User { FirstName = "Alll", LastName = "PPP", Email="AB@softserveinc.com", HashPassword="asd", RoleId=1 };
            //entity = usersRepo.Create(entity);

            //            Console.WriteLine(usersRepo.Update(entity));
            //usersRepo.Delete(new UserFilter() { FirstName = "Alll", Id = 1 });
            //var res = usersRepo.Update(entity, new UserFilter() { Id = 2 });
            //Console.WriteLine(usersRepo.Get(new UserFilter() {  }) );
            //IEnumerable<User> users = usersRepo.GetRange(new UserFilter() {Id  = 0, RoleId = 0 }, new UserFilter() { Id = 4, RoleId = 2 }, new UserFilter() { Email = "AB@softserveinc.com" });
            IEnumerable<User> users = usersRepo.GetAll(new UserFilter() { Id = 3} );

            foreach (User el in users)
            {
                Console.WriteLine("==================================");
                Console.WriteLine(el);
            }

            //Console.WriteLine(entity);
            //var _user = usersRepo.Get(0
            //Console.WriteLine(_user.FirstName + _user.LastName);


            Console.Read();

        }
    }
}
