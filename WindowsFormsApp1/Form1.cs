using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Shape : Form
    {
        public Shape()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int length = Int32.Parse(lengthbox.Text);
            int breadth = Int32.Parse(breadthbox.Text);
            int height = Int32.Parse(heightbox.Text);
            volumebox.Text = (GetVolume(length, breadth, height)).ToString();
            
        }

        public int GetVolume(int length, int breadth, int height)
        {
            var volume = length * breadth * height;
            return volume;
        }

        private void volumebox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
