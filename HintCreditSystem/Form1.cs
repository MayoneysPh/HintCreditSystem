using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace HintCreditSystem
{
    public partial class Form1 : Form
    {
        public static int hintCount = 0;
        public static double TotalCredit = 0;

        public Form1()
        {
            InitializeComponent();
            UpdateHintCountLabel();
            UpdateCreditCountLabel();
        }

        private void UpdateHintCountLabel()
        {
            hintLabel.Text = "Hints: " + hintCount.ToString();
        }

        private void UpdateCreditCountLabel()
        {
            creditLabel.Text = $"Credits: $" + TotalCredit.ToString();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

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

        private void hint1_Click(object sender, EventArgs e)
        {
            if (TotalCredit >= 100)
            {
                hintCount++;
                TotalCredit -= 100;
                UpdateHintCountLabel();
                UpdateCreditCountLabel();
            }
            else
            {
                MessageBox.Show("Not enough credits to purchase hint.");
            }
        }

        private void hint5_Click(object sender, EventArgs e)
        {
            if (TotalCredit >= 350)
            {
                hintCount += 5;
                TotalCredit -= 350;
                UpdateHintCountLabel();
                UpdateCreditCountLabel();
            }
            else
            {
                MessageBox.Show("Not enough credits to purchase hints.");
            }
        }

        private void enterButton_Click(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(textBox1.Text, "eagle"))
            {
                MessageBox.Show("Congratulations!");

                TotalCredit += 25;

                creditLabel.Text = $"Credits: ${TotalCredit:F2}";
            }
            else
            {
                MessageBox.Show("Your answer is Incorrect");
            }
        }

        private void nxtButton_Click(object sender, EventArgs e)
        {
            Form2 frm = new Form2(hintCount, creditLabel.Text);
            frm.Show();
        }
    }
}
