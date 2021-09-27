using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.IO;

namespace Entrapiya._2._0
{
    public partial class Form1 : Form
    {
        
    public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            var textControl = new TextControl(textBox1.Text);
            textBox2.Text = Convert.ToString(textControl.EntrapiaCalculation());
            richTextBox1.Text = textControl.FrequencyCalculation();

        }
        private void button2_Click(object sender, EventArgs e)
        {
            
            if (button2.Text == "Показать частоту")
            {
                richTextBox1.Visible = true;
                button2.Text = "Скрыть частоту";
            }
            else
            {
                button2.Text = "Показать частоту";
                richTextBox1.Visible = false;
            }
        }
        
    }
    
}
