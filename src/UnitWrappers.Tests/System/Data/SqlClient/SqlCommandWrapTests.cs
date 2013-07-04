using System.Data.SqlClient;
using NUnit.Framework;
using NSubstitute;
using UnitWrappers.System.Data.SqlClient;

namespace UnitWrappers.Tests.System.Data.SqlClient
{
	[TestFixture]
	public class SqlCommandWrapTests
	{

		[Test]
		public void Constructor_1_Sets_Command_Instance()
		{
			var instance = new SqlCommandWrap();
		Assert.IsNotNull(instance.SqlCommandInstance);
		}

		[Test]
		public void Constructor_2_Sets_Command_Instance()
		{
			var newCmd = new SqlCommand();
			var instance = new SqlCommandWrap(newCmd);
		Assert.AreSame(newCmd, instance.SqlCommandInstance);
		}

		[Test]
		public void Constructor_3_Sets_Command_Instance()
		{
			var instance = new SqlCommandWrap("command text string");
		Assert.IsNotNull(instance.SqlCommandInstance);
		}

		[Test]
		public void Constructor_4_Sets_Command_Instance()
		{
            var mockConnWrap = NSubstitute.Substitute.For<ISqlConnection>();
			var instance = new SqlCommandWrap("command text string", mockConnWrap);
		Assert.IsNotNull(instance.SqlCommandInstance);
		}


		[Test]
		public void Initialize_1_Sets_Command_Instance()
		{
			var instance = new SqlCommandWrap();
		Assert.IsNotNull(instance.SqlCommandInstance);
		}

		[Test]
		public void Initialize_2_Sets_Command_Instance()
		{
            var newCmd = new SqlCommand();
            var instance = new SqlCommandWrap(newCmd);
		Assert.AreSame(newCmd, instance.SqlCommandInstance);
		}

		[Test]
		public void Initialize_3_Sets_Command_Instance()
		{
            var instance = new SqlCommandWrap("command text string");
		Assert.IsNotNull(instance.SqlCommandInstance);
		}

		[Test]
		public void Initialize_4_Sets_Command_Instance()
		{
            var mockConnWrap = NSubstitute.Substitute.For<ISqlConnection>();
            var instance = new SqlCommandWrap("command text string", mockConnWrap);
		Assert.IsNotNull(instance.SqlCommandInstance);
		}

	}
}