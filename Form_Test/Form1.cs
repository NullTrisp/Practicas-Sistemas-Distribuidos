using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Form_Test
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int valueA = Convert.ToInt32(this.textBox1.Text);
                int valueB = Convert.ToInt32(this.numericUpDown1.Value);

                double valueC = valueB / valueA;
                Console.WriteLine(valueC);
                MessageBox.Show(valueC,,MessageBoxButtons.OK);

            }
            catch (DivideByZeroException err)
            {
                MessageBox.Show(err.Message);
            }
            catch (FormatException err)
            {
                MessageBox.Show(err.Message);

            }
            finally
            {
                MessageBox.Show("end");
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }
    }
}
