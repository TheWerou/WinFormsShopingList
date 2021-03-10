using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShopingList.Component
{
    public partial class ZPKcomponentcs : UserControl
    {
        private IMainData mainData;

        public ZPKcomponentcs()
        {
            InitializeComponent();
            this.mainData = new MainData();
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
                this.ListProd.Items.Add($"Nazwa {item.Name}");
                
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
    }
}
