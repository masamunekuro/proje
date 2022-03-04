namespace proje.admin
{
    partial class frmcategory
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
            this.kategoriadı = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.rtdesccategoryy = new System.Windows.Forms.RichTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btsave = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // kategoriadı
            // 
            this.kategoriadı.Location = new System.Drawing.Point(105, 44);
            this.kategoriadı.Name = "kategoriadı";
            this.kategoriadı.Size = new System.Drawing.Size(186, 22);
            this.kategoriadı.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "kategori adı";
            // 
            // rtdesccategoryy
            // 
            this.rtdesccategoryy.Location = new System.Drawing.Point(105, 83);
            this.rtdesccategoryy.Name = "rtdesccategoryy";
            this.rtdesccategoryy.Size = new System.Drawing.Size(186, 139);
            this.rtdesccategoryy.TabIndex = 24;
            this.rtdesccategoryy.Text = "";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(21, 83);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 16);
            this.label7.TabIndex = 23;
            this.label7.Text = "açıklama";
            // 
            // btsave
            // 
            this.btsave.Location = new System.Drawing.Point(105, 244);
            this.btsave.Name = "btsave";
            this.btsave.Size = new System.Drawing.Size(186, 48);
            this.btsave.TabIndex = 25;
            this.btsave.Text = "save";
            this.btsave.UseVisualStyleBackColor = true;
            // 
            // frmcategory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.btsave);
            this.Controls.Add(this.rtdesccategoryy);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.kategoriadı);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmcategory";
            this.Text = "frmcategory";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox kategoriadı;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox rtdesccategoryy;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btsave;
    }
}