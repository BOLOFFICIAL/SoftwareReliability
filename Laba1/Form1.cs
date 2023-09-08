using System;
using System.Windows.Forms;

namespace Laba1
{
    public partial class Form1 : Form
    {
        private int successfulTrials = 0;
        private static Random random = new Random();

        public Form1()
        {
            InitializeComponent();
        }

        private void button_Test_Click(object sender, EventArgs e)
        {
            if (!CheckInput())
                return;

            double A = double.Parse(textBox_ProbabilityA.Text);
            double B = double.Parse(textBox_ProbabilityB.Text);
            double C = double.Parse(textBox_ProbabilityC.Text);
            int Steps = (int)numericUpDown_Steps.Value;

            for (int i = 0; i < Steps; i++)
            {
                bool eventA = random.NextDouble() < A;
                bool eventB = random.NextDouble() < B;
                bool eventC = random.NextDouble() < C;

                if (radioButton_Independent.Checked && eventA && eventB && eventC)
                {
                    successfulTrials++;
                }

                if (radioButton_Incompatible.Checked && (eventA || eventB || eventC))
                {
                    successfulTrials++;
                }
            }

            double frequency = (double)successfulTrials / Steps;
            textBox_Frequency.Text = frequency.ToString();

            if (radioButton_Independent.Checked)
            {
                textBox_Probability.Text = (A * B * C).ToString();
            }
            else if (radioButton_Incompatible.Checked)
            {
                textBox_Probability.Text = (A + B + C).ToString();
            }
        }

        private bool CheckInput()
        {
            bool isValid = true;
            double[] probabilities = new double[3];

            if (!double.TryParse(textBox_ProbabilityA.Text, out probabilities[0]) ||
                !double.TryParse(textBox_ProbabilityB.Text, out probabilities[1]) ||
                !double.TryParse(textBox_ProbabilityC.Text, out probabilities[2]))
            {
                MessageBox.Show("Вероятности A, B, C должны быть числами.");
                isValid = false;
            }

            if (radioButton_Independent.Checked)
            {
                if (probabilities[0] > 1 || probabilities[1] > 1 || probabilities[2] > 1)
                {
                    MessageBox.Show("Вероятности не могут быть больше 1.");
                    isValid = false;
                }
            }
            else if (radioButton_Incompatible.Checked && probabilities[0] + probabilities[1] + probabilities[2] > 1)
            {
                MessageBox.Show("Сумма вероятностей не может быть больше 1.");
                isValid = false;
            }

            return isValid;
        }
    }
}
