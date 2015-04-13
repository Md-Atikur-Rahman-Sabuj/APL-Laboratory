using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace UI
{
    class CarClass
    {
        public void Car1draw(int k, int l, PaintEventArgs e)
        {
            Pen p = new Pen(Color.Black, 7);
            //e.Graphics.DrawLine(p, x, y, (x + 20), y);
            e.Graphics.FillRectangle(Brushes.SteelBlue, k,l, 100,40);
            e.Graphics.FillRectangle(Brushes.SteelBlue, k + 102, l+5, 40, 30);
            e.Graphics.DrawLine(p,k + 100, l + 30, k + 103, l + 30);
            e.Graphics.FillEllipse(Brushes.Black, k + 20, l + 35, 10, 10);
            e.Graphics.FillEllipse(Brushes.Black, k + 70, l + 35, 10, 10);
            e.Graphics.FillEllipse(Brushes.Black, k + 120, l + 30, 10, 10);
        }
        public void Car2draw(int k, int l, PaintEventArgs e)
        {
            Pen p = new Pen(Color.Black, 7);
            //e.Graphics.DrawLine(p, x, y, (x + 20), y);
            e.Graphics.FillRectangle(Brushes.SteelBlue, k + 50, l, 100, 40);
            e.Graphics.FillRectangle(Brushes.SteelBlue, k + 50 - 42, l + 5, 40, 30);
            e.Graphics.DrawLine(p, k + 47, l + 30, k + 50, l + 30);
            e.Graphics.FillEllipse(Brushes.Black, k + 20, l + 30, 10, 10);
            e.Graphics.FillEllipse(Brushes.Black, k + 70, l + 35, 10, 10);
            e.Graphics.FillEllipse(Brushes.Black, k + 120, l + 35, 10, 10);
        }
        public void Car3draw(int k, int l, PaintEventArgs e)
        {
            Pen p = new Pen(Color.Black, 12);
            e.Graphics.FillRectangle(Brushes.SteelBlue, k + 50, l + 5, 40, 45);
            e.Graphics.FillRectangle(Brushes.SteelBlue, k + 45, l + 55, 49, 90);
            e.Graphics.DrawLine(p, k + 70, l + 50, k + 70, l + 55);
        }
        public void Car4draw(int k, int l, PaintEventArgs e)
        {
            Pen p = new Pen(Color.Black, 12);
            e.Graphics.FillRectangle(Brushes.SteelBlue, k + 50, l + 100, 40, 45);
            e.Graphics.FillRectangle(Brushes.SteelBlue, k + 45, l + 5, 49, 90);
            e.Graphics.DrawLine(p, k + 70, l + 95, k + 70, l + 100);
        }

    }
}
