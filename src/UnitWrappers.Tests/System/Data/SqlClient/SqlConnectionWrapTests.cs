using System.Data.SqlClient;
using NUnit.Framework;

using UnitWrappers.System.Data.SqlClient;

namespace UnitWrappers.Tests.System.Data.SqlClient
{
    [TestFixture]
    public class SqlConnectionWrapTests
    {

         

			[Test]
			public void Constructor_1_Sets_SqlConnectionInstance()
			{
				var instance = new SqlConnectionWrap();
			Assert.IsNotNull(instance.UnderlyingObject);
			}

			[Test]
			public void Constructor_2_Sets_SqlConnectionInstance()
			{
				var newConn = new SqlConnection();
				var instance = new SqlConnectionWrap(newConn);
			Assert.AreSame(newConn, instance.UnderlyingObject);
			}

			[Test]
			public void Constructor_3_Sets_SqlConnectionInstance()
			{
				var instance = new SqlConnectionWrap("Data Source=myServerAddress;Initial Catalog=myDataBase;Integrated Security=SSPI;");
			Assert.IsNotNull(instance.UnderlyingObject);
			}


			[Test]
			public void Initialize_1_Sets_SqlConnectionInstance()
			{
				var instance = new SqlConnectionWrap();
			Assert.IsNotNull(instance.UnderlyingObject);
			}

			[Test]
			public void Initialize_2_Sets_SqlConnectionInstance()
			{
                var newCmd = new SqlConnection();
                var instance = new SqlConnectionWrap(newCmd);
			Assert.AreSame(newCmd, instance.UnderlyingObject);
			}

			[Test]
			public void Initialize_3_Sets_SqlConnectionInstance()
			{
                var instance = new SqlConnectionWrap("Data Source=myServerAddress;Initial Catalog=myDataBase;Integrated Security=SSPI;");
			Assert.IsNotNull(instance.UnderlyingObject);
			}
    }
}