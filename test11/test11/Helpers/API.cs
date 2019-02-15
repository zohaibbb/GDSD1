using Android.Net;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
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

        public ObservableCollection<Product> getWishList()
        {
            ObservableCollection<Product> pro = new ObservableCollection<Product>();
            using (var webClient = new WebClient())
            {

                try
                {
                    String json = webClient.DownloadString("https://fulda-buyandsell.herokuapp.com/api/wishlist/5c3fa39047eca600301357a5");




                    MyWishList data = JsonConvert.DeserializeObject<MyWishList>(json);

                    List<wishListItems> wl = data.Wishlist;




                    for (int i = 0; i < wl.Count; i++)
                    {
                        pro.Add(
                            wl[i].Product_details);

                    }
                    return pro;

                }
                catch (Exception e)
                {
                    Console.Write(e);
                }
                return pro;

            }







        }

        public async Task addToWishListAsync(string sellerid, string producdid)
        {
            using (var webClient = new WebClient())
            {

                try
                {

                    string url = "https://fulda-buyandsell.herokuapp.com/api/wishlist";
                    string contentType = "application/json";
                    JObject oJsonObject = new JObject();

                    oJsonObject.Add("seller_id", sellerid);
                    oJsonObject.Add("buyer_id", "5c3fa39047eca600301357a5");
                    oJsonObject.Add("product_id", producdid);

                    HttpClient oHttpClient = new HttpClient();
                    var oTaskPostAsync = oHttpClient.PostAsync(url, new StringContent(oJsonObject.ToString(), Encoding.UTF8, contentType)).Result;

                }
                catch (Exception e)
                {
                    Console.Write(e);
                }






            }

        }





        public async Task checkOut(float price)
        {
            API api = new API();
            using (var webClient = new WebClient())
            {

                try
                {
                    MyWishList mwishlist = api.mList();
                    

                    List<wishListItems> wi = mwishlist.Wishlist;

                    String[] pids = new String[10];
                    String[] wids = new String[10];

                    for (int i = 0; i < wi.Count; i++)
                    {
                        pids[i] = wi[i].Product_id;
                        wids[i] = wi[i]._Id;
                    }



                    var a = JsonConvert.SerializeObject(pids);
                    var b = JsonConvert.SerializeObject(wids);


                    string url = "https://fulda-buyandsell.herokuapp.com/api/wishlist/checkout";
                    string contentType = "application/json";
                    JObject oJsonObject = new JObject();


                    oJsonObject.Add("buyer_id", "5c3fa39047eca600301357a5");
                    oJsonObject.Add("total", price);
                    oJsonObject.Add("wishlist", a);
                    oJsonObject.Add("products", b);
               



                    HttpClient oHttpClient = new HttpClient();
                    var oTaskPostAsync = oHttpClient.PostAsync(url, new StringContent(oJsonObject.ToString(), Encoding.UTF8, contentType)).Result;

                }
                catch (Exception e)
                {
                    Console.Write(e);
                }






            }

        }




        public MyWishList mList()
        {
            MyWishList data = null;
            using (var webClient = new WebClient())
            {

                try
                {
                    String json = webClient.DownloadString("https://fulda-buyandsell.herokuapp.com/api/wishlist/5c3fa39047eca600301357a5");




                    data = JsonConvert.DeserializeObject<MyWishList>(json);
                }

                catch (Exception e)
                {
                    Console.Write(e);
                }
                return data;
            }






        }
    }
}
    
