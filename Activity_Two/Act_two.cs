﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Wishlist.Items.Add("Eferrari na karton");
            Wishlist.Items.Add("FighterJet na plastic");
            Wishlist.Items.Add("Hamburger na walay Patty");
            Wishlist.Items.Add("SteamRice na dli Steam");
            Wishlist.Items.Add("House&Lot sa Cebu");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Wishlist.Sorted = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Wishlist.Items.Clear();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox2.Text = Convert.ToString(Wishlist.Items.Count);
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Wishlist_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBox1.Text = Wishlist.Text;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
