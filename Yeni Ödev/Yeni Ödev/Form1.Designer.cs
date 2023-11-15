namespace Yeni_Ödev
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
            panel1 = new Panel();
            label4 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            comboBox2 = new ComboBox();
            MesaiTxt2 = new TextBox();
            birimTxt2 = new ComboBox();
            AdresTxt2 = new TextBox();
            YasTxt2 = new TextBox();
            AdTxt2 = new TextBox();
            button2 = new Button();
            textBox5 = new TextBox();
            adTxt = new TextBox();
            mesaiTxt = new TextBox();
            yasTxt = new TextBox();
            adresTxt = new TextBox();
            comboBox1 = new ComboBox();
            button3 = new Button();
            panel2 = new Panel();
            label17 = new Label();
            label12 = new Label();
            label13 = new Label();
            label14 = new Label();
            label15 = new Label();
            label16 = new Label();
            mesaiTxt3 = new TextBox();
            unvanTxt3 = new ComboBox();
            turTxt3 = new ComboBox();
            adTxt3 = new TextBox();
            adresTxt3 = new TextBox();
            yasTxt3 = new TextBox();
            textBox9 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label5 = new Label();
            label6 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(113, 444);
            button1.Name = "button1";
            button1.Size = new Size(182, 68);
            button1.TabIndex = 0;
            button1.Text = "Personel Oluştur";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.SlateGray;
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(label9);
            panel1.Controls.Add(label10);
            panel1.Controls.Add(label11);
            panel1.Controls.Add(comboBox2);
            panel1.Controls.Add(MesaiTxt2);
            panel1.Controls.Add(birimTxt2);
            panel1.Controls.Add(AdresTxt2);
            panel1.Controls.Add(YasTxt2);
            panel1.Controls.Add(AdTxt2);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(textBox5);
            panel1.Location = new Point(362, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(436, 624);
            panel1.TabIndex = 1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(44, 435);
            label4.Name = "label4";
            label4.Size = new Size(61, 25);
            label4.TabIndex = 27;
            label4.Text = "Birim :";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(38, 366);
            label7.Name = "label7";
            label7.Size = new Size(71, 25);
            label7.TabIndex = 26;
            label7.Text = "Unvan :";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(45, 310);
            label8.Name = "label8";
            label8.Size = new Size(67, 25);
            label8.TabIndex = 25;
            label8.Text = "Mesai :";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(66, 241);
            label9.Name = "label9";
            label9.Size = new Size(46, 25);
            label9.TabIndex = 24;
            label9.Text = "Yaş :";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(38, 106);
            label10.Name = "label10";
            label10.Size = new Size(67, 25);
            label10.TabIndex = 23;
            label10.Text = "Adres :";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(13, 38);
            label11.Name = "label11";
            label11.Size = new Size(99, 25);
            label11.TabIndex = 22;
            label11.Text = "Ad Soyad :";
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "İşçi ", "Muhendis" });
            comboBox2.Location = new Point(126, 363);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(199, 33);
            comboBox2.TabIndex = 17;
            // 
            // MesaiTxt2
            // 
            MesaiTxt2.Location = new Point(126, 303);
            MesaiTxt2.Name = "MesaiTxt2";
            MesaiTxt2.Size = new Size(199, 31);
            MesaiTxt2.TabIndex = 16;
            // 
            // birimTxt2
            // 
            birimTxt2.FormattingEnabled = true;
            birimTxt2.Items.AddRange(new object[] { "Üretim", "Pazarlama", "AR-GE" });
            birimTxt2.Location = new Point(126, 427);
            birimTxt2.Name = "birimTxt2";
            birimTxt2.Size = new Size(199, 33);
            birimTxt2.TabIndex = 15;
            // 
            // AdresTxt2
            // 
            AdresTxt2.Location = new Point(126, 106);
            AdresTxt2.Multiline = true;
            AdresTxt2.Name = "AdresTxt2";
            AdresTxt2.Size = new Size(199, 102);
            AdresTxt2.TabIndex = 14;
            // 
            // YasTxt2
            // 
            YasTxt2.Location = new Point(126, 232);
            YasTxt2.Name = "YasTxt2";
            YasTxt2.Size = new Size(199, 31);
            YasTxt2.TabIndex = 13;
            // 
            // AdTxt2
            // 
            AdTxt2.Location = new Point(126, 41);
            AdTxt2.Name = "AdTxt2";
            AdTxt2.Size = new Size(199, 31);
            AdTxt2.TabIndex = 11;
            // 
            // button2
            // 
            button2.Location = new Point(101, 506);
            button2.Name = "button2";
            button2.Size = new Size(252, 76);
            button2.TabIndex = 2;
            button2.Text = "Mühendis Kaydet";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(59, -54);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(150, 31);
            textBox5.TabIndex = 10;
            // 
            // adTxt
            // 
            adTxt.Location = new Point(113, 50);
            adTxt.Name = "adTxt";
            adTxt.Size = new Size(182, 31);
            adTxt.TabIndex = 3;
            // 
            // mesaiTxt
            // 
            mesaiTxt.Location = new Point(113, 308);
            mesaiTxt.Name = "mesaiTxt";
            mesaiTxt.Size = new Size(182, 31);
            mesaiTxt.TabIndex = 6;
            // 
            // yasTxt
            // 
            yasTxt.Location = new Point(113, 250);
            yasTxt.Name = "yasTxt";
            yasTxt.Size = new Size(182, 31);
            yasTxt.TabIndex = 7;
            // 
            // adresTxt
            // 
            adresTxt.Location = new Point(113, 115);
            adresTxt.Multiline = true;
            adresTxt.Name = "adresTxt";
            adresTxt.Size = new Size(182, 105);
            adresTxt.TabIndex = 8;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(113, 362);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(182, 33);
            comboBox1.TabIndex = 9;
            // 
            // button3
            // 
            button3.Location = new Point(128, 496);
            button3.Name = "button3";
            button3.Size = new Size(279, 86);
            button3.TabIndex = 10;
            button3.Text = "İşçi Kaydet";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(192, 64, 0);
            panel2.Controls.Add(label17);
            panel2.Controls.Add(label12);
            panel2.Controls.Add(label13);
            panel2.Controls.Add(label14);
            panel2.Controls.Add(label15);
            panel2.Controls.Add(label16);
            panel2.Controls.Add(mesaiTxt3);
            panel2.Controls.Add(unvanTxt3);
            panel2.Controls.Add(turTxt3);
            panel2.Controls.Add(button3);
            panel2.Controls.Add(adTxt3);
            panel2.Controls.Add(adresTxt3);
            panel2.Controls.Add(yasTxt3);
            panel2.Controls.Add(textBox9);
            panel2.Location = new Point(884, 12);
            panel2.Name = "panel2";
            panel2.Size = new Size(462, 624);
            panel2.TabIndex = 15;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Location = new Point(72, 419);
            label17.Name = "label17";
            label17.Size = new Size(46, 25);
            label17.TabIndex = 32;
            label17.Text = "Tür :";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(57, 350);
            label12.Name = "label12";
            label12.Size = new Size(71, 25);
            label12.TabIndex = 31;
            label12.Text = "Unvan :";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(61, 296);
            label13.Name = "label13";
            label13.Size = new Size(67, 25);
            label13.TabIndex = 30;
            label13.Text = "Mesai :";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(61, 244);
            label14.Name = "label14";
            label14.Size = new Size(46, 25);
            label14.TabIndex = 29;
            label14.Text = "Yaş :";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(72, 98);
            label15.Name = "label15";
            label15.Size = new Size(67, 25);
            label15.TabIndex = 28;
            label15.Text = "Adres :";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(40, 32);
            label16.Name = "label16";
            label16.Size = new Size(99, 25);
            label16.TabIndex = 27;
            label16.Text = "Ad Soyad :";
            // 
            // mesaiTxt3
            // 
            mesaiTxt3.Location = new Point(171, 293);
            mesaiTxt3.Name = "mesaiTxt3";
            mesaiTxt3.Size = new Size(188, 31);
            mesaiTxt3.TabIndex = 16;
            // 
            // unvanTxt3
            // 
            unvanTxt3.FormattingEnabled = true;
            unvanTxt3.Items.AddRange(new object[] { "İşçi", "Mühendis" });
            unvanTxt3.Location = new Point(171, 350);
            unvanTxt3.Name = "unvanTxt3";
            unvanTxt3.Size = new Size(188, 33);
            unvanTxt3.TabIndex = 15;
            // 
            // turTxt3
            // 
            turTxt3.FormattingEnabled = true;
            turTxt3.Items.AddRange(new object[] { "Gündelik", "Aylık" });
            turTxt3.Location = new Point(171, 411);
            turTxt3.Name = "turTxt3";
            turTxt3.Size = new Size(188, 33);
            turTxt3.TabIndex = 14;
            // 
            // adTxt3
            // 
            adTxt3.Location = new Point(171, 32);
            adTxt3.Name = "adTxt3";
            adTxt3.Size = new Size(188, 31);
            adTxt3.TabIndex = 13;
            // 
            // adresTxt3
            // 
            adresTxt3.Location = new Point(171, 98);
            adresTxt3.Multiline = true;
            adresTxt3.Name = "adresTxt3";
            adresTxt3.Size = new Size(188, 110);
            adresTxt3.TabIndex = 12;
            // 
            // yasTxt3
            // 
            yasTxt3.Location = new Point(171, 241);
            yasTxt3.Name = "yasTxt3";
            yasTxt3.Size = new Size(188, 31);
            yasTxt3.TabIndex = 11;
            // 
            // textBox9
            // 
            textBox9.Location = new Point(59, -54);
            textBox9.Name = "textBox9";
            textBox9.Size = new Size(150, 31);
            textBox9.TabIndex = 10;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(15, 50);
            label1.Name = "label1";
            label1.Size = new Size(99, 25);
            label1.TabIndex = 16;
            label1.Text = "Ad Soyad :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(40, 118);
            label2.Name = "label2";
            label2.Size = new Size(67, 25);
            label2.TabIndex = 17;
            label2.Text = "Adres :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(61, 250);
            label3.Name = "label3";
            label3.Size = new Size(46, 25);
            label3.TabIndex = 18;
            label3.Text = "Yaş :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(40, 308);
            label5.Name = "label5";
            label5.Size = new Size(67, 25);
            label5.TabIndex = 20;
            label5.Text = "Mesai :";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(27, 370);
            label6.Name = "label6";
            label6.Size = new Size(71, 25);
            label6.TabIndex = 21;
            label6.Text = "Unvan :";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDark;
            ClientSize = new Size(1388, 695);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(panel2);
            Controls.Add(comboBox1);
            Controls.Add(adresTxt);
            Controls.Add(yasTxt);
            Controls.Add(mesaiTxt);
            Controls.Add(adTxt);
            Controls.Add(panel1);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Panel panel1;
        private Button button2;
        private TextBox adTxt;
        private TextBox textBox5;
        private TextBox mesaiTxt;
        private TextBox yasTxt;
        private TextBox adresTxt;
        private ComboBox comboBox1;
        private Button button3;
        private ComboBox birimTxt2;
        private TextBox AdresTxt2;
        private TextBox YasTxt2;
        private TextBox AdTxt2;
        private Panel panel2;
        private ComboBox turTxt3;
        private TextBox adTxt3;
        private TextBox adresTxt3;
        private TextBox yasTxt3;
        private TextBox textBox9;
        private ComboBox comboBox2;
        private TextBox MesaiTxt2;
        private TextBox mesaiTxt3;
        private ComboBox unvanTxt3;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
        private Label label4;
        private Label label12;
        private Label label13;
        private Label label14;
        private Label label15;
        private Label label16;
        private Label label17;
    }
}