using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Security.Test
{
    [TestClass]
    public class UserManagementTest
    {
        [TestMethod]
        public void t()
        {
            var users = new User[]
            {
                new User("log1", "pass1"),
                new User("log2", "pass2"),
                new User("log3", "pass3")
            };
            var userManagement = new UserManagement();
            userManagement.AddRange(users);

        }
    }
}
