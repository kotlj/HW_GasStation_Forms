namespace CW_Form_Practic_2_1
{
    public partial class Form1 : Form
    {
        double DayTotal = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void OilType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (OilType.SelectedIndex == 0)
            {
                Price.Text = "40";
            }
            if (OilType.SelectedIndex == 1)
            {
                Price.Text = "45";
            }
            if (OilType.SelectedIndex == 2)
            {
                Price.Text = "20";
            }
        }

        private void ByOil_EnabledChanged(object sender, EventArgs e)
        {
            if (ByOil.Enabled == true)
            {
                textBoxByOil.ReadOnly = false;
            }
            else
            {
                textBoxByOil.ReadOnly = true;
            }
        }

        private void ByPrice_EnabledChanged(object sender, EventArgs e)
        {
            if (ByPrice.Enabled == true)
            {
                textBoxByPrice.ReadOnly = false;
            }
            else
            {
                textBoxByPrice.ReadOnly = true;
            }
        }

        private void ByPrice_CheckedChanged(object sender, EventArgs e)
        {
            if (ByPrice.Checked == true)
            {
                textBoxByPrice.ReadOnly = false;
                textBoxByOil.Text = null;
                OilSumGroup.Text = "К выдаче:";
                OilUAH.Text = "л";
            }
            else
            {
                textBoxByPrice.ReadOnly = true;
                textBoxByOil.Text = null;
            }
        }

        private void ByOil_CheckedChanged(object sender, EventArgs e)
        {
            if (ByOil.Checked == true)
            {
                textBoxByOil.ReadOnly = false;
                textBoxByPrice.Text = null;
                OilSumGroup.Text = "К оплате:";
                OilUAH.Text = "грн";
            }
            else
            {
                textBoxByOil.ReadOnly = true;
                textBoxByOil.Text = null;
            }
        }

        private void textBoxByOil_TextChanged(object sender, EventArgs e)
        {
            double.TryParse(textBoxByOil.Text, out double number);
            double.TryParse(Price.Text, out double price);
            OilSum.Text = $"{number * price}";
        }

        private void textBoxByPrice_TextChanged(object sender, EventArgs e)
        {
            double.TryParse(textBoxByPrice.Text, out double price);
            double.TryParse(Price.Text, out double singlePrice);
            OilSum.Text = $"{price / singlePrice}";
        }

        private void HotDog_CheckedChanged(object sender, EventArgs e)
        {
            if (HotDog.Checked == true)
            {
                HotDogCount.ReadOnly = false;
            }
            else
            {
                HotDogCount.ReadOnly = true;
                HotDogCount.Text = null;
            }
        }

        private void Burger_CheckedChanged(object sender, EventArgs e)
        {
            if (Burger.Checked == true)
            {
                BurgerCount.ReadOnly = false;
            }
            else
            {
                BurgerCount.ReadOnly = true;
                BurgerCount.Text = null;
            }
        }

        private void Frie_CheckedChanged(object sender, EventArgs e)
        {
            if (Frie.Checked == true)
            {
                FrieCount.ReadOnly = false;
            }
            else
            {
                FrieCount.ReadOnly = true;
                FrieCount.Text = null;
            }
        }

        private void Cola_CheckedChanged(object sender, EventArgs e)
        {
            if (Cola.Checked == true)
            {
                ColaCount.ReadOnly = false;
            }
            else
            {
                ColaCount.ReadOnly = true;
                ColaCount.Text = null;
            }
        }
        private void CafeCount_TextChanged(object sender, EventArgs e)
        {
            int TextForLabel = 0;
            if (int.TryParse(HotDogPrice.Text, out int price1) && int.TryParse(HotDogCount.Text, out int count1))
            {
                TextForLabel += price1 * count1;
            }
            if (int.TryParse(BurgerPrice.Text, out int price2) && int.TryParse(BurgerCount.Text, out int count2))
            {
                TextForLabel += price2 * count2;
            }
            if (int.TryParse(FriePrice.Text, out int price3) && int.TryParse(FrieCount.Text, out int count3))
            {
                TextForLabel += price3 * count3;
            }
            if (int.TryParse(ColaPrice.Text, out int price4) && int.TryParse(ColaCount.Text, out int count4))
            {
                TextForLabel += price4 * count4;
            }
            CafeSum.Text = $"{TextForLabel}";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            OilType.SelectedIndex = 0;
        }

        private void ButTotalSum_Click(object sender, EventArgs e)
        {
            double Oil = 0;
            if (OilUAH.Text == "грн")
            {
                double.TryParse(OilSum.Text, out Oil);
            }
            else
            {
                double.TryParse(textBoxByPrice.Text, out Oil);
            }
            double.TryParse(CafeSum.Text, out double Cafe);
            TotalSum.Text = $"{Oil + Cafe}";
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Закончить расчет?", "Запрос", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                OilType.SelectedIndex = 0;
                ByOil.Checked = true;
                textBoxByOil.Text = null;
                textBoxByPrice.Text = null;
                OilGroup.Text = "К оплате:";
                OilSum.Text = "0";
                OilUAH.Text = "грн";
                HotDog.Checked = false;
                Burger.Checked = false;
                Frie.Checked = false;
                Cola.Checked = false;
                CafeSum.Text = "0";
                Double.TryParse(TotalSum.Text, out double total);
                DayTotal += total;
                TotalSum.Text = "0";
                timer1.Stop();
            }
            else
            {
                timer1.Start();
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            MessageBox.Show($"Общий заработок: {DayTotal}");
        }
    }
}