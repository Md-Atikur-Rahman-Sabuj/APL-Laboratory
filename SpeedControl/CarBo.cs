using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using Dal;
using System.Windows.Forms;
using Entity;

namespace SpeedControl
{
    public class CarBo
    {    
        enum position
        {
            Left, Right, Up, Down,  stop
        }
        position objPosition = position.stop;
        int x=350, y=190;
        public void carposition(int i)
        {
            if (i == 0)
                this.objPosition = position.Right;
            else if (i == 1)
                this.objPosition = position.Left;
            else if (i == 2)
                this.objPosition = position.Up;
            else if (i == 3)
                this.objPosition = position.Down;
            else
                this.objPosition = position.stop;

        }


        public void SpeedControl(int speed,Panel p1,Panel p2,Panel p3,Panel p4)
        {
            if (objPosition == position.Right)
            {
                p4.Visible = false;
                p1.Visible = true;
                p2.Visible = false;
                p3.Visible = false;
                x = p1.Location.X;
                y = p1.Location.Y;
                x = x + speed;
               
            }
            else if (objPosition == position.Left)
            {
                p4.Visible = false;
                p1.Visible = false;
                p2.Visible = true;
                p3.Visible = false;
                x = p2.Location.X;
                y = p2.Location.Y;
                x = x - speed;
                
            }
            else if (objPosition == position.Up)
            {
                p4.Visible = false;
                p1.Visible = false;
                p2.Visible = false;
                p3.Visible = true;
                x = p3.Location.X;
                y = p3.Location.Y;
                y = y - speed;
                
            }
            else if (objPosition == position.Down)
            {
                p4.Visible = true;
                p1.Visible = false;
                p2.Visible = false;
                p3.Visible = false;
                x = p4.Location.X;
                y = p4.Location.Y;
                y = y + speed;
                
            }
            if (y > 185 && y < 250)
            {
                p1.Location = new Point(x, y);
                p2.Location = new Point(x, y);
                p3.Location = new Point(x, y);
                p4.Location = new Point(x, y);
            }
            else if(x<420&&x>345)
            {
                p1.Location = new Point(x, y);
                p2.Location = new Point(x, y);
                p3.Location = new Point(x, y);
                p4.Location = new Point(x, y);
            }
        }
        public int tirerotate(int i)
        {
            if (objPosition != position.stop)
            {
                if (i == 0)
                    i = 1;
                else if (i == 1)
                    i = 2;
                else
                    i = 0;
            }
            return i;
        }
    }

}
