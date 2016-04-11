namespace Lab4
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
            this.rbPolski = new System.Windows.Forms.RadioButton();
            this.rbAngielski = new System.Windows.Forms.RadioButton();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.tbWyszukaj = new System.Windows.Forms.TextBox();
            this.tbWynik = new System.Windows.Forms.TextBox();
            this.tbToTranslate = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rbPolski
            // 
            this.rbPolski.AutoSize = true;
            this.rbPolski.Checked = true;
            this.rbPolski.Location = new System.Drawing.Point(37, 28);
            this.rbPolski.Name = "rbPolski";
            this.rbPolski.Size = new System.Drawing.Size(60, 17);
            this.rbPolski.TabIndex = 0;
            this.rbPolski.TabStop = true;
            this.rbPolski.Text = "pol-ang";
            this.rbPolski.UseVisualStyleBackColor = true;
            this.rbPolski.CheckedChanged += new System.EventHandler(this.rbAngielski_CheckedChanged);
            // 
            // rbAngielski
            // 
            this.rbAngielski.AutoSize = true;
            this.rbAngielski.Location = new System.Drawing.Point(201, 28);
            this.rbAngielski.Name = "rbAngielski";
            this.rbAngielski.Size = new System.Drawing.Size(66, 17);
            this.rbAngielski.TabIndex = 1;
            this.rbAngielski.Text = "ang - pol";
            this.rbAngielski.UseVisualStyleBackColor = true;
            this.rbAngielski.CheckedChanged += new System.EventHandler(this.rbAngielski_CheckedChanged);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(37, 107);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(120, 95);
            this.listBox1.TabIndex = 2;
            this.listBox1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listBox1_MouseDoubleClick);
            // 
            // tbWyszukaj
            // 
            this.tbWyszukaj.Location = new System.Drawing.Point(37, 81);
            this.tbWyszukaj.Name = "tbWyszukaj";
            this.tbWyszukaj.Size = new System.Drawing.Size(120, 20);
            this.tbWyszukaj.TabIndex = 3;
            this.tbWyszukaj.TextChanged += new System.EventHandler(this.tbWyszukaj_TextChanged);
            // 
            // tbWynik
            // 
            this.tbWynik.Location = new System.Drawing.Point(201, 107);
            this.tbWynik.Multiline = true;
            this.tbWynik.Name = "tbWynik";
            this.tbWynik.Size = new System.Drawing.Size(208, 95);
            this.tbWynik.TabIndex = 5;
            // 
            // tbToTranslate
            // 
            this.tbToTranslate.Location = new System.Drawing.Point(201, 80);
            this.tbToTranslate.Name = "tbToTranslate";
            this.tbToTranslate.Size = new System.Drawing.Size(100, 20);
            this.tbToTranslate.TabIndex = 6;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(307, 76);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(30, 25);
            this.button2.TabIndex = 7;
            this.button2.Text = "T";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(343, 75);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(30, 25);
            this.button3.TabIndex = 8;
            this.button3.Text = "+";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(379, 75);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(30, 25);
            this.button4.TabIndex = 9;
            this.button4.Text = "-";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(539, 240);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.tbToTranslate);
            this.Controls.Add(this.tbWynik);
            this.Controls.Add(this.tbWyszukaj);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.rbAngielski);
            this.Controls.Add(this.rbPolski);
            this.Name = "Form1";
            this.Text = "Słownik";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rbPolski;
        private System.Windows.Forms.RadioButton rbAngielski;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TextBox tbWyszukaj;
        private System.Windows.Forms.TextBox tbWynik;
        private System.Windows.Forms.TextBox tbToTranslate;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
    }
}

