using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InterestCalculator
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(comboBox1.SelectedItem.ToString() == "Time Period(t)")
            {
                formulaLabel.Text = "Where: t = (1/r)(A/P - 1)";
                inputLabel1.Text = "Total P+I (A): TK";
                inputLabel2.Text = "Principal (P): TK";
                inputLabel3.Text = "Rate (R): %";
                comboBox2.Visible = false;
            }
            else if (comboBox1.SelectedItem.ToString() == "Total P+I(A)")
            {
                formulaLabel.Text = "Where: A = P(1 + rt)";
                inputLabel1.Text = "Principal(P): TK";
                inputLabel2.Text = "Rate(R): %";
                inputLabel3.Text = "Time (t):";
                comboBox2.Show();
            }
            else if (comboBox1.SelectedItem.ToString() == "Principal(P)")
            {
                formulaLabel.Text = "Where: P = A / (1 + rt)";
                inputLabel1.Text = "Total P+I (A): TK";
                inputLabel2.Text = "Rate (R): %";
                inputLabel3.Text = "Time (t):";
                
                comboBox2.Show();
            }
            else if (comboBox1.SelectedItem.ToString() == "Rate(R)")
            {
                formulaLabel.Text = "Where: r = (1/t)(A/P - 1)";
                inputLabel1.Text = "Total P+I (A): TK";
                inputLabel2.Text = "Principal(P): TK";
                inputLabel3.Text = "Time (t):";
                comboBox2.Show();
            }


        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadComboBox();
        }

        private void LoadComboBox()
        {
            comboBox1.Items.Add("Time Period(t)");
            comboBox1.Items.Add("Principal(P)");
            comboBox1.Items.Add("Rate(R)");
            comboBox1.Items.Add("Total P+I(A)");
            comboBox2.Items.Add("days(365/yr)");
            comboBox2.Items.Add("days(360/yr)");
            comboBox2.Items.Add("weeks");
            comboBox2.Items.Add("months");
            comboBox2.Items.Add("quarters");
            comboBox2.Items.Add("years");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ClearTextBox();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void ClearTextBox()
        {
            inputTextBox1.Clear();
            inputTextBox2.Clear();
            inputTextBox3.Clear();
            equationLabel.Text = "";
            showAnswerLabel.Text = "";
        }

        private void equationLabel_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            double principal;
            double time;
            double rate;
            double total;
             if (String.IsNullOrEmpty(inputTextBox1.Text) || String.IsNullOrEmpty(inputTextBox2.Text) || String.IsNullOrEmpty(inputTextBox3.Text) || comboBox1.SelectedItem == null)
            {
                MessageBox.Show("You Must provide all informations");
            }
            else {
                if (comboBox1.SelectedItem.ToString() == "Time Period(t)")
            {
                double.TryParse(inputTextBox1.Text, out total);
                double.TryParse(inputTextBox2.Text, out principal);
                double.TryParse(inputTextBox3.Text, out rate);
                rate = rate / 100;
                time = (1 / rate) * ((total / principal) - 1);
                equationLabel.Text = "Equation: t = (1/r)(A/P - 1)";
                showAnswerLabel.Text = "t = "+time.ToString()+" years";
            }
            else if(comboBox1.SelectedItem.ToString() == "Total P+I(A)")
            {
                double.TryParse(inputTextBox1.Text, out principal);
                double.TryParse(inputTextBox2.Text, out rate);
                double.TryParse(inputTextBox3.Text, out time);
                rate = rate / 100;
                if(comboBox2.SelectedItem.ToString() == "days(365/yr)")
                {
                    time = time / 365;
                }
                else if (comboBox2.SelectedItem.ToString() == "days(360/yr)")
                {
                    time = time / 360;
                }

                else if (comboBox2.SelectedItem.ToString() == "weeks")
                {
                    time = time / 52;
                }
                else if (comboBox2.SelectedItem.ToString() == "months")
                {
                    time = time / 12;
                }
                else if (comboBox2.SelectedItem.ToString() == "quarters")
                {
                    time = time / 4;
                }
                total = principal * (1 + rate * time);
                equationLabel.Text = "Equation: A = P(1 + rt)";
                showAnswerLabel.Text = "A = " + total.ToString() + " TK";
            }
            else if (comboBox1.SelectedItem.ToString() == "Principal(P)")
            {
                double.TryParse(inputTextBox1.Text, out total);
                double.TryParse(inputTextBox2.Text, out rate);
                double.TryParse(inputTextBox3.Text, out time);
                rate = rate / 100;
                if (comboBox1.SelectedItem == null)
                {
                    MessageBox.Show("You must Select Time period");
                }
                else if (comboBox2.SelectedItem.ToString() == "days(365/yr)")
                {
                    time = time / 365;
                }
                else if (comboBox2.SelectedItem.ToString() == "days(360/yr)")
                {
                    time = time / 360;
                }

                else if (comboBox2.SelectedItem.ToString() == "weeks")
                {
                    time = time / 52;
                }
                else if (comboBox2.SelectedItem.ToString() == "months")
                {
                    time = time / 12;
                }
                else if (comboBox2.SelectedItem.ToString() == "quarters")
                {
                    time = time / 4;
                }
                principal = total / (1 + (rate * time));  
                equationLabel.Text = "Equation: P = A / (1 + rt)";
                showAnswerLabel.Text = "P = " + principal.ToString()+" TK";
            }
             else if (comboBox1.SelectedItem.ToString() == "Rate(R)")
             {
                double.TryParse(inputTextBox1.Text, out total);
                double.TryParse(inputTextBox2.Text, out principal);
                double.TryParse(inputTextBox3.Text, out time);
                if (comboBox1.SelectedItem == null)
                {
                    MessageBox.Show("You must Select Time period");
                }
                else if (comboBox2.SelectedItem.ToString() == "days(365/yr)")
                {
                    time = time / 365;
                    rate = (1 / time) * ((total / principal) - 1);
                    rate = rate * 100;
                    rate = rate / 365;
                    showAnswerLabel.Text = "R = " + rate.ToString() + " % Per Day";
                }
                else if (comboBox2.SelectedItem.ToString() == "days(360/yr)")
                {
                    time = time / 360;
                    rate = (1 / time) * ((total / principal) - 1);
                    rate = rate * 100;
                    rate = rate / 360;
                    showAnswerLabel.Text = "R = " + rate.ToString() + " % Per Day";
                }
                else if (comboBox2.SelectedItem.ToString() == "years")
                {
                    
                    rate = (1 / time) * ((total / principal) - 1);
                    rate = rate * 100;
                    showAnswerLabel.Text = "R = " + rate.ToString() + " % Per year";
                }

                else if (comboBox2.SelectedItem.ToString() == "weeks")
                {
                    time = time / 52;
                    rate = (1 / time) * ((total / principal) - 1);
                    rate = rate * 100;
                    rate = rate / 52;
                    showAnswerLabel.Text = "R = " + rate.ToString() + " % Per Week";
                }
                else if (comboBox2.SelectedItem.ToString() == "months")
                {
                    time = time / 12;
                    rate = (1 / time) * ((total / principal) - 1);
                    rate = rate * 100;
                    rate = rate / 12;
                    showAnswerLabel.Text = "R = " + rate.ToString() + " % Per month";
                }
                else if (comboBox2.SelectedItem.ToString() == "quarters")
                {
                    time = time / 4;
                    rate = (1 / time) * ((total / principal) - 1);
                    rate = rate * 100;
                    rate = rate / 12;
                    showAnswerLabel.Text = "R = " + rate.ToString() + " % Per quarter";
                }

                equationLabel.Text = "Equation:  r = (1/t)(A/P - 1)";
             }

            }

        }

        private void inputTextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
          
        }
        private void inputTextBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
           
        }
        private void inputTextBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
          
        }
    }
}
