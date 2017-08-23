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
using BTL1.Properties;
using BTL1.Common;

namespace BTL1
{
    public partial class fmQuanLiBanAn : DevExpress.XtraEditors.XtraForm
    {
        private Booking book = new Booking();
        public fmQuanLiBanAn()
        {
            InitializeComponent();   
        }
        public static Image anh2 = Resources.anh2;
        public static Image anh1 = Resources.anh3;
        public static Image anh11 = Resources.anh4;
        public static Image anh12 = Resources.square_icon;
       private void pictureEdit1_Click(object sender, EventArgs e)
       {
            
         book.Booked(true, pictureEdit1);
       }
        // ban: 1 17 26 35 44 53 62 71 80
        // ghe:  còn lại
        private void pictureEdit17_Click(object sender, EventArgs e)
        {
            //var book = new Booking();
            book.Booked(true, pictureEdit17);
        }

        private void pictureEdit26_Click(object sender, EventArgs e)
        {
            //var book = new Booking();
            book.Booked(true, pictureEdit26);
        }

        private void pictureEdit2_Click(object sender, EventArgs e)
        {
            //var book = new Booking();
            book.Booked(false, pictureEdit2);
        }

        private void pictureEdit3_Click(object sender, EventArgs e)
        {
            book.Booked(false, pictureEdit3);
        }

        private void pictureEdit35_Click(object sender, EventArgs e)
        {
            //ar book = new Booking();
            book.Booked(true, pictureEdit35);
        }

        private void pictureEdit44_Click(object sender, EventArgs e)
        {
            //var book = new Booking();
            book.Booked(true, pictureEdit44);
        }

        private void pictureEdit53_Click(object sender, EventArgs e)
        {
            //var book = new Booking();
            book.Booked(true, pictureEdit53);
        }

        private void pictureEdit62_Click(object sender, EventArgs e)
        {
            //var book = new Booking();
            book.Booked(true, pictureEdit62);
        }

        private void pictureEdit71_Click(object sender, EventArgs e)
        {
            //var book = new Booking();
            book.Booked(true, pictureEdit71);
        }

        private void pictureEdit80_Click(object sender, EventArgs e)
        {
            //var book = new Booking();
            book.Booked(true, pictureEdit80);
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            CallProcedure a = new CallProcedure();
            string[,] ar = new string[10, 10];
            ar[0, 0] = "P_Test";
            ar[0, 1] = "P_Test1";
            ar[1, 0] = "P_a";
            ar[1, 1] = "P_a1";
            var test = a.callProcedure("TestA", ar);
        }

        private void pictureEdit1_DoubleClick(object sender, EventArgs e)
        {
            book.Booked(true, pictureEdit1);
        }

        private void pictureEdit5_Click(object sender, EventArgs e)
        {
            book.Booked(false, pictureEdit5);
        }

        private void pictureEdit4_Click(object sender, EventArgs e)
        {
            book.Booked(false, pictureEdit4);
        }

        private void pictureEdit6_Click(object sender, EventArgs e)
        {
            book.Booked(false, pictureEdit6);
        }

        private void pictureEdit7_Click(object sender, EventArgs e)
        {
            book.Booked(false, pictureEdit7);
        }

        private void pictureEdit9_Click(object sender, EventArgs e)
        {
            book.Booked(false, pictureEdit9);
        }

        private void pictureEdit8_Click(object sender, EventArgs e)
        {
            book.Booked(false, pictureEdit8);
        }

        private void pictureEdit11_Click(object sender, EventArgs e)
        {
            book.Booked(false, pictureEdit11);
        }

        private void pictureEdit18_Click(object sender, EventArgs e)
        {
            book.Booked(false, pictureEdit18);
        }

        private void pictureEdit16_Click(object sender, EventArgs e)
        {
            book.Booked(false, pictureEdit16);
        }

        private void pictureEdit14_Click(object sender, EventArgs e)
        {
            book.Booked(false, pictureEdit14);
        }

