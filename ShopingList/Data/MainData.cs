using ShopingList.Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace ShopingList.Data
{
    public class MainData
    {
        public List<ListOfProducts> SotrageOfProductList { get; private set; }

        public MainData()
        {
            SotrageOfProductList = new List<ListOfProducts>();
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

        public void SaveToJsonFile()
        {

        }


    }
    
}
