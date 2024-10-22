using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Change_Counter
{
    public partial class Form1 : Form
    {
        const decimal FIVE_CENTS_VALUE = 0.05M;
        const decimal TEN_CENTS_VALUE=0.10M;
        const decimal TWENTY_FIVE_CENTS_VALUE = 0.25M;
        const decimal FIFTY_CENTS_VALUE = 0.50M;

        private decimal total = 0M;
        public Form1()
        {
            InitializeComponent();
        }

     
        private void fiveCentsPictureBox_Click(object sender, EventArgs e)
        {
            //otal = total + 0.05m
            total += 0.05M;
            total += FIVE_CENTS_VALUE;
            totalLabel.Text = total.ToString("C");
        }

        private void tenCentsPictureBox_Click(object sender, EventArgs e)
        {
            total += 0.10M;
            total +=TEN_CENTS_VALUE;
            totalLabel.Text = total.ToString("C");
        }

        private void twentyFiveCentsPictureBox_Click(object sender, EventArgs e)
        {
            total += 0.25M;
            total += TWENTY_FIVE_CENTS_VALUE;
           totalLabel.Text = total.ToString("C");
        }

        private void fiftyCentsPictureBox_Click(object sender, EventArgs e)
        {
            total += 0.50M;
            total += FIFTY_CENTS_VALUE;
            totalLabel.Text = total.ToString("C");
        }
    
