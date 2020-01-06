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
    
    public partial class UpdatePosition : Form
    {
        bool on = true;
        bool togglelight = true;
        Timer t = new Timer();
        public UpdatePosition()
        {
            InitializeComponent();
        }

        private void UpdatePosition_Load(object sender, EventArgs e)
        {
            button1.Text = " Safe";
            t.Interval = 1000;
            
            //t.Tick += new EventHandler(t_tick);
        }

        //private void t_tick(object sender, EventArgs e)
        //{
        //    if (togglelight)
        //    {
        //        button1.BackColor = Color.Green;
        //        togglelight = false;
        //    }
        //    else
        //    {
        //        button1.BackColor = Color.Gray;
        //        togglelight = true;
        //    }

        //}

        private void button1_Click(object sender, EventArgs e)
        {
            if (on)
            {
                button1.Text = "Danger";
                button1.BackColor = Color.Red;
                t.Start();
                on = false;
            }
            else
            {
                button1.Text = "Safe";
                button1.BackColor = Color.SpringGreen;
                t.Stop();
                on = true;
            }
        }
    }
}
