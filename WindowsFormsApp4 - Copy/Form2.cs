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

namespace FireApp
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Owner.Show();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\84931\Documents\List_User.mdf;Integrated Security=True;Connect Timeout=30");
                SqlDataAdapter sda = new SqlDataAdapter("Insert into CreateAccount Values ('" + textBox1.Text + "','" + textBox3.Text + "','" + textBox2.Text + "','" + textBox4.Text + "','" + textBox5.Text + "')",con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                this.Close();
            }
        }

        private bool dragging = false;
        private Point startPoint = new Point(0, 0);
        private void Form2_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            startPoint = new Point(e.X, e.Y);
        }

        private void Form2_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point p = PointToScreen(e.Location);
                Location = new Point(p.X - this.startPoint.X, p.Y - this.startPoint.Y);
            }
        }

        private void Form2_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            String uname = textBox1.Text;
            if(uname.ToLower().Trim().Equals("user name"))
            {
                textBox1.Text = "";
                textBox1.ForeColor = Color.Black;
            }
        }
        private void textBox1_Leave(object sender, EventArgs e)
        {
            String uname = textBox1.Text;
            if (uname.ToLower().Trim().Equals("user name") || uname.Equals(""))
            {
                textBox1.Text = "user name";
                textBox1.ForeColor = Color.Gray;
            }
        }

        private void textBox3_Enter(object sender, EventArgs e)
        {
           String yname = textBox3.Text;
            if (yname.ToLower().Trim().Equals("your name"))
            {
                textBox3.Text = "";
                textBox3.ForeColor = Color.Black;
            }
        }

        private void textBox3_Leave(object sender, EventArgs e)
        {
            String yname = textBox3.Text;
            if (yname.ToLower().Trim().Equals("your name") || yname.Equals(""))
            {
                textBox3.Text = "your name";
                textBox3.ForeColor = Color.Gray;
            }
        }

        private void textBox4_Enter(object sender, EventArgs e)
        {
            String age = textBox4.Text;
            if (age.ToLower().Trim().Equals("age")) 
            {
                textBox4.Text = "";
                textBox4.ForeColor = Color.Black;
            }
        }

        private void textBox4_Leave(object sender, EventArgs e)
        {
            String age = textBox4.Text;
            if (age.ToLower().Trim().Equals("age") || age.Equals(""))
            {
                textBox4.Text = "age";
                textBox4.ForeColor = Color.Gray;
            }
        }

        private void textBox5_Enter(object sender, EventArgs e)
        {
            String phone = textBox5.Text;
            if (phone.ToLower().Trim().Equals("phone number"))
            {
                textBox5.Text = "";
                textBox5.ForeColor = Color.Black;
            }
        }

        private void textBox5_Leave(object sender, EventArgs e)
        {
            String phone = textBox5.Text;
            if (phone.ToLower().Trim().Equals("phone number") || phone.Equals(""))
            {
                textBox5.Text = "phone number";
                textBox5.ForeColor = Color.Gray;
            }
        }

        private void textBox2_Enter(object sender, EventArgs e)
        {
            String pass = textBox2.Text;
            if (pass.ToLower().Trim().Equals("password"))
            {
                textBox2.Text = "";
                textBox2.UseSystemPasswordChar = true;
                textBox2.ForeColor = Color.Black;
            }
        }

        private void textBox2_Leave(object sender, EventArgs e)
        {
            String pass = textBox2.Text;
            if (pass.ToLower().Trim().Equals("password") || pass.Equals(""))
            {
                textBox2.Text = "password";
                textBox2.UseSystemPasswordChar = false;
                textBox2.ForeColor = Color.Gray;
            }
        }

        private void lblmovetologin_MouseEnter(object sender, EventArgs e)
        {
            lblmovetologin.ForeColor = Color.Red;
        }

        private void lblmovetologin_MouseLeave(object sender, EventArgs e)
        {
            lblmovetologin.ForeColor = Color.Black;
        }

        private void lblmovetologin_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
