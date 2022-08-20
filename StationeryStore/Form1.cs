using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StationeryStore
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void checkKitap_CheckedChanged(object sender, EventArgs e)
        {
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            decimal sum=0, sum1=0, sum2=0, sum3=0, sum4=0, sum5 = 0;
            if (checkKitap.Checked)
            {
                decimal price1 = Decimal.Parse(labelFiyatKitap.Text);
                decimal num1 = Convert.ToInt32(numericUpDown1.Value);
                sum1 = price1*num1;
                listBox1.Items.Add(checkKitap.Text + " " + numericUpDown1.Value + " " + "adet seçildi"+" "+sum1+" TL");

            }
            if (checkDefter.Checked)
            {
                decimal price2 = Decimal.Parse(labelFiyatKitap.Text);
                decimal num2 = Convert.ToInt32(numericUpDown2.Value);
                sum2 = price2 * num2;
                listBox1.Items.Add(checkDefter.Text + " " + numericUpDown2.Value + " " + "adet seçildi" + " " + sum2 + " TL");
            }
            if (checkSilgi.Checked)
            {
                decimal price3 = Decimal.Parse(labelFiyatKitap.Text);
                decimal num3 = Convert.ToInt32(numericUpDown3.Value);
                sum3 = price3 * num3;
                listBox1.Items.Add(checkSilgi.Text + " " + numericUpDown3.Value + " " + "adet seçildi" + " " + sum3 + " TL");
            }
            if (checkKarton.Checked)
            {
                decimal price4 = Decimal.Parse(labelFiyatKitap.Text);
                decimal num4 = Convert.ToInt32(numericUpDown4.Value);
                sum4 = price4 * num4;
                listBox1.Items.Add(checkKarton.Text + " " + numericUpDown4.Value + " " + "adet seçildi" + " " + sum4 + " TL");
            }
            if (checkBoya.Checked)
            {
                decimal price5 = Decimal.Parse(labelFiyatKitap.Text);
                decimal num5 = Convert.ToInt32(numericUpDown5.Value);
                sum5 = price5 * num5;
                listBox1.Items.Add(checkBoya.Text + " " + numericUpDown5.Value + " " + "adet seçildi" + " " + sum5 + " TL");
            }

            sum = sum1+sum2+sum3+sum4+sum5;
            labelToplamFiyat.Text = sum.ToString()+" TL";



        }
    }
}
