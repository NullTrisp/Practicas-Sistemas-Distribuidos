
namespace CurrencyClient
{
    partial class MainView
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.CurrencyInput = new System.Windows.Forms.TextBox();
            this.FromSelect = new System.Windows.Forms.ComboBox();
            this.ToSelect = new System.Windows.Forms.ComboBox();
            this.ValueLabel = new System.Windows.Forms.Label();
            this.SwapBtn = new System.Windows.Forms.Button();
            this.CurrencyLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.LabelValue = new System.Windows.Forms.Label();
            this.ConvertBtn = new System.Windows.Forms.Button();
            this.CurrencyLabelStatic = new System.Windows.Forms.Label();
            this.ValueLabelStatic = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // CurrencyInput
            // 
            this.CurrencyInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CurrencyInput.Location = new System.Drawing.Point(111, 3);
            this.CurrencyInput.Name = "CurrencyInput";
            this.CurrencyInput.Size = new System.Drawing.Size(151, 30);
            this.CurrencyInput.TabIndex = 0;
            this.CurrencyInput.TextChanged += new System.EventHandler(this.CurrencyInput_TextChanged);
            // 
            // FromSelect
            // 
            this.FromSelect.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FromSelect.FormattingEnabled = true;
            this.FromSelect.Location = new System.Drawing.Point(111, 99);
            this.FromSelect.Name = "FromSelect";
            this.FromSelect.Size = new System.Drawing.Size(151, 33);
            this.FromSelect.TabIndex = 1;
            this.FromSelect.SelectedIndexChanged += new System.EventHandler(this.FromSelect_SelectedIndexChanged);
            // 
            // ToSelect
            // 
            this.ToSelect.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ToSelect.FormattingEnabled = true;
            this.ToSelect.Location = new System.Drawing.Point(111, 188);
            this.ToSelect.Name = "ToSelect";
            this.ToSelect.Size = new System.Drawing.Size(151, 33);
            this.ToSelect.TabIndex = 2;
            this.ToSelect.SelectedIndexChanged += new System.EventHandler(this.ToSelect_SelectedIndexChanged);
            // 
            // ValueLabel
            // 
            this.ValueLabel.AutoSize = true;
            this.ValueLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ValueLabel.Location = new System.Drawing.Point(111, 273);
            this.ValueLabel.Name = "ValueLabel";
            this.ValueLabel.Size = new System.Drawing.Size(0, 25);
            this.ValueLabel.TabIndex = 3;
            // 
            // SwapBtn
            // 
            this.SwapBtn.BackColor = System.Drawing.Color.LemonChiffon;
            this.SwapBtn.FlatAppearance.BorderSize = 0;
            this.SwapBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SwapBtn.Location = new System.Drawing.Point(268, 141);
            this.SwapBtn.Name = "SwapBtn";
            this.SwapBtn.Size = new System.Drawing.Size(83, 41);
            this.SwapBtn.TabIndex = 4;
            this.SwapBtn.Text = "Swap";
            this.SwapBtn.UseVisualStyleBackColor = false;
            this.SwapBtn.Click += new System.EventHandler(this.SwapBtn_Click);
            // 
            // CurrencyLabel
            // 
            this.CurrencyLabel.AutoSize = true;
            this.CurrencyLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CurrencyLabel.Location = new System.Drawing.Point(111, 232);
            this.CurrencyLabel.Name = "CurrencyLabel";
            this.CurrencyLabel.Size = new System.Drawing.Size(0, 25);
            this.CurrencyLabel.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 25);
            this.label1.TabIndex = 6;
            this.label1.Text = "From";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 185);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 25);
            this.label2.TabIndex = 7;
            this.label2.Text = "To";
            // 
            // LabelValue
            // 
            this.LabelValue.AutoSize = true;
            this.LabelValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelValue.Location = new System.Drawing.Point(3, 0);
            this.LabelValue.Name = "LabelValue";
            this.LabelValue.Size = new System.Drawing.Size(63, 25);
            this.LabelValue.TabIndex = 8;
            this.LabelValue.Text = "Value";
            // 
            // ConvertBtn
            // 
            this.ConvertBtn.BackColor = System.Drawing.Color.LemonChiffon;
            this.ConvertBtn.FlatAppearance.BorderSize = 0;
            this.ConvertBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConvertBtn.Location = new System.Drawing.Point(268, 3);
            this.ConvertBtn.Name = "ConvertBtn";
            this.ConvertBtn.Size = new System.Drawing.Size(83, 41);
            this.ConvertBtn.TabIndex = 9;
            this.ConvertBtn.Text = "Convert";
            this.ConvertBtn.UseVisualStyleBackColor = false;
            this.ConvertBtn.Click += new System.EventHandler(this.ConvertBtn_Click);
            // 
            // CurrencyLabelStatic
            // 
            this.CurrencyLabelStatic.AutoSize = true;
            this.CurrencyLabelStatic.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CurrencyLabelStatic.Location = new System.Drawing.Point(3, 232);
            this.CurrencyLabelStatic.Name = "CurrencyLabelStatic";
            this.CurrencyLabelStatic.Size = new System.Drawing.Size(98, 25);
            this.CurrencyLabelStatic.TabIndex = 10;
            this.CurrencyLabelStatic.Text = "Currency:";
            this.CurrencyLabelStatic.Visible = false;
            // 
            // ValueLabelStatic
            // 
            this.ValueLabelStatic.AutoSize = true;
            this.ValueLabelStatic.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ValueLabelStatic.Location = new System.Drawing.Point(3, 273);
            this.ValueLabelStatic.Name = "ValueLabelStatic";
            this.ValueLabelStatic.Size = new System.Drawing.Size(69, 25);
            this.ValueLabelStatic.TabIndex = 11;
            this.ValueLabelStatic.Text = "Value:";
            this.ValueLabelStatic.Visible = false;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 108F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 157F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 372F));
            this.tableLayoutPanel1.Controls.Add(this.CurrencyInput, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.ConvertBtn, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.FromSelect, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.SwapBtn, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.ToSelect, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.LabelValue, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.CurrencyLabelStatic, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.ValueLabelStatic, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.CurrencyLabel, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.ValueLabel, 1, 5);
            this.tableLayoutPanel1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(165, 89);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 29.72973F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.91291F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.71472F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.71472F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.61261F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.41441F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(375, 323);
            this.tableLayoutPanel1.TabIndex = 13;
            // 
            // MainView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Beige;
            this.ClientSize = new System.Drawing.Size(764, 468);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "MainView";
            this.Text = "Convert Currencies";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox CurrencyInput;
        private System.Windows.Forms.ComboBox FromSelect;
        private System.Windows.Forms.ComboBox ToSelect;
        private System.Windows.Forms.Label ValueLabel;
        private System.Windows.Forms.Button SwapBtn;
        private System.Windows.Forms.Label CurrencyLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label LabelValue;
        private System.Windows.Forms.Button ConvertBtn;
        private System.Windows.Forms.Label CurrencyLabelStatic;
        private System.Windows.Forms.Label ValueLabelStatic;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    }
}

