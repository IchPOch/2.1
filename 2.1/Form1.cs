using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2._1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Search_Click(object sender, EventArgs e)
        {
            float x, y;
            if (X.Text == "" || Y.Text == "")
                Sea.Text = "Неккоректно введены данные";
            else
            {
                x = float.Parse(X.Text);
                y = float.Parse(Y.Text);
                if ((x == 70 && x >= y && y >=0) || (y == 0 && x >= y && x >=0) || (x == y && x <= 70 && y <= 70 && x >=0 && y >=0))
                    Sea.Text = "На границе ";
                else
                {
                    if (x <= 70 && y <=70 && x >=0 && y>=0 && x - y >=0 )
                        Sea.Text = "Внутри";
                    else Sea.Text = "Вне ";
                }
            }
        }
    }
}
