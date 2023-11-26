using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace HintCreditSystem
{



    public partial class Form2 : Form
    {

        private int hintCount;
        public double amount = 25;

        public Form2(int hintCount, string strLabel)
        {
            InitializeComponent();
            this.hintCount = hintCount;
            UpdateHintCountLabel();
            creditLabel.Text = strLabel;
            UpdateCreditCountLabel();

        }

        private void UpdateHintCountLabel()
        {
            hintLabel.Text = "Hints: " + hintCount.ToString();
        }

        private void UpdateCreditCountLabel()
        {
            creditLabel.Text = $"Credits: $" + Form1.TotalCredit.ToString();
        }


        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {


        }

        private void enterButton_Click(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(textBox1.Text, "tamaraw"))
            {
                MessageBox.Show("Congratulations!");

                Form1.TotalCredit += amount;

                creditLabel.Text = $"Credits: ${Form1.TotalCredit:F2}";
            }
            else
            {
                MessageBox.Show("Your answer is Incorrect");
            }
        }

        private void hintButton_Click(object sender, EventArgs e)
        {
            if (hintCount > 0)
            {
                hintCount--;
                pctrBox.Visible = true;
                hintButton.Visible = false;
                UpdateHintCountLabel();
            }
            else
            {
                MessageBox.Show("Buy hint at store.");
            }
        }

        private void nxtButton_Click(object sender, EventArgs e)
        {
            var newform = new Form1();
            newform.Show();
            this.Hide();
        }
    }
    
}
