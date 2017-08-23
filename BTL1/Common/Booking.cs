using BTL1.Properties;
using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTL1.Common
{

    public class Booking
    {
        public static Image tableBooking = Resources.anh2;
        public static Image tableBooked = Resources.anh3;
        public static Image chairBooked = Resources.anh4;
        public static Image chairBooking = Resources.square_icon;

        public void Booked(bool obj,PictureEdit picedit )
        {
            // dat mac dinh no la ban
            var imageBooked = tableBooked;
            var imageBooking = tableBooking;

            // neu no la ghe
            if (!obj)
            {
                imageBooked = chairBooked;
                imageBooking = chairBooking;
            }

            //gan gia tri anh cho picedit
            if (picedit.Image == imageBooking)
            {
                picedit.Image = imageBooked;
            }
            else
            {
                picedit.Image = imageBooking;
            }
        }
    }
}
