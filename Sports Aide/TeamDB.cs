﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SportsAide
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            foreach (string name in Player.GetAll())
            {
                listBox1.Items.Add(name);
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem != null)
            {
                lblName.Text = listBox1.SelectedItem.ToString();
            }
        }

        private void button1_Click(object sender, EventArgs e) // CHANGE SOURCE
        {
            MessageBox.Show("This will allow for external SQL databases to be imported. There will also be an option to just store data locally with SQLite/text file.", "Coming Soon");
        }

        // BACK BUTTON
        private void button3_Click(object sender, EventArgs e)
        {
            Core.OpenForm(Core.MainMenu);
        }

        private void rmbtn_Click(object sender, EventArgs e)
        {
            listBox1.SetSelected(0, true);
            listBox1.Items.Remove(listBox1.SelectedItem);
        }

        private void addBTN_Click(object sender, EventArgs e)
        {
            Player.Add(plyname.Text);
            listBox1.Items.Add(plyname.Text);
        }

        // REFRESH BUTTON
        private void button2_Click(object sender, EventArgs e)
        {
            foreach (string str in listBox1.Items) // BROKEN HERE PLS FIX
            {
                listBox1.Items.Remove(str);
            }

            foreach (string name in Player.GetAll())
            {
                listBox1.Items.Add(name);
            }
        }
    }
} 
