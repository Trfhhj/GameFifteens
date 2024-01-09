using GameFifteens2;

namespace GameFifteens5Test
{
    [TestFixture]
    public class Tests
    {
        private DB db;

        [SetUp]
        public void Setup()
        {
            db = new DB();
        }

        [Test]
        public void HasConnectToDatabase_ReturnsTrue()
        {
            db.openConnection();
            Assert.True(db.IsConnectionOpen());
        }

        [Test]
        public void LoginTest_ExistingUserLogin_ReturnsTrue()
        {
            Assert.True(db.Login("sun", "123"));
        }

        [Test]
        public void LoginTest_UserLoginIsEmpty_ReturnsFalse()
        {
            Assert.False(db.Login("", "123"));
        }
    }
}