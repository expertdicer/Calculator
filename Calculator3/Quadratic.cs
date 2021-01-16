using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator3
{
    public partial class Quadratic : Form
    {
        private double a;
        private double b;
        private double c;
        private double delta;
        public Quadratic()
        {
            InitializeComponent();
            ketqua.Text = "";
            x1.Text = "";
            x2.Text = "";
        }
        private void solve(object sender, EventArgs e)
        {
            try
            {
                a = double.Parse(textBox1.Text.ToString());
                b = double.Parse(textBox2.Text.ToString());
                c = double.Parse(textBox3.Text.ToString());
                delta = b * b - 4 * a * c;
            }
            catch
            {
                ketqua.Text = "Mời bạn nhập đầy đủ tham số";
            }
            
            try
            {
                if (a == 0)
                {
                    if (b == 0)
                    {
                        clear_result();
                        ketqua.Text = " Phương trình có vô số nghiệm";
                    }
                    else
                    {
                        clear_result();
                        ketqua.Text = " Phương trình có nghiệm duy nhất";
                        x1.Text = (-c / b).ToString();
                    }
                }
                else
                {
                    if (delta == 0)
                    {
                        clear_result();
                        ketqua.Text = " Phương trình có nghiệm kép";
                        x1.Text = x2.Text = (-b / (2 * a)).ToString();
                    }
                    else if (delta < 0)
                    {
                        clear_result();
                        ketqua.Text = " Phương trình có 2 nghiệm phức";
                        x1.Text = ((-b / 2 * a) + "+" + (Math.Sqrt(Math.Abs(delta)) / 2 * a) + "i").ToString();
                        x2.Text = ((-b / 2 * a) + "-" + (Math.Sqrt(Math.Abs(delta)) / 2 * a) + "i").ToString();

                    }
                    else
                    {
                        clear_result();
                        ketqua.Text = " Phương trình có 2 nghiệm phân biệt";
                        x1.Text = ((-b + Math.Sqrt(delta)) / (2 * a)).ToString();
                        x2.Text = ((-b - Math.Sqrt(delta)) / (2 * a)).ToString();
                    }
                }
            }
            catch
            {
                clear_result();
                ketqua.Text = "Math Error";
            }
        }
        private void clear_result()
        {
            x1.Text = "";
            x2.Text = "";
        }
        private void close(object sender, EventArgs e)
        {
            this.Hide();
            var form1 = new Form1();
            form1.Closed += (s, args) => this.Close();
            form1.Show();
        }
        private void Quadratic_Load(object sender, EventArgs e)
        {
            CenterToScreen();
        }
    }
}