        private void pictureEdit15_Click(object sender, EventArgs e)
        {
            book.Booked(false, pictureEdit15);
        }

        private void pictureEdit13_Click(object sender, EventArgs e)
        {
            book.Booked(false, pictureEdit13);
        }

        private void pictureEdit12_Click(object sender, EventArgs e)
        {
            book.Booked(false, pictureEdit12);
        }

       

        private void pictureEdit11_EditValueChanged(object sender, EventArgs e)
        {
            book.Booked(false, pictureEdit11);
        }

      
        private void pictureEdit24_EditValueChanged(object sender, EventArgs e)
        {
            book.Booked(false, pictureEdit3);
        }

        private void pictureEdit10_Click(object sender, EventArgs e)
        {
            book.Booked(false, pictureEdit10);
        }

        private void pictureEdit20_Click(object sender, EventArgs e)
        {
            book.Booked(false, pictureEdit20);
        }

        private void pictureEdit19_Click(object sender, EventArgs e)
        {
            book.Booked(false, pictureEdit19);
        }

        private void pictureEdit21_Click(object sender, EventArgs e)
        {
            book.Booked(false, pictureEdit21);
        }

        private void pictureEdit22_Click(object sender, EventArgs e)
        {
            book.Booked(false, pictureEdit22);
        }

        private void pictureEdit24_Click(object sender, EventArgs e)
        {
            book.Booked(false, pictureEdit24);
        }

        private void pictureEdit23_Click(object sender, EventArgs e)
        {
            book.Booked(false, pictureEdit23);
        }

        private void pictureEdit25_Click(object sender, EventArgs e)
        {
            book.Booked(false, pictureEdit25);
        }

        private void pictureEdit27_Click(object sender, EventArgs e)
        {
            book.Booked(false, pictureEdit27);
        }

        private void pictureEdit36_Click(object sender, EventArgs e)
        {
            book.Booked(false, pictureEdit36);
        }


        private void pictureEdit34_Click(object sender, EventArgs e)
        {
            book.Booked(false, pictureEdit34);
        }

        private void pictureEdit32_Click(object sender, EventArgs e)
        {
            book.Booked(false, pictureEdit32);
        }

        private void pictureEdit33_Click(object sender, EventArgs e)
        {
            book.Booked(false, pictureEdit33);
        }

        private void pictureEdit31_Click(object sender, EventArgs e)
        {
            book.Booked(false, pictureEdit31);
        }

        private void pictureEdit30_Click(object sender, EventArgs e)
        {
            book.Booked(false, pictureEdit30);
        }

        private void pictureEdit28_Click(object sender, EventArgs e)
        {
            book.Booked(false, pictureEdit28);
        }

        private void pictureEdit29_Click(object sender, EventArgs e)
        {
            book.Booked(false, pictureEdit29);
        }

        private void pictureEdit45_Click(object sender, EventArgs e)
        {
            book.Booked(false, pictureEdit45);
        }

        private void pictureEdit43_Click(object sender, EventArgs e)
        {
            book.Booked(false, pictureEdit43);
        }

        private void pictureEdit41_Click(object sender, EventArgs e)
        {
            book.Booked(false, pictureEdit41);
        }

        private void pictureEdit42_Click(object sender, EventArgs e)
        {
            book.Booked(false, pictureEdit42);
        }

        private void pictureEdit40_Click(object sender, EventArgs e)
        {
            book.Booked(false, pictureEdit40);
        }

        private void pictureEdit39_Click(object sender, EventArgs e)
        {
            book.Booked(false, pictureEdit39);
        }

        private void pictureEdit37_Click(object sender, EventArgs e)
        {
            book.Booked(false, pictureEdit37);
        }

        private void pictureEdit38_Click(object sender, EventArgs e)
        {
            book.Booked(false, pictureEdit38);
        }

        private void pictureEdit47_Click(object sender, EventArgs e)
        {
            book.Booked(false, pictureEdit47);
        }

