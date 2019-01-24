using System;
using System.Collections.Generic;
using System.Text;

namespace test11.Models
{
    public class Product
    {
        string _id;
        string name;
        string description;
        int condition;
        float price;
        string category_id;
        string seller_id;
        bool sold;
        string image_path;
        bool deleted;
        bool approved;
        DateTime created_at;

        public string _Id { get => _id; set => _id = value; }
        public string Name { get => name; set => name = value; }
        public string Description { get => description; set => description = value; }
        public int Condition { get => condition; set => condition = value; }
        public float Price { get => price; set => price = value; }
        public string Category_id { get => category_id; set => category_id = value; }
        public string Seller_id { get => seller_id; set => seller_id = value; }
        public bool Sold { get => sold; set => sold = value; }
        public string Image_path { get => image_path; set => image_path = value; }
        public bool Deleted { get => deleted; set => deleted = value; }
        public bool Approved { get => approved; set => approved = value; }
        public DateTime Created_at { get => created_at; set => created_at = value; }
    }
}
