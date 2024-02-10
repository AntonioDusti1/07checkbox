using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _07checkbox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            string izabranaStavka = comboBox1.SelectedItem.ToString();
            textBox1.Text = $"Izabrali ste stavku: {izabranaStavka}";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
