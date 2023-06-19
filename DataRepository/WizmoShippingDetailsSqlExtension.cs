using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.CodeAnalysis.Operations;
using Microsoft.EntityFrameworkCore;
using ShippingTrackingAPI.DataRepository;
using System.Data.Common;
using System.Reflection;

namespace ShippingTrackingAPI.Data
{
    public static class WizmoShippingDetailsSqlExtension
    {
        public static DbCommand LoadStoreProcedure(this WizmoShippingDetailsContext context, string storeprocedureName)
        {
            DbCommand dbCommand = context.Database.GetDbConnection().CreateCommand();
            dbCommand.CommandText = storeprocedureName;
            dbCommand.CommandType = System.Data.CommandType.StoredProcedure;
            return dbCommand;
        }

        public static DbCommand WithSqlParams(this DbCommand command, params (string, object)[] namedValues)
        {
            foreach (var namedValue in namedValues)
            {
                var param = command.CreateParameter();
                param.ParameterName = namedValue.Item1;
                param.Value = namedValue.Item2 ?? DBNull.Value;
                command.Parameters.Add(param);
            }
            return command;
        }

        public static IList<T> ExecuteStoreProcedure<T>(this DbCommand command) where T : class
        {
            using (command)
            {
                if (command.Connection != null && command.Connection.State == System.Data.ConnectionState.Closed)
                    command.Connection.Open();
                try
                {
                    using (var reader = command.ExecuteReader())
                    {
                        return reader.MapToList<T>();
                    }
                }
                finally
                {
                    command.Connection?.Close();
                }
            }
        }

        private static IList<T> MapToList<T>(this DbDataReader dr)
        {
            var objList = new List<T>();
            var props = typeof(T).GetRuntimeProperties();

            var colMapping = dr.GetColumnSchema()
                .Where(x => props.Any(y => y.Name == x.ColumnName))
                .ToDictionary(key => key.ColumnName);

            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    T obj = Activator.CreateInstance<T>();
                    foreach (var prop in props)
                    {
                        if (colMapping.ContainsKey(prop.Name))
                        {
                            var val = dr.GetValue(colMapping[prop.Name].ColumnOrdinal.Value);
                            prop.SetValue(obj, val == DBNull.Value ? null : val);
                        }
                    }
                    objList.Add(obj);
                }
            }
            return objList;
        }
    }
}
