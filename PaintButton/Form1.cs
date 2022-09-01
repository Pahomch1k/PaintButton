using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PaintButton
{
    public partial class Form1 : Form
    {
        Button button;
        private bool LMBpressed = false;
        int cX = 0;
        int cY = 0;

        int curX = 0;
        int curY = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                button = new Button();
                button.Left = Cursor.Position.X;
                button.Top = Cursor.Position.Y;
                cX = Cursor.Position.X;
                cY = Cursor.Position.Y;
                Form1_MouseMove(sender, e); 
            }
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        { 
             
            if (e.Button == MouseButtons.Left)
            {
                if (Cursor.Position.X - cX > 0 && Cursor.Position.Y - cY > 0)
                {
                    button.Width = Cursor.Position.X - cX;
                    button.Height = Cursor.Position.Y - cY;
                }

                else if (cY - Cursor.Position.Y < 0)
                {
                    button.Left = Cursor.Position.X;
                    button.Width = (cX - Cursor.Position.X);
                    button.Height = (cY - Cursor.Position.Y) * -1;
                }

                else if (cX - Cursor.Position.X < 0)
                {
                    button.Top = Cursor.Position.Y;
                    button.Width = (cX - Cursor.Position.X) * -1;
                    button.Height = (cY - Cursor.Position.Y);
                }

                else if (Cursor.Position.X - cX < 0 && Cursor.Position.Y - cY < 0)
                {
                    button.Top = Cursor.Position.Y;
                    button.Left = Cursor.Position.X;
                    button.Width = cX - Cursor.Position.X;
                    button.Height = cY - Cursor.Position.Y;
                } 

                button.Text = "ЗСУ";
                Controls.Add(button); 
            }
        } 
    }
}
