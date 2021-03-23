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

        public ZPKcomponentcs()
        {
            InitializeComponent();
            this.mainData = new MainData();
            this.lang = this.mainData.lang;
            Rewrite_Language();
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
        }

        private void UpdateProductList(ListOfProducts listOfProducts)
        {
            this.ListProd.Items.Clear();
            foreach (var item in listOfProducts.ListOfProduct)
            {
                this.ListProd.Items.Add($"Nazwa {item.Name} Category: {item.Category}");
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
            }
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
            UpdateProductList(this.mainData.StorageOfProductList[0]);

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
    }
}
