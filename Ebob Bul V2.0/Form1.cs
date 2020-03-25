using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Ebob_Bul_V2._0
{
    public partial class Form1 : Form
    {
        #region Değişkenler

        int a, b, c, ebob = 1, son;

        #endregion

        #region Metodlar

        public void son1()
        {

            if (a > b)
                son = b;
            else if (a < b)
                son = a;
        }

        public void son2()
        {
            son = 0;

            if (a > son)
            {
                son = a;
            }

            if (b < a)
            {
                son = b;
            }

            if (c < b)
            {
                son = c;
            }
        }
        #endregion

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            groupBox2.Visible = false;
            groupBox3.Visible = false;

            label3.Visible = false;
            label4.Visible = false;

            textBox2.Visible = false;
            textBox3.Visible = false;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                groupBox2.Visible = true;
                label3.Visible = true;
                textBox2.Visible = true;
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked == true)
            {
                groupBox2.Visible = true;
                label3.Visible = true;
                textBox2.Visible = true;
                label4.Visible = true;
                textBox3.Visible = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ebob = 1;

            if (radioButton1.Checked == true)
            {
                a = int.Parse(textBox1.Text);
                b = int.Parse(textBox2.Text);

                son1();

                if (a == b)
                {
                    groupBox3.Visible = true;
                    label5.Text = a.ToString();
                }

                else
                {
                    for (int i = 2; i <= son; i++)
                    {
                        if (a % i == 0 && b % i == 0)
                            ebob = i;
                    }

                    groupBox3.Visible = true;
                    label5.Text = ebob.ToString();
                }
            }

            else if (radioButton2.Checked == true)
            {
                a = int.Parse(textBox1.Text);
                b = int.Parse(textBox2.Text);
                c = int.Parse(textBox3.Text);

                son2();

                if (a == b && b == c)
                {
                    groupBox3.Visible = true;
                    label5.Text = a.ToString();
                }

                else if (a != b)
                {

                    for (int i = 2; i <= son; i++)
                    {
                        if (a % i == 0 & b % i == 0 & c % i == 0)
                            ebob = i;
                        
                    }

                    groupBox3.Visible = true;
                    label5.Text = ebob.ToString();
                }
            }
        }
    }
}
