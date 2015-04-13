using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using SpeedControl;
using Entity;

namespace UI
{
    public partial class CarAnimation : Form

    {
        CarBo bo = new CarBo();
        public int speed,i;
        public CarAnimation()
        {
            InitializeComponent();
            i = 0;
            timer1.Start();
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            try
            {
                speed = Convert.ToInt32(textBox1.Text);
            }
            catch { }
            bo.SpeedControl(speed/3, panel1, panel2, panel3, panel4);
            i = bo.tirerotate(i);
            Invalidate();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            bo.carposition(0);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            bo.carposition(1);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            bo.carposition(4);
        }

        private void Car1paint(object sender, PaintEventArgs e)
        {
            CarDraw c = new CarDraw();
            c.Car1draw(e,i);

        }

        private void Car2Paint(object sender, PaintEventArgs e)
        {
            CarDraw c = new CarDraw();
            c.Car2draw(e,i);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            bo.carposition(2);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            bo.carposition(3);
        }

        private void Car3Paint(object sender, PaintEventArgs e)
        {
            CarDraw c = new CarDraw();
            c.Car3draw(e,i);
        }

        private void Car4Paint(object sender, PaintEventArgs e)
        {
            CarDraw c = new CarDraw();
            c.Car4draw(e,i);
        }

        private void SpeedPress(object sender, KeyPressEventArgs e)
        {
            if (textBox1.Text == "integer only")
            {
                textBox1.Text = null;
            }
            if (char.IsNumber(e.KeyChar))
            {
            }
            else
            {
                e.Handled = e.KeyChar != (char)Keys.Back;
            }
        }

        private void CarAnimation_Load(object sender, EventArgs e)
        {

        }
    }
}
