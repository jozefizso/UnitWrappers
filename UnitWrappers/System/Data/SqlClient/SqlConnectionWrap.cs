using System;
using System.Data;
using System.Data.SqlClient;

namespace UnitWrappers.System.Data.SqlClient
{
    /// <summary>
    /// Wrapper for <see cref="T:System.Data.SqlClient.SqlConnection"/> class.
    /// </summary>
    public class SqlConnectionWrap : ISqlConnection
    {
        public SqlConnection UnderlyingObject { get; private set; }

        /// <summary>
        /// Initializes a new instance of the SqlConnectionWrap class. 
        /// </summary>
        public SqlConnectionWrap()
        {
            UnderlyingObject = new SqlConnection();
        }


        /// <summary>
        /// Initializes a new instance of the SqlConnectionWrap class. 
        /// </summary>
        /// <param name="connection">SqlConnection object.</param>
        public SqlConnectionWrap(SqlConnection connection)
        {
            UnderlyingObject = connection;
        }

        /// <summary>
        /// Initializes a new instance of the SqlConnection class when given a string that contains the connection string. 
        /// </summary>
        /// <param name="connectionString">The connection used to open the SQL Server database.</param>
        public SqlConnectionWrap(string connectionString)
        {
            UnderlyingObject = new SqlConnection(connectionString);
        }

        /// <summary>
        /// Gets or sets the string used to open a SQL Server database. 
        /// </summary>
        public string ConnectionString
        {
            get { return UnderlyingObject.ConnectionString; }
            set { UnderlyingObject.ConnectionString = value; }
        }
        /// <summary>
        /// Gets the time to wait while trying to establish a connection before terminating the attempt and generating an error.
        /// </summary>
        public int ConnectionTimeout
        {
            get { return UnderlyingObject.ConnectionTimeout; }
        }
        /// <summary>
        /// Gets the name of the current database or the database to be used after a connection is opened.
        /// </summary>
        public string Database
        {
            get { return UnderlyingObject.Database; }
        }

        public string DataSource
        {
            get { return UnderlyingObject.DataSource; }
        }

        public bool FireInfoMessageEventOnUserErrors
        {
            get { return UnderlyingObject.FireInfoMessageEventOnUserErrors; }
            set { UnderlyingObject.FireInfoMessageEventOnUserErrors = value; }
        }

        public int PacketSize
        {
            get { return UnderlyingObject.PacketSize; }
        }

        public string ServerVersion
        {
            get { return UnderlyingObject.ServerVersion; }
        }

        public ConnectionState State
        {
            get { return UnderlyingObject.State; }
        }

        public bool StatisticsEnabled
        {
            get { return UnderlyingObject.StatisticsEnabled; }
            set { UnderlyingObject.StatisticsEnabled = value; }
        }

        public string WorkstationId
        {
            get { return UnderlyingObject.WorkstationId; }
        }

        public IDbTransaction BeginTransaction()
        {
            return UnderlyingObject.BeginTransaction();
        }

        public IDbTransaction BeginTransaction(IsolationLevel il)
        {
            return UnderlyingObject.BeginTransaction(il);
        }

        /// <summary>
        /// Closes the connection to the database. This is the preferred method of closing any open connection.
        /// </summary>
        public void Close()
        {
            UnderlyingObject.Close();
        }

        public void ChangeDatabase(string databaseName)
        {
          UnderlyingObject.ChangeDatabase(databaseName);
        }

        public IDbCommand CreateCommand()
        {
            return UnderlyingObject.CreateCommand();
        }

        /// <summary>
        /// Opens a database connection with the property settings specified by the ConnectionString. 
        /// </summary>
        public void Open()
        {
            UnderlyingObject.Open();
        }

        public void Dispose()
        {
           UnderlyingObject.Dispose();
        }

        object ICloneable.Clone()
        {
            return new SqlConnectionWrap((UnderlyingObject as ICloneable).Clone() as SqlConnection);
        }
    }
}