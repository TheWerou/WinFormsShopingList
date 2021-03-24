
namespace ShopingList
{
    partial class Form1
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.CategoryOfElement = new System.Windows.Forms.RichTextBox();
            this.NameOfElemnt = new System.Windows.Forms.RichTextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.zpKcomponentcs1 = new ShopingList.Component.ZPKcomponentcs();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(981, 96);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(133, 28);
            this.button1.TabIndex = 1;
            this.button1.Text = "Język angielski";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(981, 148);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(133, 28);
            this.button2.TabIndex = 3;
            this.button2.Text = "Język polski";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(981, 201);
            this.button3.Margin = new System.Windows.Forms.Padding(4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(133, 28);
            this.button3.TabIndex = 4;
            this.button3.Text = "Zmiana koloru";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // CategoryOfElement
            // 
            this.CategoryOfElement.Location = new System.Drawing.Point(981, 406);
            this.CategoryOfElement.Name = "CategoryOfElement";
            this.CategoryOfElement.Size = new System.Drawing.Size(256, 30);
            this.CategoryOfElement.TabIndex = 6;
            this.CategoryOfElement.Text = "";
            // 
            // NameOfElemnt
            // 
            this.NameOfElemnt.Location = new System.Drawing.Point(981, 371);
            this.NameOfElemnt.Name = "NameOfElemnt";
            this.NameOfElemnt.Size = new System.Drawing.Size(256, 29);
            this.NameOfElemnt.TabIndex = 7;
            this.NameOfElemnt.Text = "";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(981, 443);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(256, 41);
            this.button4.TabIndex = 8;
            this.button4.Text = "Akceptuj i następny";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(981, 490);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(256, 34);
            this.button5.TabIndex = 9;
            this.button5.Text = "Następny";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // zpKcomponentcs1
            // 
            this.zpKcomponentcs1.AccessibleName = "Lista";
            this.zpKcomponentcs1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(67)))), ((int)(((byte)(147)))));
            this.zpKcomponentcs1.Location = new System.Drawing.Point(27, 60);
            this.zpKcomponentcs1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.zpKcomponentcs1.Name = "zpKcomponentcs1";
            this.zpKcomponentcs1.Size = new System.Drawing.Size(870, 545);
            this.zpKcomponentcs1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1372, 664);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.NameOfElemnt);
            this.Controls.Add(this.CategoryOfElement);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.zpKcomponentcs1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Component.ZPKcomponentcs zpKcomponentcs1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.RichTextBox CategoryOfElement;
        private System.Windows.Forms.RichTextBox NameOfElemnt;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
    }
}

