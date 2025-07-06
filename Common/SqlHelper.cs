using SqlSugar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PQToolBoxCore.Common
{
    public class SqlHelper
    {
        private static SqlHelper _instance;
        public static SqlHelper Instance => _instance ??= new SqlHelper();
        protected SqlHelper()
        {
            _client = new SqlSugarClient(new ConnectionConfig()
            {
                DbType = DbType.Sqlite,
                ConnectionString = "Data Source=main.db3",
                InitKeyType = InitKeyType.Attribute,
                IsAutoCloseConnection = true,
            });
        }
        private SqlSugarClient _client;
        public SqlSugarClient Client => _client;

    }
}
