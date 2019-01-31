using System;
using System.Collections.Generic;
using System.Text;

namespace test11.Models
{
   public  class wishListItems
    {
        string _id;
        public string _Id { get => _id; set => _id = value; }

        string seller_id;
        public string Seller_id { get => seller_id; set => seller_id = value; }

        string buyer_id;
        public string Buyer_id { get => buyer_id; set => buyer_id = value; }




        string product_id;
        public string Product_id { get => product_id; set => product_id = value; }




        Product product_details;
        public Product Product_details { get => product_details; set => product_details = value; }
    }
}
