using System;

using System.Windows.Forms;

namespace Area
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonCalculate_Click(object sender, EventArgs e)
        {
            // Входные данные (User Input) и Механизм управления (Input Validation)
            if (!double.TryParse(textBoxLength.Text, out double length) || length <= 0)
            {
                MessageBox.Show("Некорректный ввод длины. Длина должна быть положительным числом.");
                return;
            }

            if (!double.TryParse(textBoxWidth.Text, out double width) || width <= 0)
            {
                MessageBox.Show("Некорректный ввод ширины. Ширина должна быть положительным числом.");
                return;
            }

            string unit = textBoxUnit.Text.ToLower(); // Преобразуем в нижний регистр

            // Механизм (Calculation) и обработка единиц измерения
            double area = length * width;
            string unitResult = "";

            switch (unit)
            {
                case "м":
                    unitResult = "м²";
                    break;
                case "см":
                    unitResult = "см²";
                    break;
                case "мм":
                    unitResult = "мм²";
                    break;
                default:
                    MessageBox.Show("Неизвестная единица измерения. Результат выводится в м².");
                    unitResult = "м²";
                    break;
            }

            // Выходные данные (Output)
            labelResult.Text = $"   {area} {unitResult}";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBoxWidth_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxLength_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxUnit_TextChanged(object sender, EventArgs e)
        {

        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
