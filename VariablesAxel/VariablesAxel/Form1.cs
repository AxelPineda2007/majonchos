using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VariablesAxel
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        double majonchocost;
        int CantidadMajonchos;
        double totalMajonchocost;

        private void button1_Click(object sender, EventArgs e)
        {
            majonchocost = Convert.ToDouble(textBox2.Text);
            CantidadMajonchos = Convert.ToInt32(textBox1.Text);
            totalMajonchocost = CantidadMajonchos * majonchocost;
            textBox3.Text = totalMajonchocost.ToString();
        }
    }
}
