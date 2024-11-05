using MySql.Data.MySqlClient;
using MMABooksTools;
using NUnit.Framework;

namespace MMABooksTests
{
    internal class DBConnectionTest
    {
        [TestFixture]
        public class MySqlConnectionTests
        {
            [Test]
            public void TestMySqlConnection()
            {
                string connectionString = ConfigDB.GetMySqlConnectionString();

                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();
                    Assert.AreEqual(System.Data.ConnectionState.Open, connection.State,
                        "Connection to MySQL database was not successful.");
                }
            }
        }
    }
}
