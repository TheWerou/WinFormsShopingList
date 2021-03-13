
namespace ShopingList.Component
{
    partial class ZPKcomponentcs
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ListProd = new System.Windows.Forms.CheckedListBox();
            this.ListList = new System.Windows.Forms.ListBox();
            this.DeleteBut = new System.Windows.Forms.Button();
            this.DeleteButList = new System.Windows.Forms.Button();
            this.ProgresBarr = new System.Windows.Forms.ProgressBar();
            this.NameProdInput = new System.Windows.Forms.TextBox();
            this.CategoryInput = new System.Windows.Forms.TextBox();
            this.NameListInput = new System.Windows.Forms.TextBox();
            this.DescryptionInput = new System.Windows.Forms.TextBox();
            this.AddProduktButton = new System.Windows.Forms.Button();
            this.AddListaButt = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SaveList = new System.Windows.Forms.Button();
            this.LoadList = new System.Windows.Forms.Button();
            this.DescriptionText = new System.Windows.Forms.RichTextBox();
            this.CategryList = new System.Windows.Forms.ListBox();
            this.label6 = new System.Windows.Forms.Label();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.SaverData = new System.Windows.Forms.SaveFileDialog();
            this.SuspendLayout();
            // 
            // ListProd
            // 
            this.ListProd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ListProd.FormattingEnabled = true;
            this.ListProd.Location = new System.Drawing.Point(19, 121);
            this.ListProd.Name = "ListProd";
            this.ListProd.Size = new System.Drawing.Size(567, 326);
            this.ListProd.TabIndex = 0;
            // 
            // ListList
            // 
            this.ListList.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ListList.FormattingEnabled = true;
            this.ListList.ItemHeight = 20;
            this.ListList.Location = new System.Drawing.Point(818, 121);
            this.ListList.Name = "ListList";
            this.ListList.Size = new System.Drawing.Size(314, 324);
            this.ListList.TabIndex = 1;
            this.ListList.SelectedIndexChanged += new System.EventHandler(this.ListList_SelectedIndexChanged);
            // 
            // DeleteBut
            // 
            this.DeleteBut.Location = new System.Drawing.Point(19, 494);
            this.DeleteBut.Name = "DeleteBut";
            this.DeleteBut.Size = new System.Drawing.Size(221, 34);
            this.DeleteBut.TabIndex = 2;
            this.DeleteBut.Text = "Usuń przedmiot";
            this.DeleteBut.UseVisualStyleBackColor = true;
            this.DeleteBut.Click += new System.EventHandler(this.DeleteBut_Click);
            // 
            // DeleteButList
            // 
            this.DeleteButList.Location = new System.Drawing.Point(909, 495);
            this.DeleteButList.Name = "DeleteButList";
            this.DeleteButList.Size = new System.Drawing.Size(223, 34);
            this.DeleteButList.TabIndex = 3;
            this.DeleteButList.Text = "Usuń liste zakupów";
            this.DeleteButList.UseVisualStyleBackColor = true;
            this.DeleteButList.Click += new System.EventHandler(this.DeleteButList_Click);
            // 
            // ProgresBarr
            // 
            this.ProgresBarr.Location = new System.Drawing.Point(19, 82);
            this.ProgresBarr.Name = "ProgresBarr";
            this.ProgresBarr.Size = new System.Drawing.Size(567, 33);
            this.ProgresBarr.TabIndex = 4;
            // 
            // NameProdInput
            // 
            this.NameProdInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.NameProdInput.Location = new System.Drawing.Point(365, 456);
            this.NameProdInput.Name = "NameProdInput";
            this.NameProdInput.Size = new System.Drawing.Size(222, 34);
            this.NameProdInput.TabIndex = 5;
            // 
            // CategoryInput
            // 
            this.CategoryInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.CategoryInput.Location = new System.Drawing.Point(364, 494);
            this.CategoryInput.Name = "CategoryInput";
            this.CategoryInput.Size = new System.Drawing.Size(222, 34);
            this.CategoryInput.TabIndex = 6;
            // 
            // NameListInput
            // 
            this.NameListInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.NameListInput.Location = new System.Drawing.Point(593, 456);
            this.NameListInput.Name = "NameListInput";
            this.NameListInput.Size = new System.Drawing.Size(222, 34);
            this.NameListInput.TabIndex = 7;
            // 
            // DescryptionInput
            // 
            this.DescryptionInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.DescryptionInput.Location = new System.Drawing.Point(593, 496);
            this.DescryptionInput.Name = "DescryptionInput";
            this.DescryptionInput.Size = new System.Drawing.Size(222, 34);
            this.DescryptionInput.TabIndex = 8;
            // 
            // AddProduktButton
            // 
            this.AddProduktButton.Location = new System.Drawing.Point(19, 456);
            this.AddProduktButton.Name = "AddProduktButton";
            this.AddProduktButton.Size = new System.Drawing.Size(222, 34);
            this.AddProduktButton.TabIndex = 9;
            this.AddProduktButton.Text = "Dodaj przedmiot";
            this.AddProduktButton.UseVisualStyleBackColor = true;
            this.AddProduktButton.Click += new System.EventHandler(this.AddProduktButton_Click);
            // 
            // AddListaButt
            // 
            this.AddListaButt.Location = new System.Drawing.Point(910, 456);
            this.AddListaButt.Name = "AddListaButt";
            this.AddListaButt.Size = new System.Drawing.Size(222, 34);
            this.AddListaButt.TabIndex = 10;
            this.AddListaButt.Text = "Dodaj Liste";
            this.AddListaButt.UseVisualStyleBackColor = true;
            this.AddListaButt.Click += new System.EventHandler(this.AddListaButt_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(246, 494);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 29);
            this.label1.TabIndex = 11;
            this.label1.Text = "Kategoria";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(246, 461);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 29);
            this.label2.TabIndex = 12;
            this.label2.Text = "Nazwa";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(821, 495);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 29);
            this.label3.TabIndex = 13;
            this.label3.Text = "Opis";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(821, 459);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 29);
            this.label4.TabIndex = 14;
            this.label4.Text = "Nazwa";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(20, 50);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(111, 25);
            this.label5.TabIndex = 23;
            this.label5.Text = "Postęp listy";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // SaveList
            // 
            this.SaveList.Location = new System.Drawing.Point(593, 534);
            this.SaveList.Name = "SaveList";
            this.SaveList.Size = new System.Drawing.Size(539, 31);
            this.SaveList.TabIndex = 24;
            this.SaveList.Text = "Zapisz listy do pliku";
            this.SaveList.UseVisualStyleBackColor = true;
            this.SaveList.Click += new System.EventHandler(this.SaveList_Click);
            // 
            // LoadList
            // 
            this.LoadList.Location = new System.Drawing.Point(19, 534);
            this.LoadList.Name = "LoadList";
            this.LoadList.Size = new System.Drawing.Size(568, 31);
            this.LoadList.TabIndex = 25;
            this.LoadList.Text = "Wczytaj listy";
            this.LoadList.UseVisualStyleBackColor = true;
            // 
            // DescriptionText
            // 
            this.DescriptionText.Location = new System.Drawing.Point(592, 243);
            this.DescriptionText.Name = "DescriptionText";
            this.DescriptionText.Size = new System.Drawing.Size(219, 86);
            this.DescriptionText.TabIndex = 26;
            this.DescriptionText.Text = "Opis: Listy ( Work in progres ) ";
            // 
            // CategryList
            // 
            this.CategryList.FormattingEnabled = true;
            this.CategryList.ItemHeight = 16;
            this.CategryList.Items.AddRange(new object[] {
            "Lista kategori po klikniecu mozna ",
            "je sortowąć (Do zrobienia)"});
            this.CategryList.Location = new System.Drawing.Point(592, 121);
            this.CategryList.Name = "CategryList";
            this.CategryList.Size = new System.Drawing.Size(220, 116);
            this.CategryList.TabIndex = 27;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.Location = new System.Drawing.Point(592, 89);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(215, 25);
            this.label6.TabIndex = 28;
            this.label6.Text = "Wybierz by posortować";
            // 
            // richTextBox2
            // 
            this.richTextBox2.Location = new System.Drawing.Point(593, 335);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.Size = new System.Drawing.Size(218, 110);
            this.richTextBox2.TabIndex = 29;
            this.richTextBox2.Text = "Tu będa komunikaty";
            // 
            // SaverData
            // 
            this.SaverData.FileName = "ListaZakupow.txt";
            this.SaverData.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            this.SaverData.Title = "Zapisz liste list";
            this.SaverData.FileOk += new System.ComponentModel.CancelEventHandler(this.saveFileDialog1_FileOk);
            // 
            // ZPKcomponentcs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(67)))), ((int)(((byte)(147)))));
            this.Controls.Add(this.richTextBox2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.CategryList);
            this.Controls.Add(this.DescriptionText);
            this.Controls.Add(this.LoadList);
            this.Controls.Add(this.SaveList);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.AddListaButt);
            this.Controls.Add(this.AddProduktButton);
            this.Controls.Add(this.DescryptionInput);
            this.Controls.Add(this.NameListInput);
            this.Controls.Add(this.CategoryInput);
            this.Controls.Add(this.NameProdInput);
            this.Controls.Add(this.ProgresBarr);
            this.Controls.Add(this.DeleteButList);
            this.Controls.Add(this.DeleteBut);
            this.Controls.Add(this.ListList);
            this.Controls.Add(this.ListProd);
            this.Name = "ZPKcomponentcs";
            this.Size = new System.Drawing.Size(1166, 600);
            this.Load += new System.EventHandler(this.ZPKcomponentcs_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckedListBox ListProd;
        private System.Windows.Forms.ListBox ListList;
        private System.Windows.Forms.Button DeleteBut;
        private System.Windows.Forms.Button DeleteButList;
        private System.Windows.Forms.ProgressBar ProgresBarr;
        private System.Windows.Forms.TextBox NameProdInput;
        private System.Windows.Forms.TextBox CategoryInput;
        private System.Windows.Forms.TextBox NameListInput;
        private System.Windows.Forms.TextBox DescryptionInput;
        private System.Windows.Forms.Button AddProduktButton;
        private System.Windows.Forms.Button AddListaButt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button SaveList;
        private System.Windows.Forms.Button LoadList;
        private System.Windows.Forms.RichTextBox DescriptionText;
        private System.Windows.Forms.ListBox CategryList;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RichTextBox richTextBox2;
        private System.Windows.Forms.SaveFileDialog SaverData;
    }
}
