using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tmr
{
    public partial class Form1 : Form
    {
        Timer timer = new Timer();
        public Form1()
        {
            timer.Tick += new EventHandler(ShowTimer);
            InitializeComponent();
            button2.Enabled = false;
        }

        private void ShowTimer(object sender, EventArgs e)
        {
            timer.Stop();
            label2.Text = "Таймер вимкнено";
            button2.Enabled = false;
            button1.Enabled = true;
            MessageBox.Show("Таймер спрацював!", "Таймер");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer.Stop();
            button2.Enabled = false;
            button1.Enabled = true;
            label2.Text = "Таймер вимкнено";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer.Interval = (int)(1000 *numericUpDown1.Value);
            timer.Start();
            button2.Enabled = true;
            button1.Enabled = false;
            label2.Text = "Таймер ввімкнуто";
        }
    }
}
