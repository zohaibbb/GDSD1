using System;
using System.Collections.Generic;
using System.Text;

namespace test11.Models
{
   public class Orders
    {
        string _id;
        public string _Id { get => _id; set => _id = value; }



        string buyer_id;
        public string Buyer_id { get => buyer_id; set => buyer_id = value; }



        int total;
        public int Total { get => total; set => total = value; }


        List<Product> products;
        public List<Product> Products { get => products; set => products = value; }


        


    }
}
