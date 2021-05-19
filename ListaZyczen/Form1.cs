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

namespace ListaZyczen
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.zpKcomponentcs1.Change_Language(NewText());
        }

        private Language NewText()
        {
            var lang = new Language();
            lang.Progress_label = "Postępy listy";
            lang.Select_label = "Wybierz by posortować";
            lang.Thing_name_label = "Nazwa";
            lang.Thing_category_label = "Kategoria";
            lang.List_name_label = "Nazwa";
            lang.List_description_label = "Opis";
            lang.Thing_add_btn = "Dodaj życzenie";
            lang.Thing_del_btn = "Usuń życzenie";
            lang.List_add_btn = "Dodaj listę życzeń";
            lang.List_del_btn = "Usuń listę życzeń";
            lang.Load_list_btn = "Wczytaj listy życzeń";
            lang.Save_list_btn = "Zapisz listy do pliku";
            lang.Base_message = "Miłego dnia";
            lang.Descrp_List_of_product = "Tu się pokaża twoje listy życzeń";
            return lang;
        }
    }
}
