using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Numerics;
using MathNet.Numerics;

namespace Calculator3
{
    public partial class Cubic : Form
    {
        private double a;
        private double b;
        private double c;
        private double d;
        private double delta;
        public Cubic()
        {
            InitializeComponent();
            clear_result();
        }
        private void clear_result()
        {
            ketqua.Text = "";
            x1.Text = ";";
            x2.Text = ";";
            x3.Text = ";";
        }
        private void solve(object sender, EventArgs e)
        {
            try
            {
                a = double.Parse(textBox1.Text.ToString());
                b = double.Parse(textBox2.Text.ToString());
                c = double.Parse(textBox3.Text.ToString());
                d = double.Parse(textBox4.Text.ToString());
                delta = c* c - 4 * b * d;
            }
            catch
            {
                ketqua.Text = "Mời bạn nhập đầy đủ tham số";
            }
            var roots = FindRoots.Cubic(d, c, b, a);
            Complex root1 = roots.Item1;
            Complex root2 = roots.Item2;
            Complex root3 = roots.Item3;
            x1.Text = (root1.Real.ToString() + "+(" + root1.Imaginary.ToString() + "i)");
            x2.Text = (root2.Real.ToString() + "+(" + root2.Imaginary.ToString() + "i)");
            x3.Text = (root3.Real.ToString() + "+(" + root3.Imaginary.ToString() + "i)");
            /*
            if (root1 == root2 && root2 == root3)
            {
                ketqua.Text = "Phương trình có duy nhất nghiệm:";
                x1.Text= (root1.Real.ToString() + " + " + root1.Imaginary.ToString() + "i");
            }
            else
            {
                ketqua.Text = "Phương trình có 3 nghiệm phân biệt:";
                
            }
            */
        }

        private void Cubic_Load(object sender, EventArgs e)
        {
            CenterToScreen();
        }

        private void close(object sender, EventArgs e)
        {
            this.Hide();
            var form1 = new Form1();
            form1.Closed += (s, args) => this.Close();
            form1.Show();
        }

    }
 }
