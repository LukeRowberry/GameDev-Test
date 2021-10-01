/*
Luke Rowberry
9-23-2021
Identify Theft Program
 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace The_Data_Collector
{
    public partial class Data_Borrower_Form : Form
    {
        String first_name;
        public Data_Borrower_Form()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Runs on load -- setup needed data
            String name = "Kanye West";
            MessageBox.Show("Warning: "+name);
        }
        //IGNORE ZONE
        private void fname_lbl_Click(object sender, EventArgs e)
        {

        }
        //IGNORE ZONE
        private void submit_btn_Click(object sender, EventArgs e)
        {
            first_name = fname_txb.Text;
            MessageBox.Show("Thanks "+first_name);
        }

        private void fname_txb_TextChanged(object sender, EventArgs e)
        {
            first_name = fname_txb.Text;
        }
        //IGNORE ZONE
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pant_lbl_Click(object sender, EventArgs e)
        {

        }

        private void job_lbl_Click(object sender, EventArgs e)
        {

        }

        private void who_lbl_Click(object sender, EventArgs e)
        {

        }

        private void shoe_lbl_Click(object sender, EventArgs e)
        {

        }

        private void phone_lbl_Click(object sender, EventArgs e)
        {

        }
        //IGNORE ZONE
    }
}
