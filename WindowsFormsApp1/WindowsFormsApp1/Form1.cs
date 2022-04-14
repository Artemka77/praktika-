using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public void button1_Click(object sender, EventArgs e)
        {
            int year;
            int t;
            try
            {
                year = int.Parse(textBox1.Text);
                if (textBox1.Text == "")
                {
                    

                }
                else
                {


                    if (year < 0)
                    {
                        MessageBox.Show ("Год не может быть отрицательным") ;

                    }
                    else
                    {
                        if (year == ',')
                        {
                            MessageBox.Show ("Год должен быть натуральным") ;

                        }
                        else
                        {

                            Console.WriteLine("{0} високосный");


                            if (year % 4 == 0 && year % 100 != 0 || year % 400 == 0)

                                label4.Text = " Год високосный.\n " +
                                    "Количество дней в феврале: 29.\n " +
                                    "Количество дней в году: 366. \n ";
                            else
                                label4.Text = " Год не високосный.\n " +
                                    "Количество дней в феврале: 28.\n " +
                                    "Количество дней в году: 365.\n";

                        }
                    }
                }
            }
            catch (Exception)
            {
                textBox1.Text = "";
                MessageBox.Show ( "Введите натуральное число без остатка" ) ;
            }


        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click_1(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void openFileDialog2_FileOk(object sender, CancelEventArgs e)
        {
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }
    }
}

