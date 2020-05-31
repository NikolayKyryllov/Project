using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calc
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        double a = 0,b=0;
        string ch = "";
        bool flagComa = false;
        bool flagRavno = false;

        private void btnOne_Click(object sender, EventArgs e)
        {
            if (texteResult.Text == "0")
                texteResult.Text = btnOne.Text;
            else
                texteResult.Text = texteResult.Text + btnOne.Text;
        }

        private void btnTwo_Click(object sender, EventArgs e)
        {
            if (texteResult.Text == "0")
                texteResult.Text = btnTwo.Text;
            else
                texteResult.Text = texteResult.Text + btnTwo.Text;
        }

        private void btnThree_Click(object sender, EventArgs e)
        {
            if (texteResult.Text == "0")
                texteResult.Text = btnThree.Text;
            else
                texteResult.Text = texteResult.Text + btnThree.Text;
        }

        private void btnFour_Click(object sender, EventArgs e)
        {
            if (texteResult.Text == "0")
                texteResult.Text = btnFour.Text;
            else
                texteResult.Text = texteResult.Text + btnFour.Text;
        }

        private void btnFive_Click(object sender, EventArgs e)
        {
            if (texteResult.Text == "0")
                texteResult.Text = btnFour.Text;
            else
                texteResult.Text = texteResult.Text + btnFive.Text;
        }

        private void btnSix_Click(object sender, EventArgs e)
        {
            if (texteResult.Text == "0")
                texteResult.Text = btnSix.Text;
            else
                texteResult.Text = texteResult.Text + btnSix.Text;
        }

        private void btnSeven_Click(object sender, EventArgs e)
        {
            if (texteResult.Text == "0")
                texteResult.Text = btnSeven.Text;
            else
                texteResult.Text = texteResult.Text + btnSeven.Text;
        }

        private void btnEight_Click(object sender, EventArgs e)
        {
            if (texteResult.Text == "0")
                texteResult.Text = btnEight.Text;
            else
                texteResult.Text = texteResult.Text + btnEight.Text;
        }

        private void btnNine_Click(object sender, EventArgs e)
        {
            if (texteResult.Text == "0")
                texteResult.Text = btnNine.Text;
            else
                texteResult.Text = texteResult.Text + btnNine.Text;
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            ch = btnPlus.Text;

            // Убираем запятую, если она последняя в числе
            int len = texteResult.Text.Length - 1;
            string s = texteResult.Text;
            if (s.Substring(len, 1) == ",")
            {
                s = s.Substring(0, len);
                texteResult.Text = s;
            }

            a = double.Parse(texteResult.Text);
            texteEpression.Text = texteResult.Text + btnPlus.Text;
            texteResult.Clear();
            flagRavno = false;
            flagComa = false;
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            ch = btnMinus.Text;

            // Убираем запятую, если она последняя в числе
            int len = texteResult.Text.Length - 1;
            string s = texteResult.Text;
            if (s.Substring(len, 1) == ",")
            {
                s = s.Substring(0, len);
                texteResult.Text = s;
            }

            a = double.Parse(texteResult.Text);
            texteEpression.Text = texteResult.Text + btnMinus.Text;
            texteResult.Clear();
            flagRavno = false;
            flagComa = false;
        }

        private void btnMull_Click(object sender, EventArgs e)
        {
            ch = btnMull.Text;

            // Убираем запятую, если она последняя в числе
            int len = texteResult.Text.Length - 1;
            string s = texteResult.Text;
            if (s.Substring(len, 1) == ",")
            {
                s = s.Substring(0, len);
                texteResult.Text = s;
            }

            a = double.Parse(texteResult.Text);
            texteEpression.Text = texteResult.Text + btnMull.Text;
            texteResult.Clear();
            flagRavno = false;
            flagComa = false;
        }

        private void btnDiv_Click(object sender, EventArgs e)
        {
            ch = btnDiv.Text;

            // Убираем запятую, если она последняя в числе
            int len = texteResult.Text.Length - 1;
            string s = texteResult.Text;
            if (s.Substring(len, 1) == ",")
            {
                s = s.Substring(0, len);
                texteResult.Text = s;
            }

            a = double.Parse(texteResult.Text);
            texteEpression.Text = texteResult.Text + btnDiv.Text;
            texteResult.Clear();
            flagRavno = false;
            flagComa = false;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            texteEpression.Clear();
            texteResult.Text="0";
            ch = "";
            a = 0;
            b = 0;
            flagComa = false;
            flagRavno = false;
        }

        private void btnEqually_Click(object sender, EventArgs e)
        {
            // Если сразу жмем =, без вычислений, то ничего не делаем
            if (ch == "" || texteResult.Text == "")
                return;
            // Убираем запятую, если она последняя в числе
            int len = texteResult.Text.Length-1;
            string s = texteResult.Text;
            if ( s.Substring(len, 1) == "," )
            {
                s = s.Substring(0, len);
                texteResult.Text = s;
            }

            if (flagRavno == false)
            {
                b = double.Parse(texteResult.Text);
                texteEpression.Text = texteEpression.Text + texteResult.Text + "=";
                texteResult.Text = "0";
                flagRavno = true;
            }
            else
            {
                a= double.Parse(texteResult.Text);
                texteEpression.Text = a.ToString() + ch + b.ToString() + "=";
                texteResult.Text = "0";
            }

            switch (ch)
            {
                case "+":
                    {
                        texteResult.Text = Convert.ToString(a + b);
                        break;
                    }
                case "-":
                    {
                        texteResult.Text = Convert.ToString(a - b);
                        break;
                    }
                case "*":
                    {
                        texteResult.Text = Convert.ToString(a * b);
                        break;
                    }
                case "/":
                    {
                        if (b == 0)
                            MessageBox.Show("Деление на 0 не возможно!", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
                        else
                            texteResult.Text = Convert.ToString(a / b);
                        break;
                    }
            }
            
        }

        private void btnZero_Click(object sender, EventArgs e)
        {
            if  (texteResult.Text != "0")
            {
                texteResult.Text = texteResult.Text + btnZero.Text;
            }
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            if (flagRavno == true)
            {
                string s = texteResult.Text;
                btnClear.PerformClick();
                texteResult.Text=s;
            }
            else { 
                if (texteResult.Text.Length == 1)
                    texteResult.Text = "0";
                else
                {
                    string s = texteResult.Text;
                    int len = texteResult.Text.Length - 1;
                    s = s.Substring(0, len);
                    texteResult.Text = s;
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void Form1_Activated(object sender, EventArgs e)
        {
            texteEpression.Focus();
        }

        private void btnComma_Click(object sender, EventArgs e)
        {
            if (flagComa == false)
            {
                texteResult.Text = texteResult.Text + btnComma.Text;
                flagComa = true;
            }
        }
    }
}
