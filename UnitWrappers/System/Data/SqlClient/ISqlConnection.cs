using System;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;

namespace UnitWrappers.System.Data.SqlClient
{
    /// <summary>
    /// Wrapper for <see cref="T:System.Data.SqlClient.SqlConnection"/> class.
    /// </summary>
    public interface ISqlConnection : IDbConnection, ICloneable
    {

        // Properties

        /// <summary>
        /// Gets the name of the instance of SQL Server to which to connect. 
        /// </summary>
        [Browsable(true)]
        string DataSource { get; }
        /// <summary>
        /// Gets or sets the FireInfoMessageEventOnUserErrors property.
        /// </summary>
        bool FireInfoMessageEventOnUserErrors { get; set; }
        /// <summary>
        /// Gets the size (in bytes) of network packets used to communicate with an instance of SQL Server.
        /// </summary>
        int PacketSize { get; }
        /// <summary>
        /// Gets a string that contains the version of the instance of SQL Server to which the client is connected.
        /// </summary>
        [Browsable(false)]
        string ServerVersion { get; }
        /// <summary>
        /// Gets <see cref="T:System.Data.SqlClient.SqlConnection"/> object.
        /// </summary>
        SqlConnection UnderlyingObject { get; }
        /// <summary>
        /// Indicates the state of the SqlConnection.
        /// </summary>
        [Browsable(false)]
        ConnectionState State { get; }
        /// <summary>
        /// When set to true, enables statistics gathering for the current connection.
        /// </summary>
        bool StatisticsEnabled { get; set; }
        /// <summary>
        /// Gets a string that identifies the database client.
        /// </summary>
        string WorkstationId { get; }

        // Methods
        
        /*
         * 
             // Events
            [ResCategory("DataCategory_InfoMessage"), ResDescription("DbConnection_InfoMessage")]
            public event SqlInfoMessageEventHandler InfoMessage;

            // Methods
            public SqlTransaction BeginTransaction();
            public SqlTransaction BeginTransaction(IsolationLevel iso);
            public SqlTransaction BeginTransaction(string transactionName);
            public SqlTransaction BeginTransaction(IsolationLevel iso, string transactionName);
            public override void ChangeDatabase(string database);
            public static void ChangePassword(string connectionString, string newPassword);
            public static void ClearAllPools();
            public static void ClearPool(SqlConnection connection);
            public override void Close();
            public SqlCommand CreateCommand();
            public void EnlistDistributedTransaction(ITransaction transaction);
            public override void EnlistTransaction(Transaction transaction);
            public override DataTable GetSchema();
            public override DataTable GetSchema(string collectionName);
            public override DataTable GetSchema(string collectionName, string[] restrictionValues);
            public void ResetStatistics();
            public IDictionary RetrieveStatistics();
        */

    }
}