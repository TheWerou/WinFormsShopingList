using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Reflection;
using System.IO;

namespace ShopingList.Compt
{
    public class MainData : IMainData
    {
        private IZapisPlikowFacade SavingFacade;
        public List<ListOfProducts> StorageOfProductList { get; set; }

        public MainData()
        {
            StorageOfProductList = new List<ListOfProducts>();
            SavingFacade = new ZapisPlikowFacde();
        }

        public ListOfProducts AddProductList(string name, string description)
        {
            var newList = new ListOfProducts(name, description);
            StorageOfProductList.Add(newList);
            return newList;
        }

        public void AddProductList(ListOfProducts newList)
        {
            StorageOfProductList.Add(newList);
        }
        public void DeleteProductList(ListOfProducts listToDelete)
        {
            StorageOfProductList.Remove(listToDelete);
        }
        public bool EditProductList(ListOfProducts listToDelete)
        {
            var output = StorageOfProductList.FindIndex(c => c == listToDelete);
            if(output > 0)
            {
                StorageOfProductList[output] = listToDelete;
                return true;
            }
            else
            {
                return false;
            }
        }

        public void SaveToJsonFile(string nameOfFile)
        {
            string input = Path.Combine(Environment.CurrentDirectory, nameOfFile);
            this.SavingFacade.SaveObjectToFile(this.StorageOfProductList, input);
        }

        public void SaveToJsonFile(string path, string nameOfFile)
        {
            string input = Path.Combine(Environment.CurrentDirectory, nameOfFile);
            this.SavingFacade.SaveObjectToFile(this.StorageOfProductList, input);
        }

        public void ReadFromFile()
        {

        }


    }
    
}
