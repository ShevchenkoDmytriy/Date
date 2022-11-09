using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
            btnRes.Click += ResClick;
            btnOk.Click += OkClick;
            textBox2.Enter += TextInputEnter;
        }
        private void TextInputEnter(object sender, EventArgs e)
        {
            label1.Visible = false;
            textBox2.BackColor = Color.Wheat;
        }

        private void OkClick(object sender, EventArgs e)
        {
            try
            {
                DateTime dayT = new DateTime();
                dayT = DateTime.Parse(textBox2.Text);
                DateTime dayNow = DateTime.Now;
                TimeSpan tempDay = dayT - dayNow;
                if (dayT > dayNow)
                {
                    if (YearRadio.Checked)
                    {
                        textBox1.Text = (tempDay.TotalDays / 365).ToString();
                    }
                    if (MonthRadio.Checked)
                    {
                        textBox1.Text = (tempDay.TotalDays / 30).ToString();
                    }
                    if (DayRadio.Checked)
                    {
                        textBox1.Text = ((int)tempDay.TotalDays).ToString();
                    }
                    if (minutesRadio.Checked)
                    {
                        textBox1.Text = ((int)tempDay.TotalMinutes).ToString();
                    }
                    if (secondsRadio.Checked)
                    {
                        textBox1.Text = ((int)tempDay.TotalSeconds).ToString();
                    }
                }
                else
                {
                    textBox1.Text = "Эта дата уже прошла!";
                }
            }
            catch (Exception)
            {
                label1.Visible = true;
                textBox2.BackColor = Color.LightCoral;
            }

        }

        private void ResClick(object sender, EventArgs e)
        {
            textBox2.Clear();
            textBox1.Clear();
            label1.Visible = false;
            textBox2.BackColor = Color.White;
            YearRadio.Checked = true;
        }

    }
}
