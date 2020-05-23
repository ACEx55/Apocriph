namespace Телефон
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.б4 = new System.Windows.Forms.Button();
            this.б1 = new System.Windows.Forms.Button();
            this.Б2 = new System.Windows.Forms.Button();
            this.б3 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.б5 = new System.Windows.Forms.Button();
            this.б6 = new System.Windows.Forms.Button();
            this.б9 = new System.Windows.Forms.Button();
            this.б8 = new System.Windows.Forms.Button();
            this.б7 = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.б12 = new System.Windows.Forms.Button();
            this.б0 = new System.Windows.Forms.Button();
            this.б11 = new System.Windows.Forms.Button();
            this.directorySearcher1 = new System.DirectoryServices.DirectorySearcher();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // б4
            // 
            this.б4.Location = new System.Drawing.Point(89, 235);
            this.б4.Name = "б4";
            this.б4.Size = new System.Drawing.Size(54, 49);
            this.б4.TabIndex = 0;
            this.б4.Text = "4";
            this.б4.UseVisualStyleBackColor = true;
            this.б4.Click += new System.EventHandler(this.Б4_Click_1);
            // 
            // б1
            // 
            this.б1.Location = new System.Drawing.Point(89, 180);
            this.б1.Name = "б1";
            this.б1.Size = new System.Drawing.Size(54, 49);
            this.б1.TabIndex = 1;
            this.б1.Text = "1";
            this.б1.UseVisualStyleBackColor = true;
            this.б1.Click += new System.EventHandler(this.Б1_Click);
            // 
            // Б2
            // 
            this.Б2.Location = new System.Drawing.Point(149, 180);
            this.Б2.Name = "Б2";
            this.Б2.Size = new System.Drawing.Size(54, 49);
            this.Б2.TabIndex = 1;
            this.Б2.Text = "2";
            this.Б2.UseVisualStyleBackColor = true;
            this.Б2.Click += new System.EventHandler(this.Б2_Click_1);
            // 
            // б3
            // 
            this.б3.Location = new System.Drawing.Point(209, 180);
            this.б3.Name = "б3";
            this.б3.Size = new System.Drawing.Size(54, 49);
            this.б3.TabIndex = 3;
            this.б3.Text = "3";
            this.б3.UseVisualStyleBackColor = true;
            this.б3.Click += new System.EventHandler(this.Button4_Click);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.ForestGreen;
            this.textBox1.Location = new System.Drawing.Point(90, 64);
            this.textBox1.MaxLength = 3;
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(174, 71);
            this.textBox1.TabIndex = 5;
            this.textBox1.TextChanged += new System.EventHandler(this.TextBox1_TextChanged);
            // 
            // б5
            // 
            this.б5.Location = new System.Drawing.Point(149, 235);
            this.б5.Name = "б5";
            this.б5.Size = new System.Drawing.Size(54, 49);
            this.б5.TabIndex = 6;
            this.б5.Text = "5";
            this.б5.UseVisualStyleBackColor = true;
            this.б5.Click += new System.EventHandler(this.Б5_Click_1);
            // 
            // б6
            // 
            this.б6.Location = new System.Drawing.Point(209, 235);
            this.б6.Name = "б6";
            this.б6.Size = new System.Drawing.Size(54, 49);
            this.б6.TabIndex = 7;
            this.б6.Text = "6";
            this.б6.UseVisualStyleBackColor = true;
            this.б6.Click += new System.EventHandler(this.Б6_Click_1);
            // 
            // б9
            // 
            this.б9.Location = new System.Drawing.Point(209, 290);
            this.б9.Name = "б9";
            this.б9.Size = new System.Drawing.Size(54, 49);
            this.б9.TabIndex = 10;
            this.б9.Text = "9";
            this.б9.UseVisualStyleBackColor = true;
            this.б9.Click += new System.EventHandler(this.Б9_Click_1);
            // 
            // б8
            // 
            this.б8.Location = new System.Drawing.Point(149, 290);
            this.б8.Name = "б8";
            this.б8.Size = new System.Drawing.Size(54, 49);
            this.б8.TabIndex = 9;
            this.б8.Text = "8";
            this.б8.UseVisualStyleBackColor = true;
            this.б8.Click += new System.EventHandler(this.Б8_Click_1);
            // 
            // б7
            // 
            this.б7.Location = new System.Drawing.Point(89, 290);
            this.б7.Name = "б7";
            this.б7.Size = new System.Drawing.Size(54, 49);
            this.б7.TabIndex = 8;
            this.б7.Text = "7";
            this.б7.UseVisualStyleBackColor = true;
            this.б7.Click += new System.EventHandler(this.Б7_Click_1);
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.SystemColors.HotTrack;
            this.textBox2.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.textBox2.Location = new System.Drawing.Point(30, 114);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(54, 21);
            this.textBox2.TabIndex = 11;
            this.textBox2.Text = "Трубка";
            this.textBox2.TextChanged += new System.EventHandler(this.TextBox2_TextChanged);
            // 
            // б12
            // 
            this.б12.Location = new System.Drawing.Point(209, 345);
            this.б12.Name = "б12";
            this.б12.Size = new System.Drawing.Size(54, 49);
            this.б12.TabIndex = 15;
            this.б12.Text = "#";
            this.б12.UseVisualStyleBackColor = true;
            this.б12.Click += new System.EventHandler(this.Б12_Click_1);
            // 
            // б0
            // 
            this.б0.Location = new System.Drawing.Point(149, 345);
            this.б0.Name = "б0";
            this.б0.Size = new System.Drawing.Size(54, 49);
            this.б0.TabIndex = 14;
            this.б0.Text = "0";
            this.б0.UseVisualStyleBackColor = true;
            this.б0.Click += new System.EventHandler(this.Button13_Click);
            // 
            // б11
            // 
            this.б11.Location = new System.Drawing.Point(89, 345);
            this.б11.Name = "б11";
            this.б11.Size = new System.Drawing.Size(54, 49);
            this.б11.TabIndex = 13;
            this.б11.Text = "*";
            this.б11.UseVisualStyleBackColor = true;
            this.б11.Click += new System.EventHandler(this.Б11_Click_1);
            // 
            // directorySearcher1
            // 
            this.directorySearcher1.ClientTimeout = System.TimeSpan.Parse("-00:00:01");
            this.directorySearcher1.ServerPageTimeLimit = System.TimeSpan.Parse("-00:00:01");
            this.directorySearcher1.ServerTimeLimit = System.TimeSpan.Parse("-00:00:01");
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DimGray;
            this.button1.ForeColor = System.Drawing.Color.LightGreen;
            this.button1.Location = new System.Drawing.Point(270, 86);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(54, 49);
            this.button1.TabIndex = 17;
            this.button1.Text = "Вызов";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // button2
            // 
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.Location = new System.Drawing.Point(270, 180);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(72, 214);
            this.button2.TabIndex = 18;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(354, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.б12);
            this.Controls.Add(this.б0);
            this.Controls.Add(this.б11);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.б9);
            this.Controls.Add(this.б8);
            this.Controls.Add(this.б7);
            this.Controls.Add(this.б6);
            this.Controls.Add(this.б5);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.б3);
            this.Controls.Add(this.Б2);
            this.Controls.Add(this.б1);
            this.Controls.Add(this.б4);
            this.Name = "Form1";
            this.Text = "Терминал телефона";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button б4;
        private System.Windows.Forms.Button б1;
        private System.Windows.Forms.Button Б2;
        private System.Windows.Forms.Button б3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button б5;
        private System.Windows.Forms.Button б6;
        private System.Windows.Forms.Button б9;
        private System.Windows.Forms.Button б8;
        private System.Windows.Forms.Button б7;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button б12;
        private System.Windows.Forms.Button б0;
        private System.Windows.Forms.Button б11;
        private System.DirectoryServices.DirectorySearcher directorySearcher1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}

