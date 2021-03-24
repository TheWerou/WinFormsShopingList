using ShopingList.Component.Data.Model;
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
        public Form1()
        {
            InitializeComponent();
        }

        private Language PolishText()
        {
            var lang = new Language();
            lang.Progress_label = "Progress of list";
            lang.Select_label = "Sort selection";
            lang.Thing_name_label = "Name";
            lang.Thing_category_label = "Category";
            lang.List_name_label = "Name";
            lang.List_description_label = "Description";
            lang.Thing_add_btn = "Add thing";
            lang.Thing_del_btn = "Delete thing";
            lang.List_add_btn = "Add list";
            lang.List_del_btn = "Delete list";
            lang.Load_list_btn = "Load lists";
            lang.Save_list_btn = "Save lists to file";
            return lang;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.zpKcomponentcs1.Change_Language(PolishText());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.zpKcomponentcs1.Default_Language();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            List<Color> colors = new List<Color> { Color.Red, Color.Green, Color.Blue, Color.Yellow, Color.Orange, Color.Gray };
            var random = new Random();
            var helper = this.zpKcomponentcs1.BackColor;
            int index = random.Next(colors.Count);
            if(this.zpKcomponentcs1.BackColor == colors[index])
            {
                colors.RemoveAt(index);
            }
            try
            {
                helper = this.zpKcomponentcs1.BackColor;
                this.zpKcomponentcs1.BackColor = colors[index];
            }
            catch(ArgumentOutOfRangeException)
            {
                this.zpKcomponentcs1.BackColor = helper;
            }
            
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            var objectToShow = this.zpKcomponentcs1.GetNextElement();
            this.NameOfElemnt.Text = objectToShow.Name;
            this.CategoryOfElement.Text = objectToShow.Category;

        }

        private void button4_Click(object sender, EventArgs e)
        {
            var objectToShow = this.zpKcomponentcs1.AccepctElement();
            this.NameOfElemnt.Text = objectToShow.Name;
            this.CategoryOfElement.Text = objectToShow.Category;

        }
    }
}
