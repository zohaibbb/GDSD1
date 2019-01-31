using System;

using System.Text;
using SQLite;
using System.Collections.Generic;
using System.Linq;
using Xamarin.Forms;
using System.Collections.ObjectModel;

namespace test11
{
    public class CartDataAccess
    {
        private SQLiteConnection database;
        private static object collisionLock = new object();
        public ObservableCollection<Cart> Cart { get; set; }

        public CartDataAccess()
        {
            database =
              DependencyService.Get<IDatabaseConnection>().
              DbConnection();
            database.CreateTable<Cart>();
            this.Cart = new ObservableCollection<Cart>(database.Table<Cart>());
            // If the table is empty, initialize the collection
            if (!database.Table<Cart>().Any())
            {
                AddNewCartData();
            }
        }
        public void AddNewCartData()
        {
            this.Cart.
              Add(new Cart
              {
                  ProductName = "Test Product",
                  Price = "123",
                  Description = "Testing Product"
              });
        }
        public string SaveProductToCart(Cart cartrInstance)
        {
            lock (collisionLock)
            {
                if (cartrInstance.Id != null)
                {
                    database.Update(cartrInstance);
                    return cartrInstance.Id;
                }
                else
                {
                    database.Insert(cartrInstance);
                    return cartrInstance.Id;
                }
            }
        }
        public string DeleteCartData(Cart cartrInstance)
        {
            var id = cartrInstance.Id;
            if (id != null)
            {
                lock (collisionLock)
                {
                    database.Delete<Cart>(id);
                }
            }
            this.Cart.Remove(cartrInstance);
            return id;
        }

    }
}
