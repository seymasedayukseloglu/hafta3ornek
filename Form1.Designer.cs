namespace hafta3ornek
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
            button1 = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            adTxt = new TextBox();
            adresTxt = new TextBox();
            yasTxt = new TextBox();
            comboBox1 = new ComboBox();
            mesaiTxt = new TextBox();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(478, 59);
            button1.Name = "button1";
            button1.Size = new Size(184, 69);
            button1.TabIndex = 0;
            button1.Text = "Personel Oluştur";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(36, 59);
            label1.Name = "label1";
            label1.Size = new Size(73, 20);
            label1.TabIndex = 1;
            label1.Text = "Ad Soyad";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(36, 131);
            label2.Name = "label2";
            label2.Size = new Size(47, 20);
            label2.TabIndex = 2;
            label2.Text = "Adres";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(36, 184);
            label3.Name = "label3";
            label3.Size = new Size(30, 20);
            label3.TabIndex = 3;
            label3.Text = "Yaş";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(36, 259);
            label4.Name = "label4";
            label4.Size = new Size(50, 20);
            label4.TabIndex = 4;
            label4.Text = "Ünvan";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(36, 339);
            label5.Name = "label5";
            label5.Size = new Size(85, 20);
            label5.TabIndex = 5;
            label5.Text = "Mesai Saati";
            // 
            // adTxt
            // 
            adTxt.Location = new Point(130, 52);
            adTxt.Name = "adTxt";
            adTxt.Size = new Size(125, 27);
            adTxt.TabIndex = 6;
            // 
            // adresTxt
            // 
            adresTxt.Location = new Point(130, 124);
            adresTxt.Name = "adresTxt";
            adresTxt.Size = new Size(125, 27);
            adresTxt.TabIndex = 7;
            // 
            // yasTxt
            // 
            yasTxt.Location = new Point(130, 184);
            yasTxt.Name = "yasTxt";
            yasTxt.Size = new Size(125, 27);
            yasTxt.TabIndex = 8;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(130, 256);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(151, 28);
            comboBox1.TabIndex = 9;
            // 
            // mesaiTxt
            // 
            mesaiTxt.Location = new Point(156, 332);
            mesaiTxt.Name = "mesaiTxt";
            mesaiTxt.Size = new Size(125, 27);
            mesaiTxt.TabIndex = 10;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(mesaiTxt);
            Controls.Add(comboBox1);
            Controls.Add(yasTxt);
            Controls.Add(adresTxt);
            Controls.Add(adTxt);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox adTxt;
        private TextBox adresTxt;
        private TextBox yasTxt;
        private ComboBox comboBox1;
        private TextBox mesaiTxt;
    }
}