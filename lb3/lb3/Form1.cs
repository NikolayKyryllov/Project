using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lb3
{
    public partial class Form1 : Form
    {
        private int count=1;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.Button button15;
        private System.Windows.Forms.Button button16;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        public Form1()
        {
            InitializeComponent();
            InitButton();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if(textBox1.Text!="")
            {
                comboBox1.Items.Add(textBox1.Text);
                textBox1.Text = "";
            }
           
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            if (comboBox1.Items.Count!=0)
                comboBox1.Items.RemoveAt(comboBox1.Items.Count-1);
        }

        private void butVisibility()
        {
            foreach (Button btn in tabPage2.Controls.OfType<Button>())
            {
                btn.Visible = true;
            }
        }
  
        private int[] CreateArray()
        {
            /*На 1м шаге:  Counter = 1, длинна массива = (16 – Counter) + 1 = 16
           На 2м шаге:  Counter = 2, длинна массива = (16 – Counter) + 1 = 15
         Далее – запускаем инициализацию массива от Counter До 16
          Далее - перемешиваем по алгоритму .Next(Counter, 16) */
            int n = 16-count+1;
            //int k = 1;

            int[] arr = Enumerable.Range(count, n).ToArray(); //  1 2 ... (n)  // Инициализация массива

            Random r = new Random();
            for (int i=n-1;i>=1;i--)
            {
                int j = r.Next(i + 1);
                int temp = arr[j];
                arr[j] = arr[i];
                arr[i] = temp;
            }

            return arr;
        }
        private void RandText()
        {
         
            int[] arr = new int[16-count+1];

            arr = CreateArray();
            int i = 0;

            foreach(Button btn in tabPage2.Controls.OfType<Button>())
            {
                if(int.Parse(btn.Text) >= count) {

                    btn.Text = arr[i].ToString();
                    i++;
                 }
            }
        }

        private void buttonAll_Click(object sender, EventArgs e)
        {
            Button but = (Button)sender;
            int a = int.Parse(but.Text);
            if(textBox2.Text == "Молодець!")
            {
                textBox2.Text = "";
                count = 1;
            }
            if( a!=count)
            {
                count = 1;
                butVisibility();
            }
            else
            {
                count++;
                but.Visible = false;
            }
            RandText();
            if (count==17)
            {
                textBox2.Text = "Молодець!";
                butVisibility();
            }
        }
  
        private void Form1_Load(object sender, EventArgs e)
        {
            foreach (Button btn in tabPage2.Controls.OfType<Button>())
            {
                btn.Click += buttonAll_Click;
            }
            RandText();
        }

        private void InitButton()
        {
            this.button13 = new System.Windows.Forms.Button();
            this.button14 = new System.Windows.Forms.Button();
            this.button15 = new System.Windows.Forms.Button();
            this.button16 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();

            this.tabPage2.Controls.Add(this.button13);
            this.tabPage2.Controls.Add(this.button14);
            this.tabPage2.Controls.Add(this.button15);
            this.tabPage2.Controls.Add(this.button16);
            this.tabPage2.Controls.Add(this.button9);
            this.tabPage2.Controls.Add(this.button10);
            this.tabPage2.Controls.Add(this.button11);
            this.tabPage2.Controls.Add(this.button12);
            this.tabPage2.Controls.Add(this.button5);
            this.tabPage2.Controls.Add(this.button6);
            this.tabPage2.Controls.Add(this.button7);
            this.tabPage2.Controls.Add(this.button8);
            this.tabPage2.Controls.Add(this.button4);
            this.tabPage2.Controls.Add(this.button3);
            this.tabPage2.Controls.Add(this.button2);
            this.tabPage2.Controls.Add(this.button1);
            // 
            // button13
            // 
            this.button13.Location = new System.Drawing.Point(376, 183);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(75, 23);
            this.button13.TabIndex = 15;
            this.button13.Text = "13";
            this.button13.UseVisualStyleBackColor = true;
            // 
            // button14
            // 
            this.button14.Location = new System.Drawing.Point(277, 183);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(75, 23);
            this.button14.TabIndex = 14;
            this.button14.Text = "14";
            this.button14.UseVisualStyleBackColor = true;
            // 
            // button15
            // 
            this.button15.Location = new System.Drawing.Point(178, 183);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(75, 23);
            this.button15.TabIndex = 13;
            this.button15.Text = "15";
            this.button15.UseVisualStyleBackColor = true;
            // 
            // button16
            // 
            this.button16.Location = new System.Drawing.Point(79, 183);
            this.button16.Name = "button16";
            this.button16.Size = new System.Drawing.Size(75, 23);
            this.button16.TabIndex = 12;
            this.button16.Text = "16";
            this.button16.UseVisualStyleBackColor = true;
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(376, 137);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(75, 23);
            this.button9.TabIndex = 11;
            this.button9.Text = "9";
            this.button9.UseVisualStyleBackColor = true;
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(277, 137);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(75, 23);
            this.button10.TabIndex = 10;
            this.button10.Text = "10";
            this.button10.UseVisualStyleBackColor = true;
            // 
            // button11
            // 
            this.button11.Location = new System.Drawing.Point(178, 137);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(75, 23);
            this.button11.TabIndex = 9;
            this.button11.Text = "11";
            this.button11.UseVisualStyleBackColor = true;
            // 
            // button12
            // 
            this.button12.Location = new System.Drawing.Point(79, 137);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(75, 23);
            this.button12.TabIndex = 8;
            this.button12.Text = "12";
            this.button12.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(376, 90);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 7;
            this.button5.Text = "5";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(277, 90);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 23);
            this.button6.TabIndex = 6;
            this.button6.Text = "6";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(178, 90);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(75, 23);
            this.button7.TabIndex = 5;
            this.button7.Text = "7";
            this.button7.UseVisualStyleBackColor = true;
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(79, 90);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(75, 23);
            this.button8.TabIndex = 4;
            this.button8.Text = "8";
            this.button8.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(376, 42);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 3;
            this.button4.Text = "4";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(277, 42);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 2;
            this.button3.Text = "3";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(178, 42);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(79, 42);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "1";
            this.button1.UseVisualStyleBackColor = true;
        }
    }
}
