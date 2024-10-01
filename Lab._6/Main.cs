using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab._6
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void btnCalculateSquare_Click(object sender, EventArgs e)
        {
            double a = double.Parse(txtSquareSide.Text);
            Shape square = new Square(a);
            double area = square.GetArea();
            txtSquareArea.Text = area.ToString("0.00");
        }

        private void btnCalculateCircle_Click(object sender, EventArgs e)
        {
            double r = double.Parse(txtCircleRadius.Text);
            Shape circle = new Circle(r);
            double area = circle.GetArea();
            txtCircleArea.Text = area.ToString("0.00");
        }
    }
}
