using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTL1.Common
{
    public class CallProcedure
    {
        
        public DataTable callProcedure(string procedure, string[,] array)
        {
            Connect connect = new Connect();
            using (SqlCommand cmd = new SqlCommand(procedure, connect.cnn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    for (var i = 0; i < 2; i++)
                    {
                        cmd.Parameters.Add("@" + array[i,0], SqlDbType.VarChar).Value = array[i, 1];
                    }
                
                connect.Open();
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable ds = new DataTable();
                    da.Fill(ds);
                    return ds;
                }
        }
    }
}
