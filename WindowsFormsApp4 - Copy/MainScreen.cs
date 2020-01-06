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
    public partial class MainScreen : Form
    {
        public MainScreen()
        {
            InitializeComponent();
        }
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            this.FormBorderStyle = FormBorderStyle.None;
        }
        protected override void OnMouseDown(MouseEventArgs e)
        {
            base.OnMouseDown(e);
            if (e.Button == MouseButtons.Left)
            {
                this.Capture = false;
                Message msg = Message.Create(this.Handle, 0XA1, new IntPtr(2), IntPtr.Zero);
                this.WndProc(ref msg);
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            welcom wc = new welcom();
            wc.TopLevel = false;
            container.Controls.Add(wc);
            wc.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            wc.Dock = DockStyle.Fill;
            wc.Show();

            Information inf;
            inf = new Information();
            inf.TopLevel = false;
            contain.Controls.Add(inf);
            inf.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            inf.Dock = DockStyle.Fill;
            inf.Show();

            Contactl con = new Contactl();
            con.TopLevel = false;
            pncon.Controls.Add(con);
            con.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            con.Dock = DockStyle.Fill;
            con.Show();

            UpdatePosition ud = new UpdatePosition();
            ud.TopLevel = false;
            UpPosition.Controls.Add(ud);
            ud.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            ud.Dock = DockStyle.Fill;
            ud.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            contain.Visible = true;
            pncon.Visible = false;
            UpPosition.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            pncon.Visible = true;
            contain.Visible = false;
            UpPosition.Visible = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            pncon.Visible = false;
            contain.Visible = false;
            UpPosition.Visible = true;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://smartfirebbq.com/");
        }

        private void imagel_Click(object sender, EventArgs e)
        {
      
        }

        private void button6_Click(object sender, EventArgs e)
        {
            string imageLocation = "";
            try
            {
                OpenFileDialog dialog = new OpenFileDialog();
                dialog.Filter = "jpg files(*.jpg)|*.jpg| PNG file(*.png)|*.png| All File(*.*)|*,*";

                if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    imageLocation = dialog.FileName;

                    imagel.ImageLocation = imageLocation;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("An error Occured", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
