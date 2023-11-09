using System;
using System.Collections.Generic;
using System.Reflection;
using System.Windows.Forms;

namespace Laba4
{
    public partial class Form1 : Form
    {
        private bool _random_run = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            _random_run = true;
            var randon = new Random();

            textBox1.Text = randon.NextDouble().ToString("0.00");
            textBox2.Text = randon.NextDouble().ToString("0.00");
            textBox3.Text = randon.NextDouble().ToString("0.00");
            textBox4.Text = randon.NextDouble().ToString("0.00");
            textBox5.Text = randon.NextDouble().ToString("0.00");
            textBox6.Text = randon.NextDouble().ToString("0.00");
            textBox7.Text = randon.NextDouble().ToString("0.00");
            textBox8.Text = randon.NextDouble().ToString("0.00");
            textBox9.Text = randon.NextDouble().ToString("0.00");
            textBox10.Text = randon.NextDouble().ToString("0.00");
            textBox11.Text = randon.NextDouble().ToString("0.00");
            textBox12.Text = randon.NextDouble().ToString("0.00");
            textBox13.Text = randon.NextDouble().ToString("0.00");
            textBox14.Text = randon.NextDouble().ToString("0.00");
            textBox15.Text = randon.NextDouble().ToString("0.00");
            textBox16.Text = randon.NextDouble().ToString("0.00");

            _random_run = false;
        }

        private void Calculation()
        {
            var isSuccess = false;
            var successfulTrialsCount = 0;

            var probabilitys = GetProbability();

            if (probabilitys == null)
            {
                MessageBox.Show("Проверьте введеные значения");
                return;
            }

            var randoms = GetRandom();

            for (var i = 0; i < numericUpDown1.Value; i++)
            {
                var events = new List<bool>();

                for (var j = 0; j < 16; j++)
                {
                    events.Add(randoms[j].NextDouble() <= probabilitys[j]);
                }

                var block1 = (events[0] && events[1]) || (events[2] && events[3]);
                var block2 = (events[4] || (events[5] && events[6])) && (events[7]);
                var block3 = (events[8]) || (events[9] && (events[10] || events[11]));
                var block4 = (events[12]) || (events[13]) || (events[14] && events[15]);

                isSuccess = (block1 || block2 || block3) && block4;

                if (isSuccess)
                {
                    successfulTrialsCount++;
                }
            }

            textBox_frequency.Text = ((double)successfulTrialsCount / (double)numericUpDown1.Value).ToString("0.00000");
            textBox_probability.Text = ((1 - (1 - (1 - (1 - probabilitys[0] * probabilitys[1]) * (1 - probabilitys[2] * probabilitys[3]))) * (1 - ((1 - (1 - probabilitys[4]) * (1 - probabilitys[5] * probabilitys[6])) * probabilitys[7])) * (1 - (1 - (1 - probabilitys[8]) * (1 - (probabilitys[9] * (1 - (1 - probabilitys[10]) * (1 - probabilitys[11]))))))) * ((1 - (1 - probabilitys[12]) * (1 - probabilitys[13]) * (1 - (probabilitys[14] * probabilitys[15]))))).ToString("0.00000");
        }

        private List<double> GetProbability()
        {
            var probabilitys = new List<double>();
            var probability = 0.0;

            double.TryParse(textBox1.Text, out probability);
            probabilitys.Add(probability);
            double.TryParse(textBox2.Text, out probability);
            probabilitys.Add(probability);
            double.TryParse(textBox3.Text, out probability);
            probabilitys.Add(probability);
            double.TryParse(textBox4.Text, out probability);
            probabilitys.Add(probability);
            double.TryParse(textBox5.Text, out probability);
            probabilitys.Add(probability);
            double.TryParse(textBox6.Text, out probability);
            probabilitys.Add(probability);
            double.TryParse(textBox7.Text, out probability);
            probabilitys.Add(probability);
            double.TryParse(textBox8.Text, out probability);
            probabilitys.Add(probability);
            double.TryParse(textBox9.Text, out probability);
            probabilitys.Add(probability);
            double.TryParse(textBox10.Text, out probability);
            probabilitys.Add(probability);
            double.TryParse(textBox11.Text, out probability);
            probabilitys.Add(probability);
            double.TryParse(textBox12.Text, out probability);
            probabilitys.Add(probability);
            double.TryParse(textBox13.Text, out probability);
            probabilitys.Add(probability);
            double.TryParse(textBox14.Text, out probability);
            probabilitys.Add(probability);
            double.TryParse(textBox15.Text, out probability);
            probabilitys.Add(probability);
            double.TryParse(textBox16.Text, out probability);
            probabilitys.Add(probability);

            return probabilitys;
        }

        private List<Random> GetRandom()
        {
            var randoms = new List<Random>();
            randoms.Add(new Random());
            for (int i = 1; i < 16; i++)
            {
                randoms.Add(new Random(randoms[i - 1].Next()));
            }
            return randoms;
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            Calculation();
        }

        private void textBoxValue_TextChanged(object sender, EventArgs e)
        {
            if (sender is TextBox value)
            {
                if (_random_run)
                {
                    if (double.TryParse(value.Text, out double probability))
                    {
                        if (value.Name == "textBox16")
                        {
                            if (probability <= 1 && probability >= 0)
                            {
                                Calculation();
                            }
                        }
                    }
                    else
                    {
                        return;
                    }
                }
                else
                {
                    if (double.TryParse(value.Text, out double probability))
                    {
                        if (probability <= 1 && probability >= 0)
                        {
                            Calculation();
                        }
                    }
                    else
                    {
                        return;
                    }
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Calculation();
        }
    }
}
