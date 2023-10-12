using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Laba2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            chart.Series[1].Color = Color.Red;
            chart.Series[1].BorderWidth = 2;
        }

        private void res_Click(object sender, EventArgs e)
        {
            // Вызываем метод PerformCalculations при нажатии кнопки "Рассчитать"
            PerformCalculations();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            // Вызываем метод PerformCalculations при изменении значения в первом числовом поле
            PerformCalculations();
        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {
            // Вызываем метод PerformCalculations при изменении значения во втором числовом поле
            PerformCalculations();
        }

        private void PerformCalculations()
        {
            // Очищаем точки в первой и второй сериях графика перед вычислениями
            chart.Series[0].Points.Clear();
            chart.Series[1].Points.Clear();

            // Создаем объект для генерации случайных чисел
            Random random = new Random();
            // Получаем значение λ (интенсивность отказов) из текстового поля
            double λ = double.Parse(failure_rate.Text);
            // Получаем количество экспериментов из текстового поля
            double numExperiments = double.Parse(number_of_experiments.Text);
            List<double> list = new List<double>();

            // Генерируем случайные значения и заполняем список
            for (int i = 0; i < numExperiments; i++)
            {
                // Генерируем случайное число и добавляем его в список
                list.Add(-Math.Log(1 - random.NextDouble()) / λ);
            }

            // Находим максимальное значение в списке
            double maxNum = list.Max();
            // Вычисляем интервал для гистограммы
            double interval = maxNum / 20;
            double c = 0;

            // Выполняем вычисления и заполняем график данными
            while (c <= maxNum)
            {
                double hitRate = 0;
                // Подсчитываем, сколько значений попадает в текущий интервал
                foreach (var timeFromList in list)
                {
                    if (timeFromList >= c && timeFromList < c + interval)
                    {
                        hitRate++;
                    }
                }

                // Вычисляем частоту событий в интервале
                double freq = hitRate / numExperiments;
                // Вычисляем вероятность события в интервале
                double p = freq / interval;

                List<double> counter = new List<double>();
                for (int i = 0; i <= maxNum; i++)
                {
                    // Рассчитываем теоретическую вероятность события
                    counter.Add(λ * Math.Exp(-λ * c));
                }

                // Добавляем точку на графике для текущего интервала
                chart.Series[0].Points.AddXY(c + interval / 2, p);

                for (int i = 0; i <= maxNum; i++)
                {
                    // Добавляем точку на графике для теоретической вероятности
                    chart.Series[1].Points.AddXY(c, counter[i]);
                }

                c += interval;
            }
        }
    }
}