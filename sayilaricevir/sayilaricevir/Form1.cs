using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sayilaricevir
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }
        string rs = "";

        private void button1_Click(object sender, EventArgs e)
        {
            string number = tb.Text;
            int n = int.Parse(number);
            while (n != 0)
            {
                int rem = n % 10;
                find(rem);
                n = n / 10;
            }
            mb.Text = rs;
        }

        private void b2_Click(object sender, EventArgs e)
        {
            tb.Text = "";
            mb.Text = "";
            rs = "";

        }

        private void b3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        void find(int num)
        {
            if (num == 0)
            {
                rs = "Zero" + rs;
            }
            else if (num == 1)
            {
                rs = "|" + rs;
            }
            else if (num == 2)
            {
                rs = "||" + rs;
            }
            else if (num == 3)
            {
                rs = "|||" + rs;
            }
            else if (num == 4)
            {
                rs = "Four" + rs;
            }
            else if (num == 5)
            {
                rs = "v" + rs;
            }
            else if (num == 6)
            {
                rs = "Six" + rs;
            }
            else if (num == 7)
            {
                rs = "Seven" + rs;
            }
            else if (num == 8)
            {
                rs = "Eight" + rs;
            }
            else if (num == 9)
            {
                rs = "Nine" + rs;
            }
           

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
