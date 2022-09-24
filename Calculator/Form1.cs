using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        bool checkopt = false;
        bool checknumber = false;
        bool checkreset = false;
        Double temp = 0;
        Double result = 0;
        string opt = "";


        public Form1()
        {
            InitializeComponent();
        }

        private void Numbers_event(object sender, EventArgs e)
        {q
            Button btn = (Button)sender;
            if (txtResult.Text == "0" || checkopt )
            {
                txtResult.Clear();
            }
            if (checkreset)
            {
                txtResult.Clear();    
                lblResult.Text="";
            }
            checkopt = false;
            checkreset = false;
            checknumber = true;
            txtResult.Text += btn.Text;
            lblResult.Text += btn.Text;


        }

        private void optEvent(object sender, EventArgs e)
        {

            checkopt = true;
            Button btn = (Button)sender;
            string newopt = btn.Text;
            if (checknumber)
            {
                switch (opt)
                {
                    case "+":
                        txtResult.Text = (result + Double.Parse(txtResult.Text)).ToString();
                        break;
                    case "-":
                        txtResult.Text = (result - Double.Parse(txtResult.Text)).ToString();
                        break;
                    case "/":
                        txtResult.Text = (result / Double.Parse(txtResult.Text)).ToString();
                        break;
                    case "X":
                        txtResult.Text = (result * Double.Parse(txtResult.Text)).ToString();
                        break;
                    case "%":
                        txtResult.Text = ((result * Double.Parse(txtResult.Text))/100).ToString();
                        break;
                }
                checknumber = false;
            }
            opt = newopt;
            
            result = Double.Parse(txtResult.Text);
            lblResult.Text = result.ToString() + " " + opt;

        }

        private void equal_event(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            if (checknumber)
            {
                switch (opt)
                {
                    case "+":
                        txtResult.Text = (result + Double.Parse(txtResult.Text)).ToString();
                        break;
                    case "-":
                        txtResult.Text = (result - Double.Parse(txtResult.Text)).ToString();
                        break;
                    case "/":
                        txtResult.Text = (result / Double.Parse(txtResult.Text)).ToString();
                        break;
                    case "X":
                        txtResult.Text = (result * Double.Parse(txtResult.Text)).ToString();
                        break;
                    case "%":
                        txtResult.Text = ((result * Double.Parse(txtResult.Text)) / 100).ToString();
                        break;
                }
                checknumber = false;
                opt = "";
            }
            if (txtResult.Text == "")
            {
                if (lblResult.Text == "")
                {
                    checkreset = true;
                }
                else
                {
                    result = Double.Parse(lblResult.Text);
                }
            }
            else
            {
                result = Double.Parse(txtResult.Text);
                lblResult.Text = "=" + result.ToString();
                checkreset = true;
            }
        }

        private void clear_event(object sender, EventArgs e)
        {
            txtResult.Clear();
            result = 0;
            lblResult.Text = "";
            checkopt = false;
            opt = "";
            checknumber = false;
            checkreset = false;
        }

        private void clear_result_event(object sender, EventArgs e)
        {
            lblResult.Text = result.ToString();
            temp = Double.Parse(txtResult.Text);
            if (txtResult.Text != "")
            {
                checkreset = true;
            }
            txtResult.Clear();
        }
    }
}
