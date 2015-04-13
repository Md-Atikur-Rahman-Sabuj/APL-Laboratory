using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Entity
{
    public class CarDraw
    {
        public void Car1draw(PaintEventArgs e, int i)
        {
            Pen p = new Pen(Color.Black, 5);
            Pen q = new Pen(Color.Black, 3);
            Pen t = new Pen(Color.Brown, 2);
            e.Graphics.DrawLine(p, 50, 20, 120, 20);
            e.Graphics.DrawLine(p, 50, 20, 30, 50);
            e.Graphics.DrawLine(p, 140, 50, 120, 20);
            e.Graphics.DrawLine(p, 30, 50, 0, 55);
            e.Graphics.DrawLine(p, 0, 55, 0, 80);
            e.Graphics.DrawLine(p, 0, 80, 40, 80);
            e.Graphics.DrawLine(p, 60, 80, 110, 80);
            e.Graphics.DrawLine(p, 130, 80, 205, 80);
            e.Graphics.DrawLine(p, 140, 50, 200, 55);
            e.Graphics.DrawLine(p, 205, 80, 200, 55);
            e.Graphics.DrawLine(q, 30, 50, 140, 50);
            e.Graphics.DrawLine(q, 140, 50, 145, 80);
            e.Graphics.DrawLine(q, 30, 50, 35, 80);
            e.Graphics.DrawLine(q, 85, 50, 90, 80);
            e.Graphics.DrawLine(q, 70, 20, 60, 50);
            e.Graphics.DrawLine(q, 90, 20, 100, 50);
            e.Graphics.FillEllipse(Brushes.Black, 37, 72, 25, 25);
            e.Graphics.FillEllipse(Brushes.Black, 107, 72, 25, 25);
            if (i == 0)
            {
                e.Graphics.DrawLine(t, 40, 75, 55, 95);
                e.Graphics.DrawLine(t, 110, 75, 125, 95);
            }
            if (i == 1)
            {
                e.Graphics.DrawLine(t, 42, 95, 62, 78);
                e.Graphics.DrawLine(t, 112, 95, 132, 78);
            }

            if (i == 2)
            {
                e.Graphics.DrawLine(t, 38, 83, 62, 83);
                e.Graphics.DrawLine(t, 108, 83, 132, 83);
            }


        }
        public void Car2draw(PaintEventArgs e, int i)
        {
            Pen p = new Pen(Color.Black, 5);
            Pen q = new Pen(Color.Black, 3);
            Pen t = new Pen(Color.Brown, 2);
            e.Graphics.DrawLine(p, 90, 20, 160, 20);
            e.Graphics.DrawLine(p, 90, 20, 70, 50);
            e.Graphics.DrawLine(p, 180, 50, 160, 20);
            e.Graphics.DrawLine(p, 70, 50, 10, 55);
            e.Graphics.DrawLine(p, 10, 55, 5, 80);
            e.Graphics.DrawLine(p, 5, 80, 215, 80);
            e.Graphics.DrawLine(p, 180, 50, 215, 55);
            e.Graphics.DrawLine(p, 215, 55, 215, 80);
            e.Graphics.DrawLine(q, 70, 50, 180, 50);
            e.Graphics.DrawLine(q, 70, 50, 65, 80);
            e.Graphics.DrawLine(q, 180, 50, 175, 80);
            e.Graphics.DrawLine(q, 130, 50, 125, 80);
            e.Graphics.DrawLine(q, 110, 20, 105, 50);
            e.Graphics.DrawLine(q, 130, 20, 135, 50);
            e.Graphics.FillEllipse(Brushes.Black, 65, 72, 25, 25);
            e.Graphics.FillEllipse(Brushes.Black, 150, 72, 25, 25);
            if (i == 0)
            {
                e.Graphics.DrawLine(t, 66, 83, 90, 83);
                e.Graphics.DrawLine(t, 152, 83, 176, 83);
                
            }
            if (i == 1)
            {
                e.Graphics.DrawLine(t, 70, 95, 90, 78);
                e.Graphics.DrawLine(t, 156, 95, 176, 78);
            }
            if (i == 2)
            {
                e.Graphics.DrawLine(t, 68, 75, 83, 95);
                e.Graphics.DrawLine(t, 153, 75, 169, 95);
            }
        }
        public void Car3draw(PaintEventArgs e, int i)
        {
            Pen p = new Pen(Color.Black, 5);
            e.Graphics.DrawLine(p, 30, 0, 80, 0);
            e.Graphics.DrawLine(p, 25, 60, 85, 60);
            e.Graphics.DrawLine(p, 30, 0, 25, 60);
            e.Graphics.DrawLine(p, 80, 0, 85, 60);
            e.Graphics.DrawLine(p, 25, 60, 20, 62);
            e.Graphics.DrawLine(p, 85, 60, 90, 62);
            e.Graphics.DrawLine(p, 90, 62, 90, 100);
            e.Graphics.DrawLine(p, 20, 62, 20, 100);
            e.Graphics.DrawLine(p, 85, 102, 90, 100);
            e.Graphics.DrawLine(p, 25, 102, 20, 100);
            e.Graphics.DrawLine(p, 85, 102, 25, 102);
            e.Graphics.DrawLine(p, 85, 102, 80, 152);
            e.Graphics.DrawLine(p, 30, 152, 25, 102);
            e.Graphics.DrawLine(p, 30, 152, 80, 152);
        }
        public void Car4draw(PaintEventArgs e, int i)
        {
            Pen p = new Pen(Color.Black, 5);
            e.Graphics.DrawLine(p, 30, 10, 80, 10);
            e.Graphics.DrawLine(p, 25, 60, 85, 60);
            e.Graphics.DrawLine(p, 30, 10, 25, 60);
            e.Graphics.DrawLine(p, 80, 10, 85, 60);
            e.Graphics.DrawLine(p, 25, 60, 20, 62);
            e.Graphics.DrawLine(p, 85, 60, 90, 62);
            e.Graphics.DrawLine(p, 90, 62, 90, 100);
            e.Graphics.DrawLine(p, 20, 62, 20, 100);
            e.Graphics.DrawLine(p, 85, 102, 90, 100);
            e.Graphics.DrawLine(p, 25, 102, 20, 100);
            e.Graphics.DrawLine(p, 85, 102, 25, 102);
            e.Graphics.DrawLine(p, 85, 102, 80, 162);
            e.Graphics.DrawLine(p, 30, 162, 25, 102);
            e.Graphics.DrawLine(p, 30, 162, 80, 162);
        }
    }
}
