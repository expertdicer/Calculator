using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Permissions;

namespace Calculator3
{

    public partial class Form1 : Form
    {

        public string Ans;
        public string Memory;
        public int clear_screen = 0;
        private void memory_save(object sender, EventArgs e)
        {   
            if (Result.Text !="" && Result.Text != "No value for memory to add" && Result.Text != "No value for memory to minus")
            {
                Memory = Result.Text;
            }         
        }

        private void memory_add(object sender, EventArgs e)
        {
            try
            {
                Memory = Infix_to_Postfix.EvaluatePostfix(Infix_to_Postfix.Infix2Postfix(((new Tokenizer()).TokenizeNumber(Memory + "+" + Screen.Text)))).ToString();
            }
            catch (Exception InvalidOperationException)
            {
                Result.Text = "No value for memory to add";
            }
            catch
            {
                Memory = Infix_to_Postfix.EvaluatePostfix(Infix_to_Postfix.Infix2Postfix(((new Tokenizer()).TokenizeNumber(Memory + "+0")))).ToString();
            }
            
        }
        private void memory_minus(object sender, EventArgs e)
        {
            try
            {
                Memory = Infix_to_Postfix.EvaluatePostfix(Infix_to_Postfix.Infix2Postfix(((new Tokenizer()).TokenizeNumber(Memory + "-" + Screen.Text)))).ToString();
            }
            catch(Exception InvalidOperationException)
            {
                Result.Text = "No value for memory to minus";
            }         
        }
        private void memory_clear(object sender, EventArgs e)
        {
            Memory = "0";
        }
        private void memory_read(object sender, EventArgs e)
        {
            Result.Text = Memory;
        }

        private void opposite(object sender, EventArgs e)
        {
            try
            {
                Result.Text = Infix_to_Postfix.EvaluatePostfix(Infix_to_Postfix.Infix2Postfix(((new Tokenizer()).TokenizeNumber(Result.Text + "*(-1)")))).ToString();
            }
            catch (Exception InvalidOperationException)
            {
                Result.Text = "Wrong";
            }
        }
        public Form1()
        {
            InitializeComponent();
            Screen.Focus();
            PhimBam();
        }

        Dictionary<string, double> variables = new Dictionary<string, double>()
        {
            { "x", 0 }
        };

        private void ButtonToScreen(object sender, EventArgs e)
        {
            if (clear_screen == 1)
            {
                Screen.Clear();
                Result.Clear(); 
            }
            Screen.Text += ((Button)sender).Text;
            clear_screen = 0;
        }

        // Modification
        private void OpenQuadratic(object sender, EventArgs e)
        {
            this.Hide();
            var quadratic = new Quadratic();
            quadratic.Closed += (s, args) => this.Close();
            quadratic.Show();
        }
        private void OpenCubic(object sender, EventArgs e)
        {
            this.Hide();
            var cubic = new Cubic();
            cubic.Closed += (s, args) => this.Close();
            cubic.Show();
        }
        private void OpenHePT(object sender, EventArgs e)
        {
            this.Hide();
            var giaihept = new GiaiHePT();
            giaihept.Closed += (s, args) => this.Close();
            giaihept.Show();
        }
        private void OpenPaint(object sender, EventArgs e)
        {
            this.Hide();
            var paint = new Paint();
            paint.Closed += (s, args) => this.Close();
            paint.Show();
        }

        // Edit

        /// <summary>
        /// remove the last component
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Backspace(object sender, EventArgs e)
        {
            var s = Screen.Text;
            if (s != "") Screen.Text = s.Remove(s.Length - 1);
        }

        // this should reset state, now with just screen, used for AC
        private void Clear(object sender, EventArgs e)
        {
            Screen.Clear();
            Result.Clear();
        }
       
        private void Navigate_CursorToLeft(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }


        private void PrintResult(object sender, EventArgs e)
        {
            try
            {   if (Screen.Text=="Ans")
                {
                    Result.Text = Ans;
                }
            else
                {
                    Result.Text = Infix_to_Postfix.EvaluatePostfix(Infix_to_Postfix.Infix2Postfix(((new Tokenizer()).TokenizeNumber(Screen.Text)))).ToString();
                    Ans = Infix_to_Postfix.EvaluatePostfix(Infix_to_Postfix.Infix2Postfix(((new Tokenizer()).TokenizeNumber(Screen.Text)))).ToString();
                }
                
            }
            catch (Exception)
            {
                Result.Text = "MATH ERROR";
            }
            clear_screen = 1;
        }
        private void PrintResult(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                PrintResult(sender, (EventArgs)e);
            }
        }
        private void PhimBam()
        {
            List<Button> listt = new List<Button>()
            {
              button15 ,button16 , button17 ,button18 ,button10, button1,button2 , button3,button4, button5,button6 , button7,button8,button9,button25
            };
            List<Keys> listt2 = new List<Keys>()
            {
                Keys.A, // "+"
                Keys.S,   // "-"
                Keys.M,  // "*"
                Keys.D,   // "/"
                Keys.D0,
                Keys.D1,
                Keys.D2,
                Keys.D3,
                Keys.D4,
                Keys.D5,
                Keys.D6,
                Keys.D7,
                Keys.D8,
                Keys.D9,
                Keys.Enter
            };
            foreach (Control b in this.Controls)
            {
                if (!(b is Button)) continue;
                Button _b = b as Button;
                _b.KeyDown += (object sender, KeyEventArgs e) =>
                {
                    int idx = listt2.IndexOf(e.KeyCode);
                    if (idx != -1 && idx != 14)
                    {
                        listt[idx].PerformClick();
                    }
                    if (idx == 14)
                    {                       
                        PrintResult(sender, (EventArgs)e);                      
                    }
                };
            };
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Memory = "0";
            CenterToScreen();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
                try
                {

                }
                catch (Exception)
                {
                    MessageBox.Show("This file is not Invalid");
                }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                try
                {

                }
                catch (Exception)
                {
                    MessageBox.Show("This file is not Invalid");
                }
        }
    }
}
