namespace Laba1
{
    public partial class Form1 : Form
    {
        private int successfulTrialsCount = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void button_Test_Click(object sender, EventArgs e)
        {
            if (!CheckInput())
                return;

            double probabilityA = double.Parse(textBox_ProbabilityA.Text);
            double probabilityB = double.Parse(textBox_ProbabilityB.Text);
            double probabilityC = double.Parse(textBox_ProbabilityC.Text);
            int steps = (int)numericUpDown_Steps.Value;

            Random random = new Random();
            successfulTrialsCount = 0;

            for (int i = 0; i < steps; i++)
            {
                bool isSuccess = false;

                if (radioButton_Independent.Checked)
                {
                    bool eventA = random.NextDouble() < probabilityA;
                    bool eventB = random.NextDouble() < probabilityB;
                    bool eventC = random.NextDouble() < probabilityC;

                    isSuccess = eventA && eventB && eventC;
                }
                else if (radioButton_Incompatible.Checked)
                {
                    double eventD = random.NextDouble();

                    isSuccess = (eventD <= probabilityA) || (eventD > probabilityA && eventD <= probabilityA + probabilityB) || (eventD > probabilityA + probabilityB && eventD <= probabilityA + probabilityB + probabilityC);
                }

                if (isSuccess)
                {
                    successfulTrialsCount++;
                }
            }

            textBox_Frequency.Text = ((double)successfulTrialsCount / steps).ToString();

            if (radioButton_Independent.Checked)
            {
                textBox_Probability.Text = (probabilityA * probabilityB * probabilityC).ToString();
            }
            else if (radioButton_Incompatible.Checked)
            {
                textBox_Probability.Text = (probabilityA + probabilityB + probabilityC).ToString();
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
