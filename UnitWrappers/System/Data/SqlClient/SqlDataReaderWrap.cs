using System.Data.SqlClient;

namespace UnitWrappers.System.Data.SqlClient
{
    /// <summary>
    /// Wrapper for <see cref="T:System.Data.SqlClient.SqlDataReader"/> class.
    /// </summary>
    public class SqlDataReaderWrap : ISqlDataReader
    {
        /// <summary>
        /// Initializes a new instance of the SqlDataReaderWrap class. 
        /// </summary>
        /// <param name="dataReader">SqlDataReader object.</param>
        public SqlDataReaderWrap(SqlDataReader dataReader)
        {
            SqlDataReaderInstance = dataReader;
        }

        object ISqlDataReader.this[int i]
        {
            get { return SqlDataReaderInstance[i]; }
        }

        object ISqlDataReader.this[string name]
        {
            get { return SqlDataReaderInstance[name]; }
        }

        public SqlDataReader SqlDataReaderInstance { get; private set; }

        public void Close()
        {
            SqlDataReaderInstance.Close();
        }

        public bool Read()
        {
            return SqlDataReaderInstance.Read();
        }
    }
}