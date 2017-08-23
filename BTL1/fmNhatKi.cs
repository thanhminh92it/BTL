using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using BTL1.Common;
using System.Data.SqlClient;

namespace BTL1
{
    public partial class fmNhatKi : DevExpress.XtraEditors.XtraForm
    {
        public fmNhatKi()
        {
            InitializeComponent();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            Connect connect = new Connect();
            connect.Open();
                connect.cmm = connect.cnn.CreateCommand();
                connect.cmm.CommandText = "SELECT * FROM ThucDon";
                SqlDataAdapter da = new SqlDataAdapter(connect.cmm);
                DataTable ds = new DataTable();
                da.Fill(ds);
                //var a = connect.cmm.ExecuteNonQuery();
                dataGridView1.DataSource = ds;
        }

    }
}