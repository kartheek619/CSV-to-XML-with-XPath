using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Week2Question
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Conversion con = new Conversion();
            String result = con.convertToXml();
            if (result == "Success")
            {
                showXML.Text = File.ReadAllText("employeesxml.xml");
                label1.Visible = true;
                label2.Visible = true;
                linkLabel1.Visible = true;
                button2.Enabled = true;
            }
            else
            {
                showXML.Text = result;
            } 
        }
        private void button2_Click(object sender, EventArgs e)
        {
            Validation val = new Validation();
            String result = val.checkValidation();
            if (result == "Document is Valid")
            {
                validateResult.BackColor = Color.LightGreen;
                validateResult.Text = "XML created from CSV file matches with Schema!!";
            }
            else
            {
                validateResult.BackColor = Color.Red;
                validateResult.Text = result;
            }
        }
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            
            System.Diagnostics.Process.Start("explorer.exe", @".\");
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void showXML_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
