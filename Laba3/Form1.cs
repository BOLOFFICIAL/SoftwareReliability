using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Laba3
{
    public partial class Form1 : Form
    {
        private double _time = 0;        // Время работы системы
        private double _failureRate = 0; // Интенсивность отказов
        private double _numberExperiments = 0; // Количество экспериментов
        private Random _random = new Random();

        public Form1()
        {
            InitializeComponent();
            chart1.Series[0].Points.Clear(); // Очистка графика вероятностей
            chart1.Series[1].Points.Clear(); // Очистка графика значений счетчика
        }

        // Обработчик события нажатия кнопки "Рассчитать"
        private void button_res_Click(object sender, EventArgs e)
        {
            if (ValidationInput()) // Проверка корректности введенных данных
            {
                chart1.Series[0].Points.Clear(); // Очистка графика вероятностей
                chart1.Series[1].Points.Clear(); // Очистка графика значений счетчика

                List<int> hits = new List<int>();
                for (int i = 0; i < _numberExperiments; i++)
                {
                    int hitCount = CalculateHitCount(); // Вычисление количества отказов в одном эксперименте
                    hits.Add(hitCount);
                }

                int maxHits = hits.Max(); // Наибольшее количество отказов в одном эксперименте
                List<double> list = new List<double>();

                for (int i = 0; i < maxHits; i++)
                {
                    int hitCount = hits.Count(h => h == i); // Подсчет количества экспериментов с i отказами
                    list.Add((double)hitCount / _numberExperiments); // Вычисление вероятности i отказов
                }

                for (int i = 0; i < maxHits; i++)
                {
                    chart1.Series[0].Points.AddXY(i, list[i]); // Добавление точек на график вероятностей
                    double counter = CalculateCounter(i); // Вычисление значения счетчика
                    chart1.Series[1].Points.AddXY(i, counter); // Добавление точек на график счетчика
                }
            }
        }

        // Метод для вычисления количества отказов в одном эксперименте
        private int CalculateHitCount()
        {
            double expt = (-Math.Log(1 - _random.NextDouble()) / _failureRate); // Генерация времени до первого отказа
            int hitCount = 0;

            while (expt < _time) // Пока время до отказа меньше заданного времени
            {
                hitCount++;
                expt += (-Math.Log(1 - _random.NextDouble()) / _failureRate); // Генерация времени до следующего отказа
            }

            return hitCount;
        }

        // Метод для вычисления значения счетчика
        private double CalculateCounter(int i)
        {
            return (Math.Pow(_failureRate * _time, i) / Factorial(i)) * Math.Exp(-_failureRate * _time);
        }

        // Метод для проверки корректности входных данных
        private bool ValidationInput()
        {
            if (!double.TryParse(textBox_Time.Text, out _time))
            {
                MessageBox.Show("Некорректное значение для поля Время");
                return false;
            }
            else
            {
                _time = Math.Abs(_time);
            }
            if (!double.TryParse(textBox_FailureRate.Text, out _failureRate))
            {
                MessageBox.Show("Некорректное значение для поля Интенсивность отказов");
                return false;
            }
            else
            {
                _failureRate = Math.Abs(_failureRate);
                if (_failureRate > 35)
                {
                    MessageBox.Show("Интенсивность отказов вне диаппазона допустимых значений");
                    return false;
                }
            }
            if (!double.TryParse(textBox_NumberExperiments.Text, out _numberExperiments))
            {
                MessageBox.Show("Некорректное значение для поля Количество испытаний");
                return false;
            }
            else
            {
                _numberExperiments = Math.Abs(_numberExperiments);
            }

            textBox_Time.Text = _time.ToString();
            textBox_FailureRate.Text = _failureRate.ToString();
            textBox_NumberExperiments.Text = _numberExperiments.ToString();
            return true;
        }

        // Метод для вычисления факториала
        static long Factorial(int n)
        {
            if (n == 0)
            {
                return 1;
            }
            return n * Factorial(n - 1);
        }
    }
}
