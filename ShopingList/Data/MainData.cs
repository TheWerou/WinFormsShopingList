using ShopingList.Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Reflection;
using System.IO;
using ShopingList.FileSaving;

namespace ShopingList.Data
{
    public class MainData
    {
        private IZapisPlikowFacade SavingFacade;
        public List<ListOfProducts> SotrageOfProductList { get; private set; }

        public MainData()
        {
            SotrageOfProductList = new List<ListOfProducts>();
            SavingFacade = new ZapisPlikowFacde();
        }

        public ListOfProducts AddProductList(string name, string description)
        {
            var newList = new ListOfProducts(name, description);
            SotrageOfProductList.Add(newList);
            return newList;
        }

        public void AddProductList(ListOfProducts newList)
        {
            SotrageOfProductList.Add(newList);
        }
        public void DeleteProductList(ListOfProducts listToDelete)
        {
            SotrageOfProductList.Remove(listToDelete);
        }
        public bool EditProductList(ListOfProducts listToDelete)
        {
            var output = SotrageOfProductList.FindIndex(c => c == listToDelete);
            if(output > 0)
            {
                SotrageOfProductList[output] = listToDelete;
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
            this.SavingFacade.SaveObjectToFile(this.SotrageOfProductList, input);
        }

        public void SaveToJsonFile(string path, string nameOfFile)
        {
            string input = Path.Combine(Environment.CurrentDirectory, nameOfFile);
            this.SavingFacade.SaveObjectToFile(this.SotrageOfProductList, input);
        }

        public void ReadFromFile()
        {

        }


    }
    
}
