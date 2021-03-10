using System;
using System.Collections.Generic;
using System.Text;

namespace ShopingList.Component
{
    public interface IMainData
    {
        List<ListOfProducts> StorageOfProductList { get; set; }
        ListOfProducts AddProductList(string name, string description);

        void AddProductList(ListOfProducts newList);

        void DeleteProductList(ListOfProducts listToDelete);

        bool EditProductList(ListOfProducts listToDelete);

        void SaveToJsonFile(string nameOfFile);

        void SaveToJsonFile(string path, string nameOfFile);

        void ReadFromFile();
    }
}
