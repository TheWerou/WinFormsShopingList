using System;
using System.Collections.Generic;
using System.Text;

namespace ShopingList.Compt
{
    public interface IMainData
    {
        public List<ListOfProducts> StorageOfProductList { get; set; }
        public ListOfProducts AddProductList(string name, string description);

        public void AddProductList(ListOfProducts newList);

        public void DeleteProductList(ListOfProducts listToDelete);

        public bool EditProductList(ListOfProducts listToDelete);

        public void SaveToJsonFile(string nameOfFile);

        public void SaveToJsonFile(string path, string nameOfFile);

        public void ReadFromFile();
    }
}
