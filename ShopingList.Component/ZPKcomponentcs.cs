using Newtonsoft.Json;
using ShopingList.Component.Data.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShopingList.Component
{
    public partial class ZPKcomponentcs : UserControl
    {
        private IMainData mainData;
        private Language lang;
        private ShopingElement viewElement;
        private int itemPosition;

        public ZPKcomponentcs()
        {
            InitializeComponent();
            this.mainData = new MainData();
            this.lang = this.mainData.lang;
            Rewrite_Language();
            this.Komunikat.Text = "Miłego dnia";
            this.DescriptionText.Text = "Tu pokaże się opis twojej cudownej listy";
        }

        public void Change_Language(Language lang)
        {
            this.lang = lang;
            Rewrite_Language();
        }

        public void Default_Language()
        {
            this.lang = this.mainData.DefaultLanguage();
            Rewrite_Language();
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ZPKcomponentcs_Load(object sender, EventArgs e)
        {

        }

        private void AddListaButt_Click(object sender, EventArgs e)
        {
            var name = this.NameListInput.Text;
            var description = this.DescryptionInput.Text;
            this.mainData.AddProductList(name, description);

            UpdateListList();
            this.Komunikat.Text = "Dodano listę";
        }

        private void UpdateProductList(ListOfProducts listOfProducts)
        {
            this.ListProd.Items.Clear();
            foreach (var item in listOfProducts.ListOfProduct)
            {
                this.ListProd.Items.Add($"Nazwa {item.Name} Category: {item.Category}", item.isChecked);
            }
        }

        private void UpdateListOfCategory(List<string> listOfCategories)
        {
            this.CategryList.Items.Clear();
            foreach (var item in listOfCategories)
            {
                this.CategryList.Items.Add($" {item} ");
            }
        }

        private void UpdateListList()
        {
            this.ListList.Items.Clear();
            foreach (var item in this.mainData.StorageOfProductList)
            {
                this.ListList.Items.Add($"Nazwa: {item.Name}");
            }
        }

        private void ListList_SelectedIndexChanged(object sender, EventArgs e)
        {
            var output = this.ListList.SelectedIndex;
            if (output >= 0)
            {
                UpdateProductList(this.mainData.StorageOfProductList[output]);
                this.DescriptionText.Text = this.mainData.StorageOfProductList[output].Description;
            }
            this.Komunikat.Text = "Wybrano nowy element";
        }

        private void AddProduktButton_Click(object sender, EventArgs e)
        {
            var name = this.NameProdInput.Text;
            var category = this.CategoryInput.Text;
            var output = this.ListList.SelectedIndex;
            if (output >= 0)
            {
                this.mainData.StorageOfProductList[output].AddToProductToList(name,category);
                UpdateProductList(this.mainData.StorageOfProductList[output]);
            }

            var listOfCategories = this.mainData.GetAllCategory();
            UpdateListOfCategory(listOfCategories);
            this.Komunikat.Text = "Dodano produkt do listy";
        }

        private void DeleteBut_Click(object sender, EventArgs e)
        {
            var output = this.ListList.SelectedIndex;
            var output2 = this.ListProd.SelectedIndex;
            if (output >= 0)
            {
                if(output2 >= 0)
                {
                    var listFromDelete = this.mainData.StorageOfProductList[output];
                    listFromDelete.DeleteProductFromList(listFromDelete.ListOfProduct[output2]);
                }
            }
            UpdateProductList(this.mainData.StorageOfProductList[output]);

            this.Komunikat.Text = "Usunięto produkt z listy";
        }

        private void DeleteButList_Click(object sender, EventArgs e)
        {
            var output = this.ListList.SelectedIndex;
            if (output >= 0)
            {
                var listToDelete = this.mainData.StorageOfProductList[output];
                this.mainData.DeleteProductList(listToDelete);
            }
            UpdateListList();
            try
            {
                UpdateProductList(this.mainData.StorageOfProductList[0]);
            }
            catch(Exception)
            {
                this.ListProd.Items.Clear();
            }
            this.Komunikat.Text = "Usunięto liste";

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void DecryptionOutput_TextChanged(object sender, EventArgs e)
        {

        }

        private void SaveList_Click(object sender, EventArgs e)
        {
            this.SaverData.ShowDialog();
            
        }

        private void saveFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            var jsonToSave = this.mainData.PrepToSave();

            using (StreamWriter writetext = new StreamWriter(this.SaverData.FileName))
            {
                foreach(var item in jsonToSave)
                {
                    writetext.WriteLine(item);
                }

            }
        }

        private void LoadList_Click(object sender, EventArgs e)
        {
            if (this.LoadDataDail.ShowDialog() == DialogResult.OK)
            {
                string objectInJson;
                var list = new List<string>();
                using (var readtext = new StreamReader(this.LoadDataDail.FileName))
                {
                    while (!readtext.EndOfStream)
                    {
                        list.Add(readtext.ReadLine());
                    }
                    
                }
                this.mainData.ReadFromFile(list);
                UpdateListList();
                this.Komunikat.Text = "Wczytano liste";
            }
            else
            {
                this.Komunikat.Text = "nie pyklo";
            }
        }
        private void LoaderData_FileOk(object sender, CancelEventArgs e)
        {
            

        }
        private void Rewrite_Language()
        {
            label5.Text = lang.Progress_label;
            label6.Text = lang.Select_label;
            label2.Text = lang.Thing_name_label;
            label1.Text = lang.Thing_category_label;
            label4.Text = lang.List_name_label;
            label3.Text = lang.List_description_label;
            AddProduktButton.Text = lang.Thing_add_btn;
            DeleteBut.Text = lang.Thing_del_btn;
            AddListaButt.Text = lang.List_add_btn;
            DeleteButList.Text = lang.List_del_btn;
            LoadList.Text = lang.Load_list_btn;
            SaveList.Text = lang.Save_list_btn;
        }


        public ShopingElement GetNextElement()
        {

            try
            {
                var output = this.ListList.SelectedIndex;
                var item = this.mainData.StorageOfProductList[output].ListOfProduct.FindIndex(c => c.isChecked == false);
                this.itemPosition = item;
                this.viewElement = this.mainData.StorageOfProductList[output].ListOfProduct[item];
                RefreshListProd();
                return this.viewElement;
            }
            catch(Exception)
            {
                return this.viewElement;
            }

        }
        private void RefreshListProd()
        {
            try
            {
                UpdateProductList(this.mainData.StorageOfProductList[0]);
            }
            catch (Exception)
            {
                this.ListProd.Items.Clear();
            }
        }

        public ShopingElement AccepctElement()
        { 
            this.mainData.StorageOfProductList[this.ListList.SelectedIndex].ListOfProduct[this.itemPosition].isChecked = true;
            
            try
            {
                UpdateProductList(this.mainData.StorageOfProductList[0]);
            }
            catch (Exception)
            {
                this.ListProd.Items.Clear();
            }
            return GetNextElement();
        }
    }
}