        private void pictureEdit46_Click(object sender, EventArgs e)
        {
            book.Booked(false, pictureEdit46);
        }

        private void pictureEdit48_Click(object sender, EventArgs e)
        {
            book.Booked(false, pictureEdit48);
        }

        private void pictureEdit49_Click(object sender, EventArgs e)
        {
            book.Booked(false, pictureEdit49);
        }

        private void pictureEdit51_Click(object sender, EventArgs e)
        {
            book.Booked(false, pictureEdit51);
        }

        private void pictureEdit50_Click(object sender, EventArgs e)
        {
            book.Booked(false, pictureEdit50);
        }

        private void pictureEdit52_Click(object sender, EventArgs e)
        {
            book.Booked(false, pictureEdit52);
        }

        private void pictureEdit54_Click(object sender, EventArgs e)
        {
            book.Booked(false, pictureEdit54);
        }

        private void pictureEdit63_Click(object sender, EventArgs e)
        {
            book.Booked(false, pictureEdit63);
        }

        private void pictureEdit56_Click(object sender, EventArgs e)
        {
            book.Booked(false, pictureEdit56);
        }

        private void pictureEdit61_Click(object sender, EventArgs e)
        {
            book.Booked(false, pictureEdit61);
        }

        private void pictureEdit59_Click(object sender, EventArgs e)
        {
            book.Booked(false, pictureEdit59);
        }

        private void pictureEdit60_Click(object sender, EventArgs e)
        {
            book.Booked(false, pictureEdit60);
        }

        private void pictureEdit58_Click(object sender, EventArgs e)
        {
            book.Booked(false, pictureEdit58);
        }

        private void pictureEdit57_Click(object sender, EventArgs e)
        {
            book.Booked(false, pictureEdit57);
        }

        private void pictureEdit55_Click(object sender, EventArgs e)
        {
            book.Booked(false, pictureEdit55);
        }

        private void pictureEdit65_Click(object sender, EventArgs e)
        {
            book.Booked(false, pictureEdit65);
        }

        private void pictureEdit64_Click(object sender, EventArgs e)
        {
            book.Booked(false, pictureEdit64);
        }

        private void pictureEdit66_EditValueChanged(object sender, EventArgs e)
        {
            book.Booked(false, pictureEdit64);
        }

        private void pictureEdit67_Click(object sender, EventArgs e)
        {
            book.Booked(false, pictureEdit67);
        }

        private void pictureEdit69_Click(object sender, EventArgs e)
        {
            book.Booked(false, pictureEdit69);
        }

        private void pictureEdit68_Click(object sender, EventArgs e)
        {
            book.Booked(false, pictureEdit68);
        }

        private void pictureEdit70_Click(object sender, EventArgs e)
        {
            book.Booked(false, pictureEdit70);
        }

        private void pictureEdit72_Click(object sender, EventArgs e)
        {
            book.Booked(false, pictureEdit72);
        }

        private void pictureEdit74_Click(object sender, EventArgs e)
        {
            book.Booked(false, pictureEdit74);
        }

        private void pictureEdit73_Click(object sender, EventArgs e)
        {
            book.Booked(false, pictureEdit73);
        }

        private void pictureEdit75_Click(object sender, EventArgs e)
        {
            book.Booked(false, pictureEdit75);
        }

        private void pictureEdit76_Click(object sender, EventArgs e)
        {
            book.Booked(false, pictureEdit76);
        }

        private void pictureEdit78_Click(object sender, EventArgs e)
        {
            book.Booked(false, pictureEdit78);
        }

        private void pictureEdit77_Click(object sender, EventArgs e)
        {
            book.Booked(false, pictureEdit77);
        }

        private void pictureEdit79_Click(object sender, EventArgs e)
        {
            book.Booked(false, pictureEdit79);
        }

        private void pictureEdit81_Click(object sender, EventArgs e)
        {
            book.Booked(false, pictureEdit81);
        }
    }
}