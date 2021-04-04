﻿using ShopingList.Component.Data.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace ShopingList.Component
{
    public interface IMainData
    {
        List<ListOfProducts> StorageOfProductList { get; set; }
        Language lang { get; set; }

        Language DefaultLanguage();

        ListOfProducts AddProductList(string name, string description);

        void AddProductList(ListOfProducts newList);

        void DeleteProductList(ListOfProducts listToDelete);

        bool EditProductList(ListOfProducts listToDelete);

        void SaveToJsonFile(string nameOfFile);

        void SaveToJsonFile(string path, string nameOfFile);

        void ReadFromFile(IEnumerable<string> jsonObjects);

        List<string> GetAllCategory();

        IEnumerable<string> PrepToSave();
    }
}
