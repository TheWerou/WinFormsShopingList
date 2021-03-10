using System;
using System.Collections.Generic;
using System.Text;

namespace ShopingList.Component
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

        public void AddToProductToList(string name, string category)
        {
            ListOfProduct.Add(CreateShopingElementObject(name, category));
        }

        private ShopingElement CreateShopingElementObject(string name, string category)
        {
            var newObject = new ShopingElement();
            newObject.Name = name;
            newObject.Category = category;
            return newObject;
        }

        public void DeleteProductFromList(ShopingElement productToDelete)
        {
            ListOfProduct.Remove(productToDelete);
        }

        public void DeleteProductFromList(string name, string category)
        {
            ListOfProduct.Remove(CreateShopingElementObject(name, category));
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
