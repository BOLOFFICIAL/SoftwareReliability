using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Laba5
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
            Calculation();
        }

        private void Calculation()
        {

            var isSuccess = false;
            var successfulTrialsCount = 0;

            var p = GetProbability();

            if (p == null)
            {
                MessageBox.Show("Проверьте введеные значения");
                return;
            }

            var randoms = GetRandom();

            for (var i = 0; i < numericUpDown1.Value; i++)
            {
                var events = new List<bool>();

                for (var j = 0; j < 8; j++)
                {
                    events.Add(randoms[j].NextDouble() <= p[j]);
                }

                var e1 = (events[0] && events[1]);
                var e2 = (events[0] && events[2] && events[4]);
                var e3 = (events[0] && events[2] && events[6] && events[7]);
                var e4 = (events[3] && events[2] && events[1]);
                var e5 = (events[3] && events[4]);
                var e6 = (events[3] && events[6] && events[7]);
                var e7 = (events[5] && events[6] && events[4]);
                var e8 = (events[5] && events[7] && events[2] && events[1]);
                var e9 = (events[5] && events[7]);

                isSuccess = e1 || e2 || e3 || e4 || e5 || e6 || e7 || e8 || e9 &&
                    !(e1 && e2) && !(e1 && e3) && !(e1 && e4) && !(e1 && e5) &&
                    !(e1 && e6) && !(e1 && e7) && !(e1 && e8) && !(e1 && e9) &&
                    !(e2 && e3) && !(e2 && e4) && !(e2 && e5) && !(e2 && e6) &&
                    !(e2 && e7) && !(e2 && e8) && !(e2 && e9) &&
                    !(e3 && e4) && !(e3 && e5) && !(e3 && e6) && !(e3 && e7) &&
                    !(e3 && e8) && !(e3 && e9) &&
                    !(e4 && e5) && !(e4 && e6) && !(e4 && e7) && !(e4 && e8) &&
                    !(e4 && e9) &&
                    !(e5 && e6) && !(e5 && e7) && !(e5 && e8) && !(e5 && e9) &&
                    !(e6 && e7) && !(e6 && e8) && !(e6 && e9) &&
                    !(e7 && e8) && !(e7 && e9) &&
                    !(e8 && e9);

                if (isSuccess)
                {
                    successfulTrialsCount++;
                }
            }

            textBox_frequency.Text = ((double)successfulTrialsCount / (double)numericUpDown1.Value).ToString("0.0000");

            var p3070 = 1 - (1 - (p[0] * p[1])) * (1 - (p[3] * p[4])) * (1 - (p[5] * p[7]));
            var p3071 = 1 - (1 - (p[0] * p[1])) * (1 - ((1 - (1 - p[3]) * (1 - p[5])) * (1 - (1 - p[4]) * (1 - p[7]))));
            var p3170 = 1 - (1 - ((1 - (1 - p[0]) * (1 - p[3])) * (1 - (1 - p[1]) * (1 - p[4])))) * (1 - (p[5] * p[7]));
            var p3171 = (1 - (1 - p[0]) * (1 - (1 - (1 - p[3]) * (1 - p[5])))) * (1 - (1 - (1 - (1 - p[1]) * (1 - p[4]))) * (1 - p[7]));

            var p30 = (p[6] * p3071) + ((1 - p[6]) * p3070);
            var p31 = (p[6] * p3171) + ((1 - p[6]) * p3170);

            textBox_probability.Text = ((p[2] * p31) + ((1 - p[2]) * p30)).ToString("0.0000");
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
            double.TryParse(textBox_probability.Text, out probability);
            probabilitys.Add(probability);

            return probabilitys;
        }

        private List<Random> GetRandom()
        {
            var randoms = new List<Random>();
            randoms.Add(new Random());
            for (int i = 1; i < 8; i++)
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
            if (sender is System.Windows.Forms.TextBox value)
            {
                if (_random_run)
                {
                    if (double.TryParse(value.Text, out double probability))
                    {
                        if (value.Name == "textBox8")
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
    }
}

//p(1, 2) = P1 * P2
//p(4, 5) = P4 * P5
//p(6, 8) = P6 * P8
//p(3070) = 1 - (1 - (P1 * P2)) * (1 - (P4 * P5)) * (1 - (P6 * P8))

//p(1, 2) = P1 * P2
//p(4, 6) = 1 - (1 - P4) * (1 - P6)
//p(5, 8) = 1 - (1 - P5) * (1 - P8)
//p(3071) = 1 - (1 - (P1 * P2)) * (1 - ((1 - (1 - P4) * (1 - P6)) * (1 - (1 - P5) * (1 - P8))))

//p(30) = P(7)*P(3071)+(1-P7)*(3070)

//p(1, 4) = 1 - (1 - P1) * (1 - P4)
//p(2, 5) = 1 - (1 - P2) * (1 - P5)
//p(6, 8) = P6 * P8
//p(3170) = 1 - (1 - ((1 - (1 - P1) * (1 - P4)) * (1 - (1 - P2) * (1 - P5)))) * (1 - (P6 * P8))

//p(4, 6) = 1 - (1 - P4) * (1 - P6)
//p(2, 5) = 1 - (1 - P2) * (1 - P5)
//p(3171) = (1 - (1 - P1) * (1 - (1 - (1 - P4) * (1 - P6)))) * (1 - (1 - (1 - (1 - P2) * (1 - P5))) * (1 - P8))

//p(31) = P(7)*P(3171)+(1-P7)*(3170)

//P = P(3)*P(31)+(1-P3)*P(30)