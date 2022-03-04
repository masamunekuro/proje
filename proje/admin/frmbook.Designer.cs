namespace proje.admin
{
    partial class frmbook
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
            this.label1 = new System.Windows.Forms.Label();
            this.bookname = new System.Windows.Forms.TextBox();
            this.aouther = new System.Windows.Forms.TextBox();
            this.price = new System.Windows.Forms.TextBox();
            this.publisher = new System.Windows.Forms.TextBox();
            this.pagenumber = new System.Windows.Forms.TextBox();
            this.basım = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.rtdesc = new System.Windows.Forms.RichTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(51, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "kitap adı";
            // 
            // bookname
            // 
            this.bookname.Location = new System.Drawing.Point(140, 50);
            this.bookname.Name = "bookname";
            this.bookname.Size = new System.Drawing.Size(100, 22);
            this.bookname.TabIndex = 1;
            // 
            // aouther
            // 
            this.aouther.Location = new System.Drawing.Point(140, 78);
            this.aouther.Name = "aouther";
            this.aouther.Size = new System.Drawing.Size(100, 22);
            this.aouther.TabIndex = 12;
            // 
            // price
            // 
            this.price.Location = new System.Drawing.Point(140, 200);
            this.price.Name = "price";
            this.price.Size = new System.Drawing.Size(100, 22);
            this.price.TabIndex = 13;
            // 
            // publisher
            // 
            this.publisher.Location = new System.Drawing.Point(140, 157);
            this.publisher.Name = "publisher";
            this.publisher.Size = new System.Drawing.Size(100, 22);
            this.publisher.TabIndex = 14;
            // 
            // pagenumber
            // 
            this.pagenumber.Location = new System.Drawing.Point(140, 115);
            this.pagenumber.Name = "pagenumber";
            this.pagenumber.Size = new System.Drawing.Size(100, 22);
            this.pagenumber.TabIndex = 15;
            // 
            // basım
            // 
            this.basım.Location = new System.Drawing.Point(140, 238);
            this.basım.Name = "basım";
            this.basım.Size = new System.Drawing.Size(100, 22);
            this.basım.TabIndex = 16;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(51, 163);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 16);
            this.label2.TabIndex = 17;
            this.label2.Text = "yayınevi";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(51, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 16);
            this.label3.TabIndex = 17;
            this.label3.Text = "yazar";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(51, 121);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 16);
            this.label4.TabIndex = 18;
            this.label4.Text = "sayfa sayası";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(51, 203);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 16);
            this.label5.TabIndex = 19;
            this.label5.Text = "fiyat";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(51, 244);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 16);
            this.label6.TabIndex = 20;
            this.label6.Text = "basımyeri";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(51, 284);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 16);
            this.label7.TabIndex = 21;
            this.label7.Text = "açıklama";
            // 
            // rtdesc
            // 
            this.rtdesc.Location = new System.Drawing.Point(140, 284);
            this.rtdesc.Name = "rtdesc";
            this.rtdesc.Size = new System.Drawing.Size(186, 139);
            this.rtdesc.TabIndex = 22;
            this.rtdesc.Text = "";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(140, 451);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(186, 46);
            this.button1.TabIndex = 23;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // frmbook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.rtdesc);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.basım);
            this.Controls.Add(this.pagenumber);
            this.Controls.Add(this.publisher);
            this.Controls.Add(this.price);
            this.Controls.Add(this.aouther);
            this.Controls.Add(this.bookname);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmbook";
            this.Text = "frmbook";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox bookname;
        private System.Windows.Forms.TextBox aouther;
        private System.Windows.Forms.TextBox price;
        private System.Windows.Forms.TextBox publisher;
        private System.Windows.Forms.TextBox pagenumber;
        private System.Windows.Forms.TextBox basım;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RichTextBox rtdesc;
        private System.Windows.Forms.Button button1;
    }
}