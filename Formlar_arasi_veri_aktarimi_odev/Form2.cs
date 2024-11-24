using System;
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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        public string m1,m2,m3;
        private void Form2_Load(object sender, EventArgs e)
        {
            comboBox1.Text = m1.ToString() + m2.ToString() + m3.ToString();
        }
    }
}
