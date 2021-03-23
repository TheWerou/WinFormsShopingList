using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Reflection;
using System.IO;
using ShopingList.Component.Data.Model;

namespace ShopingList.Component
{
    public class MainData : IMainData
    {
        private IZapisPlikowFacade SavingFacade;
        public List<ListOfProducts> StorageOfProductList { get; set; }
        public Language lang { get; set; }

        public MainData()
        {
            SetUp();
            DefaultLanguage();
        }

        public MainData(Language lang)
        {
            SetUp();
            this.lang = lang;
        }

        private void SetUp()
        {
            this.StorageOfProductList = new List<ListOfProducts>();
            this.SavingFacade = new ZapisPlikowFacde();
        }

        public Language DefaultLanguage()
        {
            this.lang = PolishText();
            return this.lang;
        }

        private Language PolishText()
        {
            var lang = new Language();
            lang.Progress_label = "Postępy listy";
            lang.Select_label = "Wybierz by posortować";
            lang.Thing_name_label = "Nazwa";
            lang.Thing_category_label = "Kategoria";
            lang.List_name_label = "Nazwa";
            lang.List_description_label = "Opis";
            lang.Thing_add_btn = "Dodaj przedmiot";
            lang.Thing_del_btn = "Usuń przedmiot";
            lang.List_add_btn = "Dodaj listę";
            lang.List_del_btn = "Usuń listę";
            lang.Load_list_btn = "Wczytaj listy";
            lang.Save_list_btn = "Zapisz listy do pliku";
            return lang;
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

        public void ReadFromFile(IEnumerable<string> jsonObjects)
        {
            foreach(var item in jsonObjects)
            {
                this.StorageOfProductList.Add(this.SavingFacade.ConvertJsonToObject<ListOfProducts>(item));
            }

        }

        public IEnumerable<string> PrepToSave()
        {
            var list = new List<string>();

            foreach (var item in this.StorageOfProductList)
            {
                list.Add(this.SavingFacade.ConvertObjectToJson(item));
            }
            return list;
        }

    }
    
}
