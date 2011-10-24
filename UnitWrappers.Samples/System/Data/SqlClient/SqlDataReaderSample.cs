using System.Collections.Generic;
using NUnit.Framework;
using Rhino.Mocks;
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
            ISqlDataReader readerStub = MockRepository.GenerateStub<ISqlDataReader>();
            readerStub.Stub(x => x.Read()).Return(true).Repeat.Twice();
            List<string> result = new SqlDataReaderSample().ReadData(readerStub);
            Assert.AreEqual(2, result.Count);
        }
    }
}