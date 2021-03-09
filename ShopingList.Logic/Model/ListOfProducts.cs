using System;
using System.Collections.Generic;
using System.Text;

namespace ShopingList.Logic.Model
{
    public class ListOfProducts
    {
        public List<ShopingElement> ListOfProduct { get; set; }

        public string Name;

        public string Description;

        public ListOfProducts()
        {
            this.ListOfProduct = new List<ShopingElement>();
        }
        public ListOfProducts(string name, string description)
        {
            this.ListOfProduct = new List<ShopingElement>();
            this.Name = name;
            this.Description = description;
        }

        public void AddToProductToList(ShopingElement newProduct)
        {
            ListOfProduct.Add(newProduct);
        }

        public void DeleteProductFromList(ShopingElement productToDelete)
        {
            ListOfProduct.Remove(productToDelete);
        }

        public bool EditProductFromList(ShopingElement productToEdit)
        {
            var output = ListOfProduct.FindIndex(c => c == productToEdit);
            if (output > 0)
            {
                ListOfProduct[output] = productToEdit;
                return true;
            }
            else
            {
                return false;
            }
        }
    }

}
