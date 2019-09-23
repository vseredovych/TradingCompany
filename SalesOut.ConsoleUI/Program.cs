using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SalesOut.DAL.Core;
using SalesOut.DAL.Repositories.Implementations;

namespace SalesOut.ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            DbManager dbManager = new DbManager();

            //dbManager.CommandExecuteNonQuery(@"insert into tblRole (Name) Values ('Admin'), ('Customer');");
            //var reader = dbManager.GetDataReader(@"select Id, Name from tblRole;");

            //while (reader.Read())
            //{
            //    Console.WriteLine("{0}\t{1}", reader.GetInt32(0),
            //                            reader.GetString(1));
            //}


            UsersRepository usersRepo = new UsersRepository();

            User user = new User { Id = 14, FirstName = "Alll", LastName = "BASD", Email="AB@gmail.com", HashPassword="asd", RoleId="asd" };
            //user = usersRepo.Create(user);

            //            Console.WriteLine(usersRepo.Update(user));

            var res = usersRepo.Update(user);

            IEnumerable<User> users = usersRepo.GetRange(3, 15);
            foreach (User el in users)
            {
                Console.WriteLine("==================================");
                Console.WriteLine(el);
            }

            //Console.WriteLine(user);
            //var _user = usersRepo.Get(0
            //Console.WriteLine(_user.FirstName + _user.LastName);


            Console.Read();

        }
    }
}
