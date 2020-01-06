using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp4
{
    public partial class welcom : Form
    {
        public welcom()
        {
            InitializeComponent();
        }

        private void welcom_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }
      

        private void timer1_Tick(object sender, EventArgs e)
        {
            lbTime.Text = DateTime.Now.ToString("HH:mm");
            lbdatetime.Text = DateTime.Now.ToString("MMM dd yyyy");
        }

        private void lbdatetime_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
