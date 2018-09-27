using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace WindowsFormsApp2
{

    public partial class Form1 : Form
    {
        static Int32 X, Y;
        string input, input2;
        Bitmap bitmapa;
        Automat2D Automat;

        private void start()
        {
            try
            {
                for (int i = 0; i < Automat.Ibound; i++)
                    for (int j = 0; j < Automat.Jbound; j++)
                        bitmapa.SetPixel(i, j, (Automat.Cells[i, j] == 1) ? Color.White : Color.Black);
            }
            catch (IndexOutOfRangeException e)
            {

            }
            catch (ArgumentOutOfRangeException ex)
            {

            }
            pictureBox1.Invoke(new Action(() => pictureBox1.Image = bitmapa));
        }


        private void button2_Click(object sender, EventArgs e)
        {
            if (button2.Text == "Start")
            {
                button2.Text = "Stop";
                Task.Run(() => Automat.Iterate(start));
            }

            else
            {
                button2.Text = "Start";
                Automat.stop();
            }

            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Automat.setStructure(structure.Immutable);
        }

        private void Oscilator_Click(object sender, EventArgs e)
        {
            Automat.setStructure(structure.Oscilator);
        }

        private void Glider_Click(object sender, EventArgs e)
        {
            Automat.setStructure(structure.Glider);
        }

        private void Dakota_Click(object sender, EventArgs e)
        {
            Automat.setStructure(structure.Dakota);
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            input = textBox1.Text;
            Int32.TryParse(input, out X);
            input2 = textBox2.Text;
            Int32.TryParse(input2, out Y);
            Int32 x = 2 * X / 3;
            Int32 y = 2 * Y / 3;
            bitmapa = new Bitmap(x, y);
            Automat = new Automat2D(x, y);
        }
    }
}
