﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Formlar_arasi_veri_aktarimi_odev
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 fr = new Form2();
            fr.m1 = textBox1.Text;
            fr.m2 = textBox2.Text;
            fr.m3 = textBox3.Text;
            fr.Show();
            this.Hide();

        }
    }
}
