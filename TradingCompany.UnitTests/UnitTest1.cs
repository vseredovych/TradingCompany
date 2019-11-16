using NUnit.Framework;
using TradingCompany.DAL.Repositories.Implementations;
using TradingCompany.DAL.Models.Entities.Implementations;

namespace Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {

        }

        [Test]
        public void Test1()
        {
            UsersRepository users = new UsersRepository();
            User user = new User() { Id = 1, Email = "noemail@gmail.com", FirstName="Viktor", HashPassword="qwerty", LastName="Surname", RoleId=1};
            Assert.AreEqual(user.Id, 1);
            Assert.AreEqual(user.Email, "noemail@gmail.com");
            Assert.AreEqual(user.FirstName, "Viktor");
            Assert.AreEqual(user.LastName, "Surname");
            Assert.AreEqual(user.HashPassword, "qwerty");
            Assert.AreEqual(user.RoleId, 1);
        }
    }
}