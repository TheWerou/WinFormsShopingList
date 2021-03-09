using ShopingList.Data;
using ShopingList.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShopingList
{
    public partial class Form1 : Form
    {
        public MainData dataObject;
        public int lastIndex;
        public Form1()
        {
            InitializeComponent();
            this.dataObject = new MainData();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        { 

            if (ListaList.SelectedIndex >= 0)
            {
                var newItem = new ShopingElement();
                newItem.Name = NameInput.Text;
                newItem.Category = CategoryInput.Text;
                var output = this.dataObject.SotrageOfProductList[ListaList.SelectedIndex];
                output.AddToProductToList(newItem);
                UpdateListaProduktow(output);
            }


        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if(ListaList.SelectedIndex >= 0)
            {
                var productIndex = ListaProduktow.SelectedIndex;
                if(productIndex >= 0)
                {
                    var output = this.dataObject.SotrageOfProductList[ListaList.SelectedIndex];
                    output.DeleteProductFromList(output.ListOfProduct[productIndex]);
                    UpdateListaProduktow(output);
                }
                
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            var newitem = this.dataObject.AddProductList(NazwaListInput.Text, OpisListyInput.Text);
            UpdateListList();

        }
        private void UpdateListList()
        {
            ListaList.Items.Clear();
            foreach (var item in this.dataObject.SotrageOfProductList)
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

        private void ListaList_SelectedIndexChanged(object sender, EventArgs e)
        {
            var index = ListaList.SelectedIndex;
            if(index >= 0)
            {
                var output = this.dataObject.SotrageOfProductList[index];
                this.lastIndex = index;
                UpdateListaProduktow(output);
            }

        }

        private void button8_Click(object sender, EventArgs e)
        {
            var index = ListaList.SelectedIndex;
            if (index >= 0)
            {
                this.dataObject.DeleteProductList(this.dataObject.SotrageOfProductList[index]);
                UpdateListList();
                         
               if(this.dataObject.SotrageOfProductList.Count == 0)
               {
                    ListaProduktow.Items.Clear();
               }
               else
               {
                    UpdateListaProduktow(this.dataObject.SotrageOfProductList[0]);
                }
                    
                
            }
        }
    }
}
