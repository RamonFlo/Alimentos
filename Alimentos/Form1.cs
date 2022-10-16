using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Alimentos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           comboBox1.Items.Add("Pozole");
           comboBox1.Items.Add("Tamales");
           comboBox1.Items.Add("Capirotado");


        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int indice = comboBox1.SelectedIndex;
            label1.Text = indice.ToString();
            label2.Text = comboBox1.Items[indice].ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Agregamos valores al ComboBox
            comboBox1.Items.Add(textBox1.Text);
            textBox1.Text = "";
            comboBox1.Focus();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
