using lab3.Models;
using lab3.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab3
{
    public partial class Form1 : Form
    {
        StrategyService service = new StrategyService();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            decimal numberOfSides = Convert.ToDecimal(textBox1.Text);
            decimal lenght = Convert.ToDecimal(textBox2.Text);
            Polygon polygon = new Polygon(numberOfSides, lenght);

            decimal result = service.Perimetr(polygon);

            textBox3.Text = result.ToString();
        }
    }
}
