
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
            this.zpKcomponentcs1 = new ShopingList.Component.ZPKcomponentcs();
            this.SuspendLayout();
            // 
            // zpKcomponentcs1
            // 
            this.zpKcomponentcs1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(67)))), ((int)(((byte)(147)))));
            this.zpKcomponentcs1.Location = new System.Drawing.Point(11, 21);
            this.zpKcomponentcs1.Name = "zpKcomponentcs1";
            this.zpKcomponentcs1.Size = new System.Drawing.Size(1166, 600);
            this.zpKcomponentcs1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1185, 684);
            this.Controls.Add(this.zpKcomponentcs1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Component.ZPKcomponentcs zpKcomponentcs1;
    }
}

