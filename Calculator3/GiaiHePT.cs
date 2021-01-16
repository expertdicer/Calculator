using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MathNet.Numerics.LinearAlgebra;

namespace Calculator3
{
    public partial class GiaiHePT : Form
    {
        private double A;
        private double B;
        private double C;
        private double D;
        private double E;
        private double F;
        public GiaiHePT()
        {
            InitializeComponent();
            clear_result();
        }
        private void clear_result()
        {
            ketqua.Text = "";
            x.Text = "";
            y.Text = "";          
        }
        private void solve(object sender, EventArgs e)
        {
            try
            {
                A = double.Parse(textBox1.Text.ToString());
                B = double.Parse(textBox3.Text.ToString());
                C = double.Parse(textBox5.Text.ToString());
                D = double.Parse(textBox2.Text.ToString());
                E = double.Parse(textBox4.Text.ToString());
                F = double.Parse(textBox6.Text.ToString());
                
            }
            catch
            {
                MessageBox.Show("Mời bạn nhập đúng tham số", "Error", MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            try
            {
                if ((A / D) == (B / E) && (C != F))
                {
                    clear_result();
                    ketqua.Text = "Phương trình vô nghiệm !";
                }
                else if ((A / D) == (B / E) && (C == F))
                {
                    clear_result();
                    ketqua.Text = "Phương trình có vô số nghiệm !";
                }
                else
                {
                    clear_result();
                    var a = Matrix<double>.Build.DenseOfArray(new double[,] {
                    { A, B, },
                    { D, E }
                    });
                    var b = Vector<double>.Build.Dense(new double[] { C, F });
                    var result = a.Solve(b);
                    x.Text = result[0].ToString();
                    y.Text = result[1].ToString();
                }
            }
            catch
            {
                ketqua.Text = "Math Error";
            }
        }
        private void close(object sender, EventArgs e)
        {
            this.Hide();
            var form1 = new Form1();
            form1.Closed += (s, args) => this.Close();
            form1.Show();
        }
        private void GiaiHePT_Load(object sender, EventArgs e)
        {
            CenterToScreen();
        }
    }
}
