using System;
using System.Collections.Generic;
using System.Text;

namespace test11.Models
{
    public class MyWishList
    {
        bool status;
        string message;
        List<Orders> orders;
        List<wishListItems> wishlist;

        public bool Status { get => status; set => status = value; }
        public string Message { get => message; set => message = value; }
        public List<Orders> Orders { get => orders; set => orders = value; }

        public List<wishListItems> Wishlist { get => wishlist; set => wishlist = value; }
    }
}
