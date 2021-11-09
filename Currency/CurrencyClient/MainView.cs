using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CurrencyClient
{
    public partial class MainView : Form
    {
        private readonly string[] currencies = { "dollar", "euro" };
        private decimal value;
        private string from;
        private string to;
        public MainView()
        {
            InitializeComponent();
            this.FromSelect.Items.AddRange(currencies);
            this.ToSelect.Items.AddRange(currencies);
            this.CurrencyInput.Visible = false;
            this.LabelValue.Visible = false;
            this.ConvertBtn.Visible = false;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.FromSelect.DropDownStyle = ComboBoxStyle.DropDownList;
            this.ToSelect.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void CurrencyInput_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (this.CurrencyInput.Text.Equals(""))
                {
                    this.value = 0;
                }
                else
                {

                    this.value = Convert.ToDecimal(this.CurrencyInput.Text);
                }
            }
            catch
            {
                MessageBox.Show("Input a valid number!", "Close Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.CurrencyInput.Text = String.Empty;
            }
        }

        private void UpdateLabels(XMLHandler res)
        {
            this.ValueLabel.Text = res.value.ToString();
            this.CurrencyLabel.Text = res.currency;
            this.CurrencyLabelStatic.Visible = true;
            this.ValueLabelStatic.Visible = true;
        }

        private void SwapBtn_Click(object sender, EventArgs e)
        {
            if ((this.ToSelect.Text.Equals("") ||
                this.FromSelect.Text.Equals("") ||
                !this.currencies.Contains(this.ToSelect.Text) ||
                !this.currencies.Contains(this.FromSelect.Text)) &&
                !this.CurrencyInput.Text.Equals(""))
            {
                var fromCurrency = this.FromSelect.Text;
                var toCurrency = this.ToSelect.Text;

                this.ToSelect.Text = fromCurrency + " ";
                this.FromSelect.Text = toCurrency;
                this.ToSelect.Text = fromCurrency;
            }
        }

        private void ConvertBtn_Click(object sender, EventArgs e)
        {
            try
            {

                this.UpdateLabels(XMLHandler.GetResponse(
                        Client.SendMessage(
                            XMLHandler.CreateXmlRequest(
                                   this.value,
                                    this.FromSelect.Text,
                                    this.ToSelect.Text
                                )
                            )
                        ));
            }
            catch (System.Net.Sockets.SocketException err)
            {
                MessageBox.Show($"There was a server error, {err.Message}", "Close Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FromSelect_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!this.FromSelect.Text.Equals(this.ToSelect.Text))
            {
                this.from = this.FromSelect.Text;
            }
            else
            {
                this.FromSelect.Text = String.Empty;
                this.FromSelect.SelectedIndex = -1;
            }
        }

        private void ToSelect_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!this.FromSelect.Text.Equals(this.ToSelect.Text))
            {
                this.to = this.ToSelect.Text;
            }
            else
            {
                this.ToSelect.Text = String.Empty;
                this.ToSelect.SelectedIndex = -1;
            }
        }
    }
}
