using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HelloWorld
{
    public class Form1 : Form
    {
        private Button center;
        private Button up;
        private Button down;
        private Button left;
        private Button right;

        public Form1()
        {
            center = new Button();
            center.Text = "center";
            center.Anchor = AnchorStyles.None;
            center.Location = new Point(this.ClientRectangle.Width/2-center.Width/2, this.ClientRectangle.Height / 2 - center.Height / 2);
            this.Controls.Add(center);

            up = new Button();
            up.Text = "up";
            up.Anchor = AnchorStyles.Top;
            up.Location = new Point(this.ClientRectangle.Width/2-up.Width/2, 0);
            this.Controls.Add(up);

            down = new Button();
            down.Text = "down";
            down.Anchor = AnchorStyles.Bottom;
            down.Location = new Point(this.ClientRectangle.Width/2-down.Width/2, this.ClientRectangle.Height-down.Height);
            this.Controls.Add(down);

            left = new Button();
            left.Text = "left";
            left.Anchor = AnchorStyles.Left;
            left.Location = new Point(0,this.ClientRectangle.Height/2-left.Height/2);
            this.Controls.Add(left);

            right = new Button();
            right.Text = "right";
            right.Anchor = AnchorStyles.Right;
            right.Location = new Point(this.ClientRectangle.Width-right.Width, this.ClientRectangle.Height / 2 - right.Height / 2);
            this.Controls.Add(right);

        }

        [STAThread]
        public static void Main()
        {
            // Start the application.
            Application.Run(new Form1());
        }
    }
}

