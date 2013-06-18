using System;
using System.Data;
using System.Data.SqlClient;

namespace UnitWrappers.System.Data.SqlClient
{
    /// <summary>
    /// Wrapper for <see cref="T:System.Data.SqlClient.SqlDataReader"/> class.
    /// </summary>
    public interface ISqlDataReader:  IDataReader
    {

        /// <summary>
        /// Gets <see cref="T:System.Data.SqlClient.SqlDataReader"/> object.
        /// </summary>
        SqlDataReader UnderlyingObject { get; }


 
        /*
                 // Methods
            public override bool GetBoolean(int i);
            public override byte GetByte(int i);
            public override long GetBytes(int i, long dataIndex, byte[] buffer, int bufferIndex, int length);
            public override char GetChar(int i);
            public override long GetChars(int i, long dataIndex, char[] buffer, int bufferIndex, int length);
            public override string GetDataTypeName(int i);
            public override DateTime GetDateTime(int i);
            public virtual DateTimeOffset GetDateTimeOffset(int i);
            public override decimal GetDecimal(int i);
            public override double GetDouble(int i);
            public override IEnumerator GetEnumerator();
            public override Type GetFieldType(int i);
            public override float GetFloat(int i);
            public override Guid GetGuid(int i);
            public override short GetInt16(int i);
            public override int GetInt32(int i);
            public override long GetInt64(int i);
            public override string GetName(int i);
            public override int GetOrdinal(string name);
            public override Type GetProviderSpecificFieldType(int i);
            public override object GetProviderSpecificValue(int i);
            public override int GetProviderSpecificValues(object[] values);
            public override DataTable GetSchemaTable();
            public virtual SqlBinary GetSqlBinary(int i);
            public virtual SqlBoolean GetSqlBoolean(int i);
            public virtual SqlByte GetSqlByte(int i);
            public virtual SqlBytes GetSqlBytes(int i);
            public virtual SqlChars GetSqlChars(int i);
            public virtual SqlDateTime GetSqlDateTime(int i);
            public virtual SqlDecimal GetSqlDecimal(int i);
            public virtual SqlDouble GetSqlDouble(int i);
            public virtual SqlGuid GetSqlGuid(int i);
            public virtual SqlInt16 GetSqlInt16(int i);
            public virtual SqlInt32 GetSqlInt32(int i);
            public virtual SqlInt64 GetSqlInt64(int i);
            public virtual SqlMoney GetSqlMoney(int i);
            public virtual SqlSingle GetSqlSingle(int i);
            public virtual SqlString GetSqlString(int i);
            public virtual object GetSqlValue(int i);
            public virtual int GetSqlValues(object[] values);
            public virtual SqlXml GetSqlXml(int i);
            public override string GetString(int i);
            public virtual TimeSpan GetTimeSpan(int i);
            public override object GetValue(int i);
            public override int GetValues(object[] values);
            public override bool IsDBNull(int i);
            public override bool NextResult();
            IDataReader IDataRecord.GetData(int i);

            // Properties
            public override int Depth { get; }
            public override int FieldCount { get; }
            public override bool HasRows { get; }
            public override bool IsClosed { get; }
            public override object this[int i] { get; }
            public override object this[string name] { get; }
            public override int RecordsAffected { get; }
            public override int VisibleFieldCount { get; }

        */

    }
}