using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTL1.Common
{
    public class Connect
    {
        private static string str = "Data Source=.;Initial Catalog=DETAI1;Integrated Security=True";
        public SqlConnection cnn = new SqlConnection(str);
        public SqlCommand cmm = new SqlCommand();
        // connection open in sql
        public void Open()
        {
            try
            {
                cnn.Open();
            }
            catch(Exception ex)
            {
                // ex.Message;
            }
        }

        // connection closed when process finish
        public string Close()
        {
            try
            {
                cnn.Close();
                return null;
            }
            catch(Exception ex)
            {
                return ex.Message;
            }

        }

    }
}
