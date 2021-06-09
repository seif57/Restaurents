using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurents
{
    public class Database
    {
        public DataTable GetTable(string storedProcedureName)
        {
                
            DataTable dt = GetTable(storedProcedureName, null );

           
            return dt;
        }
        public DataTable GetTable(string storedProcedureName, List<ParamObj> paramObjList)
        {
            DataTable dt = new DataTable();

            using (var con = DataBaseConnection.SqlConnection)
            {
                using (var adapter = new SqlDataAdapter(storedProcedureName, con))
                {
                    adapter.SelectCommand.CommandType = CommandType.StoredProcedure;

                    if (paramObjList != null)
                    {
                        foreach (var param in paramObjList)
                        {
                            SqlDbType type = SqlDbType.NVarChar;
                            switch (param.Type)
                            {
                                case ParamType.String:
                                    type = SqlDbType.NVarChar;
                                    break;
                                case ParamType.Int:
                                    type = SqlDbType.Int;
                                    break;
                                case ParamType.Bool:
                                    type = SqlDbType.Bit;
                                    break;
                                default:
                                    break;
                            }
                            adapter.SelectCommand.Parameters.Add(param.Name, type).Value = param.Value;
                        } 
                    }

                    adapter.Fill(dt);
                };
            }

            return dt;
        }

    }
}
