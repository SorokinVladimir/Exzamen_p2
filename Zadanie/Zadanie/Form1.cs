using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zadanie
{
    public partial class Form1 : Form
    {
        int Count = 0;
        public Form1()
        {
            InitializeComponent();
        }


        private void click_btn_Click(object sender, EventArgs e)
        {
            Count = Count + 10;
            Count_lbl.Text = Count.ToString();
            if (Count == 20)
                MessageBox.Show("Day is over");

            if (Count >= 20)
            {
                click_btn.Enabled = false;
                button1.Enabled = false;
                if (Count >= 20)
                {
                    click_btn.Enabled = false;
                    button1.Enabled = false;

                }
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Count = Count + 5;
            Count_lbl.Text = Count.ToString();
            if (Count == 20)
                MessageBox.Show("Day is over");

            if (Count == 20)
            {
                click_btn.Enabled = true;
                button2.Enabled = true;

            }

            if (Count >= 20)
            {
                click_btn.Enabled = false;
                button1.Enabled = false;
                click_btn.Enabled = false;
                button1.Enabled = false;

            }
        }
        private void Button2_Click(object sender, EventArgs e)
        {
            Count = 0;
            Count_lbl.Text = Count.ToString();
            if (Count == 0)
                MessageBox.Show("New day");

            if (Count == 0)
            {
                click_btn.Enabled = true;
                button1.Enabled = true;
                if (Count == 0)
                {
                    click_btn.Enabled = true;
                    button3.Enabled = true;
                }
                if (Count == 0)
                {
                    click_btn.Enabled = true;
                    button1.Enabled = true;
                }
                if (Count >= 20)
                {
                    click_btn.Enabled = false;
                    button1.Enabled = false;
                    click_btn.Enabled = false;
                    button1.Enabled = false;

                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Count_lbl.Text = Count.ToString();
            if (Count < 10) Count = Count + 1;
            else if (Count >= 10) Count = Count + 2;

            if (Count >= 22)
            {
                click_btn.Enabled = false;
                button3.Enabled = false;
            }
            if (Count >= 18)
            {
                click_btn.Enabled = false;
                button1.Enabled = false;

            }
        }
    }
}


