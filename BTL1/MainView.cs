using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BTL1.Properties;
using System.Data.SqlClient;
namespace BTL1
{ 
    public partial class fMain : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public fMain()
        {
            InitializeComponent();
            if (!mvvmContext1.IsDesignMode)
                InitializeBindings();
        }

        void InitializeBindings()
        {
            var fluent = mvvmContext1.OfType<MainViewModel>();
        }

        private void MainView_Load(object sender, EventArgs e)
        {

        }
       public static Image anh2 = Resources.anh2;
       public static Image anh1 = Resources.anh3;
        void pictureEdit1_Click(object sender, EventArgs e)
        { } //pictureEdit1.Image = anh2; }

       // private void pictureEdit17_EditValueChanged(object sender, EventArgs e)
        // {
           //pictureEdit1.Image = Resources.anh2;
        // }

        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            fmDoiMatKhau frm = new fmDoiMatKhau();
            frm.MdiParent = this;
            frm.Show();
        } 
        
        private void barButtonItem3_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            fmNhatKi frm = new fmNhatKi();
            frm.MdiParent = this;
            frm.Show();
        }

        private void barButtonItem4_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            fmPhanQuyen frm = new fmPhanQuyen();
            frm.MdiParent = this;
            frm.Show();
        }

        private void barButtonItem8_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)//qlKh
        {
            fmQuanLiKH frm = new fmQuanLiKH();
            frm.MdiParent = this;
            frm.Show();
        }

        private void barButtonItem7_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)// ql nv
        {
            fmQuanLiNV frm = new fmQuanLiNV();
            frm.MdiParent = this;
            frm.Show();
        }

        private void barButtonItem9_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)// phân công
        {
            fmPhanCong  frm = new fmPhanCong();
            frm.MdiParent = this;
            frm.Show();
        }

        private void barButtonItem10_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)// hóa đơn
        {
            fmHoaDon frm = new fmHoaDon();
            frm.MdiParent = this;
            frm.Show();
        }

        private void barButtonItem12_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)// qli ban ăn
        {
            fmQuanLiBanAn frm = new fmQuanLiBanAn();
            frm.MdiParent = this;
            frm.Show();
        }

        private void barButtonItem13_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)// quản lí vị trí
        {
            fmQuanLiViTri frm = new fmQuanLiViTri();
            frm.MdiParent = this;
            frm.Show();
        }

        private void barButtonItem14_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)// quản lí hàng nhập
        {
            fmHangNhap frm = new fmHangNhap();
            frm.MdiParent = this;
            frm.Show();
        }

        private void barButtonItem18_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            fmThucDon frm = new fmThucDon();
            frm.MdiParent = this;
            frm.Show();
        }
       
    }
}
