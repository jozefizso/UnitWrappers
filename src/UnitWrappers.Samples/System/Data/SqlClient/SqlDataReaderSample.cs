using System.Collections.Generic;
using NUnit.Framework;
using NSubstitute;
using UnitWrappers.System.Data.SqlClient;

namespace UnitWrappers.Samples.System.Data.SqlClient
{
    public class SqlDataReaderSample
    {
        public List<string> ReadData(ISqlDataReader reader)
        {
            List<string> result = new List<string>();
            try
            {
                while (reader.Read())
                    result.Add(string.Format("{0}", reader[0]));
            }
            finally
            {
                reader.Close();
            }
            return result;
        }
    }

    public class SqlDataReaderSampleTests
    {
        [Test]
        public void ReadData_test()
        {
            ISqlDataReader readerStub = NSubstitute.Substitute.For<ISqlDataReader>();
            readerStub.Read().Returns(true,true,false);
            List<string> result = new SqlDataReaderSample().ReadData(readerStub);
            readerStub.Received(2);
            Assert.AreEqual(2, result.Count);
        }
    }
}