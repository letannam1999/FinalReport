using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using WindowsFormsApp4;

namespace FireApp
{
    public partial class form1 : Form
    {
        public form1()
        {
            InitializeComponent();
            panelLeft.Height = btnHome.Height;
            panelLeft.Top = btnHome.Top;
        }
        private void BtnCreate_Click(object sender, EventArgs e)
        {
            panelLeft.Height = btnCreate.Height;
            panelLeft.Top = btnCreate.Top;
            Form2 myForm = new Form2();
            myForm.Owner = this;
            myForm.Show();
        }

        private void Sign1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\84931\Documents\List_User.mdf;Integrated Security=True;Connect Timeout=30");
            SqlDataAdapter sda = new SqlDataAdapter("Select Count(*) From CreateAccount where username='" + textBox1.Text + "' and password='" + textBox2.Text + "'", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if (dt.Rows[0][0].ToString() == "1")
            {
                this.Hide();
                MainScreen ss = new MainScreen();
                ss.Show();
            }
            else
            {
                MessageBox.Show("Please Check Your Username and Password");
            }
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            panelLeft.Height = btnHome.Height;
            panelLeft.Top = btnHome.Top;
            System.Diagnostics.Process.Start("https://smartfirebbq.com/");
        }

        private bool dragging = false;
        private Point startPoint = new Point(0, 0);

        private void panel3_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            startPoint = new Point(e.X, e.Y);
        }

        private void panel3_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point p = PointToScreen(e.Location);
                Location = new Point(p.X - this.startPoint.X, p.Y - this.startPoint.Y);
            }
        }

        private void panel3_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            panelLeft.Height = btnExit.Height;
            panelLeft.Top = btnExit.Top;
            this.Close();
        }

        private void form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(MessageBox.Show("Are you sure want to quit?", "Close?", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
