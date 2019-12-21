using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Training_apparatus.Presenter;

namespace Training_apparatus
{
    public partial class MainForm : Form, IMainFormView
    {
        public MainForm()
        {
            InitializeComponent();
        }

        public event Action UserEnter;

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void list_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MathGraph();
        }
        private void MathGraph() {
            const double Pi = 10;
            double shag = 0.1;
            double mathtab = 30;

            int fillHeight = 100;
            int fillWigh = 1030;
            int otstup = 5;

            Graphics e = this.CreateGraphics();
            SolidBrush brush = new SolidBrush(Color.White);

            e.FillRectangle(brush, new Rectangle(otstup, otstup, fillWigh, fillHeight));
            e.FillRectangle(brush, new Rectangle(otstup, otstup*2 + fillHeight, fillWigh, fillHeight));

            int n = Convert.ToInt32(4*Pi/shag);

            Point[] pointSin = new Point[n];
            Point[] pointCos = new Point[n];

            int p = 0;
            for (double i=0; i<4*Pi; i+=shag) {
                pointSin[p] = new Point(Convert.ToInt32(i * mathtab + otstup), Convert.ToInt32(Math.Sin(i) * mathtab + (fillHeight / 2) + otstup));
                pointSin[p] = new Point(Convert.ToInt32(i * mathtab + otstup), Convert.ToInt32(Math.Cos(i) * mathtab + fillHeight / 2 + 2 * otstup + fillHeight));
                p++;
            }

            Pen pen = new Pen(Color.Black);

            e.DrawCurve(pen, pointSin);
            e.DrawCurve(pen, pointCos);


        }
        private void Main_Click(object sender, EventArgs e)
        {

        }

        private void temp_Click(object sender, EventArgs e)
        {

        }
    }
}
