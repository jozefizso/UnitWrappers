using System;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;

namespace UnitWrappers.System.Data.SqlClient
{
    /// <summary>
    /// Wrapper for <see cref="T:System.Data.SqlClient.SqlDataReader"/> class.
    /// </summary>
    public class SqlDataReaderWrap : ISqlDataReader
    {
        public SqlDataReader UnderlyingObject { get; private set; }

        /// <summary>
        /// Initializes a new instance of the SqlDataReaderWrap class. 
        /// </summary>
        /// <param name="dataReader">SqlDataReader object.</param>
        public SqlDataReaderWrap(SqlDataReader dataReader)
        {
            UnderlyingObject = dataReader;
        }

        /// <inheritdoc />
        public string GetName(int i)
        {
            return UnderlyingObject.GetName(i);
        }
        /// <inheritdoc />
        public string GetDataTypeName(int i)
        {
            return UnderlyingObject.GetDataTypeName(i);
        }
        /// <inheritdoc />
        public Type GetFieldType(int i)
        {
            return UnderlyingObject.GetFieldType(i);
        }
        /// <inheritdoc />
        public object GetValue(int i)
        {
            return UnderlyingObject.GetValue(i);
        }
        /// <inheritdoc />
        public int GetValues(object[] values)
        {
            return UnderlyingObject.GetValues(values);
        }
        /// <inheritdoc />
        public int GetOrdinal(string name)
        {
            return UnderlyingObject.GetOrdinal(name);
        }
        /// <inheritdoc />
        public bool GetBoolean(int i)
        {
            return UnderlyingObject.GetBoolean(i);
        }
        /// <inheritdoc />
        public byte GetByte(int ordinal)
        {
            return UnderlyingObject.GetByte(ordinal);
        }
        /// <inheritdoc />
        public long GetBytes(int i, long fieldOffset, byte[] buffer, int bufferoffset, int length)
        {
            return UnderlyingObject.GetBytes(i, fieldOffset, buffer, bufferoffset,length);
        }
        /// <inheritdoc />
        public char GetChar(int i)
        {
            return UnderlyingObject.GetChar(i);
        }
        /// <inheritdoc />
        public long GetChars(int i, long fieldoffset, char[] buffer, int bufferoffset, int length)
        {
            return UnderlyingObject.GetChars(i, fieldoffset, buffer, bufferoffset, length);
        }
        /// <inheritdoc />
        public Guid GetGuid(int i)
        {
            return UnderlyingObject.GetGuid(i);
        }
        /// <inheritdoc />
        public short GetInt16(int i)
        {
            return UnderlyingObject.GetInt16(i);
        }
        /// <inheritdoc />
        public int GetInt32(int i)
        {
            return UnderlyingObject.GetInt32(i);
        }
        /// <inheritdoc />
        public long GetInt64(int i)
        {
            return UnderlyingObject.GetInt64(i);
        }
        /// <inheritdoc />
        public float GetFloat(int i)
        {
            return UnderlyingObject.GetFloat(i);
        }
        /// <inheritdoc />
        public double GetDouble(int i)
        {
            return UnderlyingObject.GetDouble(i);
        }
        /// <inheritdoc />
        public string GetString(int i)
        {
            return UnderlyingObject.GetString(i);
        }
        /// <inheritdoc />
        public decimal GetDecimal(int i)
        {
            return UnderlyingObject.GetDecimal(i);
        }
        /// <inheritdoc />
        public DateTime GetDateTime(int i)
        {
            return UnderlyingObject.GetDateTime(i);
        }
        /// <inheritdoc />
        public IDataReader GetData(int i)
        {
            return UnderlyingObject.GetData(i);
        }
        /// <inheritdoc />
        public bool IsDBNull(int i)
        {
            return UnderlyingObject.IsDBNull(i);
        }
        /// <inheritdoc />
        public int FieldCount
        {
            get { return UnderlyingObject.FieldCount; }
        }
        /// <inheritdoc />
        object IDataRecord.this[int i]
        {
            get { return UnderlyingObject[i]; }
        }
        /// <inheritdoc />
        object IDataRecord.this[string name]
        {
            get { return (IDataRecord)UnderlyingObject[name]; }
        }
        /// <inheritdoc />
        object ISqlDataReader.this[int i]
        {
            get { return (ISqlDataReader)UnderlyingObject[i]; }
        }
        /// <inheritdoc />
        object ISqlDataReader.this[string name]
        {
            get { return (ISqlDataReader)UnderlyingObject[name]; }
        }

        /// <inheritdoc />
        public void Close()
        {
            UnderlyingObject.Close();
        }
        /// <inheritdoc />
        public DataTable GetSchemaTable()
        {
            return UnderlyingObject.GetSchemaTable();
        }
        /// <inheritdoc />
        public bool NextResult()
        {
            return UnderlyingObject.NextResult();
        }

        /// <inheritdoc />
        public bool Read()
        {
            return UnderlyingObject.Read();
        }
        /// <inheritdoc />
        public int Depth
        {
            get { return UnderlyingObject.Depth; }
        }
        /// <inheritdoc />
        public bool IsClosed
        {
            get { return UnderlyingObject.IsClosed; }
        }
        /// <inheritdoc />
        public int RecordsAffected
        {
            get { return UnderlyingObject.RecordsAffected; }
        }

        /// <inheritdoc />
        public void Dispose()
        {
            UnderlyingObject.Dispose();
        }
    }
}