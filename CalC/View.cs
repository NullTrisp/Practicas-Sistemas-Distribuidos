using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalC
{
    public partial class View : Form
    {
        private string operandus = "";
        private Connect server = new Connect("127.0.0.1");
        public View()
        {
            InitializeComponent();
            this.label2.Visible = false;
            this.Text = "Calculator";
            this.MaximizeBox = false;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
        }

        public void changeLabel(string newValue)
        {
            if (this.label1.Text.CompareTo("0") == 0 || this.label1.Text.CompareTo("Cannot divide by zero") == 0)
            {
                this.label1.Text = newValue;
            }
            else
            {
                this.label1.Text += newValue;
            }
        }

        public void operatorsLoad(string operandus)
        {
            if (this.label1.Text.Length > 0 && this.label1.Text.CompareTo("0") > 0)
            {
                this.operandus = operandus;
                this.label2.Visible = true;
                this.label2.Text = this.label1.Text;
                this.label1.Text = "0";
            }
            else if (this.label1.Text.CompareTo("Cannot divide by zero") == 0)
            {
                this.label1.Text = "0";
            }
        }

        private void View_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button16_Click(object sender, EventArgs e)
        {
            this.changeLabel((sender as Button).Text);
        }

        private void button19_Click(object sender, EventArgs e)
        {
            this.changeLabel((sender as Button).Text);
        }

        private void button24_Click(object sender, EventArgs e)
        {
            this.changeLabel((sender as Button).Text);
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void button23_Click(object sender, EventArgs e)
        {
            this.changeLabel((sender as Button).Text);
        }

        private void button22_Click(object sender, EventArgs e)
        {
            this.changeLabel((sender as Button).Text);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            this.changeLabel((sender as Button).Text);
        }

        private void button11_Click(object sender, EventArgs e)
        {
            this.changeLabel((sender as Button).Text);
        }

        private void button12_Click(object sender, EventArgs e)
        {
            this.changeLabel((sender as Button).Text);
        }

        private void button14_Click(object sender, EventArgs e)
        {
            this.changeLabel((sender as Button).Text);
        }

        private void button15_Click(object sender, EventArgs e)
        {
            this.changeLabel((sender as Button).Text);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (this.label1.Text.Length == 1)
            {
                this.label1.Text = "0";
            }
            else
            {
                this.label1.Text = this.label1.Text.Remove(this.label1.Text.Length - 1);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.label2.Text = "0";
            this.label2.Visible = false;
            this.label1.Text = "0";
        }

        private void button20_Click(object sender, EventArgs e)
        {
            if (this.label1.Text[0].CompareTo('-') == 0 && this.label1.Text.Length > 1)
            {
                this.label1.Text = this.label1.Text.Remove(0, 1);
            }
            else if (this.label1.Text[0].CompareTo('0') == 0)
            {
                this.label1.Text = "0";
            }
            else
            {
                this.label1.Text = $"-{this.label1.Text}";
            }
        }

        private void button21_Click(object sender, EventArgs e)
        {
            if (this.label1.Text != "0" && this.label2.Visible)
            {
                this.label2.Visible = false;

                this.server.SendMessage("sum");
                //this.label1.Text = Calculator.Sum(this.label2.Text, this.label1.Text);
            }
            else
            {

                this.operatorsLoad((sender as Button).Text);
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (this.label1.Text != "0" && this.label2.Visible)
            {
                this.label2.Visible = false;
                this.server.SendMessage("subs");
                //this.label1.Text = Calculator.Subs(this.label2.Text, this.label1.Text);
            }
            else
            {

                this.operatorsLoad((sender as Button).Text);
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            if (this.label1.Text != "0" && this.label2.Visible)
            {
                this.label2.Visible = false;
                this.server.SendMessage("sum");
                //this.label1.Text = Calculator.Sum(this.label2.Text, this.label1.Text);
            }
            else
            {

                this.operatorsLoad((sender as Button).Text);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (this.label1.Text != "0" && this.label2.Visible)
            {
                this.label2.Visible = false;
                this.server.SendMessage("sum");
                //this.label1.Text = Calculator.Div(this.label2.Text, this.label1.Text);
            }
            else
            {

                this.operatorsLoad((sender as Button).Text);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.label1.Text = "0";
        }

        private void button17_Click(object sender, EventArgs e)
        {
            this.label2.Visible = false;
            switch (this.operandus)
            {
                case "+":
                    {
                        this.label1.Text = this.server.SendMessage($"sum,{this.label2.Text},{this.label1.Text}");
                        break;
                    }
                case "-":
                    {

                        this.label1.Text = this.server.SendMessage($"subs,{this.label2.Text},{this.label1.Text}");
                        break;
                    }
                case "÷":
                    {
                        this.label1.Text = this.server.SendMessage($"div,{this.label2.Text},{this.label1.Text}");
                        break;
                    }
                case "x":
                    {
                        this.label1.Text = this.server.SendMessage($"mult,{this.label2.Text},{this.label1.Text}");
                        break;
                    }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (this.label2.Visible)
            {
                this.server.SendMessage("percentage");
                //this.label1.Text = Calculator.Percentage(this.label1.Text, this.label2.Text);
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (this.label1.Text.CompareTo("0") == 0)
            {
                this.label1.Text = "Cannot divide by zero";
            }
            else
            {
                this.server.SendMessage("divByX");
                //this.label1.Text = Calculator.DivideByX(this.label1.Text);
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (this.label1.Text.CompareTo("0") > 0)
            {
                this.label1.Text = this.server.SendMessage($"sqrRoot,{this.label1.Text}");
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (this.label1.Text.CompareTo("0") > 0)
            {
                this.server.SendMessage("pow");
                //this.label1.Text = Calculator.Pow(this.label1.Text);
            }
        }

        private void button18_Click(object sender, EventArgs e)
        {
            if (!this.label1.Text.Contains("."))
            {
                this.label1.Text += ".";
            }
        }
    }
}
