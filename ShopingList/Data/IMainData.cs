using ShopingList.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace ShopingList.Data
{
    public interface IMainData
    {

        public ListOfProducts AddProductList(string name, string description);

        public void AddProductList(ListOfProducts newList);

        public void DeleteProductList(ListOfProducts listToDelete);

        public bool EditProductList(ListOfProducts listToDelete);

        public void SaveToJsonFile(string nameOfFile);

        public void SaveToJsonFile(string path, string nameOfFile);

        public void ReadFromFile();
    }
}
