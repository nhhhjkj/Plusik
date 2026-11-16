using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace plusik
{
    public partial class plusik : Form
    {
        Random rnd = new Random();
        int RandomNumber;
        int PlayerStep = 0;
        int PlayerNumber = 1;
        public plusik()
        {
            InitializeComponent();
            RandomNumber = rnd.Next(1, 100);
            random_number.Text = "Число " + RandomNumber.ToString();
            your_number.Text = "Твое число: " + PlayerNumber.ToString();
            step.Text = "Шаг: " + PlayerStep.ToString();
        }
        int Optimum(int k)
        {
            int CountStep = 0;
            while (k != 1)
            {
                if (k % 2 == 0)
                {
                    k /= 2;
                }
                else
                {
                    k -= 1;
                }
                CountStep++;
            }
            return CountStep;
        }
        private void plusik_Load(object sender, EventArgs e)
        {

        }

        private void plus_Click_1(object sender, EventArgs e)
        {
            PlayerNumber += 1;
            PlayerStep += 1;
            your_number.Text = "Твое число: " + PlayerNumber.ToString();
            step.Text = "Шаг: " + PlayerStep.ToString();

            if (PlayerNumber == RandomNumber)
            {
                if (PlayerStep == Optimum(RandomNumber))
                {
                    MessageBox.Show("Вы выиграли!");
                }
                else
                {
                    MessageBox.Show("Вы выиграли, но можно было лучше!");
                }
            }
            else if (PlayerNumber > RandomNumber)
            {
                MessageBox.Show("Вы проиграли, попробуйте еще раз");
            }
        }

        private void mulptiply_Click_1(object sender, EventArgs e)
        {
            PlayerNumber *= 2;
            PlayerStep += 1;
            your_number.Text = "Твое число: " + PlayerNumber.ToString();
            step.Text = "Шаг: " + PlayerStep.ToString();

            if (PlayerNumber == RandomNumber)
            {
                if (PlayerStep == Optimum(RandomNumber))
                {
                    MessageBox.Show("Вы выиграли!");
                }
                else
                {
                    MessageBox.Show("Вы выиграли, но можно было лучше!");
                }
            }
            else if (PlayerNumber > RandomNumber)
            {
                MessageBox.Show("Вы проиграли, попробуйте еще раз");
            }
        }

        private void reset_Click_1(object sender, EventArgs e)
        {
            PlayerNumber = 1;
            your_number.Text = "Твое число: " + PlayerNumber.ToString();
            PlayerStep = 0;
            step.Text = "Шаг: " + PlayerStep.ToString();
        }

        private void random_number_button_Click_1(object sender, EventArgs e)
        {
            RandomNumber = rnd.Next(1, 100);
            Optimum(RandomNumber);
            random_number.Text = "Число " + RandomNumber.ToString();
        }


        private void step_Click(object sender, EventArgs e)
        {

        }

        private void your_number_Click(object sender, EventArgs e)
        {

        }

        private void random_number_Click(object sender, EventArgs e)
        {

        }
    }
}
