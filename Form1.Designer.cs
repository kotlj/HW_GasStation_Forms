namespace CW_Form_Practic_2_1
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
            components = new System.ComponentModel.Container();
            CafeGroup = new GroupBox();
            CafeSumGroup = new GroupBox();
            cafeUAH = new Label();
            CafeSum = new Label();
            ColaCount = new TextBox();
            FrieCount = new TextBox();
            BurgerCount = new TextBox();
            HotDogCount = new TextBox();
            ColaPrice = new TextBox();
            FriePrice = new TextBox();
            BurgerPrice = new TextBox();
            Cola = new CheckBox();
            Frie = new CheckBox();
            Burger = new CheckBox();
            HotDogPrice = new TextBox();
            HotDog = new CheckBox();
            EndGroup = new GroupBox();
            TotalSumUah = new Label();
            TotalSum = new Label();
            ButTotalSum = new Button();
            OilGroup = new GroupBox();
            OilSumGroup = new GroupBox();
            OilUAH = new Label();
            OilSum = new Label();
            textBoxByPrice = new TextBox();
            textBoxByOil = new TextBox();
            panel1 = new Panel();
            ByPrice = new RadioButton();
            ByOil = new RadioButton();
            Price = new TextBox();
            label2 = new Label();
            label1 = new Label();
            OilType = new ComboBox();
            timer1 = new System.Windows.Forms.Timer(components);
            CafeGroup.SuspendLayout();
            CafeSumGroup.SuspendLayout();
            EndGroup.SuspendLayout();
            OilGroup.SuspendLayout();
            OilSumGroup.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // CafeGroup
            // 
            CafeGroup.Controls.Add(CafeSumGroup);
            CafeGroup.Controls.Add(ColaCount);
            CafeGroup.Controls.Add(FrieCount);
            CafeGroup.Controls.Add(BurgerCount);
            CafeGroup.Controls.Add(HotDogCount);
            CafeGroup.Controls.Add(ColaPrice);
            CafeGroup.Controls.Add(FriePrice);
            CafeGroup.Controls.Add(BurgerPrice);
            CafeGroup.Controls.Add(Cola);
            CafeGroup.Controls.Add(Frie);
            CafeGroup.Controls.Add(Burger);
            CafeGroup.Controls.Add(HotDogPrice);
            CafeGroup.Controls.Add(HotDog);
            CafeGroup.Location = new Point(410, 12);
            CafeGroup.Name = "CafeGroup";
            CafeGroup.Size = new Size(413, 477);
            CafeGroup.TabIndex = 0;
            CafeGroup.TabStop = false;
            CafeGroup.Text = "Мини-кафе";
            // 
            // CafeSumGroup
            // 
            CafeSumGroup.Controls.Add(cafeUAH);
            CafeSumGroup.Controls.Add(CafeSum);
            CafeSumGroup.Location = new Point(6, 333);
            CafeSumGroup.Name = "CafeSumGroup";
            CafeSumGroup.Size = new Size(395, 125);
            CafeSumGroup.TabIndex = 12;
            CafeSumGroup.TabStop = false;
            CafeSumGroup.Text = "К оплате";
            // 
            // cafeUAH
            // 
            cafeUAH.AutoSize = true;
            cafeUAH.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point);
            cafeUAH.Location = new Point(315, 65);
            cafeUAH.Name = "cafeUAH";
            cafeUAH.Size = new Size(28, 17);
            cafeUAH.TabIndex = 1;
            cafeUAH.Text = "грн";
            // 
            // CafeSum
            // 
            CafeSum.AutoSize = true;
            CafeSum.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            CafeSum.Location = new Point(190, 43);
            CafeSum.Name = "CafeSum";
            CafeSum.Size = new Size(38, 46);
            CafeSum.TabIndex = 0;
            CafeSum.Text = "0";
            // 
            // ColaCount
            // 
            ColaCount.Location = new Point(321, 195);
            ColaCount.Name = "ColaCount";
            ColaCount.ReadOnly = true;
            ColaCount.Size = new Size(49, 27);
            ColaCount.TabIndex = 11;
            ColaCount.TextChanged += CafeCount_TextChanged;
            // 
            // FrieCount
            // 
            FrieCount.Location = new Point(321, 153);
            FrieCount.Name = "FrieCount";
            FrieCount.ReadOnly = true;
            FrieCount.Size = new Size(49, 27);
            FrieCount.TabIndex = 10;
            FrieCount.TextChanged += CafeCount_TextChanged;
            // 
            // BurgerCount
            // 
            BurgerCount.Location = new Point(321, 108);
            BurgerCount.Name = "BurgerCount";
            BurgerCount.ReadOnly = true;
            BurgerCount.Size = new Size(49, 27);
            BurgerCount.TabIndex = 9;
            BurgerCount.TextChanged += CafeCount_TextChanged;
            // 
            // HotDogCount
            // 
            HotDogCount.Location = new Point(321, 59);
            HotDogCount.Name = "HotDogCount";
            HotDogCount.ReadOnly = true;
            HotDogCount.Size = new Size(49, 27);
            HotDogCount.TabIndex = 8;
            HotDogCount.TextChanged += CafeCount_TextChanged;
            // 
            // ColaPrice
            // 
            ColaPrice.Location = new Point(226, 195);
            ColaPrice.Name = "ColaPrice";
            ColaPrice.ReadOnly = true;
            ColaPrice.Size = new Size(49, 27);
            ColaPrice.TabIndex = 7;
            ColaPrice.Text = "49";
            // 
            // FriePrice
            // 
            FriePrice.Location = new Point(226, 153);
            FriePrice.Name = "FriePrice";
            FriePrice.ReadOnly = true;
            FriePrice.Size = new Size(49, 27);
            FriePrice.TabIndex = 6;
            FriePrice.Text = "20";
            // 
            // BurgerPrice
            // 
            BurgerPrice.Location = new Point(226, 108);
            BurgerPrice.Name = "BurgerPrice";
            BurgerPrice.ReadOnly = true;
            BurgerPrice.Size = new Size(49, 27);
            BurgerPrice.TabIndex = 5;
            BurgerPrice.Text = "50";
            // 
            // Cola
            // 
            Cola.AutoSize = true;
            Cola.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            Cola.Location = new Point(34, 193);
            Cola.Name = "Cola";
            Cola.Size = new Size(73, 29);
            Cola.TabIndex = 4;
            Cola.Text = "Кола";
            Cola.UseVisualStyleBackColor = true;
            Cola.CheckedChanged += Cola_CheckedChanged;
            // 
            // Frie
            // 
            Frie.AutoSize = true;
            Frie.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            Frie.Location = new Point(34, 151);
            Frie.Name = "Frie";
            Frie.Size = new Size(152, 29);
            Frie.TabIndex = 3;
            Frie.Text = "Картошка фри";
            Frie.UseVisualStyleBackColor = true;
            Frie.CheckedChanged += Frie_CheckedChanged;
            // 
            // Burger
            // 
            Burger.AutoSize = true;
            Burger.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            Burger.Location = new Point(34, 106);
            Burger.Name = "Burger";
            Burger.Size = new Size(91, 29);
            Burger.TabIndex = 2;
            Burger.Text = "Бургер";
            Burger.UseVisualStyleBackColor = true;
            Burger.CheckedChanged += Burger_CheckedChanged;
            // 
            // HotDogPrice
            // 
            HotDogPrice.Location = new Point(226, 59);
            HotDogPrice.Name = "HotDogPrice";
            HotDogPrice.ReadOnly = true;
            HotDogPrice.Size = new Size(49, 27);
            HotDogPrice.TabIndex = 1;
            HotDogPrice.Text = "20";
            // 
            // HotDog
            // 
            HotDog.AutoSize = true;
            HotDog.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            HotDog.Location = new Point(34, 57);
            HotDog.Name = "HotDog";
            HotDog.Size = new Size(98, 29);
            HotDog.TabIndex = 0;
            HotDog.Text = "Хот-дог";
            HotDog.UseVisualStyleBackColor = true;
            HotDog.CheckedChanged += HotDog_CheckedChanged;
            // 
            // EndGroup
            // 
            EndGroup.Controls.Add(TotalSumUah);
            EndGroup.Controls.Add(TotalSum);
            EndGroup.Controls.Add(ButTotalSum);
            EndGroup.Dock = DockStyle.Bottom;
            EndGroup.Location = new Point(0, 495);
            EndGroup.Name = "EndGroup";
            EndGroup.Size = new Size(823, 185);
            EndGroup.TabIndex = 1;
            EndGroup.TabStop = false;
            EndGroup.Text = "Общая сумма к оплате";
            // 
            // TotalSumUah
            // 
            TotalSumUah.AutoSize = true;
            TotalSumUah.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point);
            TotalSumUah.Location = new Point(731, 124);
            TotalSumUah.Name = "TotalSumUah";
            TotalSumUah.Size = new Size(28, 17);
            TotalSumUah.TabIndex = 2;
            TotalSumUah.Text = "грн";
            // 
            // TotalSum
            // 
            TotalSum.AutoSize = true;
            TotalSum.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            TotalSum.Location = new Point(606, 102);
            TotalSum.Name = "TotalSum";
            TotalSum.Size = new Size(38, 46);
            TotalSum.TabIndex = 2;
            TotalSum.Text = "0";
            // 
            // ButTotalSum
            // 
            ButTotalSum.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            ButTotalSum.Location = new Point(182, 64);
            ButTotalSum.Name = "ButTotalSum";
            ButTotalSum.Size = new Size(165, 84);
            ButTotalSum.TabIndex = 0;
            ButTotalSum.Text = "Подсчитать";
            ButTotalSum.UseVisualStyleBackColor = true;
            ButTotalSum.Click += ButTotalSum_Click;
            // 
            // OilGroup
            // 
            OilGroup.Controls.Add(OilSumGroup);
            OilGroup.Controls.Add(textBoxByPrice);
            OilGroup.Controls.Add(textBoxByOil);
            OilGroup.Controls.Add(panel1);
            OilGroup.Controls.Add(Price);
            OilGroup.Controls.Add(label2);
            OilGroup.Controls.Add(label1);
            OilGroup.Controls.Add(OilType);
            OilGroup.Location = new Point(0, 12);
            OilGroup.Name = "OilGroup";
            OilGroup.Size = new Size(404, 477);
            OilGroup.TabIndex = 2;
            OilGroup.TabStop = false;
            OilGroup.Text = "Автозаправка";
            // 
            // OilSumGroup
            // 
            OilSumGroup.Controls.Add(OilUAH);
            OilSumGroup.Controls.Add(OilSum);
            OilSumGroup.Location = new Point(25, 333);
            OilSumGroup.Name = "OilSumGroup";
            OilSumGroup.Size = new Size(373, 125);
            OilSumGroup.TabIndex = 0;
            OilSumGroup.TabStop = false;
            OilSumGroup.Text = "К оплате";
            // 
            // OilUAH
            // 
            OilUAH.AutoSize = true;
            OilUAH.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point);
            OilUAH.Location = new Point(289, 65);
            OilUAH.Name = "OilUAH";
            OilUAH.Size = new Size(28, 17);
            OilUAH.TabIndex = 2;
            OilUAH.Text = "грн";
            // 
            // OilSum
            // 
            OilSum.AutoSize = true;
            OilSum.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            OilSum.Location = new Point(157, 43);
            OilSum.Name = "OilSum";
            OilSum.Size = new Size(38, 46);
            OilSum.TabIndex = 2;
            OilSum.Text = "0";
            // 
            // textBoxByPrice
            // 
            textBoxByPrice.Location = new Point(182, 247);
            textBoxByPrice.Name = "textBoxByPrice";
            textBoxByPrice.ReadOnly = true;
            textBoxByPrice.Size = new Size(125, 27);
            textBoxByPrice.TabIndex = 0;
            textBoxByPrice.TextChanged += textBoxByPrice_TextChanged;
            // 
            // textBoxByOil
            // 
            textBoxByOil.Location = new Point(182, 190);
            textBoxByOil.Name = "textBoxByOil";
            textBoxByOil.Size = new Size(125, 27);
            textBoxByOil.TabIndex = 5;
            textBoxByOil.TextChanged += textBoxByOil_TextChanged;
            // 
            // panel1
            // 
            panel1.Controls.Add(ByPrice);
            panel1.Controls.Add(ByOil);
            panel1.Location = new Point(25, 175);
            panel1.Name = "panel1";
            panel1.Size = new Size(120, 127);
            panel1.TabIndex = 4;
            // 
            // ByPrice
            // 
            ByPrice.AutoSize = true;
            ByPrice.Location = new Point(3, 75);
            ByPrice.Name = "ByPrice";
            ByPrice.Size = new Size(65, 24);
            ByPrice.TabIndex = 0;
            ByPrice.Text = "Сума";
            ByPrice.UseVisualStyleBackColor = true;
            ByPrice.CheckedChanged += ByPrice_CheckedChanged;
            // 
            // ByOil
            // 
            ByOil.AutoSize = true;
            ByOil.Checked = true;
            ByOil.Location = new Point(3, 18);
            ByOil.Name = "ByOil";
            ByOil.Size = new Size(111, 24);
            ByOil.TabIndex = 0;
            ByOil.TabStop = true;
            ByOil.Text = "Количество";
            ByOil.UseVisualStyleBackColor = true;
            ByOil.CheckedChanged += ByOil_CheckedChanged;
            // 
            // Price
            // 
            Price.Location = new Point(182, 117);
            Price.Name = "Price";
            Price.ReadOnly = true;
            Price.Size = new Size(125, 27);
            Price.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(25, 106);
            label2.Name = "label2";
            label2.Size = new Size(83, 38);
            label2.TabIndex = 2;
            label2.Text = "Цена";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(25, 43);
            label1.Name = "label1";
            label1.Size = new Size(108, 38);
            label1.TabIndex = 1;
            label1.Text = "Бензин";
            // 
            // OilType
            // 
            OilType.FormattingEnabled = true;
            OilType.Items.AddRange(new object[] { "90a", "Дизель", "45а" });
            OilType.Location = new Point(182, 53);
            OilType.Name = "OilType";
            OilType.Size = new Size(160, 28);
            OilType.TabIndex = 0;
            OilType.SelectedIndexChanged += OilType_SelectedIndexChanged;
            // 
            // timer1
            // 
            timer1.Interval = 10000;
            timer1.Tick += timer1_Tick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(823, 680);
            Controls.Add(OilGroup);
            Controls.Add(EndGroup);
            Controls.Add(CafeGroup);
            Name = "Form1";
            Text = "Form1";
            FormClosing += Form1_FormClosing;
            Load += Form1_Load;
            CafeGroup.ResumeLayout(false);
            CafeGroup.PerformLayout();
            CafeSumGroup.ResumeLayout(false);
            CafeSumGroup.PerformLayout();
            EndGroup.ResumeLayout(false);
            EndGroup.PerformLayout();
            OilGroup.ResumeLayout(false);
            OilGroup.PerformLayout();
            OilSumGroup.ResumeLayout(false);
            OilSumGroup.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox CafeGroup;
        private GroupBox EndGroup;
        private GroupBox OilGroup;
        private Label label2;
        private Label label1;
        private ComboBox OilType;
        private TextBox Price;
        private GroupBox OilSumGroup;
        private TextBox textBoxByPrice;
        private TextBox textBoxByOil;
        private Panel panel1;
        private RadioButton ByPrice;
        private RadioButton ByOil;
        private TextBox ColaCount;
        private TextBox FrieCount;
        private TextBox BurgerCount;
        private TextBox HotDogCount;
        private TextBox ColaPrice;
        private TextBox FriePrice;
        private TextBox BurgerPrice;
        private CheckBox Cola;
        private CheckBox Frie;
        private CheckBox Burger;
        private TextBox HotDogPrice;
        private CheckBox HotDog;
        private GroupBox CafeSumGroup;
        private Label CafeSum;
        private Label cafeUAH;
        private Label TotalSumUah;
        private Label TotalSum;
        private Button ButTotalSum;
        private Label OilUAH;
        private Label OilSum;
        private System.Windows.Forms.Timer timer1;
    }
}