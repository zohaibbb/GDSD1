using SQLite;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using test11.Models;

namespace test11
{
    
   public class Cart : INotifyPropertyChanged
    {

        //public void addToCart(Product product)
        //{

        //    _id = product._Id;

        //    ProductName = product.Name;

        //    ImagePath = product.Image_path;

        //    Description = product.Description;

        //    Price = product.Price.ToString();

        //    Condition = product.Condition.ToString();





        //}
        private string _id;
        
        public string Id
        {
            get
            {
                return _id;
            }
            set
            {
                this._id = value;
                OnPropertyChanged(nameof(Id));
            }
        }

        private string _productName;
        [NotNull]
        public string ProductName
        {
            get
            {
                return _productName;
            }
            set
            {
                this._productName = value;
                OnPropertyChanged(nameof(ProductName));
            }
        }
        private string _imagePath;
        
        public string ImagePath
        {
            get
            {
                return _imagePath;
            }
            set
            {
                this._imagePath = value;
                OnPropertyChanged(nameof(ImagePath));
            }
        }
        private string _description;
    
        public string Description
        {
            get
            {
                return _description;
            }
            set
            {
                this._description = value;
                OnPropertyChanged(nameof(Description));
            }
        }
        private string _condition;
        
        public string Condition
        {
            get
            {
                return _condition;
            }
            set
            {
                this._condition = value;
                OnPropertyChanged(nameof(Condition));
            }
        }
        private string _price;
       
        public string Price
        {
            get
            {
                return _price;
            }
            set
            {
                this._price = value;
                OnPropertyChanged(nameof(Price));
            }
        }


        public event PropertyChangedEventHandler PropertyChanged;
        private void OnPropertyChanged(string propertyName)
        {
            this.PropertyChanged?.Invoke(this,
              new PropertyChangedEventArgs(propertyName));
        }
    }
}
