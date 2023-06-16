using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2002_координати_мишки_Деревянко
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.MouseClick += Form1_MouseClick;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private String CoordinatesToString(MouseEventArgs e)
        {
            return "Координати миші: х=" + e.X.ToString() + "; y=" + e.Y.ToString();
        }
        //обробник MouseMove
        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            //відображення поточних координат миші в заголовку вікна
            Text = CoordinatesToString(e);
        }
        //обробник події MouseClick
        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            //визначаємо, яку кнопку миші натиснув користувач
            String message = "";
            if (e.Button == MouseButtons.Right)
            {
                message = "Ви натиснули праву кнопку миші.";
            }
            if (e.Button == MouseButtons.Left)
            {
                message = "Ви натиснули ліву кнопку миші.";
            }
            message += "\n" + CoordinatesToString(e);
            //виведемо повідомлення в діалогове вікно
            String caption = "Клік";
            MessageBox.Show(message, caption, MessageBoxButtons.OK,
           MessageBoxIcon.Information);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label1_Click_2(object sender, EventArgs e)
        {

        }
    }
}
