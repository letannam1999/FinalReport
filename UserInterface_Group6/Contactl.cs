using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp4
{
    public partial class Contactl : Form
    {
        public Contactl()
        {
            InitializeComponent();
        }

        private void BtNew_Click(object sender, EventArgs e)
        {
            try
            {
                panel1.Enabled = true;
                App.PhoneList.AddPhoneListRow(App.PhoneList.NewPhoneListRow());
                phoneListBindingSource.MoveLast();
                txtPhoneNumber.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                App.PhoneList.RejectChanges();
            }
        }

        private void BtEdit_Click(object sender, EventArgs e)
        {
            panel1.Enabled = true;
            txtPhoneNumber.Focus();
        }

        private void BtCancel_Click(object sender, EventArgs e)
        {
            phoneListBindingSource.ResetBindings(false);
            panel1.Enabled = false;
        }

        private void BtSave_Click(object sender, EventArgs e)
        {
            try
            {
                phoneListBindingSource.EndEdit();
                App.PhoneList.AcceptChanges();
                App.PhoneList.WriteXml(string.Format("{0}//data.dat", Application.StartupPath));
                panel1.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                App.PhoneList.RejectChanges();
            }
        }
        static AppData db;
        protected static AppData App
        {
            get
            {
                if (db == null)
                    db = new AppData();
                return db;
            }
        }
        private void Contactl_Load(object sender, EventArgs e)
        {
            string fileName = string.Format("{0}//data.dat", Application.StartupPath);
            if (File.Exists(fileName))
                App.PhoneList.ReadXml(fileName);
            phoneListBindingSource.DataSource = App.PhoneList;
            panel1.Enabled = false;
        }

        private void dataGridView1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                if (MessageBox.Show("Are you sure want to delete this record", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    phoneListBindingSource.RemoveCurrent();
            }

        }
        private void txtSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                if (!string.IsNullOrEmpty(txtSearch.Text))
                {
                    var query = from o in App.PhoneList
                                where o.PhoneNumber == txtSearch.Text || o.Name.Contains(txtSearch.Text) || o.Email == txtSearch.Text
                                select o;
                    dataGridView1.DataSource = query.ToList();
                }
                else
                    dataGridView1.DataSource = phoneListBindingSource;
            }
        }
    }
}
