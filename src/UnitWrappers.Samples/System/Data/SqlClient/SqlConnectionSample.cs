using System.Data;
using NUnit.Framework;
using NSubstitute;
using UnitWrappers.System.Data.SqlClient;

namespace UnitWrappers.Samples.System.Data.SqlClient
{
    public class SqlConnectionSample
    {
        public ConnectionState OpenSqlConnection(ISqlConnection connection)
        {
            connection.Open();
            ConnectionState connectionState = connection.State;
            connection.Close();
            return connectionState;
        }
    }

    public class SqlConnectionSampleTests
    {
        [Test]
        public void OpenSqlConnection_test()
        {
            ISqlConnection connectionStub = Substitute.For<ISqlConnection>();
            connectionStub.State.Returns(ConnectionState.Open);
            Assert.AreEqual(ConnectionState.Open, new SqlConnectionSample().OpenSqlConnection(connectionStub));
          
            connectionStub.Received().Open();
            connectionStub.Received().Close();
        }
    }
}