using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using ShopingList.Compt;

namespace ShopingList.Component
{
    public partial class ShopingListComponent : UserControl
    {

        private int lastIndex;

        public IMainData dataObject;

        public ShopingListComponent()
        {
            BaseOperations();
            this.dataObject = new MainData();
        }

        public ShopingListComponent(IMainData dataobject)
        {
            BaseOperations();
            this.dataObject = dataobject;
        }

        private void UpdateListList()
        {
            ListaList.Items.Clear();
            foreach (var item in this.dataObject.StorageOfProductList)
            {
                ListaList.Items.Add($"{item.Name}");
            }

        }

        private void UpdateListaProduktow(ListOfProducts list)
        {
            ListaProduktow.Items.Clear();
            foreach (var item in list.ListOfProduct)
            {
                ListaProduktow.Items.Add($"{item.Name} Kategoria: {item.Category}");
            }
        }

        private void BaseOperations()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (ListaList.SelectedIndex >= 0)
            {
                var newItem = new ShopingElement();
                newItem.Name = NameInput.Text;
                newItem.Category = CategoryInput.Text;
                var output = this.dataObject.StorageOfProductList[ListaList.SelectedIndex];
                output.AddToProductToList(newItem);
                UpdateListaProduktow(output);
            }
        }

        private void DodajListeButt_Click(object sender, EventArgs e)
        {
            var newitem = this.dataObject.AddProductList(NazwaListInput.Text, OpisListyInput.Text);
            UpdateListList();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (ListaList.SelectedIndex >= 0)
            {
                var productIndex = ListaProduktow.SelectedIndex;
                if (productIndex >= 0)
                {
                    var output = this.dataObject.StorageOfProductList[ListaList.SelectedIndex];
                    output.DeleteProductFromList(output.ListOfProduct[productIndex]);
                    UpdateListaProduktow(output);
                }

            }
        }

        private void ListaList_SelectedIndexChanged(object sender, EventArgs e)
        {
            var index = ListaList.SelectedIndex;
            if (index >= 0)
            {
                var output = this.dataObject.StorageOfProductList[index];
                this.lastIndex = index;
                UpdateListaProduktow(output);
            }

        }

        private void button8_Click(object sender, EventArgs e)
        {
            var index = ListaList.SelectedIndex;
            if (index >= 0)
            {
                this.dataObject.DeleteProductList(this.dataObject.StorageOfProductList[index]);
                UpdateListList();

                if (this.dataObject.StorageOfProductList.Count == 0)
                {
                    ListaProduktow.Items.Clear();
                }
                else
                {
                    UpdateListaProduktow(this.dataObject.StorageOfProductList[0]);
                }


            }
        }
    }
}
