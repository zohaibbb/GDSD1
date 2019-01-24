using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net;
using System.Text;
using test11.Models;

namespace test11.Helpers
{
    public class API
    {
        public IList<Product> getProducts()
        {
            using (var webClient = new WebClient())
            {
                IList<Product> product = null;
                try
                {
                    String json = webClient.DownloadString("https://fulda-buyandsell.herokuapp.com/api/products");
                    ProductsApi data = JsonConvert.DeserializeObject<ProductsApi>(json);

                    product = data.Product;
                    return product;
                }
                catch (Exception e)
                {
                    Console.Write(e);
                }
                return product;
            }
        }
        public IList<Product> getSearchResult(string keyword)
        {
            IList<Product> products = null;

            using (var webClient = new WebClient())
            {

                try
                {
                    string url = "https://fulda-buyandsell.herokuapp.com/api/products/?name=" + keyword;
                    String json = webClient.DownloadString(url);
                    ProductsApi data = JsonConvert.DeserializeObject<ProductsApi>(json);

                    products = data.Product;
                    return products;
                }
                catch (Exception e)
                {
                    Console.Write(e);
                }





                return products;
            }
        }
    }
}
