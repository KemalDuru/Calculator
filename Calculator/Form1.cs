﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//Author : Kemal DURU


namespace Calculator
{
    public partial class Form1 : Form
    {   
        //Variables
        bool checkopt = false;
        bool checknumber = false;
        bool checkreset = false;
        Double result = 0;
        string opt = "";


        public Form1()
        {
            InitializeComponent();
        }
        //Numbers Button
        private void Numbers_event(object sender, EventArgs e)
        {
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
        //Operator Button
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
        //Equal Button
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
                checkreset = true;
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
                
            }
        }
        //Clear All button (C)
        private void clear_event(object sender, EventArgs e)
        {
            txtResult.Clear();
            result = 0;
            lblResult.Text = "";
            txtResult.Text = "0";
            checkopt = false;
            opt = "";
            checknumber = false;
            checkreset = false;
        }
        //Clear operator button (CE)
        private void clear_result_event(object sender, EventArgs e)
        {
            lblResult.Text = result.ToString();
            txtResult.Clear();
            txtResult.Text = "0";
            checkreset = true;
            
            
        }
        // Square and Root Buttons
        private void optsqrt(object sender, EventArgs e)
        {
            
            Button btn = (Button)sender;
            opt = btn.Text;
            if (checknumber)
            {
                switch (opt)
                {
                    case "X2":
                        txtResult.Text = (Double.Parse(txtResult.Text) * Double.Parse(txtResult.Text)).ToString();
                        break;
                    case "½X":
                        txtResult.Text = (Math.Sqrt(Double.Parse(txtResult.Text))).ToString();
                        break;
                }
                
            }

            result = Double.Parse(txtResult.Text);
            lblResult.Text = result.ToString();
        }
    }
}
