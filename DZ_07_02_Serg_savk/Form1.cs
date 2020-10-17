using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DZ_07_02_Serg_savk
{
    public partial class Form1 : Form
    {
        Random r = new Random();
        int value = 0;
        int count = 0;
        bool flag = false;


        public Form1()
        {
            InitializeComponent();
            label1.Text = "Добро пожаловать \n" +
                "Что бы начать угадывать число нажмите Play";
            button1.Text = "Play";
            button2.Text = "Try";
            label2.Text = "0";
            label3.Text = "Количество попыток " + count;
        }
        

        private void button1_Click(object sender, EventArgs e)
        {
            count = 0;
            Random r = new Random();
            value = r.Next(1, 101);
            label2.Text = "загаданно число от 1 до 100";
            flag = true;
            label3.Text = "Количество попыток " + count;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(flag == true)
            {
                count++;
                if (int.Parse(textBox1.Text) < value)
                {
                    label2.Text = "too little";
                    label3.Text = "Количество попыток " + count;
                }
                else if (int.Parse(textBox1.Text) > value)
                {
                    label2.Text = "too match";
                    label3.Text = "Количество попыток " + count;
                }
                else if (int.Parse(textBox1.Text) == value)
                {
                    label3.Text = "Количество попыток " + count;
                    label2.Text = "Вы угадали число с " + count + " попытки";
                }
            }
            

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (flag == true)
            {
                if ((e.KeyChar >= '0') && (e.KeyChar <= '9'))
                {
                    return;
                }
                if (Char.IsControl(e.KeyChar))
                {
                    if (e.KeyChar == (char)Keys.Enter)
                        button2.Focus();
                    return;
                }
                e.Handled = true;
            }
                
        }
    }
}
