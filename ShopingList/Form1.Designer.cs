
namespace ShopingList
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ListaProduktow = new System.Windows.Forms.CheckedListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.CategoryInput = new System.Windows.Forms.TextBox();
            this.NameInput = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.ListaList = new System.Windows.Forms.ListBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.NazwaListInput = new System.Windows.Forms.TextBox();
            this.OpisListyInput = new System.Windows.Forms.TextBox();
            this.DodajListeButt = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button6 = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // ListaProduktow
            // 
            this.ListaProduktow.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ListaProduktow.FormattingEnabled = true;
            this.ListaProduktow.Location = new System.Drawing.Point(184, 107);
            this.ListaProduktow.Name = "ListaProduktow";
            this.ListaProduktow.Size = new System.Drawing.Size(294, 202);
            this.ListaProduktow.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(184, 395);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(294, 41);
            this.button1.TabIndex = 1;
            this.button1.Text = "Dodaj Produkt";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(12, 280);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(165, 29);
            this.button3.TabIndex = 3;
            this.button3.Text = "Usuń";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // CategoryInput
            // 
            this.CategoryInput.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CategoryInput.Location = new System.Drawing.Point(287, 315);
            this.CategoryInput.Name = "CategoryInput";
            this.CategoryInput.Size = new System.Drawing.Size(191, 34);
            this.CategoryInput.TabIndex = 4;
            // 
            // NameInput
            // 
            this.NameInput.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.NameInput.Location = new System.Drawing.Point(287, 355);
            this.NameInput.Name = "NameInput";
            this.NameInput.Size = new System.Drawing.Size(191, 34);
            this.NameInput.TabIndex = 5;
            this.NameInput.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(-189, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(-292, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "label2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(184, 312);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 28);
            this.label3.TabIndex = 8;
            this.label3.Text = "Kategoria";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(184, 358);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 28);
            this.label4.TabIndex = 9;
            this.label4.Text = "Nazwa";
            // 
            // ListaList
            // 
            this.ListaList.FormattingEnabled = true;
            this.ListaList.ItemHeight = 20;
            this.ListaList.Location = new System.Drawing.Point(485, 107);
            this.ListaList.Name = "ListaList";
            this.ListaList.Size = new System.Drawing.Size(293, 204);
            this.ListaList.TabIndex = 10;
            this.ListaList.SelectedIndexChanged += new System.EventHandler(this.ListaList_SelectedIndexChanged);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(12, 107);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(165, 27);
            this.textBox3.TabIndex = 11;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 141);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(165, 29);
            this.button2.TabIndex = 12;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(12, 177);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(165, 27);
            this.textBox4.TabIndex = 13;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(12, 211);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(165, 29);
            this.button4.TabIndex = 14;
            this.button4.Text = "button4";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // NazwaListInput
            // 
            this.NazwaListInput.Location = new System.Drawing.Point(587, 323);
            this.NazwaListInput.Name = "NazwaListInput";
            this.NazwaListInput.Size = new System.Drawing.Size(191, 27);
            this.NazwaListInput.TabIndex = 15;
            // 
            // OpisListyInput
            // 
            this.OpisListyInput.Location = new System.Drawing.Point(587, 357);
            this.OpisListyInput.Name = "OpisListyInput";
            this.OpisListyInput.Size = new System.Drawing.Size(191, 27);
            this.OpisListyInput.TabIndex = 16;
            // 
            // DodajListeButt
            // 
            this.DodajListeButt.Location = new System.Drawing.Point(485, 395);
            this.DodajListeButt.Name = "DodajListeButt";
            this.DodajListeButt.Size = new System.Drawing.Size(293, 41);
            this.DodajListeButt.TabIndex = 17;
            this.DodajListeButt.Text = "Dodaj Liste";
            this.DodajListeButt.UseVisualStyleBackColor = true;
            this.DodajListeButt.Click += new System.EventHandler(this.button5_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(509, 323);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 20);
            this.label5.TabIndex = 18;
            this.label5.Text = "Nazwa";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(509, 358);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 20);
            this.label6.TabIndex = 19;
            this.label6.Text = "Opis";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(784, 107);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(175, 27);
            this.textBox1.TabIndex = 20;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(784, 141);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(175, 29);
            this.button6.TabIndex = 21;
            this.button6.Text = "button6";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(784, 177);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(175, 27);
            this.textBox2.TabIndex = 22;
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(784, 211);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(175, 29);
            this.button7.TabIndex = 23;
            this.button7.Text = "button7";
            this.button7.UseVisualStyleBackColor = true;
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(785, 279);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(174, 29);
            this.button8.TabIndex = 24;
            this.button8.Text = "Usuń liste";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(184, 67);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(294, 27);
            this.textBox5.TabIndex = 25;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(965, 467);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.DodajListeButt);
            this.Controls.Add(this.OpisListyInput);
            this.Controls.Add(this.NazwaListInput);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.ListaList);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.NameInput);
            this.Controls.Add(this.CategoryInput);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ListaProduktow);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckedListBox ListaProduktow;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox CategoryInput;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox ListaList;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox NameInput;
        private System.Windows.Forms.TextBox NazwaListInput;
        private System.Windows.Forms.TextBox OpisListyInput;
        private System.Windows.Forms.Button DodajListeButt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.TextBox textBox5;
    }
}

