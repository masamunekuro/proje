namespace proje.admin
{
    partial class frmaouthor
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
            this.tbyazar = new System.Windows.Forms.TextBox();
            this.tbyazar2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.rtdescyazar = new System.Windows.Forms.RichTextBox();
            this.btsyazar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "yazar adı";
            // 
            // tbyazar
            // 
            this.tbyazar.Location = new System.Drawing.Point(71, 34);
            this.tbyazar.Name = "tbyazar";
            this.tbyazar.Size = new System.Drawing.Size(100, 20);
            this.tbyazar.TabIndex = 1;
            // 
            // tbyazar2
            // 
            this.tbyazar2.Location = new System.Drawing.Point(71, 78);
            this.tbyazar2.Name = "tbyazar2";
            this.tbyazar2.Size = new System.Drawing.Size(100, 20);
            this.tbyazar2.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "soyadı";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "açıklama";
            // 
            // rtdescyazar
            // 
            this.rtdescyazar.Location = new System.Drawing.Point(71, 117);
            this.rtdescyazar.Name = "rtdescyazar";
            this.rtdescyazar.Size = new System.Drawing.Size(100, 96);
            this.rtdescyazar.TabIndex = 5;
            this.rtdescyazar.Text = "";
            // 
            // btsyazar
            // 
            this.btsyazar.Location = new System.Drawing.Point(71, 230);
            this.btsyazar.Name = "btsyazar";
            this.btsyazar.Size = new System.Drawing.Size(100, 38);
            this.btsyazar.TabIndex = 6;
            this.btsyazar.Text = "kaydet";
            this.btsyazar.UseVisualStyleBackColor = true;
            // 
            // frmaouthor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btsyazar);
            this.Controls.Add(this.rtdescyazar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbyazar2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbyazar);
            this.Controls.Add(this.label1);
            this.Name = "frmaouthor";
            this.Text = "frmaouthor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbyazar;
        private System.Windows.Forms.TextBox tbyazar2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox rtdescyazar;
        private System.Windows.Forms.Button btsyazar;
    }
}