﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SimpleCalculator
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        protected void firstTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        protected void addButton_Click(object sender, EventArgs e)
        {
            double i = double.Parse(firstTextBox.Text);
            double j = double.Parse(secondTextBox.Text);
            double k = i + j;
            resultLabel.Text = k.ToString();
        }

        protected void subtractButton_Click(object sender, EventArgs e)
        {
            double i = double.Parse(firstTextBox.Text);
            double j = double.Parse(secondTextBox.Text);
            double k = i - j;
            resultLabel.Text = k.ToString();
        }

        protected void multiplyButton_Click(object sender, EventArgs e)
        {
            double i = double.Parse(firstTextBox.Text);
            double j = double.Parse(secondTextBox.Text);
            double k = i * j;
            resultLabel.Text = k.ToString();
        }

        protected void divisionButton_Click(object sender, EventArgs e)
        {
            double i = double.Parse(firstTextBox.Text);
            double j = double.Parse(secondTextBox.Text);
            double k = i / j;
            resultLabel.Text = k.ToString();
        }
    }
}