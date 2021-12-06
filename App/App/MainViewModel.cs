using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace App
{
    public class MainViewModel
    {

        private ProductModel _oldProduct;
        public ObservableCollection<ProductModel> Products { get; set; }
        public MainViewModel()
        {
            Products = new ObservableCollection<ProductModel>()
            {
                new ProductModel
                {

                    
                    ProductName = "Primer Semestre 2021",
                    CollImage = "Plus.png",
                    ExpImage = "Minus.png",
                    IsVisible = false,
                    Poduct_Details = new ObservableCollection<ProductDetails>
                    {
                        new ProductDetails{ Key="12345", Value="Estrategia" },
                        new ProductDetails{ Key="98768", Value="Gerencia"},
                        new ProductDetails{ Key="90099", Value="Negocios Internacionales" },

                    }
                },
                new ProductModel
                {
                    ProductName = "Segundo Semestre 2021",
                    CollImage = "Plus.png",
                    ExpImage = "Minus.png",
                    IsVisible = false,
                    Poduct_Details = new ObservableCollection<ProductDetails>
                    {
                        new ProductDetails{ Key="12345", Value="Estrategia" },
                        new ProductDetails{ Key="98768", Value="Gerencia"},
                        new ProductDetails{ Key="90099", Value="Negocios Internacionales" },

                    }
                },
                new ProductModel
                {
                    ProductName = "Primer Semestre 2022",
                    CollImage = "Plus.png",
                    ExpImage = "Minus.png",
                    IsVisible = false,
                    Poduct_Details = new ObservableCollection<ProductDetails>
                    {
                        new ProductDetails{ Key="12345", Value="Estrategia" },
                        new ProductDetails{ Key="98768", Value="Gerencia"},
                        new ProductDetails{ Key="90099", Value="Negocios Internacionales" },

                    }
                },
                 new ProductModel
                {
                    ProductName = "Segundo Semestre 2022",
                    ExpImage = "Minus.png",
                    IsVisible = false,
                    Poduct_Details = new ObservableCollection<ProductDetails>
                    {
                        new ProductDetails{ Key="12345", Value="Estrategia" },
                        new ProductDetails{ Key="98768", Value="Gerencia"},
                        new ProductDetails{ Key="90099", Value="Negocios Internacionales" },

                    }
                },
            };
        }
        
        public void ShowHideProduct(ProductModel Product)
        {
            if (_oldProduct==Product)
            {
                //Hide When click twice
                Product.IsVisible = !Product.IsVisible;
                UpdateProduct(Product);
            }
            else
            {
                if (_oldProduct!=null)
                {
                    //Hide previous item
                    _oldProduct.IsVisible = false;
                    UpdateProduct(Product);
                }
            }
            Product.IsVisible = true;
            UpdateProduct(Product);
        }
        
        public void UpdateProduct(ProductModel product)
        {
            var index = Products.IndexOf(product);
            Products.Remove(product);
            Products.Insert(index, product);
        }
    }

    public class ProductModel
    {
        public bool IsVisible { get; set; }

        public string ProductName { get; set; }


        public string CollImage { get; set; }

        public string ExpImage { get; set; }

        public ObservableCollection<ProductDetails> Poduct_Details { get; set; }

    }

    public class ProductDetails
    {
        public string Key { get; set; }
        public string Value { get; set; }
    }
}
