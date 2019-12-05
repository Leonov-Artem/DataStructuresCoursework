using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Security.Test
{
    [TestClass]
    public class UserManagementTest
    {
        UserManagement _userManagement;

        [TestInitialize]
        public void Init()
        {
            _userManagement = new UserManagement();
            var expected = new User[]
            {
                new User("log1", "pass1"),
                new User("log2", "pass2"),
                new User("log3", "pass3")
            };
            _userManagement.AddRange(expected);
        }

        [TestMethod]
        public void AddTest()
        {
            var expected = new List<string>() { "log1", "log2", "log3" };
            var actual = _userManagement.UserLogins();
            CollectionAssert.AreEquivalent(actual, expected);
        }

        [TestMethod]
        public void FindTest()
        {
            Assert.IsTrue(_userManagement.Find(new User("log2", "pass2")));
            Assert.IsFalse(_userManagement.Find(new User("log2", "pass3")));
        }

        [TestMethod]
        public void FindLoginTest()
        {
            Assert.IsTrue(_userManagement.FindLogin("log2"));
            Assert.IsFalse(_userManagement.FindLogin("log5"));
        }

        [TestMethod]
        public void DeleteTest()
        {
            _userManagement.Delete("log2");
            Assert.IsFalse(_userManagement.FindLogin("log2"));
        }
    }
}
